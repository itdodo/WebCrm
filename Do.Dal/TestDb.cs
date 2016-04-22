using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Do.Entity;

namespace Do.Dal
{
    public class TestDb :DbContext
    {
        public TestDb() : base("name=Test")
        {
        }

        public DbSet<Menu> Menus { get; set; } 
    }
}
