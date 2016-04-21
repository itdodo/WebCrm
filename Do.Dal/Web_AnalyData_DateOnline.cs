namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_AnalyData_DateOnline
    {
        public int ID { get; set; }

        public int AvgOnline { get; set; }

        public int MaxOnline { get; set; }

        public int MinOnline { get; set; }

        public DateTime ReportDate { get; set; }
    }
}
