namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_ContestRank
    {
        public int ID { get; set; }

        public int UserID { get; set; }

        public int DayID { get; set; }

        public int ContestID { get; set; }

        public long Score { get; set; }

        public int RankNum { get; set; }

        public DateTime ReportTime { get; set; }

        [StringLength(50)]
        public string NickName { get; set; }

        [StringLength(50)]
        public string ComName { get; set; }

        public int? ContestCount { get; set; }
    }
}
