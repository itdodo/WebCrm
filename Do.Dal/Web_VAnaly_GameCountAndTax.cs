namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_VAnaly_GameCountAndTax
    {
        [StringLength(68)]
        public string ID { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(14)]
        public string ComName { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string RoomName { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RoomID { get; set; }

        [StringLength(8)]
        public string ReportDate { get; set; }

        public int? GameCount { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TaxCount { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaxOnline { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MinOnline { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AvgOnline { get; set; }
    }
}
