namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_System
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string ParaName { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string ParaValue { get; set; }

        [Required]
        [StringLength(50)]
        public string Descript { get; set; }
    }
}
