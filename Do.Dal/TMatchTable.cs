namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TMatchTable")]
    public partial class TMatchTable
    {
        public int ID { get; set; }

        public int UserID { get; set; }

        public int RoomID { get; set; }

        public int NameID { get; set; }

        public long Point { get; set; }

        public long Money { get; set; }

        public long TaxCom { get; set; }

        public int Win { get; set; }

        public int Lost { get; set; }

        public int Mid { get; set; }

        public int Cut { get; set; }

        public int PlayTimeCount { get; set; }

        public int OnLineTimeCount { get; set; }

        public int MasterPower { get; set; }

        public int GamePower { get; set; }

        public int LogonTimes { get; set; }

        public DateTime LogonDate { get; set; }

        public int PlayTimes_T { get; set; }

        public int PlayCounts_T { get; set; }

        public virtual TGameNameInfo TGameNameInfo { get; set; }

        public virtual TUsers TUsers { get; set; }
    }
}
