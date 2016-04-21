namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TRoomIPRule")]
    public partial class TRoomIPRule
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(15)]
        public string AccessIPChar { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool LimitedGame { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool bLimitedBank { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime OverTime { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RoomID { get; set; }
    }
}
