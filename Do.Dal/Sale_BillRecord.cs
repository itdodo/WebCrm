namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sale_BillRecord
    {
        public int ID { get; set; }

        public int BillID { get; set; }

        public long SendMoney { get; set; }

        public DateTime SendTime { get; set; }

        [StringLength(300)]
        public string Remark { get; set; }

        [StringLength(50)]
        public string AdminUser { get; set; }
    }
}
