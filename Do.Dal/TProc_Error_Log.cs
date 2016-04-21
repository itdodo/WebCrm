namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TProc_Error_Log
    {
        [Key]
        public long ProID { get; set; }

        [StringLength(128)]
        public string ProName { get; set; }

        [StringLength(4098)]
        public string ProParam { get; set; }

        public int? ProNumber { get; set; }

        public int? ProLine { get; set; }

        [StringLength(1024)]
        public string ProMessage { get; set; }

        public DateTime? EndTime { get; set; }
    }
}
