namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TContestUserRecord")]
    public partial class TContestUserRecord
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ContestID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DayID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }

        [StringLength(30)]
        public string NickName { get; set; }

        [Key]
        [Column(Order = 3)]
        public byte ContestState { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ContestScore { get; set; }

        public long? LastScore { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ContestCount { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RankNum { get; set; }

        public byte? IsAward { get; set; }

        public int? AwardID { get; set; }

        [Key]
        [Column(Order = 7)]
        public DateTime EntryTime { get; set; }

        [Key]
        [Column(Order = 8)]
        public DateTime LeftTime { get; set; }
    }
}
