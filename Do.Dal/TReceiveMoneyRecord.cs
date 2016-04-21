namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TReceiveMoneyRecord")]
    public partial class TReceiveMoneyRecord
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ReceiveCount { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime LastReceiveTime { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ReceiveMoneyCount { get; set; }

        [Key]
        [Column(Order = 4)]
        public long ID { get; set; }
    }
}
