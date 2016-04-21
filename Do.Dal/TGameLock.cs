namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TGameLock")]
    public partial class TGameLock
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RoomID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(15)]
        public string AccessIP { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(30)]
        public string RoomName { get; set; }

        public virtual TUsers TUsers { get; set; }
    }
}
