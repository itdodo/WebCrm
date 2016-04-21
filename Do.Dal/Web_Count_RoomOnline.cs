namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_Count_RoomOnline
    {
        public int ID { get; set; }

        public int RoomID { get; set; }

        public int OnlineCount { get; set; }

        public DateTime InputDate { get; set; }
    }
}
