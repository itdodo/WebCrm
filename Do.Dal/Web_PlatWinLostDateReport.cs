namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_PlatWinLostDateReport
    {
        public int ID { get; set; }

        public DateTime ReportDate { get; set; }

        public long InitPlamtformMoney { get; set; }

        public long CurrentPlamtformMoney { get; set; }

        public long AdminOperateMoney { get; set; }

        public int NameID { get; set; }

        public long WonOrLostMoney { get; set; }
    }
}
