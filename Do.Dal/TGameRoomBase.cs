namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TGameRoomBase")]
    public partial class TGameRoomBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RoomID { get; set; }

        public int RoomRule { get; set; }

        public int DeskCount { get; set; }

        public int MaxPeople { get; set; }

        public int BasePoint { get; set; }

        public int LessPoint { get; set; }

        public int MoneyPoint { get; set; }

        public int Tax { get; set; }

        public int UserPower { get; set; }

        public int MaxLimite { get; set; }

        public int RunPublish { get; set; }

        public int t_change_m { get; set; }

        public int t_unit { get; set; }

        public int t_money { get; set; }

        public int day_moneytimes { get; set; }

        public int VipResever { get; set; }

        public int Tickets { get; set; }

        public int TaxType { get; set; }

        public int PlayTimes { get; set; }

        public int PlayTimesMoney { get; set; }

        public int PlayCounts_1 { get; set; }

        public int PlayCountsMoney_1 { get; set; }

        public int PlayCounts_2 { get; set; }

        public int PlayCountsMoney_2 { get; set; }

        public int PlayCounts_3 { get; set; }

        public int PlayCountsMoney_3 { get; set; }

        public long MaxPoint { get; set; }

        public int ContestID { get; set; }

        public long ExercisePoint { get; set; }

        public int? RoomAdID { get; set; }

        public virtual TGameRoomMsg TGameRoomMsg { get; set; }

        public virtual TGameRoomTable TGameRoomTable { get; set; }
    }
}
