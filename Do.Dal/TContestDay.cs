namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TContestDay")]
    public partial class TContestDay
    {
        public int ID { get; set; }

        public int ContestID { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public byte AllowGame { get; set; }

        public short ReportStatus { get; set; }

        public virtual TContestInfo TContestInfo { get; set; }
    }
}
