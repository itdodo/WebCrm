using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do.Entity
{
    [Serializable]
    public class retResult
    {
        public int result { get; set; }
        public dynamic rows { get; set; } 
    }
}
