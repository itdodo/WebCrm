namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TSendMoneyRecord_New
    {
        public int id { get; set; }

        public int UserID { get; set; }

        public int RoomID { get; set; }

        public int SendMoney { get; set; }

        public int SendCount_1 { get; set; }

        public int SendCount_2 { get; set; }

        public int SendType { get; set; }

        [Required]
        [StringLength(15)]
        public string SendDate { get; set; }

        public virtual TUsers TUsers { get; set; }
    }
}
