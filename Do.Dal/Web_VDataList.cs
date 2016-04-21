namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_VDataList
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TypeID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string TypeName { get; set; }

        public int? CountTotal { get; set; }

        public DateTime? StartTime { get; set; }

        public DateTime? EndTime { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string TableName { get; set; }
    }
}
