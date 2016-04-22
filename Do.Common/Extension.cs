using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Do.Entity;

namespace Do.Common
{
    public static class Extension
    {
        public static retResult ToGridList(this IEnumerable list)
        {
            var ret = new retResult();
            ret.result = 100;
            ret.rows = list;
            return ret;
        }
    }
}
