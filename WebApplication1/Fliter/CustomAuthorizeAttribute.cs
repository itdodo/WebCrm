using System;
using System.Linq;
using System.Net.Security;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;
using Do.Bll;
using WebGrease.Css.Extensions;

namespace Do.Web.Backend.Fliter
{
    public class CustomAuthorizeAttribute: AuthorizeAttribute
    {
        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            base.HandleUnauthorizedRequest(filterContext);
        }
        
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            if (httpContext == null)
            {
                throw new ArgumentNullException("HttpContext");
            }
            if (!httpContext.User.Identity.IsAuthenticated)
            {
                return false;
            }
            return true;
            //禁止直接输入功能模块访问
            //if (httpContext.Request.UrlReferrer == null)
            //    return false;
            //var url = httpContext.Request.RawUrl;
            //if (url.ToLower() == "/home/index")
            //   return true;
            //return true;
            //确定当前用户角色是否属于指定的角色
            //#region 确定当前用户角色是否属于指定的角色
            //1. 获取用户名字
            //var currentUser = httpContext.User.Identity.Name;

            //var userinfo = new UserBll().GetList(c => c.UserName == currentUser).FirstOrDefault();
            //if (userinfo == null || userinfo.UserId == null || userinfo.RoleId == null)
            //    return false;

            //var roleMenu = new RoleMenuBll().GetList(c => c.RoleId == userinfo.RoleId);
            //var menuList = new MenuBll().GetList();
            //var q = from a in menuList
            //        join b in roleMenu on a.MenuId equals b.MenuId
            //        where b.RoleId == userinfo.RoleId
            //        select new { a.Url };
            //foreach (var item in q)
            //{
            //    if (item.Url == url)
            //    {
            //        return true;
            //    }
            //}

            //#endregion

            return false;
        }

        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            //string controllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;
            //string actionName = filterContext.ActionDescriptor.ActionName;
            //var roleMenu = new RoleMenuBll().GetList(c => c.RoleId == CurrentUser.RoleId);
            //var menuList = new MenuBll().GetList();
            //var q = from a in menuList
            //        join b in roleMenu on a.MenuId equals b.MenuId
            //        where b.RoleId == CurrentUser.RoleId
            //        select new { a.Url };
            //filterContext.Result = null;

            //foreach (var item in q)
            //{
            //    if (item.Url == url)
            //    {
            //        return true;
            //    }
            //}
            base.OnAuthorization(filterContext);
        }
    }
}
