namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_Config
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public string BadUserName { get; set; }

        public string BadNickName { get; set; }

        public int? MoneyToViptime { get; set; }

        public int? MoneyToViptimeDay { get; set; }

        public int? MoneyToViptimeWeek { get; set; }

        public int? MoneyToViptimeMonth { get; set; }

        public int? MoneyToViptimeHYear { get; set; }

        public int? MoneyToViptimeYear { get; set; }

        public int? UserobligateMoney { get; set; }

        public long? TransferLessMoney { get; set; }

        public long? TransferLessAllMoney { get; set; }

        public int? TransferTax { get; set; }

        public int? TransferMultiple { get; set; }

        public int? MaxTransTax { get; set; }

        public int? Con_ValidDay { get; set; }

        public int? Con_OnlineTime { get; set; }

        public int? Con_ValidUserAddMoney { get; set; }

        public int? Con_CardInPercent { get; set; }

        public int? Con_GetMoneyPercent { get; set; }

        public int? Con_RegMoney { get; set; }

        public int? Con_ValidUserMoney { get; set; }

        public int? Con_MinClearingMoney { get; set; }

        public int? Con_MoneyChangeRate { get; set; }

        public int? RegWallet { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2000)]
        public string IPDisabled { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ReRegTimeSpan { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "text")]
        public string YeepayMsgInfo { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int VipTransferTax { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Yeepay_Rate_NetBank { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Yeepay_Rate_Junnet { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Yeepay_Rate_Szx { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Yeepay_Rate_Unicom { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Yeepay_Rate_YPCard { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FreeCardCount { get; set; }

        public int? MaxTransUserMoney { get; set; }

        public DateTime? StartPresent { get; set; }

        public DateTime? EndPresent { get; set; }

        public int? CoinNum { get; set; }

        public int? TimeLength { get; set; }

        [StringLength(500)]
        public string GameNameID { get; set; }

        [StringLength(500)]
        public string TG_GameNameID { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(20)]
        public string SpecialUser { get; set; }

        [Key]
        [Column(Order = 12)]
        public bool MRView { get; set; }

        [StringLength(500)]
        public string FineryIDRegex { get; set; }

        [StringLength(500)]
        public string FineryIDDefaultPrice { get; set; }

        public long? MaxPayMoney { get; set; }

        [Key]
        [Column(Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CreateBankTax { get; set; }

        [Key]
        [Column(Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BankVersion { get; set; }

        [Key]
        [Column(Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RobotRank { get; set; }

        public int? UserMaxPayMoney { get; set; }

        public int? SameIPRegCount { get; set; }

        public int? SameCardNoRegCount { get; set; }

        public int? LastLoginGameCount { get; set; }

        public long? Con_PointChangeRate { get; set; }

        public int? BankRate { get; set; }

        public bool? IsDisplayHomeGameAD { get; set; }

        public bool? IsDisplayHomeMoneyInfo { get; set; }

        [Key]
        [Column(Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Ingot_MoneyChangeRate { get; set; }

        [Key]
        [Column(Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Con_IngotChangeRate { get; set; }

        [Key]
        [Column(Order = 18)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IsPayToIngot { get; set; }

        [Key]
        [Column(Order = 19)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IsIngotToProp { get; set; }

        [Key]
        [Column(Order = 20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IsIngotToGold { get; set; }

        [Key]
        [Column(Order = 21)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PartnerToCommonTax { get; set; }

        [Key]
        [Column(Order = 22)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PartnerToPartnerTax { get; set; }

        [Key]
        [Column(Order = 23)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CommToPartnerTax { get; set; }

        [Key]
        [Column(Order = 24)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PToCReturnTax { get; set; }

        [Key]
        [Column(Order = 25)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PToPReturnTax { get; set; }

        [Key]
        [Column(Order = 26)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TranMonBackLimit { get; set; }

        public int? IsOpenCommonTran { get; set; }
    }
}
