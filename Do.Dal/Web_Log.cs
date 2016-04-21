namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_Log
    {
        [Key]
        public int LogID { get; set; }

        [StringLength(20)]
        public string LogUser { get; set; }

        [StringLength(30)]
        public string LogIP { get; set; }

        [StringLength(70)]
        public string OS { get; set; }

        public byte? Result { get; set; }

        [StringLength(500)]
        public string ErrorPas { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? LoginTime { get; set; }

        public bool? IsManage { get; set; }
    }
}
