namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_AdminEmail
    {
        [Key]
        public int MsgID { get; set; }

        [Required]
        [StringLength(500)]
        public string MsgContent { get; set; }

        public DateTime SendTime { get; set; }

        [Required]
        [StringLength(50)]
        public string AdminName { get; set; }

        public int UserID { get; set; }

        public int IsSend { get; set; }

        public int IsToAll { get; set; }

        public int IsMarquee { get; set; }

        [Column(TypeName = "ntext")]
        public string MsgWebContent { get; set; }

        public int? Type { get; set; }

        [StringLength(100)]
        public string MsgTitle { get; set; }

        public int? IsHallMarquee { get; set; }

        public int? LoopTime { get; set; }

        public int? MsgTimes { get; set; }
    }
}
