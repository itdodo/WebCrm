namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_UserModifyLog
    {
        public int ID { get; set; }

        public int? UserID { get; set; }

        [StringLength(20)]
        public string OldValue { get; set; }

        [StringLength(20)]
        public string NewValue { get; set; }

        public byte? MType { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? MTime { get; set; }
    }
}
