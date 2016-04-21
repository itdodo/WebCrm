namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_msg
    {
        [Key]
        public int msgid { get; set; }

        [StringLength(50)]
        public string msgname { get; set; }

        [StringLength(50)]
        public string msgtitle { get; set; }

        [StringLength(50)]
        public string msgsex { get; set; }

        [StringLength(50)]
        public string tel { get; set; }

        [StringLength(50)]
        public string fax { get; set; }

        [StringLength(50)]
        public string msgface { get; set; }

        [Column(TypeName = "ntext")]
        public string msgtext { get; set; }

        [StringLength(50)]
        public string msgmail { get; set; }

        [StringLength(50)]
        public string msghome { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? msgtime { get; set; }

        [StringLength(50)]
        public string ip { get; set; }

        [StringLength(50)]
        public string msgreplyname { get; set; }

        [Column(TypeName = "ntext")]
        public string msgreply { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? msgreplytime { get; set; }

        public int? msgprivate { get; set; }

        public int? count { get; set; }

        public int? msghit { get; set; }

        public bool? IsPass { get; set; }
    }
}
