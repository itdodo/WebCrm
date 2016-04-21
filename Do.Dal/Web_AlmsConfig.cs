namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_AlmsConfig
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int AlmsMoney { get; set; }

        public int AlmsDayCounts { get; set; }

        [Required]
        public string AlmsFirstNews { get; set; }

        [Required]
        public string AlmsSecondNews { get; set; }

        [Required]
        public string AlmsThirdNews { get; set; }

        public int AlmsLimitMoney { get; set; }
    }
}
