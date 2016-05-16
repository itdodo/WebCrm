using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Do.Common;
using Do.Entity;

namespace Do.Common
{
    public static class Reflect
    {
        public static void GetArea()
        {
            var types = Assembly.Load("Do.Web.Backend").GetTypes();
            foreach (var type in types)
            {
                if (type.BaseType.Name == "AreaRegistration")
                {

                }
            }
        }

        /// <summary>
        /// 反射获取系统所有action
        /// </summary>
        /// <returns></returns>
        public static IList<ActionModule> GetAllActionByAssembly()
        {
            var result = new List<ActionModule>();

            var types = Assembly.Load("Do.Web.Backend").GetTypes();

            foreach (var type in types)
            {
                if (type.BaseType.Name == "BaseController")//如果是Controller
                {
                    var members = type.GetMethods();
                    foreach (var member in members)
                    {
                        if (member.ReturnType.Name == "ActionResult")//如果是Action
                        {

                            var ap = new ActionModule();

                            ap.ActionName = member.Name;
                            ap.ControllerName = member.DeclaringType.Name.Substring(0, member.DeclaringType.Name.Length - 10); // 去掉“Controller”后缀

                            //object[] attrs = member.GetCustomAttributes(typeof(System.ComponentModel.DescriptionAttribute), true);
                            object[] attrs = member.GetCustomAttributes(typeof(ModuleAttribute), true);

                            if (attrs.Length > 0)
                            {
                                ap.Name = (attrs[0] as ModuleAttribute).Name;
                                ap.Code = (attrs[0] as ModuleAttribute).Code;
                            }
                            //ap.Description = (attrs[0] as ModuleAttribute).Desc;

                            result.Add(ap);
                        }

                    }
                }
            }
            return result;
        }
    }
}
