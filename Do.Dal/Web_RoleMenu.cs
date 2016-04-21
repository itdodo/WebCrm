namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_RoleMenu
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int PID { get; set; }

        [StringLength(200)]
        public string ICO { get; set; }

        [StringLength(250)]
        public string URL { get; set; }

        [StringLength(100)]
        public string Permission { get; set; }

        public int? SortID { get; set; }

        public int MenuType { get; set; }
    }
}
