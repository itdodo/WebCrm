namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_TGPayRecord
    {
        [Key]
        public int RecordID { get; set; }

        public int? PayUserID { get; set; }

        public int? TGUserID { get; set; }

        public int? PayMoney { get; set; }

        public int? GetMoney { get; set; }

        [StringLength(50)]
        public string PayType { get; set; }

        public DateTime? AddTime { get; set; }
    }
}
