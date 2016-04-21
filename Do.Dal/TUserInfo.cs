namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TUserInfo")]
    public partial class TUserInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }

        public int Member { get; set; }

        public int MatchMember { get; set; }

        public int Master { get; set; }

        public int GamePower { get; set; }

        public DateTime GPLimitTime { get; set; }

        public long WalletMoney { get; set; }

        public long BankMoney { get; set; }

        public int Fascination { get; set; }

        public int Viptime { get; set; }

        public int DoublePointTime { get; set; }

        public int ProtectTime { get; set; }

        [Required]
        [StringLength(16)]
        public string LastLoginIP { get; set; }

        public int TimeIsMoney { get; set; }

        public int AllLoginTime { get; set; }

        public DateTime LastLoginTM { get; set; }

        public long? TaxCom { get; set; }

        [Required]
        [StringLength(50)]
        public string PhoneNum { get; set; }

        [Required]
        [StringLength(50)]
        public string AdrNation { get; set; }

        [Required]
        [StringLength(50)]
        public string AdrProvince { get; set; }

        [Required]
        [StringLength(50)]
        public string AdrCity { get; set; }

        [Required]
        [StringLength(50)]
        public string AdrZone { get; set; }

        [Required]
        [StringLength(50)]
        public string OccuPation { get; set; }

        public int UserType { get; set; }

        public int DiamondTime { get; set; }

        public int LockMathine { get; set; }

        public string MathineCode { get; set; }

        public int? OnlineMinutes { get; set; }

        public DateTime? RoomLoginTime { get; set; }

        public int? PresentCoinNum { get; set; }

        public int? StatusByGM { get; set; }

        public DateTime? StatusTime { get; set; }

        public short? Trader { get; set; }

        public int? KickUserTime { get; set; }

        public int? AntiKickTime { get; set; }

        [StringLength(50)]
        public string MyHardID { get; set; }

        public int AddFriendType { get; set; }

        public int? EmailCount { get; set; }

        public long UserIngot { get; set; }

        public short ISCanTranMonBack { get; set; }

        public long TranMonBackValue { get; set; }

        public virtual TUsers TUsers { get; set; }
    }
}
