namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class web_vTGpayClearing
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RecordID { get; set; }

        public int? PayUserID { get; set; }

        public int? TGUserID { get; set; }

        public int? PayMoney { get; set; }

        public int? GetMoney { get; set; }

        [StringLength(50)]
        public string PayType { get; set; }

        public DateTime? AddTime { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string UserName { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime RegisterTM { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PlayTimeHourCount { get; set; }
    }
}
