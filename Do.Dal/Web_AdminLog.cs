namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_AdminLog
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string ModelName { get; set; }

        [StringLength(50)]
        public string TableName { get; set; }

        [StringLength(300)]
        public string TablePrimaryKey { get; set; }

        [StringLength(300)]
        public string BeEditField { get; set; }

        [StringLength(300)]
        public string BeforeEdit { get; set; }

        [StringLength(300)]
        public string AfterEdit { get; set; }

        public int ByWho { get; set; }

        public DateTime ByTime { get; set; }

        [Required]
        [StringLength(15)]
        public string ByIP { get; set; }

        [StringLength(500)]
        public string Remark { get; set; }
    }
}
