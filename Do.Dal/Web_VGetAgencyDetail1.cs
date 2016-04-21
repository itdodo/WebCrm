namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_VGetAgencyDetail1
    {
        [Key]
        [Column(Order = 0)]
        public int AgencyID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string AgencyName { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ParentAgencyID { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LevelID { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Account { get; set; }

        public long? NotBaMoney { get; set; }

        public int? MyDownAgencyCount { get; set; }

        public int? MyDownPlayerCount { get; set; }

        [StringLength(100)]
        public string ParentAgencyName { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string TrueName { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime RegisterTime { get; set; }

        [Key]
        [Column(Order = 7)]
        public decimal SpareValueRate { get; set; }

        [Key]
        [Column(Order = 8)]
        public byte IsTaboo { get; set; }
    }
}
