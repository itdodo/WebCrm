namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_IndexFlash
    {
        [Key]
        public int Flash_ID { get; set; }

        [StringLength(100)]
        public string Title { get; set; }

        [StringLength(200)]
        public string Picture { get; set; }

        [StringLength(200)]
        public string URL { get; set; }

        public int? Flash_Sort { get; set; }

        public bool? Through { get; set; }
    }
}
