namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_TaxStatEveryDay
    {
        public int ID { get; set; }

        public DateTime StatTime { get; set; }

        public int NameID { get; set; }

        public long Tax { get; set; }
    }
}
