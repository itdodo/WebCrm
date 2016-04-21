namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_ApplyVipRoom
    {
        public int ID { get; set; }

        public int UserID { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string QQ { get; set; }

        [StringLength(50)]
        public string Mobile { get; set; }

        public int ApplyGameNameID { get; set; }

        public DateTime OpenRoomDate { get; set; }

        public int AppleyDays { get; set; }

        [Required]
        [StringLength(50)]
        public string RoomName { get; set; }

        [Required]
        [StringLength(50)]
        public string RoomPwd { get; set; }

        public int DeskCount { get; set; }

        public int TaxType { get; set; }

        public int Tax { get; set; }

        public int MaxPeople { get; set; }

        public int BasePoint { get; set; }

        public int LessPoint { get; set; }

        public int MaxPoint { get; set; }

        [StringLength(1000)]
        public string RoomMsg { get; set; }

        [StringLength(1000)]
        public string RallWelcome { get; set; }

        public string Remark { get; set; }

        public int RoomID { get; set; }

        public short AuditStatus { get; set; }

        public DateTime AddDate { get; set; }
    }
}
