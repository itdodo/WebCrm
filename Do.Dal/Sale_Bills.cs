namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sale_Bills
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [StringLength(50)]
        public string AdminUser { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string BarUser { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string BarName { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TransMoney { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long DebtMoney { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime AddTime { get; set; }

        [StringLength(300)]
        public string Remark { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Statu { get; set; }
    }
}
