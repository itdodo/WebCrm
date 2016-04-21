namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_NewsData
    {
        [Key]
        public int News_ID { get; set; }

        public byte? News_Type { get; set; }

        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        [StringLength(50)]
        public string TitleColor { get; set; }

        [StringLength(100)]
        public string Keywords { get; set; }

        [StringLength(50)]
        public string News_From { get; set; }

        [StringLength(20)]
        public string Author { get; set; }

        [StringLength(20)]
        public string Issuer { get; set; }

        [Column(TypeName = "ntext")]
        public string Content { get; set; }

        [StringLength(100)]
        public string News_picture { get; set; }

        public bool? Through { get; set; }

        public bool? Recommendation { get; set; }

        public bool? Istop { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Issue_Time { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Update_Time { get; set; }

        public int? Hits { get; set; }

        [Required]
        [StringLength(300)]
        public string News_Describe { get; set; }
    }
}
