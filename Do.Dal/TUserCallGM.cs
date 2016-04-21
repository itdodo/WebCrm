namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TUserCallGM")]
    public partial class TUserCallGM
    {
        [Key]
        public int CallID { get; set; }

        public int UserID { get; set; }

        [Required]
        [StringLength(20)]
        public string UserName { get; set; }

        public int RoomID { get; set; }

        public int NameID { get; set; }

        public int RoomType { get; set; }

        public int DeskStation { get; set; }

        public int DeskNumber { get; set; }

        public int ProblemType { get; set; }

        public DateTime callTime { get; set; }

        [Required]
        [StringLength(250)]
        public string MessageReason { get; set; }

        public int GMID { get; set; }

        [Required]
        [StringLength(20)]
        public string GMName { get; set; }

        public DateTime receiveTime { get; set; }

        public DateTime overTime { get; set; }

        public int TraiteRecord { get; set; }

        public virtual TGameNameInfo TGameNameInfo { get; set; }

        public virtual TUsers TUsers { get; set; }
    }
}
