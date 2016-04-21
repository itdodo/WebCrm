namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_Clothes
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string LogName { get; set; }

        public long Price { get; set; }

        public long SendLotteries { get; set; }

        public int LogID { get; set; }

        public bool Sex { get; set; }

        [StringLength(1000)]
        public string Descript { get; set; }

        public int? LargessGold { get; set; }

        public int SendGold { get; set; }

        public int PriceType { get; set; }
    }
}
