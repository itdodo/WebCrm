namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_AgencyRMBCost
    {
        [Key]
        public int PayID { get; set; }

        [Required]
        [StringLength(30)]
        public string TrueName { get; set; }

        [Required]
        [StringLength(50)]
        public string Phone { get; set; }

        [Required]
        [StringLength(50)]
        public string UserName { get; set; }

        public int PayMoney { get; set; }

        public byte PayType { get; set; }

        [Required]
        [StringLength(50)]
        public string TypeInfo { get; set; }

        [Required]
        [StringLength(50)]
        public string OrderID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime AddTime { get; set; }

        public bool PaySuccess { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? BackTime { get; set; }

        public int MoneyFront { get; set; }

        public int MoneyAfter { get; set; }
    }
}
