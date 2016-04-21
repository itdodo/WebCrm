namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TGameIPRule")]
    public partial class TGameIPRule
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(15)]
        public string AccessIPChar { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool LimitedReg { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool LimitedLogon { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime OverTime { get; set; }
    }
}
