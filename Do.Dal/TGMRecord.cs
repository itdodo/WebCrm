namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TGMRecord")]
    public partial class TGMRecord
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GMID { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime beginTime { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(250)]
        public string MsgResult { get; set; }
    }
}
