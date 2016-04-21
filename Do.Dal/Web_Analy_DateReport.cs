namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_Analy_DateReport
    {
        public int ID { get; set; }

        public DateTime ReportDate { get; set; }

        public int AvgOnline { get; set; }

        public int MaxOnline { get; set; }

        public int MinOnline { get; set; }

        public int LoginNum { get; set; }

        public int ActiveNum { get; set; }

        public int ActiveGameCount { get; set; }

        public int NewUserNum { get; set; }

        public int PayNum { get; set; }

        public int PayMoneyCount { get; set; }

        public int PayCount { get; set; }

        public int GameCount { get; set; }

        public int TaxCount { get; set; }

        [Required]
        [StringLength(100)]
        public string AgencyName { get; set; }

        public int AgencyID { get; set; }

        public int RegNum { get; set; }
    }
}