namespace Do.Dal
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Fish : DbContext
    {
        public Fish()
            : base("name=Fish")
        {
        }

        public virtual DbSet<Sale_Admin> Sale_Admin { get; set; }
        public virtual DbSet<Sale_Bars> Sale_Bars { get; set; }
        public virtual DbSet<Sale_BillRecord> Sale_BillRecord { get; set; }
        public virtual DbSet<Sys_ProcErrorCollection> Sys_ProcErrorCollection { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TBankDeposit> TBankDeposit { get; set; }
        public virtual DbSet<TBattleRoomInfo> TBattleRoomInfo { get; set; }
        public virtual DbSet<TChangeRecord> TChangeRecord { get; set; }
        public virtual DbSet<TChangeRecordUser> TChangeRecordUser { get; set; }
        public virtual DbSet<TCharmExchange> TCharmExchange { get; set; }
        public virtual DbSet<TContestDay> TContestDay { get; set; }
        public virtual DbSet<TContestInfo> TContestInfo { get; set; }
        public virtual DbSet<TFasciChangeRecord> TFasciChangeRecord { get; set; }
        public virtual DbSet<TGame_FlowWater> TGame_FlowWater { get; set; }
        public virtual DbSet<TGameKindInfo> TGameKindInfo { get; set; }
        public virtual DbSet<TGameNameInfo> TGameNameInfo { get; set; }
        public virtual DbSet<TGameRoomBase> TGameRoomBase { get; set; }
        public virtual DbSet<TGameRoomMsg> TGameRoomMsg { get; set; }
        public virtual DbSet<TGameRoomTable> TGameRoomTable { get; set; }
        public virtual DbSet<TGM_AwardType> TGM_AwardType { get; set; }
        public virtual DbSet<TGM_OperationRecord> TGM_OperationRecord { get; set; }
        public virtual DbSet<TMatchTable> TMatchTable { get; set; }
        public virtual DbSet<TMoneyChangeRecord> TMoneyChangeRecord { get; set; }
        public virtual DbSet<TMoneyExceptLog> TMoneyExceptLog { get; set; }
        public virtual DbSet<TPropBuyGive> TPropBuyGive { get; set; }
        public virtual DbSet<TPropDefine> TPropDefine { get; set; }
        public virtual DbSet<TReceiveMoneyDefind> TReceiveMoneyDefind { get; set; }
        public virtual DbSet<TSendMoneyRecord> TSendMoneyRecord { get; set; }
        public virtual DbSet<TSendMoneyRecord_New> TSendMoneyRecord_New { get; set; }
        public virtual DbSet<TUserCallGM> TUserCallGM { get; set; }
        public virtual DbSet<TUserInfo> TUserInfo { get; set; }
        public virtual DbSet<TUsers> TUsers { get; set; }
        public virtual DbSet<Web_AdminEmail> Web_AdminEmail { get; set; }
        public virtual DbSet<Web_AdminLog> Web_AdminLog { get; set; }
        public virtual DbSet<Web_AdminModifyLog> Web_AdminModifyLog { get; set; }
        public virtual DbSet<Web_Agency> Web_Agency { get; set; }
        public virtual DbSet<Web_AgencyAccountLog> Web_AgencyAccountLog { get; set; }
        public virtual DbSet<Web_AgencyBalanceLog> Web_AgencyBalanceLog { get; set; }
        public virtual DbSet<Web_AgencyDayReport> Web_AgencyDayReport { get; set; }
        public virtual DbSet<Web_AgencyMoneyChangeLog> Web_AgencyMoneyChangeLog { get; set; }
        public virtual DbSet<Web_AgencyPercentChange> Web_AgencyPercentChange { get; set; }
        public virtual DbSet<Web_AgencyPopeSet> Web_AgencyPopeSet { get; set; }
        public virtual DbSet<Web_AgencyRMBCost> Web_AgencyRMBCost { get; set; }
        public virtual DbSet<Web_AlmsConfig> Web_AlmsConfig { get; set; }
        public virtual DbSet<Web_Analy_DateReport> Web_Analy_DateReport { get; set; }
        public virtual DbSet<Web_Analy_MonthReport> Web_Analy_MonthReport { get; set; }
        public virtual DbSet<Web_Analy_NewUserReport> Web_Analy_NewUserReport { get; set; }
        public virtual DbSet<Web_AnalyData_DateOnline> Web_AnalyData_DateOnline { get; set; }
        public virtual DbSet<Web_ApplyVipRoom> Web_ApplyVipRoom { get; set; }
        public virtual DbSet<Web_Award> Web_Award { get; set; }
        public virtual DbSet<Web_AwardLog> Web_AwardLog { get; set; }
        public virtual DbSet<Web_Card> Web_Card { get; set; }
        public virtual DbSet<Web_CashConnection> Web_CashConnection { get; set; }
        public virtual DbSet<Web_CharmExchangeLog> Web_CharmExchangeLog { get; set; }
        public virtual DbSet<Web_CheckAwardList> Web_CheckAwardList { get; set; }
        public virtual DbSet<Web_ClearFasciPropDefine> Web_ClearFasciPropDefine { get; set; }
        public virtual DbSet<Web_ClearFasciPropUseLog> Web_ClearFasciPropUseLog { get; set; }
        public virtual DbSet<Web_ClearingLog> Web_ClearingLog { get; set; }
        public virtual DbSet<Web_Clothes> Web_Clothes { get; set; }
        public virtual DbSet<Web_CompanyInfo> Web_CompanyInfo { get; set; }
        public virtual DbSet<Web_ContestAwardConfig> Web_ContestAwardConfig { get; set; }
        public virtual DbSet<Web_ContestAwardType> Web_ContestAwardType { get; set; }
        public virtual DbSet<Web_ContestRank> Web_ContestRank { get; set; }
        public virtual DbSet<Web_Count_AgencyOnline> Web_Count_AgencyOnline { get; set; }
        public virtual DbSet<Web_Count_OnlineUsers> Web_Count_OnlineUsers { get; set; }
        public virtual DbSet<Web_Count_RoomOnline> Web_Count_RoomOnline { get; set; }
        public virtual DbSet<Web_DataAnaly_Users> Web_DataAnaly_Users { get; set; }
        public virtual DbSet<Web_DataClearLog> Web_DataClearLog { get; set; }
        public virtual DbSet<Web_DayTaxReport> Web_DayTaxReport { get; set; }
        public virtual DbSet<Web_Exchange> Web_Exchange { get; set; }
        public virtual DbSet<Web_FasciExchangeConfig> Web_FasciExchangeConfig { get; set; }
        public virtual DbSet<Web_FasciExchangeLog> Web_FasciExchangeLog { get; set; }
        public virtual DbSet<Web_FriendLink> Web_FriendLink { get; set; }
        public virtual DbSet<Web_GameGuidList> Web_GameGuidList { get; set; }
        public virtual DbSet<Web_GameInfo> Web_GameInfo { get; set; }
        public virtual DbSet<Web_GameMain> Web_GameMain { get; set; }
        public virtual DbSet<Web_GameType> Web_GameType { get; set; }
        public virtual DbSet<Web_GUID> Web_GUID { get; set; }
        public virtual DbSet<Web_IndexFlash> Web_IndexFlash { get; set; }
        public virtual DbSet<web_IngotChangeGold> web_IngotChangeGold { get; set; }
        public virtual DbSet<Web_IngotChangeLog> Web_IngotChangeLog { get; set; }
        public virtual DbSet<Web_IngotTransLog> Web_IngotTransLog { get; set; }
        public virtual DbSet<Web_LotterAward> Web_LotterAward { get; set; }
        public virtual DbSet<Web_LotterConfig> Web_LotterConfig { get; set; }
        public virtual DbSet<Web_LotteriesLog> Web_LotteriesLog { get; set; }
        public virtual DbSet<Web_LotterLog> Web_LotterLog { get; set; }
        public virtual DbSet<Web_LotterSpecial> Web_LotterSpecial { get; set; }
        public virtual DbSet<Web_manage_admin> Web_manage_admin { get; set; }
        public virtual DbSet<Web_Manage_Model> Web_Manage_Model { get; set; }
        public virtual DbSet<Web_Manage_Popedom> Web_Manage_Popedom { get; set; }
        public virtual DbSet<Web_MoneyChangeLog> Web_MoneyChangeLog { get; set; }
        public virtual DbSet<Web_MoneyStatEveryday> Web_MoneyStatEveryday { get; set; }
        public virtual DbSet<Web_msg> Web_msg { get; set; }
        public virtual DbSet<Web_NewsData> Web_NewsData { get; set; }
        public virtual DbSet<Web_NewsType> Web_NewsType { get; set; }
        public virtual DbSet<Web_PConfig> Web_PConfig { get; set; }
        public virtual DbSet<Web_PlatWinLostDateReport> Web_PlatWinLostDateReport { get; set; }
        public virtual DbSet<Web_PlayerDayReport> Web_PlayerDayReport { get; set; }
        public virtual DbSet<Web_PointChangeLog> Web_PointChangeLog { get; set; }
        public virtual DbSet<Web_ProductList> Web_ProductList { get; set; }
        public virtual DbSet<Web_PropChangeLog> Web_PropChangeLog { get; set; }
        public virtual DbSet<Web_PVAndIPStat> Web_PVAndIPStat { get; set; }
        public virtual DbSet<Web_RMBCost> Web_RMBCost { get; set; }
        public virtual DbSet<Web_Role> Web_Role { get; set; }
        public virtual DbSet<Web_RoleBeAdmin> Web_RoleBeAdmin { get; set; }
        public virtual DbSet<Web_RoleBeMenu> Web_RoleBeMenu { get; set; }
        public virtual DbSet<Web_RoleMenu> Web_RoleMenu { get; set; }
        public virtual DbSet<Web_System> Web_System { get; set; }
        public virtual DbSet<Web_TaxStatEveryDay> Web_TaxStatEveryDay { get; set; }
        public virtual DbSet<Web_TransfersAccount> Web_TransfersAccount { get; set; }
        public virtual DbSet<Web_TransLog> Web_TransLog { get; set; }
        public virtual DbSet<Web_TuiGuang> Web_TuiGuang { get; set; }
        public virtual DbSet<Web_TuiGuangLog> Web_TuiGuangLog { get; set; }
        public virtual DbSet<Web_UserAlbum> Web_UserAlbum { get; set; }
        public virtual DbSet<Web_UserAlbumColumn> Web_UserAlbumColumn { get; set; }
        public virtual DbSet<Web_UserApplyVipRecord> Web_UserApplyVipRecord { get; set; }
        public virtual DbSet<Web_UserEmail> Web_UserEmail { get; set; }
        public virtual DbSet<Web_UserModifyLog> Web_UserModifyLog { get; set; }
        public virtual DbSet<Web_Users> Web_Users { get; set; }
        public virtual DbSet<Sale_Bills> Sale_Bills { get; set; }
        public virtual DbSet<TBankSerialRes> TBankSerialRes { get; set; }
        public virtual DbSet<TBankSerialResource> TBankSerialResource { get; set; }
        public virtual DbSet<TBankWallet> TBankWallet { get; set; }
        public virtual DbSet<TBattleMatchTable> TBattleMatchTable { get; set; }
        public virtual DbSet<TContestRecord> TContestRecord { get; set; }
        public virtual DbSet<TContestUserRecord> TContestUserRecord { get; set; }
        public virtual DbSet<TGameIPRule> TGameIPRule { get; set; }
        public virtual DbSet<TGameLock> TGameLock { get; set; }
        public virtual DbSet<TGameRoomInfo> TGameRoomInfo { get; set; }
        public virtual DbSet<TGameServerInfo> TGameServerInfo { get; set; }
        public virtual DbSet<TGiveIngotRecord> TGiveIngotRecord { get; set; }
        public virtual DbSet<TGMRecord> TGMRecord { get; set; }
        public virtual DbSet<TLockCode> TLockCode { get; set; }
        public virtual DbSet<TLoginRecord> TLoginRecord { get; set; }
        public virtual DbSet<TProc_Error_Log> TProc_Error_Log { get; set; }
        public virtual DbSet<TReceiveMoneyRecord> TReceiveMoneyRecord { get; set; }
        public virtual DbSet<TRoomIPRule> TRoomIPRule { get; set; }
        public virtual DbSet<TRoomRecord> TRoomRecord { get; set; }
        public virtual DbSet<TTransferRecord> TTransferRecord { get; set; }
        public virtual DbSet<TUserList> TUserList { get; set; }
        public virtual DbSet<TUserLoginGame> TUserLoginGame { get; set; }
        public virtual DbSet<TUserNameRule> TUserNameRule { get; set; }
        public virtual DbSet<TUserProp> TUserProp { get; set; }
        public virtual DbSet<TWLoginRecord> TWLoginRecord { get; set; }
        public virtual DbSet<TZLoginRecord> TZLoginRecord { get; set; }
        public virtual DbSet<Web_AlmsDrawLog> Web_AlmsDrawLog { get; set; }
        public virtual DbSet<Web_CheckIn> Web_CheckIn { get; set; }
        public virtual DbSet<Web_CheckInGot> Web_CheckInGot { get; set; }
        public virtual DbSet<Web_CheckInLog> Web_CheckInLog { get; set; }
        public virtual DbSet<Web_CheckInSet> Web_CheckInSet { get; set; }
        public virtual DbSet<Web_ClearPropLog> Web_ClearPropLog { get; set; }
        public virtual DbSet<Web_ClothLog> Web_ClothLog { get; set; }
        public virtual DbSet<Web_Config> Web_Config { get; set; }
        public virtual DbSet<Web_ContestAwardLog> Web_ContestAwardLog { get; set; }
        public virtual DbSet<Web_CreateID> Web_CreateID { get; set; }
        public virtual DbSet<Web_FineryID> Web_FineryID { get; set; }
        public virtual DbSet<Web_Log> Web_Log { get; set; }
        public virtual DbSet<Web_MenuOften> Web_MenuOften { get; set; }
        public virtual DbSet<Web_TGClearingRecord> Web_TGClearingRecord { get; set; }
        public virtual DbSet<Web_TGPayRecord> Web_TGPayRecord { get; set; }
        public virtual DbSet<VChangeRecord> VChangeRecord { get; set; }
        public virtual DbSet<VPropGive> VPropGive { get; set; }
        public virtual DbSet<VRoomList> VRoomList { get; set; }
        public virtual DbSet<VUserBuy> VUserBuy { get; set; }
        public virtual DbSet<VUserListReceive> VUserListReceive { get; set; }
        public virtual DbSet<VUserListSend> VUserListSend { get; set; }
        public virtual DbSet<VUserProp> VUserProp { get; set; }
        public virtual DbSet<VUsers> VUsers { get; set; }
        public virtual DbSet<VUsersAlbum> VUsersAlbum { get; set; }
        public virtual DbSet<Web_PayPropRecord> Web_PayPropRecord { get; set; }
        public virtual DbSet<Web_VAgency_UserPayList> Web_VAgency_UserPayList { get; set; }
        public virtual DbSet<Web_vAgencyAccountLog> Web_vAgencyAccountLog { get; set; }
        public virtual DbSet<Web_vAgencyAndPlayerSumPoint_List> Web_vAgencyAndPlayerSumPoint_List { get; set; }
        public virtual DbSet<Web_VAgencyBalanceLog> Web_VAgencyBalanceLog { get; set; }
        public virtual DbSet<Web_vAgencyExchange> Web_vAgencyExchange { get; set; }
        public virtual DbSet<Web_vAgencyList> Web_vAgencyList { get; set; }
        public virtual DbSet<Web_vAgencySpareValue> Web_vAgencySpareValue { get; set; }
        public virtual DbSet<Web_vAgencySpareValueLog> Web_vAgencySpareValueLog { get; set; }
        public virtual DbSet<Web_ValmsDrawRecord> Web_ValmsDrawRecord { get; set; }
        public virtual DbSet<Web_VAnaly_AgencyDateReport> Web_VAnaly_AgencyDateReport { get; set; }
        public virtual DbSet<Web_VAnaly_DateReport> Web_VAnaly_DateReport { get; set; }
        public virtual DbSet<Web_VAnaly_GameCountAndTax> Web_VAnaly_GameCountAndTax { get; set; }
        public virtual DbSet<Web_VAnaly_NewUserPayList> Web_VAnaly_NewUserPayList { get; set; }
        public virtual DbSet<Web_VAnaly_NewUserReport> Web_VAnaly_NewUserReport { get; set; }
        public virtual DbSet<Web_VAnaly_PayList> Web_VAnaly_PayList { get; set; }
        public virtual DbSet<Web_VAnaly_UserList24A> Web_VAnaly_UserList24A { get; set; }
        public virtual DbSet<Web_VAnaly_UserList24B> Web_VAnaly_UserList24B { get; set; }
        public virtual DbSet<Web_VAnaly_UserListReg> Web_VAnaly_UserListReg { get; set; }
        public virtual DbSet<Web_VAnalyData_DateOnline> Web_VAnalyData_DateOnline { get; set; }
        public virtual DbSet<Web_VApplyVipRoom> Web_VApplyVipRoom { get; set; }
        public virtual DbSet<Web_vAwardLog> Web_vAwardLog { get; set; }
        public virtual DbSet<Web_vAwardRecord> Web_vAwardRecord { get; set; }
        public virtual DbSet<Web_VBankDeposit> Web_VBankDeposit { get; set; }
        public virtual DbSet<Web_vBankMoneyOpera> Web_vBankMoneyOpera { get; set; }
        public virtual DbSet<Web_vBuyPropLog> Web_vBuyPropLog { get; set; }
        public virtual DbSet<Web_vBuyVipLog> Web_vBuyVipLog { get; set; }
        public virtual DbSet<Web_VChangeRecord> Web_VChangeRecord { get; set; }
        public virtual DbSet<Web_VCharmExchange> Web_VCharmExchange { get; set; }
        public virtual DbSet<Web_VClearPropLog> Web_VClearPropLog { get; set; }
        public virtual DbSet<Web_VDataList> Web_VDataList { get; set; }
        public virtual DbSet<Web_vExchangeFasciLog> Web_vExchangeFasciLog { get; set; }
        public virtual DbSet<Web_vFaciSum> Web_vFaciSum { get; set; }
        public virtual DbSet<Web_VFasciClearPropLog> Web_VFasciClearPropLog { get; set; }
        public virtual DbSet<Web_VFasciExchangeLog> Web_VFasciExchangeLog { get; set; }
        public virtual DbSet<Web_VGameKindList> Web_VGameKindList { get; set; }
        public virtual DbSet<Web_VGameNameInfo> Web_VGameNameInfo { get; set; }
        public virtual DbSet<Web_vGameRecord> Web_vGameRecord { get; set; }
        public virtual DbSet<Web_VGameRoomInfo> Web_VGameRoomInfo { get; set; }
        public virtual DbSet<Web_VGameRoomInfo2> Web_VGameRoomInfo2 { get; set; }
        public virtual DbSet<Web_VGameRoomInfo3> Web_VGameRoomInfo3 { get; set; }
        public virtual DbSet<Web_VGetAgencyDetail1> Web_VGetAgencyDetail1 { get; set; }
        public virtual DbSet<Web_VGetPlayDetail> Web_VGetPlayDetail { get; set; }
        public virtual DbSet<Web_VGetUserOnline> Web_VGetUserOnline { get; set; }
        public virtual DbSet<web_vGetVipLog> web_vGetVipLog { get; set; }
        public virtual DbSet<Web_vIngotTransferLog> Web_vIngotTransferLog { get; set; }
        public virtual DbSet<Web_VLoginRecord> Web_VLoginRecord { get; set; }
        public virtual DbSet<Web_VLotterLog> Web_VLotterLog { get; set; }
        public virtual DbSet<Web_VLotterSpecial> Web_VLotterSpecial { get; set; }
        public virtual DbSet<Web_VMatchAwardConfig> Web_VMatchAwardConfig { get; set; }
        public virtual DbSet<Web_VMatchLog> Web_VMatchLog { get; set; }
        public virtual DbSet<Web_VMatchTable> Web_VMatchTable { get; set; }
        public virtual DbSet<web_vMoneyChangeLog> web_vMoneyChangeLog { get; set; }
        public virtual DbSet<Web_VMoneyChangeRecord> Web_VMoneyChangeRecord { get; set; }
        public virtual DbSet<Web_vNewsList> Web_vNewsList { get; set; }
        public virtual DbSet<web_VPlayerLoginLog> web_VPlayerLoginLog { get; set; }
        public virtual DbSet<Web_vPlayerSpareValue> Web_vPlayerSpareValue { get; set; }
        public virtual DbSet<Web_VPropBuyGive> Web_VPropBuyGive { get; set; }
        public virtual DbSet<Web_VReceiveMoneyLog> Web_VReceiveMoneyLog { get; set; }
        public virtual DbSet<Web_vSendMoneyRecord_New> Web_vSendMoneyRecord_New { get; set; }
        public virtual DbSet<Web_vTaxStatEveryday> Web_vTaxStatEveryday { get; set; }
        public virtual DbSet<Web_VTContestRoom> Web_VTContestRoom { get; set; }
        public virtual DbSet<web_VTGBalanceLog> web_VTGBalanceLog { get; set; }
        public virtual DbSet<Web_VTGLog> Web_VTGLog { get; set; }
        public virtual DbSet<web_vTGpayClearing> web_vTGpayClearing { get; set; }
        public virtual DbSet<Web_vTransferLog> Web_vTransferLog { get; set; }
        public virtual DbSet<Web_VTransLog> Web_VTransLog { get; set; }
        public virtual DbSet<Web_VTuiGuang> Web_VTuiGuang { get; set; }
        public virtual DbSet<Web_vUserAlbumColumn> Web_vUserAlbumColumn { get; set; }
        public virtual DbSet<Web_vUserAllMoneyChangeLog> Web_vUserAllMoneyChangeLog { get; set; }
        public virtual DbSet<Web_VUserBattlePoint> Web_VUserBattlePoint { get; set; }
        public virtual DbSet<Web_VUserEmail> Web_VUserEmail { get; set; }
        public virtual DbSet<Web_VUserGameMoney> Web_VUserGameMoney { get; set; }
        public virtual DbSet<Web_vUserList> Web_vUserList { get; set; }
        public virtual DbSet<Web_vUserList_New> Web_vUserList_New { get; set; }
        public virtual DbSet<Web_vUserLoginList> Web_vUserLoginList { get; set; }
        public virtual DbSet<Web_vUserMoneyRank> Web_vUserMoneyRank { get; set; }
        public virtual DbSet<Web_vUserPoint> Web_vUserPoint { get; set; }
        public virtual DbSet<Web_vUserPropertyAnaly> Web_vUserPropertyAnaly { get; set; }
        public virtual DbSet<Web_vUserPropertyReport> Web_vUserPropertyReport { get; set; }
        public virtual DbSet<Web_VUsersList> Web_VUsersList { get; set; }
        public virtual DbSet<Web_vUserTime> Web_vUserTime { get; set; }

        public virtual DbSet<A_test> ATest { get; set; } 

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<A_test>()
                .Property(e => e.TestName)
                .IsUnicode(false);

            modelBuilder.Entity<TChangeRecord>()
                .HasMany(e => e.TChangeRecordUser)
                .WithRequired(e => e.TChangeRecord)
                .HasForeignKey(e => e.RecordIndex);

            modelBuilder.Entity<TContestInfo>()
                .Property(e => e.SendTime)
                .IsUnicode(false);

            modelBuilder.Entity<TContestInfo>()
                .Property(e => e.MatchDesc)
                .IsUnicode(false);

            modelBuilder.Entity<TContestInfo>()
                .HasMany(e => e.TContestDay)
                .WithRequired(e => e.TContestInfo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TGame_FlowWater>()
                .Property(e => e.ServerName)
                .IsUnicode(false);

            modelBuilder.Entity<TGame_FlowWater>()
                .Property(e => e.UserStartGameTime)
                .IsUnicode(false);

            modelBuilder.Entity<TGame_FlowWater>()
                .Property(e => e.UserEndGameTime)
                .IsUnicode(false);

            modelBuilder.Entity<TGameNameInfo>()
                .HasMany(e => e.TGameRoomInfo)
                .WithRequired(e => e.TGameNameInfo)
                .HasForeignKey(e => e.GameNameID);

            modelBuilder.Entity<TGameRoomBase>()
                .HasOptional(e => e.TGameRoomMsg)
                .WithRequired(e => e.TGameRoomBase)
                .WillCascadeOnDelete();

            modelBuilder.Entity<TGameRoomBase>()
                .HasOptional(e => e.TGameRoomTable)
                .WithRequired(e => e.TGameRoomBase)
                .WillCascadeOnDelete();

            modelBuilder.Entity<TSendMoneyRecord_New>()
                .Property(e => e.SendDate)
                .IsUnicode(false);

            modelBuilder.Entity<TUserInfo>()
                .Property(e => e.PhoneNum)
                .IsUnicode(false);

            modelBuilder.Entity<TUserInfo>()
                .Property(e => e.AdrProvince)
                .IsUnicode(false);

            modelBuilder.Entity<TUserInfo>()
                .Property(e => e.AdrCity)
                .IsUnicode(false);

            modelBuilder.Entity<TUserInfo>()
                .Property(e => e.AdrZone)
                .IsUnicode(false);

            modelBuilder.Entity<TUserInfo>()
                .Property(e => e.OccuPation)
                .IsUnicode(false);

            modelBuilder.Entity<TUsers>()
                .Property(e => e.Salt)
                .IsUnicode(false);

            modelBuilder.Entity<TUsers>()
                .HasOptional(e => e.TUserInfo)
                .WithRequired(e => e.TUsers)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Web_AdminModifyLog>()
                .Property(e => e.AdminName)
                .IsUnicode(false);

            modelBuilder.Entity<Web_AdminModifyLog>()
                .Property(e => e.IP)
                .IsUnicode(false);

            modelBuilder.Entity<Web_AdminModifyLog>()
                .Property(e => e.System)
                .IsUnicode(false);

            modelBuilder.Entity<Web_AdminModifyLog>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Web_Agency>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Web_Agency>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Web_Agency>()
                .Property(e => e.MobilPhone)
                .IsUnicode(false);

            modelBuilder.Entity<Web_Agency>()
                .Property(e => e.SpareValue)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Web_AwardLog>()
                .Property(e => e.TrueName)
                .IsUnicode(false);

            modelBuilder.Entity<Web_AwardLog>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Web_AwardLog>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Web_Card>()
                .Property(e => e.types)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Web_ClearingLog>()
                .Property(e => e.IP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Web_FasciExchangeLog>()
                .Property(e => e.IP)
                .IsUnicode(false);

            modelBuilder.Entity<Web_GameInfo>()
                .Property(e => e.Game_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Web_GameInfo>()
                .Property(e => e.Provice)
                .IsUnicode(false);

            modelBuilder.Entity<Web_GameInfo>()
                .Property(e => e.Area)
                .IsUnicode(false);

            modelBuilder.Entity<Web_GameMain>()
                .Property(e => e.Main_Info)
                .IsUnicode(false);

            modelBuilder.Entity<Web_GameMain>()
                .Property(e => e.sMain_Info)
                .IsUnicode(false);

            modelBuilder.Entity<Web_GameType>()
                .Property(e => e.TypeName)
                .IsUnicode(false);

            modelBuilder.Entity<web_IngotChangeGold>()
                .Property(e => e.TitleName)
                .IsUnicode(false);

            modelBuilder.Entity<web_IngotChangeGold>()
                .Property(e => e.ImgUrl)
                .IsUnicode(false);

            modelBuilder.Entity<Web_Manage_Model>()
                .Property(e => e.ModelNo)
                .IsUnicode(false);

            modelBuilder.Entity<Web_Manage_Model>()
                .Property(e => e.ModelName)
                .IsUnicode(false);

            modelBuilder.Entity<Web_Manage_Model>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<Web_Manage_Popedom>()
                .Property(e => e.ModelNo)
                .IsUnicode(false);

            modelBuilder.Entity<Web_System>()
                .Property(e => e.ParaName)
                .IsUnicode(false);

            modelBuilder.Entity<Web_Users>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Web_Users>()
                .Property(e => e.ZJ_Number)
                .IsUnicode(false);

            modelBuilder.Entity<Web_Users>()
                .Property(e => e.qqnum)
                .IsUnicode(false);

            modelBuilder.Entity<Web_Users>()
                .Property(e => e.RealName)
                .IsUnicode(false);

            modelBuilder.Entity<Web_Users>()
                .Property(e => e.FindPwdQue_1)
                .IsUnicode(false);

            modelBuilder.Entity<Web_Users>()
                .Property(e => e.FindPwdAnw_1)
                .IsUnicode(false);

            modelBuilder.Entity<Web_Users>()
                .Property(e => e.FindPwdQue_2)
                .IsUnicode(false);

            modelBuilder.Entity<Web_Users>()
                .Property(e => e.FindPwdAnw_2)
                .IsUnicode(false);

            modelBuilder.Entity<TBankSerialRes>()
                .Property(e => e.id)
                .HasPrecision(10, 0);

            modelBuilder.Entity<TBankSerialRes>()
                .Property(e => e.used)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TBankSerialResource>()
                .Property(e => e.id)
                .HasPrecision(10, 0);

            modelBuilder.Entity<TBankSerialResource>()
                .Property(e => e.used)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TContestUserRecord>()
                .Property(e => e.NickName)
                .IsUnicode(false);

            modelBuilder.Entity<TGameRoomInfo>()
                .Property(e => e.RoomPassword)
                .IsUnicode(false);

            modelBuilder.Entity<TLoginRecord>()
                .Property(e => e.LastLoginIP)
                .IsFixedLength();

            modelBuilder.Entity<TProc_Error_Log>()
                .Property(e => e.ProName)
                .IsUnicode(false);

            modelBuilder.Entity<TProc_Error_Log>()
                .Property(e => e.ProParam)
                .IsUnicode(false);

            modelBuilder.Entity<TProc_Error_Log>()
                .Property(e => e.ProMessage)
                .IsUnicode(false);

            modelBuilder.Entity<TZLoginRecord>()
                .Property(e => e.ZID)
                .IsUnicode(false);

            modelBuilder.Entity<Web_CheckInGot>()
                .Property(e => e.CheckInSetName)
                .IsUnicode(false);

            modelBuilder.Entity<Web_ClothLog>()
                .Property(e => e.LogName)
                .IsUnicode(false);

            modelBuilder.Entity<Web_ClothLog>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<Web_Config>()
                .Property(e => e.YeepayMsgInfo)
                .IsUnicode(false);

            modelBuilder.Entity<Web_Config>()
                .Property(e => e.FineryIDRegex)
                .IsUnicode(false);

            modelBuilder.Entity<Web_Config>()
                .Property(e => e.FineryIDDefaultPrice)
                .IsUnicode(false);

            modelBuilder.Entity<Web_ContestAwardLog>()
                .Property(e => e.AwardName)
                .IsUnicode(false);

            modelBuilder.Entity<Web_ContestAwardLog>()
                .Property(e => e.UserID)
                .IsFixedLength();

            modelBuilder.Entity<Web_ContestAwardLog>()
                .Property(e => e.PropName)
                .IsUnicode(false);

            modelBuilder.Entity<Web_ContestAwardLog>()
                .Property(e => e.PropName1)
                .IsUnicode(false);

            modelBuilder.Entity<Web_ContestAwardLog>()
                .Property(e => e.PropName2)
                .IsUnicode(false);

            modelBuilder.Entity<Web_FineryID>()
                .Property(e => e.PassWord)
                .IsUnicode(false);

            modelBuilder.Entity<Web_FineryID>()
                .Property(e => e.Explain)
                .IsUnicode(false);

            modelBuilder.Entity<Web_TGPayRecord>()
                .Property(e => e.PayType)
                .IsUnicode(false);

            modelBuilder.Entity<Web_PayPropRecord>()
                .Property(e => e.BuyType)
                .IsUnicode(false);

            modelBuilder.Entity<Web_PayPropRecord>()
                .Property(e => e.TranType)
                .IsUnicode(false);

            modelBuilder.Entity<Web_PayPropRecord>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<Web_vAgencyList>()
                .Property(e => e.SpareValue)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Web_VAnaly_DateReport>()
                .Property(e => e.ReportDate)
                .IsUnicode(false);

            modelBuilder.Entity<Web_VAnaly_DateReport>()
                .Property(e => e.Date)
                .IsUnicode(false);

            modelBuilder.Entity<Web_VAnaly_GameCountAndTax>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<Web_VAnaly_GameCountAndTax>()
                .Property(e => e.ReportDate)
                .IsUnicode(false);

            modelBuilder.Entity<Web_VAnaly_NewUserPayList>()
                .Property(e => e.RealName)
                .IsUnicode(false);

            modelBuilder.Entity<Web_VAnaly_NewUserPayList>()
                .Property(e => e.AddTime)
                .IsUnicode(false);

            modelBuilder.Entity<Web_VAnaly_UserList24A>()
                .Property(e => e.RealName)
                .IsUnicode(false);

            modelBuilder.Entity<Web_VAnaly_UserList24A>()
                .Property(e => e.OnlineStatus)
                .IsUnicode(false);

            modelBuilder.Entity<Web_VAnaly_UserList24B>()
                .Property(e => e.RealName)
                .IsUnicode(false);

            modelBuilder.Entity<Web_VAnaly_UserList24B>()
                .Property(e => e.OnlineStatus)
                .IsUnicode(false);

            modelBuilder.Entity<Web_VAnaly_UserListReg>()
                .Property(e => e.RealName)
                .IsUnicode(false);

            modelBuilder.Entity<Web_VAnaly_UserListReg>()
                .Property(e => e.OnlineStatus)
                .IsUnicode(false);

            modelBuilder.Entity<Web_vAwardLog>()
                .Property(e => e.TrueName)
                .IsUnicode(false);

            modelBuilder.Entity<Web_vAwardLog>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Web_vAwardLog>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Web_vAwardRecord>()
                .Property(e => e.TrueName)
                .IsUnicode(false);

            modelBuilder.Entity<Web_vAwardRecord>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Web_vAwardRecord>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Web_VDataList>()
                .Property(e => e.TypeName)
                .IsUnicode(false);

            modelBuilder.Entity<Web_VDataList>()
                .Property(e => e.TableName)
                .IsUnicode(false);

            modelBuilder.Entity<Web_vExchangeFasciLog>()
                .Property(e => e.IP)
                .IsUnicode(false);

            modelBuilder.Entity<Web_VGetAgencyDetail1>()
                .Property(e => e.SpareValueRate)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Web_VGetPlayDetail>()
                .Property(e => e.RealName)
                .IsUnicode(false);

            modelBuilder.Entity<Web_VGetPlayDetail>()
                .Property(e => e.qqnum)
                .IsUnicode(false);

            modelBuilder.Entity<Web_VGetPlayDetail>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Web_VGetPlayDetail>()
                .Property(e => e.ZJ_Number)
                .IsUnicode(false);

            modelBuilder.Entity<Web_VGetUserOnline>()
                .Property(e => e.RealName)
                .IsUnicode(false);

            modelBuilder.Entity<Web_VGetUserOnline>()
                .Property(e => e.qqnum)
                .IsUnicode(false);

            modelBuilder.Entity<Web_VLoginRecord>()
                .Property(e => e.LastLoginIP)
                .IsFixedLength();

            modelBuilder.Entity<web_VPlayerLoginLog>()
                .Property(e => e.LastLoginIP)
                .IsFixedLength();

            modelBuilder.Entity<Web_vSendMoneyRecord_New>()
                .Property(e => e.SendDate)
                .IsUnicode(false);

            modelBuilder.Entity<web_VTGBalanceLog>()
                .Property(e => e.IP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<web_vTGpayClearing>()
                .Property(e => e.PayType)
                .IsUnicode(false);

            modelBuilder.Entity<Web_vUserList>()
                .Property(e => e.PhoneNum)
                .IsUnicode(false);

            modelBuilder.Entity<Web_vUserList>()
                .Property(e => e.AdrProvince)
                .IsUnicode(false);

            modelBuilder.Entity<Web_vUserList>()
                .Property(e => e.AdrCity)
                .IsUnicode(false);

            modelBuilder.Entity<Web_vUserList>()
                .Property(e => e.AdrZone)
                .IsUnicode(false);

            modelBuilder.Entity<Web_vUserList>()
                .Property(e => e.OccuPation)
                .IsUnicode(false);

            modelBuilder.Entity<Web_vUserList>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Web_vUserList>()
                .Property(e => e.ZJ_Number)
                .IsUnicode(false);

            modelBuilder.Entity<Web_vUserList>()
                .Property(e => e.qqnum)
                .IsUnicode(false);

            modelBuilder.Entity<Web_vUserList_New>()
                .Property(e => e.ZJ_Number)
                .IsUnicode(false);

            modelBuilder.Entity<Web_vUserLoginList>()
                .Property(e => e.LastLoginIP)
                .IsFixedLength();

            modelBuilder.Entity<Web_VUsersList>()
                .Property(e => e.OccuPation)
                .IsUnicode(false);

            modelBuilder.Entity<Web_VUsersList>()
                .Property(e => e.PhoneNum)
                .IsUnicode(false);

            modelBuilder.Entity<Web_VUsersList>()
                .Property(e => e.AdrProvince)
                .IsUnicode(false);

            modelBuilder.Entity<Web_VUsersList>()
                .Property(e => e.AdrCity)
                .IsUnicode(false);

            modelBuilder.Entity<Web_VUsersList>()
                .Property(e => e.AdrZone)
                .IsUnicode(false);

            modelBuilder.Entity<Web_VUsersList>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Web_VUsersList>()
                .Property(e => e.ZJ_Number)
                .IsUnicode(false);

            modelBuilder.Entity<Web_VUsersList>()
                .Property(e => e.TrueName)
                .IsUnicode(false);
        }
    }
}
