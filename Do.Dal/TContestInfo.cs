namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TContestInfo")]
    public partial class TContestInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TContestInfo()
        {
            TContestDay = new HashSet<TContestDay>();
        }

        [Key]
        public int ContestID { get; set; }

        public int RoomID { get; set; }

        public int AwardTypeID { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public long Chip { get; set; }

        public int LowCount { get; set; }

        public long LowChip { get; set; }

        public long EntryFee { get; set; }

        public int CancleType { get; set; }

        public int CancleRate { get; set; }

        public int UpPeople { get; set; }

        public int MinPeople { get; set; }

        public int RankDis { get; set; }

        [Required]
        [StringLength(100)]
        public string Message { get; set; }

        [Required]
        [StringLength(5)]
        public string SendTime { get; set; }

        [StringLength(200)]
        public string MatchDesc { get; set; }

        [Column(TypeName = "ntext")]
        public string MatchContent { get; set; }

        public int? TimeOut { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TContestDay> TContestDay { get; set; }
    }
}
