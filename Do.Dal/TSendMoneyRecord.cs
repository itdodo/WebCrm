namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TSendMoneyRecord")]
    public partial class TSendMoneyRecord
    {
        public int id { get; set; }

        public int UserID { get; set; }

        public int DaySendMoney { get; set; }

        public int DaySendTimes { get; set; }

        [Required]
        [StringLength(20)]
        public string SendDate { get; set; }

        public int RoomID { get; set; }

        public virtual TUsers TUsers { get; set; }
    }
}
