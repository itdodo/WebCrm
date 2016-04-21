namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_TGClearingRecord
    {
        [Key]
        public int RecordID { get; set; }

        public int? CUserID { get; set; }

        public int? TGUserID { get; set; }

        public int? CMoney { get; set; }

        public int? GetMoney { get; set; }

        public DateTime? AddTime { get; set; }
    }
}
