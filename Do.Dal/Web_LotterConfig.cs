namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_LotterConfig
    {
        public int ID { get; set; }

        public long GoldMoney { get; set; }

        public long SilverMoney { get; set; }

        public long JadeMoney { get; set; }

        public DateTime? BeginTime { get; set; }

        public DateTime? EndTime { get; set; }
    }
}
