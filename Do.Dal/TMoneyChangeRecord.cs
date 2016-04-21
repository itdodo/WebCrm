namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TMoneyChangeRecord")]
    public partial class TMoneyChangeRecord
    {
        public int ID { get; set; }

        public int UserID { get; set; }

        public long MoneyInBank { get; set; }

        public long MoneyInRoom { get; set; }

        public long OutMoney { get; set; }

        public long InMoney { get; set; }

        public int RoomID { get; set; }

        public DateTime TimeEx { get; set; }

        public int Error { get; set; }

        public virtual TUsers TUsers { get; set; }
    }
}
