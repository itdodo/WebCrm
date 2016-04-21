namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TGameRoomTable")]
    public partial class TGameRoomTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RoomID { get; set; }

        [Required]
        [StringLength(30)]
        public string TableLock { get; set; }

        [Required]
        [StringLength(30)]
        public string TableIPRule { get; set; }

        [Required]
        [StringLength(30)]
        public string TableMatch { get; set; }

        [Required]
        [StringLength(30)]
        public string TableUserNameRule { get; set; }

        public virtual TGameRoomBase TGameRoomBase { get; set; }
    }
}
