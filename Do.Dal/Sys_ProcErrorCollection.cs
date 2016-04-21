namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_ProcErrorCollection
    {
        public long ID { get; set; }

        public int Number { get; set; }

        public int Severity { get; set; }

        public int State { get; set; }

        [Required]
        [StringLength(2000)]
        public string ProcName { get; set; }

        public int Line { get; set; }

        [Required]
        [StringLength(2000)]
        public string Msg { get; set; }

        public DateTime InputDate { get; set; }
    }
}
