namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_VGameRoomInfo2
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string RoomName { get; set; }

        public int? BattleRoomID { get; set; }

        [StringLength(50)]
        public string BattleMatchTable { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string BattleRoomName { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(14)]
        public string GameName { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime BattleBeginTime { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime BattleEndTime { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GameNameID { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RoomID { get; set; }
    }
}
