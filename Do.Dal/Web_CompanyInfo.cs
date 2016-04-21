namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_CompanyInfo
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string ItemName { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string Content { get; set; }

        public int? Sort { get; set; }
    }
}
