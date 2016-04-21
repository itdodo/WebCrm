namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sale_Bars
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string BarUser { get; set; }

        [Required]
        [StringLength(50)]
        public string BarName { get; set; }

        [Required]
        [StringLength(50)]
        public string PassWord { get; set; }

        [StringLength(15)]
        public string PhoneNum { get; set; }

        [StringLength(150)]
        public string Address { get; set; }

        [StringLength(50)]
        public string MachineCode { get; set; }

        public long AllMoney { get; set; }

        public long DebtMoney { get; set; }

        public short Status { get; set; }

        public DateTime AddTime { get; set; }
    }
}
