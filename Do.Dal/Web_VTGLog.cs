namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_VTGLog
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int? UserID { get; set; }

        public int? TG_UserID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? RegTime { get; set; }

        public int? GameTimeCount { get; set; }

        public int? GetMoney { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CalTime { get; set; }

        public bool? IsClearing { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string UserName { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string TGUserName { get; set; }

        public int? IsRegAward { get; set; }
    }
}
