namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_FineryID
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FineryID { get; set; }

        public int? UserID { get; set; }

        [StringLength(50)]
        public string PassWord { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Price { get; set; }

        [StringLength(50)]
        public string Explain { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool IsBuy { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool IsUse { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool IsSale { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool IsTop { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool IsCopy { get; set; }

        [Key]
        [Column(Order = 7)]
        public DateTime DateTime { get; set; }

        public DateTime? DateTimeBuy { get; set; }

        public DateTime? DateTimeUse { get; set; }

        public DateTime? DateTimeCopy { get; set; }
    }
}
