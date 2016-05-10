using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Do.Bll;
using Do.Common;
using Do.Db.Oracle;
using Do.Web.Backend.Controllers;
using WebGrease.Css.Extensions;

namespace Do.Web.Backend.Areas.System.Controllers
{
    public class PermissionController : BaseController
    {
        readonly MenuBll menuBll = new MenuBll();
        readonly RoleMenuBll roleMenuBll = new RoleMenuBll();

        public ActionResult Index()
        {
            return View();
        }

        #region 菜单管理-CRUD
        [HttpGet]
        public ActionResult Menu()
        {
            var list = menuBll.GetList();
            return View(list);
        }

        /// <summary>
        /// 获取菜单列表
        /// </summary>
        /// <returns></returns>
        //public ActionResult GetMenuList(SearchModel model)
        //{
        //    var list = menuBll.GetList(model);
            
        //    var retResult = list.ToGridList();
            
        //    return Json(retResult, JsonRequestBehavior.AllowGet);
        //}

        /// <summary>
        /// 打开添加修改页面
        /// </summary>
        /// <returns></returns>
        public ActionResult AddMenu()
        {
            var list = menuBll.GetList();
            list.Insert(0, new SysMenu() { MenuId = "0", Name = "一级菜单" });
            ViewBag.dropList = new SelectList(list, "MenuId","Name");
            return View();
        }

        [HttpPost]
        public ActionResult AddMenu(SysMenu entity)
        {

            var i = menuBll.AddMenu(entity);
            return Json(1 == i ? new RetJson() {Code = 200, Flag = true, Msg = "操作成功"} : new RetJson() { Code = 200, Flag = false    , Msg = "操作失败" });
        }

        /// <summary>
        /// 删除菜单
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult DeleteMenu(string id)
        {
            var i = menuBll.Delete(id);
            return Json(1 == i ? new RetJson() { Code = 200, Flag = true, Msg = "操作成功" } : new RetJson() { Code = 200, Flag = false, Msg = "操作失败" }, JsonRequestBehavior.AllowGet);
        }

        #endregion

        #region 权限-角色菜单划分
        /// <summary>
        /// 角色菜单首页
        /// </summary>
        /// <returns></returns>
        public ActionResult RoleMenu()
        {
            #region 角色列表
            var roleList = new RoleBll().GetList();
            roleList.Insert(0,new SysRole() {Name = "请选择",RoleId = "0"});
            var dropList = new SelectList(roleList,"RoleId","Name");
            ViewBag.dropList = dropList;
            #endregion
            #region 菜单列表
            var list = menuBll.GetMenuByPid("0");
            #endregion
            return View(list);
        }

        /// <summary>
        /// 添加、修改角色菜单权限
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult AddRoleMenu()
        {
            try
            {
                var menuId = Request.Form.AllKeys;
                var roleId = Request.Form["RoleId"];
                if(roleId == "0")
                    return Json(new RetJson() { Code = 400, Flag = true, Msg = "请选择角色" }, JsonRequestBehavior.AllowGet);

                //先删除所属角色的菜单，再添加新的菜单
                #region 批量删除旧权限

                //roleMenuBll.Update(c => c.CreateBy);

                roleMenuBll.Delete(c => c.RoleId == roleId);
                //var delList = roleMenuBll.GetMenuListByRoleId(roleId).Select(c => new SysRoleMenu() { Id = c.Id });
                //if (delList.Any())
                //{
                //    var tempDelList = (delList as IEnumerable<SysRoleMenu>).ToList();
                //    var delCount = roleMenuBll.Delete(tempDelList);

                //}

                #endregion

                #region 批量插入新权限
                var insertList = new List<SysRoleMenu>();
                foreach (var item in menuId)
                {
                    var model = new SysRoleMenu();
                    //TODO
                    if (!item.Contains("MenuId_")) continue;
                    model.RoleId = roleId;
                    model.MenuId = Request.Form[item];
                    model.Id = Guid.NewGuid().ToString();
                    model.CreateAt = DateTime.Now;
                    model.CreateBy = "Dong";
                    insertList.Add(model);                     
                }
                var insertCount = roleMenuBll.Insert(insertList);

                #endregion

            }
            catch (Exception exception)
            {
                throw exception;
            }

            return Json(new RetJson() { Code = 200, Flag = true, Msg = "操作成功" }, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 根据角色ID获取下属所有菜单列表
        /// </summary>
        /// <param name="rid"></param>
        /// <returns></returns>
        public ActionResult GetMenuListByRoleId(string rid)
        {
            var list = roleMenuBll.GetMenuListByRoleId(rid);
            var tempList = from a in list select new { a.MenuId};
            return Json(tempList, JsonRequestBehavior.AllowGet);
        }

        #endregion

        #region 权限-角色用户划分

        public ActionResult RoleUser()
        {
            return View();
        }

        #endregion
    }
}