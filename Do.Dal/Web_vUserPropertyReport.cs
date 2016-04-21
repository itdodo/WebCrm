namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_vUserPropertyReport
    {
        public long? ID { get; set; }

        public int? UserID { get; set; }

        public long? StartMoney { get; set; }

        public long? ChangeMoney { get; set; }

        public long? AfterMoney { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ChangeType { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime EndTime { get; set; }

        [StringLength(100)]
        public string Remark { get; set; }
    }
}
