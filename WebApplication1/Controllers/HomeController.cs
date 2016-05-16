using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using System.Web.Security;
using Do.Bll;
using Do.Common;
using Newtonsoft.Json;
using System.Web.ModelBinding;
using Do.Web.Backend.Fliter;

namespace Do.Web.Backend.Controllers
{
    [Module(Code = "01",Name = "首页")]
    public class HomeController : BaseController
    {

        [Module(Code = "0101",Name = "系统首页")]
        public ActionResult Index()
        {
            //TODO
            //获取当前登陆用户所拥有的一级导航菜单
            #region 暂时不做多个一级菜单
            //var menu1 = new RoleMenuBll().GetList(c => c.RoleId == CurrentUser.RoleId).Where(c=>c.SysMenu.ParentId=="0");
            
            //ViewBag.menu1 = menu1;
            #endregion

            return View();
        }


        [Module(Code = "0102", Name = "初始化左侧菜单")]
        public ActionResult InitLeftMenu()
        {
            var menuBll = new MenuBll();
            //var menu1 = menuBll.GetMenuByPid("0");
            var menu1 = new RoleMenuBll().GetList(c => c.RoleId == CurrentUser.RoleId).Where(c => c.SysMenu.ParentId == "0");
            var entityList1 = new List<Menu1>();
            var entity1 = new Menu1();

            Stopwatch sw = new Stopwatch();
            sw.Start();
            foreach (var item in menu1)
            {
                entity1.id = item.MenuId;
                //获取二级菜单
                //var menu2 = menuBll.GetMenuByPid(item.MenuId);
                var menu2 =
                    new RoleMenuBll().GetList(c => c.RoleId == CurrentUser.RoleId).Where(c => c.SysMenu.ParentId == item.MenuId).ToList();
                if (menu2.Any())
                {
                    var entityList2 = new List<Menu2>();
                    foreach (var m2 in menu2)
                    {
                        var entity2 = new Menu2();
                        entity2.text = m2.SysMenu.Name;

                        //var menu3 = menuBll.GetMenuByPid(m2.MenuId);
                        var menu3 =
                            new RoleMenuBll().GetList(c => c.RoleId == CurrentUser.RoleId)
                                .Where(c => c.SysMenu.ParentId == m2.MenuId).ToList();
                        if (menu3.Any())
                        {
                            var entityList3 = menu3.Select(m3 => new Menu3
                            {
                                id = m3.MenuId, text = m3.SysMenu.Name, href = m3.SysMenu.Url
                            }).ToList();
                            entity2.items = entityList3;
                        }
                        entityList2.Add(entity2);
                    }
                    entity1.menu = entityList2;
                }

            }
            entityList1.Add(entity1);
            sw.Stop();
            var i = sw.ElapsedMilliseconds;
            //JsonSerializer js = new JsonSerializer();
            //var json = JsonConvert.SerializeObject(entityList1);
            return Json(entityList1, JsonRequestBehavior.AllowGet);
        }


        [Module(Code = "0103", Name = "登陆页面")]
        [AllowAnonymous]
        public ActionResult Login()
        {
            var model = new LoginViewModel();
            FormsAuthentication.SignOut();
            return View(model);
        }


        [Module(Code = "0104", Name = "发送登陆请求")]
        [AllowAnonymous]
        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            if (!ModelState.IsValid) return Json(new RetJson() {Code = 400, Msg = "模型校验失败"});
            if (model.VCode != Session["ValidateCode"].ToString())
            {
                return Json(new RetJson() { Code = 400,  Msg = "验证码校验失败" });
            }
            
            var userBll = new UserBll();
            var entity = userBll.GetFirstRecord(c => c.UserName == model.UserName && c.Password == model.Password );
            if (entity==null)
                return Json(new RetJson() {Code = 400, Msg = "登陆失败"});
            //FormsAuthentication.SetAuthCookie(model.UserName,true);
            FormsAuthentication.SetAuthCookie(model.UserName,true);
            //FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1,model.UserName,DateTime.Now,DateTime.Now.AddDays(1),true,null,"/");
            //var cookie = new HttpCookie(FormsAuthentication.FormsCookieName,FormsAuthentication.Encrypt(ticket));
            //cookie.HttpOnly = true;
            //HttpContext.Response.Cookies.Add(cookie);
            //FormsAuthentication
            CurrentUser.UserName = entity.UserName;
            CurrentUser.UserId = entity.UserId;
            CurrentUser.RoleId = entity.RoleId;
            return Json(new RetJson() { Code = 200, Msg = "登陆成功" });
        }


        [Module(Code = "0105", Name = "退出登陆")]
        [AllowAnonymous]
        public ActionResult Logout()
        {
            //TODO 
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }


        [Module(Code = "0106", Name = "获取验证码")]
        [AllowAnonymous]
        public ActionResult GetValidateCode()
        {
            ValidateCode vCode = new ValidateCode();
            string code = vCode.CreateValidateCode(4);
            Session["ValidateCode"] = code;
            byte[] bytes = vCode.CreateValidateGraphic(code);
            return File(bytes, @"image/jpeg");
        }
    }

    #region 系统导航菜单模型
    public class Menu1
    {
        public string id { get; set; }
        public List<Menu2> menu { get; set; } 
    }

    public class Menu2
    {
        public string text { get; set; }
        public List<Menu3> items { get; set; } 
    }

    public class Menu3
    {
        public string id { get; set; }
        public string text { get; set; }
        public string href { get; set; }
        
    }

    #endregion

    #region 登陆模型

    public class LoginViewModel
    {
        [Required(ErrorMessage = "账号不能为空",AllowEmptyStrings = false)]
        public string UserName { get; set; }
        [Required(ErrorMessage = "密码不能为空",AllowEmptyStrings = false)]
        public string Password { get; set; }
        [Required]
        [StringLength(maximumLength:4,MinimumLength = 4,ErrorMessage = "验证码不能为空")]
        public string VCode { get; set; }
    }

    #endregion
    public class ActionPermission
    {
        /// <summary>
        /// 请求地址
        /// </summary>
        public virtual string ActionName { get; set; }

        /// <summary>
        /// 请求地址
        /// </summary>
        public virtual string ControllerName { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public virtual string Description { get; set; }

        public virtual string Code { get; set; }
        public virtual string Name { get; set; }
    }
}