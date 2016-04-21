namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_AgencyBalanceLog
    {
        [Key]
        public int BaID { get; set; }

        public int AgencyID { get; set; }

        public long BaMoney { get; set; }

        public long BaMoneyB { get; set; }

        public long BaMoneyA { get; set; }

        public DateTime Addtime { get; set; }

        public long AdminID { get; set; }
    }
}
