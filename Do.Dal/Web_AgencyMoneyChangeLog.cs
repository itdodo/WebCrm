namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_AgencyMoneyChangeLog
    {
        public int ID { get; set; }

        public int AgencyID { get; set; }

        [Required]
        [StringLength(20)]
        public string AgencyName { get; set; }

        public long MoneyB { get; set; }

        public long ChangeMoney { get; set; }

        public long MoneyA { get; set; }

        public int OperaType { get; set; }

        [Required]
        [StringLength(20)]
        public string TypeDesc { get; set; }

        public DateTime AddTime { get; set; }

        [Required]
        [StringLength(50)]
        public string Remark { get; set; }
    }
}
