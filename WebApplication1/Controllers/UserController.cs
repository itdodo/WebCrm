using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Do.Bll;
using Do.Common;
using Do.Db.Oracle;
using Do.Web.Backend.Fliter;

namespace Do.Web.Backend.Controllers
{
    [Module(Code = "02",Name = "用户管理",Sort = 2)]
    public class UserController : Controller
    {
        UserBll userBll = new UserBll();
        [Module(Code ="02",Name = "用户列表")]
        public ActionResult Index(int id=1)
        {
            var list = userBll.GetList(id, 12);
            if (Request.IsAjaxRequest())
                return View("_UserList", list);
            return View();
        }


        #region 用户列表
        public ActionResult UserList(int id = 1)
        {
            var list = userBll.GetList(id, 12);

            if (Request.IsAjaxRequest())
                return View("_UserList", list);

            return View(list);
        }
        #endregion

        /// <summary>
        /// 打开添加用户页面
        /// </summary>
        /// <returns></returns>
        public ActionResult AddUser()
        {
            var roleList = new RoleBll().GetList();

            ViewBag.roleList = new SelectList(roleList, "RoleId", "Name");
            return View();
        }

        /// <summary>
        /// 处理添加用户请求
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult AddUser(SysUser model)
        {
            var count = 0;
            try
            {
                model.UserId = Guid.NewGuid().ToString();
                model.CreateBy = "Dong";
                model.CreateAt = DateTime.Now;
                if (string.IsNullOrEmpty(model.Password))
                    model.Password = "888888";
                count = userBll.Insert(model);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return Json(1 == count ? new RetJson() { Code = 200, Flag = true, Msg = "操作成功" } : new RetJson() { Code = 200, Flag = false, Msg = "操作失败" }, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 重置密码
        /// </summary>
        /// <param name="id">用户ID</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult ResetPassword(string id)
        {
            var entity = userBll.GetById(id);
            entity.Password = "888888";
            var i = userBll.Update(entity);
            return Json(1 == i ? new RetJson() { Code = 200, Flag = true, Msg = "操作成功" } : new RetJson() { Code = 200, Flag = false, Msg = "操作失败" }, JsonRequestBehavior.AllowGet);
        }
        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="id">用户ID</param>
        /// <returns></returns>
        public ActionResult DeleteUser(string id)
        {
            var i = userBll.Delete(id);
            return Json(1 == i ? new RetJson() { Code = 200, Flag = true, Msg = "操作成功" } : new RetJson() { Code = 200, Flag = false, Msg = "操作失败" }, JsonRequestBehavior.AllowGet);
        }

        public void Insert()
        {
            var list = new List<SysUser>();
            for (int i = 11; i < 101; i++)
            {
                list.Add(new SysUser
                {
                    UserId = Guid.NewGuid().ToString(),
                    Password = "888888",
                    UserName = "test" + i,
                    CreateAt = DateTime.Now,
                    CreateBy = CurrentUser.UserName
                });
            }
            var count = new UserBll().Insert(list);
        }
    }
}