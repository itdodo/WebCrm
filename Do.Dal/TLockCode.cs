namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TLockCode")]
    public partial class TLockCode
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(80)]
        public string LockCode { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(80)]
        public string LockHard { get; set; }
    }
}
