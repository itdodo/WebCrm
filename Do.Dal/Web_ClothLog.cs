namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_ClothLog
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ClothID { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string LogName { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Price { get; set; }

        public int? LogID { get; set; }

        public int? LogSex { get; set; }

        public long? sendLotteries { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime SendTime { get; set; }

        [StringLength(20)]
        public string Remark { get; set; }
    }
}
