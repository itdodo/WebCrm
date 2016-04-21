namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_MoneyChangeLog
    {
        public int ID { get; set; }

        public int UserID { get; set; }

        [Required]
        [StringLength(50)]
        public string UserName { get; set; }

        public long StartMoney { get; set; }

        public long ChangeMoney { get; set; }

        public int ChangeType { get; set; }

        public DateTime DateTime { get; set; }

        [StringLength(100)]
        public string Remark { get; set; }
    }
}
