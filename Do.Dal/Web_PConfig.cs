namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_PConfig
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(2000)]
        public string Description { get; set; }

        [StringLength(1000)]
        public string Field1 { get; set; }

        [StringLength(1000)]
        public string Field2 { get; set; }

        [StringLength(1000)]
        public string Field3 { get; set; }

        [StringLength(1000)]
        public string Field4 { get; set; }

        [StringLength(1000)]
        public string Field5 { get; set; }

        [StringLength(1000)]
        public string Field6 { get; set; }

        [StringLength(1000)]
        public string Field7 { get; set; }

        [StringLength(1000)]
        public string Field8 { get; set; }
    }
}
