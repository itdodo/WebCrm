namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_UserAlbum
    {
        public int ID { get; set; }

        public int UserID { get; set; }

        public int ColumnID { get; set; }

        [Required]
        [StringLength(300)]
        public string PicName { get; set; }

        [Required]
        [StringLength(1000)]
        public string PicPath { get; set; }

        [Required]
        [StringLength(1000)]
        public string PicDescription { get; set; }

        public int ShortNum { get; set; }

        [Required]
        [StringLength(50)]
        public string Enable { get; set; }

        public DateTime InputTime { get; set; }
    }
}
