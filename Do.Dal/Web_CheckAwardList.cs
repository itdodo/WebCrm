namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_CheckAwardList
    {
        [Key]
        public int AwardID { get; set; }

        [StringLength(50)]
        public string AwardName { get; set; }

        public long? AwardMoney { get; set; }

        public int? Lottery { get; set; }

        public int? PropID { get; set; }

        public int? PropCount { get; set; }

        public int? PropID1 { get; set; }

        public int? PropCount1 { get; set; }

        public int? PropID2 { get; set; }

        public int? PropCount2 { get; set; }
    }
}
