namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_FriendLink
    {
        public int ID { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        [Required]
        [StringLength(1000)]
        public string Link { get; set; }

        public int Type { get; set; }

        [Required]
        [StringLength(1000)]
        public string ImagePath { get; set; }

        public int OrderID { get; set; }

        public bool IsEnable { get; set; }

        [Required]
        [StringLength(200)]
        public string ShortDesc { get; set; }

        public DateTime InputTime { get; set; }
    }
}
