namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_ClearingLog
    {
        public int ID { get; set; }

        public int UserID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ClearingTime { get; set; }

        public int? Money { get; set; }

        [StringLength(30)]
        public string IP { get; set; }
    }
}
