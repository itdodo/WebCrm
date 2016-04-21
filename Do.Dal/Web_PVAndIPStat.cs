namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_PVAndIPStat
    {
        public int ID { get; set; }

        public int AgencyID { get; set; }

        [Required]
        [StringLength(100)]
        public string IP { get; set; }

        [Required]
        [StringLength(1000)]
        public string PageUrl { get; set; }

        [Required]
        [StringLength(20)]
        public string ReportDate { get; set; }
    }
}
