namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_Count_OnlineUsers
    {
        public long ID { get; set; }

        public DateTime InputDate { get; set; }

        public int OnlineCount { get; set; }

        public int UserType { get; set; }
    }
}
