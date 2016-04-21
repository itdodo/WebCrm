using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do.Dal
{
    public class A_test
    {
        [Key]
        public int ID { get; set; }

        public string TestName { get; set; }
    }
}
