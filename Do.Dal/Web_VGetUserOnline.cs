namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_VGetUserOnline
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int WID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string UserName { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short IsRobot { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(30)]
        public string RoomName { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GameCount { get; set; }

        [StringLength(20)]
        public string RealName { get; set; }

        [StringLength(20)]
        public string qqnum { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime RegisterTM { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(50)]
        public string RegisterIP { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long BankMoney { get; set; }

        public long? SumMoney { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(50)]
        public string NickName { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long WalletMoney { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(14)]
        public string ComName { get; set; }
    }
}
