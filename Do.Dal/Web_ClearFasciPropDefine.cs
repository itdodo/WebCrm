namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_ClearFasciPropDefine
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [Required]
        [StringLength(300)]
        public string Description { get; set; }

        public int Price { get; set; }

        public int DecFasci { get; set; }

        public int SortNum { get; set; }

        public DateTime InputDate { get; set; }
    }
}
