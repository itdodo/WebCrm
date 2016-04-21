namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_AwardLog
    {
        [Key]
        public int Log_ID { get; set; }

        public int? Award_ID { get; set; }

        public int? UserID { get; set; }

        public long? Award_MoneyCost { get; set; }

        public bool? IsCash { get; set; }

        public DateTime? AwardTime { get; set; }

        public int? Award_OnLineTime { get; set; }

        [StringLength(50)]
        public string TrueName { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        [StringLength(500)]
        public string UserRemark { get; set; }
    }
}
