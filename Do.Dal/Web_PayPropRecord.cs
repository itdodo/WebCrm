namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_PayPropRecord
    {
        public int? UserID { get; set; }

        [StringLength(20)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string NickName { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string BuyType { get; set; }

        [StringLength(50)]
        public string GoodName { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PriceType { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long PayPrice { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PayNum { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(4)]
        public string TranType { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime PayTime { get; set; }

        [StringLength(20)]
        public string Remark { get; set; }
    }
}
