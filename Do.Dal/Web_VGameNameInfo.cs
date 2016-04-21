namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_VGameNameInfo
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NameID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int KindID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(14)]
        public string ComName { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RecommendType { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StarCount { get; set; }

        public int? RecommendRoom { get; set; }

        [StringLength(30)]
        public string RoomName { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(20)]
        public string ComProcess { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDSort { get; set; }

        [Key]
        [Column(Order = 7)]
        public byte Enable { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(14)]
        public string KindName { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(20)]
        public string DLLFileName { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ParentKindID { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DeskPeople { get; set; }

        [StringLength(14)]
        public string ParentKindName { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long EveryDayRent { get; set; }
    }
}
