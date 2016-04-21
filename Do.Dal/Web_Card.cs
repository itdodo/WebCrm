namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_Card
    {
        public int ID { get; set; }

        public int? Users_ids { get; set; }

        [StringLength(50)]
        public string num { get; set; }

        [StringLength(50)]
        public string pwd { get; set; }

        public int? jine { get; set; }

        [StringLength(50)]
        public string player { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? tm { get; set; }

        [StringLength(15)]
        public string ip { get; set; }

        public bool? pay { get; set; }

        [StringLength(10)]
        public string types { get; set; }

        public DateTime? addtime { get; set; }

        public long BMoney { get; set; }

        public long AMoney { get; set; }

        public int? ToPoint { get; set; }

        public int CreateBy { get; set; }

        public DateTime CreateTime { get; set; }

        [Required]
        [StringLength(15)]
        public string CreateIP { get; set; }

        public int Statu { get; set; }

        public int CardType { get; set; }

        [StringLength(50)]
        public string BarUser { get; set; }
    }
}
