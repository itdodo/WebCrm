namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_VAgency_UserPayList
    {
        [StringLength(50)]
        public string OrderIDOrNum { get; set; }

        public int? UserID { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        public int? PayMoney { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? AddTime { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PayType { get; set; }

        public int? PaySuccess { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AgencyID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string AgencyName { get; set; }

        public long? MoneyFront { get; set; }

        public long? MoneyAfter { get; set; }
    }
}
