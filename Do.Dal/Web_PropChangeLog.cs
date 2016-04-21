namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_PropChangeLog
    {
        public int ID { get; set; }

        public DateTime ActionDate { get; set; }

        [Required]
        [StringLength(100)]
        public string AdminName { get; set; }

        public int UserID { get; set; }

        public int PropID { get; set; }

        public int BeforeNum { get; set; }

        public int AfterNum { get; set; }

        public int? ChangeType { get; set; }
    }
}
