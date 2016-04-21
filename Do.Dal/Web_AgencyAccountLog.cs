namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_AgencyAccountLog
    {
        public int ID { get; set; }

        public int AdminID { get; set; }

        public int AgencyID { get; set; }

        public long MoneyB { get; set; }

        public long Range { get; set; }

        public long MoneyA { get; set; }

        public DateTime InputDate { get; set; }
    }
}
