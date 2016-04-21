namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_VGameKindList
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int KindID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(14)]
        public string KindName { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDSort { get; set; }

        [Key]
        [Column(Order = 3)]
        public byte Enable { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ParentKindID { get; set; }

        [StringLength(14)]
        public string KindParentName { get; set; }
    }
}
