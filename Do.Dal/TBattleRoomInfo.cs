namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TBattleRoomInfo")]
    public partial class TBattleRoomInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BattleRoomID { get; set; }

        [Required]
        [StringLength(50)]
        public string RoomName { get; set; }

        public DateTime BeginTime { get; set; }

        public DateTime EndTime { get; set; }
    }
}
