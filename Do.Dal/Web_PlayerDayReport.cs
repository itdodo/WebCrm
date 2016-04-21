namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_PlayerDayReport
    {
        [Key]
        public int RecordID { get; set; }

        public int UserID { get; set; }

        [Required]
        [StringLength(50)]
        public string UserName { get; set; }

        public int AgencyID { get; set; }

        public int MyPercent { get; set; }

        public long LwMoney { get; set; }

        public long SpareMoney { get; set; }

        public DateTime CountTime { get; set; }

        public int RoomName { get; set; }

        public int CountState { get; set; }

        public long WinMoney { get; set; }

        public long LoseMoney { get; set; }

        public int GameNameID { get; set; }
    }
}
