namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_VMatchLog
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ContestID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ContestScore { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ContestCount { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime LeftTime { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime StartTime { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime EndTime { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(14)]
        public string ComName { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(20)]
        public string UserName { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NameID { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long LowChip { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LowCount { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(50)]
        public string NickName { get; set; }
    }
}
