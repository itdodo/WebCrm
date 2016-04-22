using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Do.Bll;
using Do.Entity;
using Do.Common;
namespace Do.Web.Areas.System.Controllers
{
    public class PermissionController : Controller
    {
        readonly MenuBll menuBll = new MenuBll();
        // GET: System/Permission
        public ActionResult Index()
        {
            return View();
        }



        #region 菜单管理
        [HttpGet]
        public ActionResult Menu()
        {
            return View();
        }

        /// <summary>
        /// 获取菜单列表
        /// </summary>
        /// <returns></returns>
        public ActionResult GetMenuList()
        {
            var list = menuBll.GetList();

            var retResult = list.ToGridList();
            
            return Json(retResult, JsonRequestBehavior.AllowGet);
        }

        public ActionResult AddMenu()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PostMenu(Menu entity)
        {

            var i = menuBll.AddMenu(entity);
            return Json(1 == i ? new RetJson() {Code = 200, Flag = true, Msg = "操作成功"} : new RetJson() { Code = 200, Flag = false    , Msg = "操作失败" });
        }
        #endregion

    }
}