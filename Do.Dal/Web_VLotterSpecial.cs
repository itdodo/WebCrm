namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_VLotterSpecial
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }

        public int? AwardID { get; set; }

        public bool? Status { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime AddDate { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string UserName { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string LotteryAwardName { get; set; }
    }
}
