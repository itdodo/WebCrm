namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_GameInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Game_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Game_Name { get; set; }

        [Column(TypeName = "ntext")]
        public string Game_Info { get; set; }

        [Column(TypeName = "ntext")]
        public string Game_Rule { get; set; }

        [StringLength(100)]
        public string Down_address { get; set; }

        public int? Down_Num { get; set; }

        [StringLength(20)]
        public string FileSize { get; set; }

        [StringLength(20)]
        public string Provice { get; set; }

        [StringLength(30)]
        public string Area { get; set; }

        public int? Game_TypeID { get; set; }

        public bool? Through { get; set; }

        [StringLength(100)]
        public string Image_URL { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? UPdate_Time { get; set; }

        public int? Game_Order { get; set; }

        [StringLength(100)]
        public string Game_Process { get; set; }

        [StringLength(100)]
        public string MatchTable { get; set; }

        public bool IsHot { get; set; }

        [Required]
        [StringLength(300)]
        public string Game_SampleIntroduce { get; set; }

        [StringLength(100)]
        public string Image_URL2 { get; set; }

        [StringLength(100)]
        public string Image_URL3 { get; set; }
    }
}
