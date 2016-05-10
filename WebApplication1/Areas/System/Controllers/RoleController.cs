using System;
using System.Security.Cryptography.X509Certificates;
using System.Web.Mvc;
using Do.Bll;
using Do.Common;
using Do.Db.Oracle;
using Do.Web.Backend.Controllers;

namespace Do.Web.Backend.Areas.System.Controllers
{
    /// <summary>
    /// 角色管理
    /// </summary>
    public class RoleController : BaseController
    {
        // GET: System/Role
        RoleBll roleBll = new RoleBll();
        /// <summary>
        /// 角色列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            var list = roleBll.GetList();
            return View(list);
        }

        [HttpGet]
        public ActionResult AddRole(string id=null)
        {
            //如果ID为null 则是添加，否则是修改
            if (string.IsNullOrEmpty(id))
            {
                return View();
            }
            var role = roleBll.GetById(id);
            return View(role);
        }

        [HttpPost]
        public ActionResult AddRole(SysRole role)
        {




            //TODO
            role.CreateAt = DateTime.Now;
            role.CreateBy = "Dong";
            role.RoleId = Guid.NewGuid().ToString();
            var i = roleBll.Insert(role);
            return Json(1 == i ? new RetJson() { Code = 200, Flag = true, Msg = "操作成功" } : new RetJson() { Code = 200, Flag = false, Msg = "操作失败" });
        }

        public ActionResult DeleteRole(string id)
        {
            var i = roleBll.Delete(id);
            return Json(1 == i ? new RetJson() { Code = 200, Flag = true, Msg = "操作成功" } : new RetJson() { Code = 200, Flag = false, Msg = "操作失败" }, JsonRequestBehavior.AllowGet);
        }
    }
}