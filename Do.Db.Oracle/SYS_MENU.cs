namespace Do.Db.Oracle
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PLATFORMNEW.SYS_MENU")]
    public partial class SYS_MENU
    {
        [Key]
        [StringLength(60)]
        public string MenuId { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(255)]
        public string Url { get; set; }

        [StringLength(60)]
        public string ParentId { get; set; }

        public DateTime? CreateAt { get; set; }

        [StringLength(60)]
        public string CreateBy { get; set; }
    }
}
