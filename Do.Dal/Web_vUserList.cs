namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_vUserList
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string UserName { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string Pass { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string TwoPassword { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LogoID { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string NickName { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(50)]
        public string LogoFileMD5 { get; set; }

        [Key]
        [Column(Order = 7)]
        public string Token { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OnlineFlag { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Disabled { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short Sex { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Member { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MatchMember { get; set; }

        [Key]
        [Column(Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GamePower { get; set; }

        [Key]
        [Column(Order = 14)]
        public DateTime GPLimitTime { get; set; }

        public long? WalletMoney { get; set; }

        [Key]
        [Column(Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long BankMoney { get; set; }

        public long? SumMoney { get; set; }

        [Key]
        [Column(Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Fascination { get; set; }

        [Key]
        [Column(Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int meili { get; set; }

        [Key]
        [Column(Order = 18)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Viptime { get; set; }

        [Key]
        [Column(Order = 19)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DoublePointTime { get; set; }

        [Key]
        [Column(Order = 20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProtectTime { get; set; }

        [Key]
        [Column(Order = 21)]
        [StringLength(16)]
        public string LastLoginIP { get; set; }

        [Key]
        [Column(Order = 22)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TimeIsMoney { get; set; }

        [Key]
        [Column(Order = 23)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AllLoginTime { get; set; }

        [Key]
        [Column(Order = 24)]
        public DateTime LastLoginTM { get; set; }

        public long? TaxCom { get; set; }

        [Key]
        [Column(Order = 25)]
        [StringLength(50)]
        public string PhoneNum { get; set; }

        [Key]
        [Column(Order = 26)]
        [StringLength(50)]
        public string AdrProvince { get; set; }

        [Key]
        [Column(Order = 27)]
        [StringLength(50)]
        public string AdrCity { get; set; }

        [Key]
        [Column(Order = 28)]
        [StringLength(50)]
        public string AdrZone { get; set; }

        [Key]
        [Column(Order = 29)]
        [StringLength(50)]
        public string OccuPation { get; set; }

        [Key]
        [Column(Order = 30)]
        [StringLength(50)]
        public string RegisterIP { get; set; }

        [Key]
        [Column(Order = 31)]
        public DateTime RegisterTM { get; set; }

        [Key]
        [Column(Order = 32)]
        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [Key]
        [Column(Order = 33)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int WebLoginTime { get; set; }

        [StringLength(50)]
        public string Pwd_anw { get; set; }

        [StringLength(50)]
        public string Pwd_ques { get; set; }

        public short? ZJ_type { get; set; }

        [StringLength(50)]
        public string ZJ_Number { get; set; }

        [Key]
        [Column(Order = 34)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserType { get; set; }

        [Key]
        [Column(Order = 35)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ParentAgencyID { get; set; }

        [StringLength(20)]
        public string qqnum { get; set; }

        [Key]
        [Column(Order = 36)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Lotteries { get; set; }
    }
}
