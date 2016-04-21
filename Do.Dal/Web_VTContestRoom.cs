namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_VTContestRoom
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ContestID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SendTypeID { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime StartTime { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime EndTime { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Chip { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LowCount { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long EntryFee { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UpPeople { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(50)]
        public string Message { get; set; }

        [Key]
        [Column(Order = 9)]
        public DateTime SendTime { get; set; }

        [StringLength(14)]
        public string ComName { get; set; }

        [StringLength(3000)]
        public string AwardContent { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [Column(TypeName = "ntext")]
        public string MatchContent { get; set; }
    }
}
