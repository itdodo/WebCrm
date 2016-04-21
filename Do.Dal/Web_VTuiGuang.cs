namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_VTuiGuang
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int? UserID { get; set; }

        [StringLength(20)]
        public string TrueName { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ApplyTime { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(100)]
        public string Address { get; set; }

        public bool? Pass { get; set; }

        public int? MoneyCount { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CountTime { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string UserName { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string NickName { get; set; }
    }
}
