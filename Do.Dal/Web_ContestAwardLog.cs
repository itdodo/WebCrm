namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_ContestAwardLog
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ContestID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string AwardName { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(10)]
        public string UserID { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserRank { get; set; }

        public int? Lottery { get; set; }

        public long? AwardMoney { get; set; }

        [StringLength(50)]
        public string PropName { get; set; }

        public int? PropCount { get; set; }

        [StringLength(50)]
        public string PropName1 { get; set; }

        public int? PropCount1 { get; set; }

        [StringLength(50)]
        public string PropName2 { get; set; }

        public int? PropCount2 { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime RecordTime { get; set; }
    }
}
