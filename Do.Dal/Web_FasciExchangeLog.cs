namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_FasciExchangeLog
    {
        public int ID { get; set; }

        public int UserID { get; set; }

        public int? ExchangeCount { get; set; }

        public int? ConPrice { get; set; }

        public int? InMoney { get; set; }

        [StringLength(50)]
        public string IP { get; set; }

        public long ChangeFrontMoney { get; set; }

        public long ChangeAfterMoney { get; set; }

        public DateTime? AddTime { get; set; }
    }
}
