namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_CheckInGot
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }

        public long? AwardMoney { get; set; }

        public long? Lottery { get; set; }

        public int? PropID { get; set; }

        public int? PropCount { get; set; }

        public int? PropID1 { get; set; }

        public int? PropCount1 { get; set; }

        public int? PropID2 { get; set; }

        public int? PropCount2 { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime GotTime { get; set; }

        public int? CheckInSetID { get; set; }

        [StringLength(50)]
        public string CheckInSetName { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AwardID { get; set; }
    }
}
