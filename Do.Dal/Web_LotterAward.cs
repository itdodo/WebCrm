namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_LotterAward
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string LotteryAwardName { get; set; }

        public int GoldRate { get; set; }

        public int SilverRate { get; set; }

        public int JadeRate { get; set; }

        [Required]
        [StringLength(100)]
        public string PicName { get; set; }

        public int? Number { get; set; }

        public DateTime AddDate { get; set; }
    }
}
