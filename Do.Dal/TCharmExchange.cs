namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TCharmExchange")]
    public partial class TCharmExchange
    {
        public int id { get; set; }

        public int CharmValue { get; set; }

        public int PropID { get; set; }

        public int PropCount { get; set; }
    }
}
