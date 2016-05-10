using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Do.Db.Oracle;
using Do.Entity;

namespace Do.Dal
{
    public class TestDb :DbContext
    {
        public TestDb() : base("name=Test")
        {
        }

        public DbSet<SysMenu> Menus { get; set; } 
    }
}
