namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_DataClearLog
    {
        public int ID { get; set; }

        public int AdminID { get; set; }

        [Required]
        [StringLength(50)]
        public string AdminName { get; set; }

        public int TypeID { get; set; }

        [Required]
        [StringLength(80)]
        public string TypeName { get; set; }

        public DateTime ClearEndTime { get; set; }

        public int ClearCount { get; set; }

        public DateTime AddTime { get; set; }
    }
}
