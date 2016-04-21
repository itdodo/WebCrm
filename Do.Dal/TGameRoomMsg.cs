namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TGameRoomMsg")]
    public partial class TGameRoomMsg
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RoomID { get; set; }

        [Required]
        [StringLength(500)]
        public string RoomWelcome { get; set; }

        [Required]
        [StringLength(500)]
        public string RallWelcome { get; set; }

        public virtual TGameRoomBase TGameRoomBase { get; set; }
    }
}
