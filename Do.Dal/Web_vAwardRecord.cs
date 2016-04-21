namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_vAwardRecord
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Log_ID { get; set; }

        public int? Award_ID { get; set; }

        [StringLength(50)]
        public string Award_Name { get; set; }

        public int? UserID { get; set; }

        [StringLength(20)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string NickName { get; set; }

        [StringLength(50)]
        public string TrueName { get; set; }

        public long? Award_MoneyCost { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        public bool? IsCash { get; set; }

        public DateTime? AwardTime { get; set; }

        public int? Award_OnLineTime { get; set; }
    }
}
