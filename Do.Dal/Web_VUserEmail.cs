namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_VUserEmail
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MsgID { get; set; }

        [StringLength(100)]
        public string MsgTitle { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime SendTime { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool IsRead { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }
    }
}
