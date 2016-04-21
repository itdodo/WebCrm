namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TGM_OperationRecord
    {
        public int ID { get; set; }

        public int UserID { get; set; }

        public int GMID { get; set; }

        public int OperationType { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime BeginTime { get; set; }

        public int LastMinutes { get; set; }

        public int AwardType { get; set; }

        [Required]
        [StringLength(64)]
        public string Reason { get; set; }
    }
}
