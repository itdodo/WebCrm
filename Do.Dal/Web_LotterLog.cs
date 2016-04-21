namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_LotterLog
    {
        public int ID { get; set; }

        public int UserID { get; set; }

        public int AwardID { get; set; }

        public DateTime AddDate { get; set; }

        public int LotterType { get; set; }

        public long ChangeMoney { get; set; }

        public int Status { get; set; }
    }
}
