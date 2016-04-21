namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_PointChangeLog
    {
        public int ID { get; set; }

        public int UserID { get; set; }

        [Required]
        [StringLength(50)]
        public string UserName { get; set; }

        [Required]
        [StringLength(100)]
        public string OrderID { get; set; }

        public int PayMoney { get; set; }

        public long ExchangeRate { get; set; }

        public bool? InSuccess { get; set; }

        public bool? PaySuccess { get; set; }

        public DateTime? AddTime { get; set; }

        public DateTime? BackTime { get; set; }

        [StringLength(50)]
        public string PayType { get; set; }

        public long BPoint { get; set; }

        public long APoint { get; set; }

        public int GameNameID { get; set; }
    }
}
