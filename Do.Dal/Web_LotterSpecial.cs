namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_LotterSpecial
    {
        public int ID { get; set; }

        public int UserID { get; set; }

        public int? AwardID { get; set; }

        public bool? Status { get; set; }

        public DateTime AddDate { get; set; }
    }
}
