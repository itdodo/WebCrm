namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_vExchangeFasciLog
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string UserName { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }

        public int? ExchangeCount { get; set; }

        public int? ConPrice { get; set; }

        public int? InMoney { get; set; }

        [StringLength(50)]
        public string IP { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ChangeFrontMoney { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ChangeAfterMoney { get; set; }

        public DateTime? AddTime { get; set; }
    }
}
