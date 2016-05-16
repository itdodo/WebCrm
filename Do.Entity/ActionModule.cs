using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do.Entity
{
    public class ActionModule
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

        public virtual int Sort { get; set; }
    }
}
