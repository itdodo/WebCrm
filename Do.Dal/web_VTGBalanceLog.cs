namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class web_VTGBalanceLog
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ClearingTime { get; set; }

        public int? Money { get; set; }

        [StringLength(30)]
        public string IP { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string UserName { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string NickName { get; set; }
    }
}
