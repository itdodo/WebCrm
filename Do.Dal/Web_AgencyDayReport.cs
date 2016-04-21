namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_AgencyDayReport
    {
        [Key]
        public int RecordID { get; set; }

        public int AgencyID { get; set; }

        [Required]
        [StringLength(50)]
        public string AgencyName { get; set; }

        public int ParentAgencyID { get; set; }

        public int MyPercent { get; set; }

        public int LevelID { get; set; }

        public int GameNameID { get; set; }

        public long LwMoney { get; set; }

        public long SpareMoney { get; set; }

        public long ActualSpareMoney { get; set; }

        public DateTime CountTime { get; set; }

        public int CountState { get; set; }

        public int IsBalance { get; set; }
    }
}
