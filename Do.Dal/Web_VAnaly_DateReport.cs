namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_VAnaly_DateReport
    {
        public int? RegNum { get; set; }

        public int? LoginNum { get; set; }

        public int? ActiveNum { get; set; }

        public int? ActiveGameCount { get; set; }

        public int? NewUserNum { get; set; }

        public int? PayNum { get; set; }

        public int? PayMoneyCount { get; set; }

        public int? PayCount { get; set; }

        public int? GameCount { get; set; }

        public int? TaxCount { get; set; }

        [StringLength(8)]
        public string ReportDate { get; set; }

        [StringLength(10)]
        public string Date { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AvgOnline { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaxOnline { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MinOnline { get; set; }
    }
}
