namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_UserAlbumColumn
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string AlbumName { get; set; }

        [Required]
        [StringLength(1000)]
        public string Cover { get; set; }

        public int UserID { get; set; }

        [Required]
        [StringLength(50)]
        public string IsPublic { get; set; }

        public DateTime InputTime { get; set; }

        public int OrderID { get; set; }
    }
}
