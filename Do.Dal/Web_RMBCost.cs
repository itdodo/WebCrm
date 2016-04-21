namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_RMBCost
    {
        [Key]
        public int PayID { get; set; }

        public int? Users_ids { get; set; }

        [StringLength(30)]
        public string TrueName { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        public int? PayMoney { get; set; }

        public byte? PayType { get; set; }

        [StringLength(50)]
        public string TypeInfo { get; set; }

        [StringLength(50)]
        public string OrderID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? AddTime { get; set; }

        public int? ExchangeRate { get; set; }

        public int? InMoney { get; set; }

        public bool? InSuccess { get; set; }

        public bool? PaySuccess { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? BackTime { get; set; }

        [StringLength(1000)]
        public string EncryptStr { get; set; }

        [StringLength(1000)]
        public string Info { get; set; }

        public long? MoneyFront { get; set; }

        public long? MoneyAfter { get; set; }

        public byte? UpdateFlag { get; set; }

        public int? PurchaseType { get; set; }

        [StringLength(50)]
        public string PayIP { get; set; }
    }
}
