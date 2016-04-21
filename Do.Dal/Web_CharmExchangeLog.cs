namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_CharmExchangeLog
    {
        [Key]
        public int Log_ID { get; set; }

        public int PropID { get; set; }

        public int UserID { get; set; }

        [Required]
        [StringLength(50)]
        public string PropName { get; set; }

        public int CharmValue { get; set; }

        public int PropCount { get; set; }

        public int Status { get; set; }

        public DateTime InputDate { get; set; }
    }
}
