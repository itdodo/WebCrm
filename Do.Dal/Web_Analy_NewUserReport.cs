namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_Analy_NewUserReport
    {
        public int ID { get; set; }

        public DateTime ReportDate { get; set; }

        public int RegNum { get; set; }

        public int LoginNum { get; set; }

        public int ActiveNum { get; set; }

        public int GameCount { get; set; }

        public int PayNum { get; set; }

        public int PayMoneyCount { get; set; }
    }
}
