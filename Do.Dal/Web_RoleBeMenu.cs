namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_RoleBeMenu
    {
        public int ID { get; set; }

        public int RoleID { get; set; }

        public int MenuID { get; set; }

        [StringLength(100)]
        public string MenuPermission { get; set; }
    }
}
