namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_vAgencySpareValue
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
        public int ParentID { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string ParentName { get; set; }

        public long? SpareMoney { get; set; }
    }
}
