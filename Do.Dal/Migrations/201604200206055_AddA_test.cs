namespace Do.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddA_test : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.A_test",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TestName = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Sale_Admin",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false, maxLength: 50),
                        PassWord = c.String(nullable: false, maxLength: 50),
                        SafePass = c.String(nullable: false, maxLength: 50),
                        Phone = c.String(maxLength: 15),
                        QQNum = c.String(maxLength: 15),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Sale_Bars",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        BarUser = c.String(nullable: false, maxLength: 50),
                        BarName = c.String(nullable: false, maxLength: 50),
                        PassWord = c.String(nullable: false, maxLength: 50),
                        PhoneNum = c.String(maxLength: 15),
                        Address = c.String(maxLength: 150),
                        MachineCode = c.String(maxLength: 50),
                        AllMoney = c.Long(nullable: false),
                        DebtMoney = c.Long(nullable: false),
                        Status = c.Short(nullable: false),
                        AddTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Sale_BillRecord",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        BillID = c.Int(nullable: false),
                        SendMoney = c.Long(nullable: false),
                        SendTime = c.DateTime(nullable: false),
                        Remark = c.String(maxLength: 300),
                        AdminUser = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Sale_Bills",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        BarUser = c.String(nullable: false, maxLength: 50),
                        BarName = c.String(nullable: false, maxLength: 50),
                        TransMoney = c.Long(nullable: false),
                        DebtMoney = c.Long(nullable: false),
                        AddTime = c.DateTime(nullable: false),
                        Statu = c.Int(nullable: false),
                        AdminUser = c.String(maxLength: 50),
                        Remark = c.String(maxLength: 300),
                    })
                .PrimaryKey(t => new { t.ID, t.BarUser, t.BarName, t.TransMoney, t.DebtMoney, t.AddTime, t.Statu });
            
            CreateTable(
                "dbo.Sys_ProcErrorCollection",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Number = c.Int(nullable: false),
                        Severity = c.Int(nullable: false),
                        State = c.Int(nullable: false),
                        ProcName = c.String(nullable: false, maxLength: 2000),
                        Line = c.Int(nullable: false),
                        Msg = c.String(nullable: false, maxLength: 2000),
                        InputDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.sysdiagrams",
                c => new
                    {
                        diagram_id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 128),
                        principal_id = c.Int(nullable: false),
                        version = c.Int(),
                        definition = c.Binary(),
                    })
                .PrimaryKey(t => t.diagram_id);
            
            CreateTable(
                "dbo.TBankDeposit",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Userid = c.Int(nullable: false),
                        Money = c.Long(nullable: false),
                        DepositID = c.String(nullable: false, maxLength: 16),
                        DepositPassWord = c.String(nullable: false, maxLength: 16),
                        GreateTime = c.DateTime(nullable: false),
                        CDSC = c.Int(nullable: false),
                        State = c.Int(nullable: false),
                        UsedUserID = c.Int(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.TBankSerialRes",
                c => new
                    {
                        id = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true, storeType: "numeric"),
                        SerialNo = c.String(maxLength: 16),
                        used = c.String(maxLength: 1, fixedLength: true, unicode: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.TBankSerialResource",
                c => new
                    {
                        id = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true, storeType: "numeric"),
                        SerialNo = c.String(maxLength: 16),
                        used = c.String(maxLength: 1, fixedLength: true, unicode: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.TBankWallet",
                c => new
                    {
                        UserID = c.Int(nullable: false),
                        GameID = c.Int(nullable: false),
                        WalletMoney = c.Long(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserID, t.GameID, t.WalletMoney });
            
            CreateTable(
                "dbo.TBattleMatchTable",
                c => new
                    {
                        UserID = c.Int(nullable: false),
                        RoomID = c.Int(nullable: false),
                        NameID = c.Int(nullable: false),
                        Point = c.Long(nullable: false),
                        Money = c.Long(nullable: false),
                        TaxCom = c.Long(nullable: false),
                        Win = c.Int(nullable: false),
                        Lost = c.Int(nullable: false),
                        Mid = c.Int(nullable: false),
                        Cut = c.Int(nullable: false),
                        PlayTimeCount = c.Int(nullable: false),
                        OnLineTimeCount = c.Int(nullable: false),
                        MasterPower = c.Int(nullable: false),
                        GamePower = c.Int(nullable: false),
                        LogonTimes = c.Int(nullable: false),
                        LogonDate = c.DateTime(nullable: false),
                        PlayTimes_T = c.Int(nullable: false),
                        PlayCounts_T = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserID, t.RoomID, t.NameID, t.Point, t.Money, t.TaxCom, t.Win, t.Lost, t.Mid, t.Cut, t.PlayTimeCount, t.OnLineTimeCount, t.MasterPower, t.GamePower, t.LogonTimes, t.LogonDate, t.PlayTimes_T, t.PlayCounts_T });
            
            CreateTable(
                "dbo.TBattleRoomInfo",
                c => new
                    {
                        BattleRoomID = c.Int(nullable: false),
                        RoomName = c.String(nullable: false, maxLength: 50),
                        BeginTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.BattleRoomID);
            
            CreateTable(
                "dbo.TChangeRecord",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        GameTime = c.Int(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        RoomID = c.Int(nullable: false),
                        DeskIndex = c.Int(nullable: false),
                        Tax = c.Int(nullable: false),
                        ModelType = c.Short(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TChangeRecordUser",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        RecordIndex = c.Int(nullable: false),
                        UserIndex = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                        SrcPoint = c.Long(nullable: false),
                        SrcMoney = c.Long(nullable: false),
                        ChangePoint = c.Long(nullable: false),
                        ChangeMoney = c.Long(nullable: false),
                        ChangeTax = c.Long(nullable: false),
                        ReportStatus = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.TUsers", t => t.UserID, cascadeDelete: true)
                .ForeignKey("dbo.TChangeRecord", t => t.RecordIndex, cascadeDelete: true)
                .Index(t => t.RecordIndex)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.TUsers",
                c => new
                    {
                        UserID = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 20),
                        Pass = c.String(nullable: false, maxLength: 50),
                        TwoPassword = c.String(nullable: false, maxLength: 50),
                        NickName = c.String(nullable: false, maxLength: 50),
                        LogoID = c.Int(nullable: false),
                        LogoFileMD5 = c.String(nullable: false, maxLength: 50),
                        Token = c.String(nullable: false, maxLength: 128),
                        OnlineFlag = c.Int(nullable: false),
                        Disabled = c.Int(nullable: false),
                        Sex = c.Short(nullable: false),
                        IsRobot = c.Short(nullable: false),
                        AgencyID = c.Int(nullable: false),
                        Salt = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.UserID);
            
            CreateTable(
                "dbo.TFasciChangeRecord",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        TargetID = c.Int(nullable: false),
                        PropID = c.Int(nullable: false),
                        FasciChange = c.Int(nullable: false),
                        Money = c.Int(nullable: false),
                        ActionTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.TPropDefine", t => t.PropID, cascadeDelete: true)
                .ForeignKey("dbo.TUsers", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID)
                .Index(t => t.PropID);
            
            CreateTable(
                "dbo.TPropDefine",
                c => new
                    {
                        PropID = c.Int(nullable: false),
                        PropName = c.String(nullable: false, maxLength: 50),
                        Price = c.Int(nullable: false),
                        VipPrice = c.Int(nullable: false),
                        Descript = c.String(nullable: false, maxLength: 50),
                        ActionAttribute = c.Int(nullable: false),
                        ValueAttribute = c.Int(nullable: false),
                        PropType = c.Int(nullable: false),
                        LargessGold = c.Int(nullable: false),
                        SendGold = c.Int(nullable: false),
                        PriceType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PropID);
            
            CreateTable(
                "dbo.TPropBuyGive",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        TargetID = c.Int(nullable: false),
                        PropID = c.Int(nullable: false),
                        PropCount = c.Int(nullable: false),
                        PriceType = c.Int(nullable: false),
                        Money = c.Int(nullable: false),
                        ActionTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.TPropDefine", t => t.PropID, cascadeDelete: true)
                .ForeignKey("dbo.TUsers", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID)
                .Index(t => t.PropID);
            
            CreateTable(
                "dbo.TUserProp",
                c => new
                    {
                        UserID = c.Int(nullable: false),
                        PropID = c.Int(nullable: false),
                        HoldCount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserID, t.PropID, t.HoldCount })
                .ForeignKey("dbo.TPropDefine", t => t.PropID, cascadeDelete: true)
                .ForeignKey("dbo.TUsers", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID)
                .Index(t => t.PropID);
            
            CreateTable(
                "dbo.TGameLock",
                c => new
                    {
                        UserID = c.Int(nullable: false),
                        RoomID = c.Int(nullable: false),
                        AccessIP = c.String(nullable: false, maxLength: 15),
                        RoomName = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => new { t.UserID, t.RoomID, t.AccessIP, t.RoomName })
                .ForeignKey("dbo.TUsers", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.TMatchTable",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        RoomID = c.Int(nullable: false),
                        NameID = c.Int(nullable: false),
                        Point = c.Long(nullable: false),
                        Money = c.Long(nullable: false),
                        TaxCom = c.Long(nullable: false),
                        Win = c.Int(nullable: false),
                        Lost = c.Int(nullable: false),
                        Mid = c.Int(nullable: false),
                        Cut = c.Int(nullable: false),
                        PlayTimeCount = c.Int(nullable: false),
                        OnLineTimeCount = c.Int(nullable: false),
                        MasterPower = c.Int(nullable: false),
                        GamePower = c.Int(nullable: false),
                        LogonTimes = c.Int(nullable: false),
                        LogonDate = c.DateTime(nullable: false),
                        PlayTimes_T = c.Int(nullable: false),
                        PlayCounts_T = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.TGameNameInfo", t => t.NameID, cascadeDelete: true)
                .ForeignKey("dbo.TUsers", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID)
                .Index(t => t.NameID);
            
            CreateTable(
                "dbo.TGameNameInfo",
                c => new
                    {
                        NameID = c.Int(nullable: false),
                        KindID = c.Int(nullable: false),
                        ComName = c.String(nullable: false, maxLength: 14),
                        ComProcess = c.String(nullable: false, maxLength: 20),
                        IDSort = c.Int(nullable: false),
                        Enable = c.Byte(nullable: false),
                        EveryDayRent = c.Long(nullable: false),
                        RecommendType = c.Int(nullable: false),
                        RecommendRoom = c.Int(),
                        StarCount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.NameID)
                .ForeignKey("dbo.TGameKindInfo", t => t.KindID, cascadeDelete: true)
                .Index(t => t.KindID);
            
            CreateTable(
                "dbo.TGameKindInfo",
                c => new
                    {
                        KindID = c.Int(nullable: false),
                        KindName = c.String(nullable: false, maxLength: 14),
                        IDSort = c.Int(nullable: false),
                        Enable = c.Byte(nullable: false),
                        ParentKindID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.KindID);
            
            CreateTable(
                "dbo.TGameRoomInfo",
                c => new
                    {
                        id = c.Int(nullable: false),
                        RoomID = c.Int(nullable: false),
                        RoomName = c.String(nullable: false, maxLength: 30),
                        ServerIP = c.String(nullable: false, maxLength: 25),
                        ServerInfoID = c.Int(nullable: false),
                        RoomTypeID = c.Int(nullable: false),
                        GameTypeID = c.Int(nullable: false),
                        GameKindID = c.Int(nullable: false),
                        GameNameID = c.Int(nullable: false),
                        SocketPort = c.Int(nullable: false),
                        OnlineCount = c.Int(nullable: false),
                        UpdateTime = c.DateTime(nullable: false),
                        EnableRoom = c.Short(nullable: false),
                        StopLogon = c.Short(nullable: false),
                        IDSort = c.Int(nullable: false),
                        Version = c.Int(nullable: false),
                        ServiceName = c.String(nullable: false, maxLength: 30),
                        VirtualUser = c.Int(nullable: false),
                        VirtualGameTime = c.Int(nullable: false),
                        SendTimeLength = c.Int(nullable: false),
                        SendCount = c.Long(nullable: false),
                        AgencyID = c.Int(nullable: false),
                        BattleRoomID = c.Int(),
                        BattleMatchTable = c.String(maxLength: 50),
                        RoomPassword = c.String(maxLength: 100, unicode: false),
                        tenancyID = c.Int(),
                    })
                .PrimaryKey(t => new { t.id, t.RoomID, t.RoomName, t.ServerIP, t.ServerInfoID, t.RoomTypeID, t.GameTypeID, t.GameKindID, t.GameNameID, t.SocketPort, t.OnlineCount, t.UpdateTime, t.EnableRoom, t.StopLogon, t.IDSort, t.Version, t.ServiceName, t.VirtualUser, t.VirtualGameTime, t.SendTimeLength, t.SendCount, t.AgencyID })
                .ForeignKey("dbo.TGameNameInfo", t => t.GameNameID, cascadeDelete: true)
                .Index(t => t.GameNameID);
            
            CreateTable(
                "dbo.TGameServerInfo",
                c => new
                    {
                        ServerInfoID = c.Int(nullable: false),
                        GameName = c.String(nullable: false, maxLength: 15),
                        GameTable = c.String(nullable: false, maxLength: 20),
                        NameID = c.Int(nullable: false),
                        SupportType = c.Int(nullable: false),
                        ServiceVer = c.Int(nullable: false),
                        DeskPeople = c.Int(nullable: false),
                        DLLFileName = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => new { t.ServerInfoID, t.GameName, t.GameTable, t.NameID, t.SupportType, t.ServiceVer, t.DeskPeople, t.DLLFileName })
                .ForeignKey("dbo.TGameNameInfo", t => t.NameID, cascadeDelete: true)
                .Index(t => t.NameID);
            
            CreateTable(
                "dbo.TUserCallGM",
                c => new
                    {
                        CallID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 20),
                        RoomID = c.Int(nullable: false),
                        NameID = c.Int(nullable: false),
                        RoomType = c.Int(nullable: false),
                        DeskStation = c.Int(nullable: false),
                        DeskNumber = c.Int(nullable: false),
                        ProblemType = c.Int(nullable: false),
                        callTime = c.DateTime(nullable: false),
                        MessageReason = c.String(nullable: false, maxLength: 250),
                        GMID = c.Int(nullable: false),
                        GMName = c.String(nullable: false, maxLength: 20),
                        receiveTime = c.DateTime(nullable: false),
                        overTime = c.DateTime(nullable: false),
                        TraiteRecord = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CallID)
                .ForeignKey("dbo.TGameNameInfo", t => t.NameID, cascadeDelete: true)
                .ForeignKey("dbo.TUsers", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID)
                .Index(t => t.NameID);
            
            CreateTable(
                "dbo.TMoneyChangeRecord",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        MoneyInBank = c.Long(nullable: false),
                        MoneyInRoom = c.Long(nullable: false),
                        OutMoney = c.Long(nullable: false),
                        InMoney = c.Long(nullable: false),
                        RoomID = c.Int(nullable: false),
                        TimeEx = c.DateTime(nullable: false),
                        Error = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.TUsers", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.TRoomRecord",
                c => new
                    {
                        RoomID = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                        ScrPoint = c.Int(nullable: false),
                        ChangePoint = c.Int(nullable: false),
                        ChangeMoney = c.Int(nullable: false),
                        ChangeTax = c.Int(nullable: false),
                        ResultPoint = c.Int(nullable: false),
                        AutoPoint = c.Int(nullable: false),
                        ChangeWin = c.Int(nullable: false),
                        ChangeLost = c.Int(nullable: false),
                        ChangeMid = c.Int(nullable: false),
                        ChangeCut = c.Int(nullable: false),
                        OnLineTime = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.RoomID, t.UserID, t.ScrPoint, t.ChangePoint, t.ChangeMoney, t.ChangeTax, t.ResultPoint, t.AutoPoint, t.ChangeWin, t.ChangeLost, t.ChangeMid, t.ChangeCut, t.OnLineTime })
                .ForeignKey("dbo.TUsers", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.TSendMoneyRecord",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        DaySendMoney = c.Int(nullable: false),
                        DaySendTimes = c.Int(nullable: false),
                        SendDate = c.String(nullable: false, maxLength: 20),
                        RoomID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.TUsers", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.TSendMoneyRecord_New",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        RoomID = c.Int(nullable: false),
                        SendMoney = c.Int(nullable: false),
                        SendCount_1 = c.Int(nullable: false),
                        SendCount_2 = c.Int(nullable: false),
                        SendType = c.Int(nullable: false),
                        SendDate = c.String(nullable: false, maxLength: 15, unicode: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.TUsers", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.TUserInfo",
                c => new
                    {
                        UserID = c.Int(nullable: false),
                        Member = c.Int(nullable: false),
                        MatchMember = c.Int(nullable: false),
                        Master = c.Int(nullable: false),
                        GamePower = c.Int(nullable: false),
                        GPLimitTime = c.DateTime(nullable: false),
                        WalletMoney = c.Long(nullable: false),
                        BankMoney = c.Long(nullable: false),
                        Fascination = c.Int(nullable: false),
                        Viptime = c.Int(nullable: false),
                        DoublePointTime = c.Int(nullable: false),
                        ProtectTime = c.Int(nullable: false),
                        LastLoginIP = c.String(nullable: false, maxLength: 16),
                        TimeIsMoney = c.Int(nullable: false),
                        AllLoginTime = c.Int(nullable: false),
                        LastLoginTM = c.DateTime(nullable: false),
                        TaxCom = c.Long(),
                        PhoneNum = c.String(nullable: false, maxLength: 50, unicode: false),
                        AdrNation = c.String(nullable: false, maxLength: 50),
                        AdrProvince = c.String(nullable: false, maxLength: 50, unicode: false),
                        AdrCity = c.String(nullable: false, maxLength: 50, unicode: false),
                        AdrZone = c.String(nullable: false, maxLength: 50, unicode: false),
                        OccuPation = c.String(nullable: false, maxLength: 50, unicode: false),
                        UserType = c.Int(nullable: false),
                        DiamondTime = c.Int(nullable: false),
                        LockMathine = c.Int(nullable: false),
                        MathineCode = c.String(),
                        OnlineMinutes = c.Int(),
                        RoomLoginTime = c.DateTime(),
                        PresentCoinNum = c.Int(),
                        StatusByGM = c.Int(),
                        StatusTime = c.DateTime(),
                        Trader = c.Short(),
                        KickUserTime = c.Int(),
                        AntiKickTime = c.Int(),
                        MyHardID = c.String(maxLength: 50),
                        AddFriendType = c.Int(nullable: false),
                        EmailCount = c.Int(),
                        UserIngot = c.Long(nullable: false),
                        ISCanTranMonBack = c.Short(nullable: false),
                        TranMonBackValue = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.UserID)
                .ForeignKey("dbo.TUsers", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.TUserList",
                c => new
                    {
                        UserID = c.Int(nullable: false),
                        RemoteID = c.Int(nullable: false),
                        GroupID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserID, t.RemoteID, t.GroupID })
                .ForeignKey("dbo.TUsers", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.TUserNameRule",
                c => new
                    {
                        UserID = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 20),
                        GameInvalidate = c.Boolean(nullable: false),
                        OverTime = c.DateTime(nullable: false),
                        RoomID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserID, t.UserName, t.GameInvalidate, t.OverTime, t.RoomID })
                .ForeignKey("dbo.TUsers", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.TCharmExchange",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        CharmValue = c.Int(nullable: false),
                        PropID = c.Int(nullable: false),
                        PropCount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.TContestDay",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ContestID = c.Int(nullable: false),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        AllowGame = c.Byte(nullable: false),
                        ReportStatus = c.Short(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.TContestInfo", t => t.ContestID)
                .Index(t => t.ContestID);
            
            CreateTable(
                "dbo.TContestInfo",
                c => new
                    {
                        ContestID = c.Int(nullable: false, identity: true),
                        RoomID = c.Int(nullable: false),
                        AwardTypeID = c.Int(nullable: false),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        Chip = c.Long(nullable: false),
                        LowCount = c.Int(nullable: false),
                        LowChip = c.Long(nullable: false),
                        EntryFee = c.Long(nullable: false),
                        CancleType = c.Int(nullable: false),
                        CancleRate = c.Int(nullable: false),
                        UpPeople = c.Int(nullable: false),
                        MinPeople = c.Int(nullable: false),
                        RankDis = c.Int(nullable: false),
                        Message = c.String(nullable: false, maxLength: 100),
                        SendTime = c.String(nullable: false, maxLength: 5, unicode: false),
                        MatchDesc = c.String(maxLength: 200, unicode: false),
                        MatchContent = c.String(storeType: "ntext"),
                        TimeOut = c.Int(),
                    })
                .PrimaryKey(t => t.ContestID);
            
            CreateTable(
                "dbo.TContestRecord",
                c => new
                    {
                        ContestID = c.Int(nullable: false),
                        ContestIndex = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                        ChangeChip = c.Long(nullable: false),
                        ChangePoint = c.Long(nullable: false),
                        Chip = c.Long(nullable: false),
                        DeskNo = c.Int(nullable: false),
                        RoomID = c.Int(nullable: false),
                        RecordTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.ContestID, t.ContestIndex, t.UserID, t.ChangeChip, t.ChangePoint, t.Chip, t.DeskNo, t.RoomID, t.RecordTime });
            
            CreateTable(
                "dbo.TContestUserRecord",
                c => new
                    {
                        ContestID = c.Int(nullable: false),
                        DayID = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                        ContestState = c.Byte(nullable: false),
                        ContestScore = c.Long(nullable: false),
                        ContestCount = c.Int(nullable: false),
                        RankNum = c.Int(nullable: false),
                        EntryTime = c.DateTime(nullable: false),
                        LeftTime = c.DateTime(nullable: false),
                        NickName = c.String(maxLength: 30, unicode: false),
                        LastScore = c.Long(),
                        IsAward = c.Byte(),
                        AwardID = c.Int(),
                    })
                .PrimaryKey(t => new { t.ContestID, t.DayID, t.UserID, t.ContestState, t.ContestScore, t.ContestCount, t.RankNum, t.EntryTime, t.LeftTime });
            
            CreateTable(
                "dbo.TGame_FlowWater",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        ServerName = c.String(nullable: false, maxLength: 20, unicode: false),
                        UserScore = c.Long(nullable: false),
                        UserStartGameTime = c.String(nullable: false, maxLength: 125, unicode: false),
                        UserEndGameTime = c.String(nullable: false, maxLength: 125, unicode: false),
                        UserGameStartScore = c.Long(),
                        UserGameEndScore = c.Long(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TGameIPRule",
                c => new
                    {
                        AccessIPChar = c.String(nullable: false, maxLength: 15),
                        LimitedReg = c.Boolean(nullable: false),
                        LimitedLogon = c.Boolean(nullable: false),
                        OverTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.AccessIPChar, t.LimitedReg, t.LimitedLogon, t.OverTime });
            
            CreateTable(
                "dbo.TGameRoomBase",
                c => new
                    {
                        RoomID = c.Int(nullable: false),
                        RoomRule = c.Int(nullable: false),
                        DeskCount = c.Int(nullable: false),
                        MaxPeople = c.Int(nullable: false),
                        BasePoint = c.Int(nullable: false),
                        LessPoint = c.Int(nullable: false),
                        MoneyPoint = c.Int(nullable: false),
                        Tax = c.Int(nullable: false),
                        UserPower = c.Int(nullable: false),
                        MaxLimite = c.Int(nullable: false),
                        RunPublish = c.Int(nullable: false),
                        t_change_m = c.Int(nullable: false),
                        t_unit = c.Int(nullable: false),
                        t_money = c.Int(nullable: false),
                        day_moneytimes = c.Int(nullable: false),
                        VipResever = c.Int(nullable: false),
                        Tickets = c.Int(nullable: false),
                        TaxType = c.Int(nullable: false),
                        PlayTimes = c.Int(nullable: false),
                        PlayTimesMoney = c.Int(nullable: false),
                        PlayCounts_1 = c.Int(nullable: false),
                        PlayCountsMoney_1 = c.Int(nullable: false),
                        PlayCounts_2 = c.Int(nullable: false),
                        PlayCountsMoney_2 = c.Int(nullable: false),
                        PlayCounts_3 = c.Int(nullable: false),
                        PlayCountsMoney_3 = c.Int(nullable: false),
                        MaxPoint = c.Long(nullable: false),
                        ContestID = c.Int(nullable: false),
                        ExercisePoint = c.Long(nullable: false),
                        RoomAdID = c.Int(),
                    })
                .PrimaryKey(t => t.RoomID);
            
            CreateTable(
                "dbo.TGameRoomMsg",
                c => new
                    {
                        RoomID = c.Int(nullable: false),
                        RoomWelcome = c.String(nullable: false, maxLength: 500),
                        RallWelcome = c.String(nullable: false, maxLength: 500),
                    })
                .PrimaryKey(t => t.RoomID)
                .ForeignKey("dbo.TGameRoomBase", t => t.RoomID, cascadeDelete: true)
                .Index(t => t.RoomID);
            
            CreateTable(
                "dbo.TGameRoomTable",
                c => new
                    {
                        RoomID = c.Int(nullable: false),
                        TableLock = c.String(nullable: false, maxLength: 30),
                        TableIPRule = c.String(nullable: false, maxLength: 30),
                        TableMatch = c.String(nullable: false, maxLength: 30),
                        TableUserNameRule = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.RoomID)
                .ForeignKey("dbo.TGameRoomBase", t => t.RoomID, cascadeDelete: true)
                .Index(t => t.RoomID);
            
            CreateTable(
                "dbo.TGiveIngotRecord",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                        DestUserID = c.Int(nullable: false),
                        GiveIngot = c.Long(nullable: false),
                        GiveTime = c.DateTime(nullable: false, storeType: "smalldatetime"),
                    })
                .PrimaryKey(t => new { t.ID, t.UserID, t.DestUserID, t.GiveIngot, t.GiveTime });
            
            CreateTable(
                "dbo.TGM＿AwardType",
                c => new
                    {
                        SeriNo = c.Int(nullable: false),
                        Gold = c.Int(nullable: false),
                        PropID1 = c.Int(),
                        PropCount1 = c.Int(),
                        PropID2 = c.Int(),
                        PropCount2 = c.Int(),
                        PropID3 = c.Int(),
                        PropCount3 = c.Int(),
                        PropID4 = c.Int(),
                        PropCount4 = c.Int(),
                    })
                .PrimaryKey(t => t.SeriNo);
            
            CreateTable(
                "dbo.TGM_OperationRecord",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        GMID = c.Int(nullable: false),
                        OperationType = c.Int(nullable: false),
                        BeginTime = c.DateTime(nullable: false, storeType: "smalldatetime"),
                        LastMinutes = c.Int(nullable: false),
                        AwardType = c.Int(nullable: false),
                        Reason = c.String(nullable: false, maxLength: 64),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TGMRecord",
                c => new
                    {
                        GMID = c.Int(nullable: false),
                        beginTime = c.DateTime(nullable: false),
                        MsgResult = c.String(nullable: false, maxLength: 250),
                    })
                .PrimaryKey(t => new { t.GMID, t.beginTime, t.MsgResult });
            
            CreateTable(
                "dbo.TLockCode",
                c => new
                    {
                        LockCode = c.String(nullable: false, maxLength: 80),
                        LockHard = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => new { t.LockCode, t.LockHard });
            
            CreateTable(
                "dbo.TLoginRecord",
                c => new
                    {
                        UserID = c.Int(nullable: false),
                        LastLoginIP = c.String(nullable: false, maxLength: 16, fixedLength: true),
                        LastLoginTM = c.DateTime(nullable: false),
                        MachineCode = c.String(maxLength: 80),
                        CPUID = c.String(maxLength: 40),
                        HardID = c.String(maxLength: 40),
                    })
                .PrimaryKey(t => new { t.UserID, t.LastLoginIP, t.LastLoginTM });
            
            CreateTable(
                "dbo.TMoneyExceptLog",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        BankMoney = c.Long(),
                        WalletMoney = c.Long(),
                        TotalMoney = c.Long(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.TProc_Error_Log",
                c => new
                    {
                        ProID = c.Long(nullable: false, identity: true),
                        ProName = c.String(maxLength: 128, unicode: false),
                        ProParam = c.String(maxLength: 4098, unicode: false),
                        ProNumber = c.Int(),
                        ProLine = c.Int(),
                        ProMessage = c.String(maxLength: 1024, unicode: false),
                        EndTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.ProID);
            
            CreateTable(
                "dbo.TReceiveMoneyDefind",
                c => new
                    {
                        id = c.Int(nullable: false),
                        ReceiveMoney = c.Long(nullable: false),
                        MinMoney = c.Long(nullable: false),
                        SpaceTime = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.TReceiveMoneyRecord",
                c => new
                    {
                        UserID = c.Int(nullable: false),
                        ReceiveCount = c.Int(nullable: false),
                        LastReceiveTime = c.DateTime(nullable: false),
                        ReceiveMoneyCount = c.Int(nullable: false),
                        ID = c.Long(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserID, t.ReceiveCount, t.LastReceiveTime, t.ReceiveMoneyCount, t.ID });
            
            CreateTable(
                "dbo.TRoomIPRule",
                c => new
                    {
                        AccessIPChar = c.String(nullable: false, maxLength: 15),
                        LimitedGame = c.Boolean(nullable: false),
                        bLimitedBank = c.Boolean(nullable: false),
                        OverTime = c.DateTime(nullable: false),
                        RoomID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.AccessIPChar, t.LimitedGame, t.bLimitedBank, t.OverTime, t.RoomID });
            
            CreateTable(
                "dbo.TTransferRecord",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                        DestUserID = c.Int(nullable: false),
                        TransferMoney = c.Long(nullable: false),
                        ActualTransfer = c.Long(nullable: false),
                        TransTime = c.DateTime(nullable: false, storeType: "smalldatetime"),
                        TranBOnceValue = c.Long(nullable: false),
                    })
                .PrimaryKey(t => new { t.ID, t.UserID, t.DestUserID, t.TransferMoney, t.ActualTransfer, t.TransTime, t.TranBOnceValue });
            
            CreateTable(
                "dbo.TUserLoginGame",
                c => new
                    {
                        UserID = c.Int(nullable: false),
                        KindID = c.Int(nullable: false),
                        GameID = c.Int(nullable: false),
                        LastTime = c.DateTime(nullable: false),
                        LoginCount = c.Int(nullable: false),
                        RoomID = c.Int(),
                    })
                .PrimaryKey(t => new { t.UserID, t.KindID, t.GameID, t.LastTime, t.LoginCount });
            
            CreateTable(
                "dbo.TWLoginRecord",
                c => new
                    {
                        UserID = c.Int(nullable: false),
                        WID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserID, t.WID });
            
            CreateTable(
                "dbo.TZLoginRecord",
                c => new
                    {
                        UserID = c.Int(nullable: false),
                        ZID = c.String(nullable: false, maxLength: 20, unicode: false),
                    })
                .PrimaryKey(t => new { t.UserID, t.ZID });
            
            CreateTable(
                "dbo.VChangeRecord",
                c => new
                    {
                        RoomID = c.Int(nullable: false),
                        id = c.Int(nullable: false),
                        RecordIndex = c.Int(nullable: false),
                        UserIndex = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                        SrcPoint = c.Long(nullable: false),
                        SrcMoney = c.Long(nullable: false),
                        ChangePoint = c.Long(nullable: false),
                        ChangeMoney = c.Long(nullable: false),
                        ChangeTax = c.Long(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        GameTime = c.Int(nullable: false),
                        ReportStatus = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.RoomID, t.id, t.RecordIndex, t.UserIndex, t.UserID, t.SrcPoint, t.SrcMoney, t.ChangePoint, t.ChangeMoney, t.ChangeTax, t.EndTime, t.GameTime, t.ReportStatus });
            
            CreateTable(
                "dbo.VPropGive",
                c => new
                    {
                        id = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                        NickName = c.String(nullable: false, maxLength: 50),
                        TargetID = c.Int(nullable: false),
                        TargetNickname = c.String(nullable: false, maxLength: 50),
                        PropName = c.String(nullable: false, maxLength: 50),
                        Price = c.Int(nullable: false),
                        VipPrice = c.Int(nullable: false),
                        Descript = c.String(nullable: false, maxLength: 50),
                        ActionTime = c.DateTime(nullable: false),
                        PropCount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.id, t.UserID, t.NickName, t.TargetID, t.TargetNickname, t.PropName, t.Price, t.VipPrice, t.Descript, t.ActionTime, t.PropCount });
            
            CreateTable(
                "dbo.VRoomList",
                c => new
                    {
                        RoomID = c.Int(nullable: false),
                        ServerInfoID = c.Int(nullable: false),
                        SocketPort = c.Int(nullable: false),
                        IDSort = c.Int(nullable: false),
                        KindID = c.Int(nullable: false),
                        EnableRoom = c.Short(nullable: false),
                        NameID = c.Int(nullable: false),
                        DeskPeople = c.Int(nullable: false),
                        SupportType = c.Int(nullable: false),
                        ServiceVer = c.Int(nullable: false),
                        GameName = c.String(nullable: false, maxLength: 15),
                        GameTable = c.String(nullable: false, maxLength: 20),
                        DLLFileName = c.String(nullable: false, maxLength: 20),
                        RoomRule = c.Int(nullable: false),
                        UserPower = c.Int(nullable: false),
                        GameTypeID = c.Int(nullable: false),
                        BasePoint = c.Int(nullable: false),
                        LessPoint = c.Int(nullable: false),
                        MaxLimite = c.Int(nullable: false),
                        RunPublish = c.Int(nullable: false),
                        Tax = c.Int(nullable: false),
                        MaxPeople = c.Int(nullable: false),
                        DeskCount = c.Int(nullable: false),
                        StopLogon = c.Short(nullable: false),
                        RoomName = c.String(nullable: false, maxLength: 30),
                        ServerIP = c.String(nullable: false, maxLength: 25),
                        TableLock = c.String(nullable: false, maxLength: 30),
                        TableMatch = c.String(nullable: false, maxLength: 30),
                        TableIPRule = c.String(nullable: false, maxLength: 30),
                        TableUserNameRule = c.String(nullable: false, maxLength: 30),
                        ServiceName = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => new { t.RoomID, t.ServerInfoID, t.SocketPort, t.IDSort, t.KindID, t.EnableRoom, t.NameID, t.DeskPeople, t.SupportType, t.ServiceVer, t.GameName, t.GameTable, t.DLLFileName, t.RoomRule, t.UserPower, t.GameTypeID, t.BasePoint, t.LessPoint, t.MaxLimite, t.RunPublish, t.Tax, t.MaxPeople, t.DeskCount, t.StopLogon, t.RoomName, t.ServerIP, t.TableLock, t.TableMatch, t.TableIPRule, t.TableUserNameRule, t.ServiceName });
            
            CreateTable(
                "dbo.VUserBuy",
                c => new
                    {
                        id = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                        NickName = c.String(nullable: false, maxLength: 50),
                        PropID = c.Int(nullable: false),
                        PropCount = c.Int(nullable: false),
                        Money = c.Int(nullable: false),
                        ActionTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.id, t.UserID, t.NickName, t.PropID, t.PropCount, t.Money, t.ActionTime });
            
            CreateTable(
                "dbo.VUserListReceive",
                c => new
                    {
                        UserID = c.Int(nullable: false),
                        RemoteID = c.Int(nullable: false),
                        Sex = c.Short(nullable: false),
                        NickName = c.String(nullable: false, maxLength: 50),
                        GroupID = c.Int(nullable: false),
                        OnlineFlag = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserID, t.RemoteID, t.Sex, t.NickName, t.GroupID, t.OnlineFlag });
            
            CreateTable(
                "dbo.VUserListSend",
                c => new
                    {
                        UserID = c.Int(nullable: false),
                        RemoteID = c.Int(nullable: false),
                        NickName = c.String(nullable: false, maxLength: 50),
                        GroupID = c.Int(nullable: false),
                        Sex = c.Short(nullable: false),
                        OnlineFlag = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserID, t.RemoteID, t.NickName, t.GroupID, t.Sex, t.OnlineFlag });
            
            CreateTable(
                "dbo.VUserProp",
                c => new
                    {
                        UserID = c.Int(nullable: false),
                        HoldCount = c.Int(nullable: false),
                        PropID = c.Int(nullable: false),
                        PropName = c.String(nullable: false, maxLength: 50),
                        Price = c.Int(nullable: false),
                        VipPrice = c.Int(nullable: false),
                        Descript = c.String(nullable: false, maxLength: 50),
                        ActionAttribute = c.Int(nullable: false),
                        ValueAttribute = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserID, t.HoldCount, t.PropID, t.PropName, t.Price, t.VipPrice, t.Descript, t.ActionAttribute, t.ValueAttribute });
            
            CreateTable(
                "dbo.VUsers",
                c => new
                    {
                        UserID = c.Int(nullable: false),
                        Member = c.Int(nullable: false),
                        MatchMember = c.Int(nullable: false),
                        Master = c.Int(nullable: false),
                        GamePower = c.Int(nullable: false),
                        GPLimitTime = c.DateTime(nullable: false),
                        WalletMoney = c.Long(nullable: false),
                        BankMoney = c.Long(nullable: false),
                        Fascination = c.Int(nullable: false),
                        Viptime = c.Int(nullable: false),
                        DoublePointTime = c.Int(nullable: false),
                        ProtectTime = c.Int(nullable: false),
                        LastLoginIP = c.String(nullable: false, maxLength: 16),
                        TimeIsMoney = c.Int(nullable: false),
                        AllLoginTime = c.Int(nullable: false),
                        LastLoginTM = c.DateTime(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 20),
                        Pass = c.String(nullable: false, maxLength: 50),
                        NickName = c.String(nullable: false, maxLength: 50),
                        LogoID = c.Int(nullable: false),
                        LogoFileMD5 = c.String(nullable: false, maxLength: 50),
                        Token = c.String(nullable: false, maxLength: 128),
                        OnlineFlag = c.Int(nullable: false),
                        Disabled = c.Int(nullable: false),
                        Sex = c.Short(nullable: false),
                        TwoPassword = c.String(nullable: false, maxLength: 50),
                        ISCanTranMonBack = c.Short(nullable: false),
                        TranMonBackValue = c.Long(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserID, t.Member, t.MatchMember, t.Master, t.GamePower, t.GPLimitTime, t.WalletMoney, t.BankMoney, t.Fascination, t.Viptime, t.DoublePointTime, t.ProtectTime, t.LastLoginIP, t.TimeIsMoney, t.AllLoginTime, t.LastLoginTM, t.UserName, t.Pass, t.NickName, t.LogoID, t.LogoFileMD5, t.Token, t.OnlineFlag, t.Disabled, t.Sex, t.TwoPassword, t.ISCanTranMonBack, t.TranMonBackValue });
            
            CreateTable(
                "dbo.VUsersAlbum",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                        ColumnID = c.Int(nullable: false),
                        PicName = c.String(nullable: false, maxLength: 300),
                        PicPath = c.String(nullable: false, maxLength: 1000),
                        PicDescription = c.String(nullable: false, maxLength: 1000),
                        ShortNum = c.Int(nullable: false),
                        Enable = c.String(nullable: false, maxLength: 50),
                        InputTime = c.DateTime(nullable: false),
                        UserName = c.String(maxLength: 20),
                        AlbumName = c.String(maxLength: 50),
                        IsPublic = c.String(maxLength: 50),
                        NickName = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => new { t.ID, t.UserID, t.ColumnID, t.PicName, t.PicPath, t.PicDescription, t.ShortNum, t.Enable, t.InputTime });
            
            CreateTable(
                "dbo.Web_AdminEmail",
                c => new
                    {
                        MsgID = c.Int(nullable: false, identity: true),
                        MsgContent = c.String(nullable: false, maxLength: 500),
                        SendTime = c.DateTime(nullable: false),
                        AdminName = c.String(nullable: false, maxLength: 50),
                        UserID = c.Int(nullable: false),
                        IsSend = c.Int(nullable: false),
                        IsToAll = c.Int(nullable: false),
                        IsMarquee = c.Int(nullable: false),
                        MsgWebContent = c.String(storeType: "ntext"),
                        Type = c.Int(),
                        MsgTitle = c.String(maxLength: 100),
                        IsHallMarquee = c.Int(),
                        LoopTime = c.Int(),
                        MsgTimes = c.Int(),
                    })
                .PrimaryKey(t => t.MsgID);
            
            CreateTable(
                "dbo.Web_AdminLog",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ModelName = c.String(maxLength: 50),
                        TableName = c.String(maxLength: 50),
                        TablePrimaryKey = c.String(maxLength: 300),
                        BeEditField = c.String(maxLength: 300),
                        BeforeEdit = c.String(maxLength: 300),
                        AfterEdit = c.String(maxLength: 300),
                        ByWho = c.Int(nullable: false),
                        ByTime = c.DateTime(nullable: false),
                        ByIP = c.String(nullable: false, maxLength: 15),
                        Remark = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Web_AdminModifyLog",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AdminName = c.String(nullable: false, maxLength: 50, unicode: false),
                        IP = c.String(nullable: false, maxLength: 50, unicode: false),
                        System = c.String(maxLength: 50, unicode: false),
                        Description = c.String(maxLength: 2000, unicode: false),
                        State = c.Boolean(nullable: false),
                        AddTime = c.DateTime(nullable: false),
                        OperateType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Web_Agency",
                c => new
                    {
                        AgencyID = c.Int(nullable: false, identity: true),
                        AgencyName = c.String(nullable: false, maxLength: 50),
                        AgencyPassword = c.String(nullable: false, maxLength: 255),
                        ParentAgencyID = c.Int(nullable: false),
                        LevelID = c.Int(nullable: false),
                        TrueName = c.String(nullable: false, maxLength: 50),
                        Phone = c.String(nullable: false, maxLength: 50, unicode: false),
                        Address = c.String(nullable: false, maxLength: 100),
                        PostalCode = c.Int(nullable: false),
                        QQNum = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 50, unicode: false),
                        MobilPhone = c.String(nullable: false, maxLength: 50, unicode: false),
                        AccountNO = c.String(nullable: false, maxLength: 50),
                        Account = c.Long(nullable: false),
                        AccountName = c.String(nullable: false, maxLength: 50),
                        BankName = c.String(nullable: false, maxLength: 100),
                        BankAddress = c.String(nullable: false, maxLength: 100),
                        PayorNo = c.String(nullable: false, maxLength: 50),
                        TenpayNo = c.String(nullable: false, maxLength: 100),
                        SpareValue = c.Decimal(nullable: false, precision: 18, scale: 0),
                        RegisterTime = c.DateTime(nullable: false),
                        UpdateTime = c.DateTime(nullable: false),
                        IsTaboo = c.Byte(nullable: false),
                        LastLoginDateTime = c.DateTime(nullable: false),
                        LastLoginIP = c.String(nullable: false, maxLength: 20),
                        DomainUrl = c.String(nullable: false, maxLength: 50),
                        Remark = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.AgencyID);
            
            CreateTable(
                "dbo.Web_AgencyAccountLog",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AdminID = c.Int(nullable: false),
                        AgencyID = c.Int(nullable: false),
                        MoneyB = c.Long(nullable: false),
                        Range = c.Long(nullable: false),
                        MoneyA = c.Long(nullable: false),
                        InputDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Web_AgencyBalanceLog",
                c => new
                    {
                        BaID = c.Int(nullable: false, identity: true),
                        AgencyID = c.Int(nullable: false),
                        BaMoney = c.Long(nullable: false),
                        BaMoneyB = c.Long(nullable: false),
                        BaMoneyA = c.Long(nullable: false),
                        Addtime = c.DateTime(nullable: false),
                        AdminID = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.BaID);
            
            CreateTable(
                "dbo.Web_AgencyDayReport",
                c => new
                    {
                        RecordID = c.Int(nullable: false, identity: true),
                        AgencyID = c.Int(nullable: false),
                        AgencyName = c.String(nullable: false, maxLength: 50),
                        ParentAgencyID = c.Int(nullable: false),
                        MyPercent = c.Int(nullable: false),
                        LevelID = c.Int(nullable: false),
                        GameNameID = c.Int(nullable: false),
                        LwMoney = c.Long(nullable: false),
                        SpareMoney = c.Long(nullable: false),
                        ActualSpareMoney = c.Long(nullable: false),
                        CountTime = c.DateTime(nullable: false),
                        CountState = c.Int(nullable: false),
                        IsBalance = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RecordID);
            
            CreateTable(
                "dbo.Web_AgencyMoneyChangeLog",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AgencyID = c.Int(nullable: false),
                        AgencyName = c.String(nullable: false, maxLength: 20),
                        MoneyB = c.Long(nullable: false),
                        ChangeMoney = c.Long(nullable: false),
                        MoneyA = c.Long(nullable: false),
                        OperaType = c.Int(nullable: false),
                        TypeDesc = c.String(nullable: false, maxLength: 20),
                        AddTime = c.DateTime(nullable: false),
                        Remark = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Web_AgencyPercentChange",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        OperaID = c.Int(nullable: false),
                        AgencyID = c.Int(nullable: false),
                        BPercent = c.Int(nullable: false),
                        APercent = c.Int(nullable: false),
                        Change = c.Int(nullable: false),
                        AddTime = c.DateTime(nullable: false),
                        OperaType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Web_AgencyPopeSet",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AgencyName = c.String(nullable: false, maxLength: 50),
                        IsAddAgency = c.Int(nullable: false),
                        IsPickUpCashToAgency = c.Int(nullable: false),
                        IsPickUpCashToPlayer = c.Int(nullable: false),
                        IsGiveToAgency = c.Int(nullable: false),
                        IsGiveToPlayer = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Web_AgencyRMBCost",
                c => new
                    {
                        PayID = c.Int(nullable: false, identity: true),
                        TrueName = c.String(nullable: false, maxLength: 30),
                        Phone = c.String(nullable: false, maxLength: 50),
                        UserName = c.String(nullable: false, maxLength: 50),
                        PayMoney = c.Int(nullable: false),
                        PayType = c.Byte(nullable: false),
                        TypeInfo = c.String(nullable: false, maxLength: 50),
                        OrderID = c.String(nullable: false, maxLength: 50),
                        AddTime = c.DateTime(nullable: false, storeType: "smalldatetime"),
                        PaySuccess = c.Boolean(nullable: false),
                        BackTime = c.DateTime(storeType: "smalldatetime"),
                        MoneyFront = c.Int(nullable: false),
                        MoneyAfter = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PayID);
            
            CreateTable(
                "dbo.Web_AlmsConfig",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        AlmsMoney = c.Int(nullable: false),
                        AlmsDayCounts = c.Int(nullable: false),
                        AlmsFirstNews = c.String(nullable: false),
                        AlmsSecondNews = c.String(nullable: false),
                        AlmsThirdNews = c.String(nullable: false),
                        AlmsLimitMoney = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Web_AlmsDrawLog",
                c => new
                    {
                        UserId = c.Int(nullable: false),
                        DrawTime = c.DateTime(nullable: false),
                        DrawMoney = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserId, t.DrawTime, t.DrawMoney });
            
            CreateTable(
                "dbo.Web_Analy_DateReport",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ReportDate = c.DateTime(nullable: false),
                        AvgOnline = c.Int(nullable: false),
                        MaxOnline = c.Int(nullable: false),
                        MinOnline = c.Int(nullable: false),
                        LoginNum = c.Int(nullable: false),
                        ActiveNum = c.Int(nullable: false),
                        ActiveGameCount = c.Int(nullable: false),
                        NewUserNum = c.Int(nullable: false),
                        PayNum = c.Int(nullable: false),
                        PayMoneyCount = c.Int(nullable: false),
                        PayCount = c.Int(nullable: false),
                        GameCount = c.Int(nullable: false),
                        TaxCount = c.Int(nullable: false),
                        AgencyName = c.String(nullable: false, maxLength: 100),
                        AgencyID = c.Int(nullable: false),
                        RegNum = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Web_Analy_MonthReport",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ReportDate = c.DateTime(nullable: false),
                        AvgOnline = c.Int(nullable: false),
                        MaxOnline = c.Int(nullable: false),
                        MinOnline = c.Int(nullable: false),
                        LoginNum = c.Int(nullable: false),
                        ActiveNum = c.Int(nullable: false),
                        NewUserNum = c.Int(nullable: false),
                        PayNum = c.Int(nullable: false),
                        PayMoneyCount = c.Int(nullable: false),
                        PayCount = c.Int(nullable: false),
                        GameCount = c.Int(nullable: false),
                        TaxCount = c.Int(nullable: false),
                        RegNum = c.Int(nullable: false),
                        LossNum = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Web_Analy_NewUserReport",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ReportDate = c.DateTime(nullable: false),
                        RegNum = c.Int(nullable: false),
                        LoginNum = c.Int(nullable: false),
                        ActiveNum = c.Int(nullable: false),
                        GameCount = c.Int(nullable: false),
                        PayNum = c.Int(nullable: false),
                        PayMoneyCount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Web_AnalyData_DateOnline",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AvgOnline = c.Int(nullable: false),
                        MaxOnline = c.Int(nullable: false),
                        MinOnline = c.Int(nullable: false),
                        ReportDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Web_ApplyVipRoom",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        Email = c.String(maxLength: 50),
                        QQ = c.String(maxLength: 50),
                        Mobile = c.String(maxLength: 50),
                        ApplyGameNameID = c.Int(nullable: false),
                        OpenRoomDate = c.DateTime(nullable: false),
                        AppleyDays = c.Int(nullable: false),
                        RoomName = c.String(nullable: false, maxLength: 50),
                        RoomPwd = c.String(nullable: false, maxLength: 50),
                        DeskCount = c.Int(nullable: false),
                        TaxType = c.Int(nullable: false),
                        Tax = c.Int(nullable: false),
                        MaxPeople = c.Int(nullable: false),
                        BasePoint = c.Int(nullable: false),
                        LessPoint = c.Int(nullable: false),
                        MaxPoint = c.Int(nullable: false),
                        RoomMsg = c.String(maxLength: 1000),
                        RallWelcome = c.String(maxLength: 1000),
                        Remark = c.String(),
                        RoomID = c.Int(nullable: false),
                        AuditStatus = c.Short(nullable: false),
                        AddDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Web_Award",
                c => new
                    {
                        Award_ID = c.Int(nullable: false, identity: true),
                        Award_Name = c.String(maxLength: 50),
                        Award_Info = c.String(storeType: "ntext"),
                        Award_Pic = c.String(maxLength: 50),
                        Award_Num = c.Int(),
                        Award_MoneyCost = c.Long(),
                        Award_MoneyGet = c.Int(),
                        Award_Type = c.Int(),
                        Award_AddDate = c.DateTime(),
                        Award_Hot = c.Boolean(),
                        Award_OnLineTime = c.Int(),
                        Award_NeedMoney = c.Long(),
                    })
                .PrimaryKey(t => t.Award_ID);
            
            CreateTable(
                "dbo.Web_AwardLog",
                c => new
                    {
                        Log_ID = c.Int(nullable: false, identity: true),
                        Award_ID = c.Int(),
                        UserID = c.Int(),
                        Award_MoneyCost = c.Long(),
                        IsCash = c.Boolean(),
                        AwardTime = c.DateTime(),
                        Award_OnLineTime = c.Int(),
                        TrueName = c.String(maxLength: 50, unicode: false),
                        Phone = c.String(maxLength: 50, unicode: false),
                        Address = c.String(maxLength: 200, unicode: false),
                        UserRemark = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.Log_ID);
            
            CreateTable(
                "dbo.Web_Card",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Users_ids = c.Int(),
                        num = c.String(maxLength: 50),
                        pwd = c.String(maxLength: 50),
                        jine = c.Int(),
                        player = c.String(maxLength: 50),
                        tm = c.DateTime(storeType: "smalldatetime"),
                        ip = c.String(maxLength: 15),
                        pay = c.Boolean(),
                        types = c.String(maxLength: 10, fixedLength: true, unicode: false),
                        addtime = c.DateTime(),
                        BMoney = c.Long(nullable: false),
                        AMoney = c.Long(nullable: false),
                        ToPoint = c.Int(),
                        CreateBy = c.Int(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        CreateIP = c.String(nullable: false, maxLength: 15),
                        Statu = c.Int(nullable: false),
                        CardType = c.Int(nullable: false),
                        BarUser = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Web_CashConnection",
                c => new
                    {
                        ConKey = c.String(nullable: false, maxLength: 40),
                        UserName = c.String(nullable: false, maxLength: 20),
                        CreateDate = c.DateTime(nullable: false),
                        UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ConKey);
            
            CreateTable(
                "dbo.Web_CharmExchangeLog",
                c => new
                    {
                        Log_ID = c.Int(nullable: false, identity: true),
                        PropID = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                        PropName = c.String(nullable: false, maxLength: 50),
                        CharmValue = c.Int(nullable: false),
                        PropCount = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                        InputDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Log_ID);
            
            CreateTable(
                "dbo.Web_CheckAwardList",
                c => new
                    {
                        AwardID = c.Int(nullable: false, identity: true),
                        AwardName = c.String(maxLength: 50),
                        AwardMoney = c.Long(),
                        Lottery = c.Int(),
                        PropID = c.Int(),
                        PropCount = c.Int(),
                        PropID1 = c.Int(),
                        PropCount1 = c.Int(),
                        PropID2 = c.Int(),
                        PropCount2 = c.Int(),
                    })
                .PrimaryKey(t => t.AwardID);
            
            CreateTable(
                "dbo.Web_CheckIn",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.ID, t.StartDate, t.EndDate });
            
            CreateTable(
                "dbo.Web_CheckInGot",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                        GotTime = c.DateTime(nullable: false),
                        AwardID = c.Int(nullable: false),
                        AwardMoney = c.Long(),
                        Lottery = c.Long(),
                        PropID = c.Int(),
                        PropCount = c.Int(),
                        PropID1 = c.Int(),
                        PropCount1 = c.Int(),
                        PropID2 = c.Int(),
                        PropCount2 = c.Int(),
                        CheckInSetID = c.Int(),
                        CheckInSetName = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => new { t.ID, t.UserID, t.GotTime, t.AwardID });
            
            CreateTable(
                "dbo.Web_CheckInLog",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                        CheckInTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.ID, t.UserID, t.CheckInTime });
            
            CreateTable(
                "dbo.Web_CheckInSet",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        Amount = c.Int(nullable: false),
                        Type = c.Int(nullable: false),
                        State = c.Int(nullable: false),
                        CheckInID = c.Int(nullable: false),
                        GotType = c.Int(nullable: false),
                        LastEditTime = c.DateTime(nullable: false),
                        RewardID = c.Int(),
                    })
                .PrimaryKey(t => new { t.ID, t.Name, t.Amount, t.Type, t.State, t.CheckInID, t.GotType, t.LastEditTime });
            
            CreateTable(
                "dbo.Web_ClearFasciPropDefine",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 50),
                        Description = c.String(nullable: false, maxLength: 300),
                        Price = c.Int(nullable: false),
                        DecFasci = c.Int(nullable: false),
                        SortNum = c.Int(nullable: false),
                        InputDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Web_ClearFasciPropUseLog",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PropID = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                        BeforeFasci = c.Int(nullable: false),
                        AfterFasci = c.Int(nullable: false),
                        ChangeFasci = c.Int(nullable: false),
                        BeforeMoney = c.Long(nullable: false),
                        AfterMoney = c.Long(nullable: false),
                        ChangeMoney = c.Int(nullable: false),
                        InputDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Web_ClearingLog",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        ClearingTime = c.DateTime(storeType: "smalldatetime"),
                        Money = c.Int(),
                        IP = c.String(maxLength: 30, fixedLength: true, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Web_ClearPropLog",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        PropID = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                        InputDate = c.DateTime(nullable: false),
                        BeforeValue = c.Int(),
                        AfterValue = c.Int(),
                        PropType = c.Int(),
                        GameNameID = c.Int(),
                    })
                .PrimaryKey(t => new { t.ID, t.PropID, t.UserID, t.InputDate });
            
            CreateTable(
                "dbo.Web_Clothes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LogName = c.String(nullable: false, maxLength: 50),
                        Price = c.Long(nullable: false),
                        SendLotteries = c.Long(nullable: false),
                        LogID = c.Int(nullable: false),
                        Sex = c.Boolean(nullable: false),
                        Descript = c.String(maxLength: 1000),
                        LargessGold = c.Int(),
                        SendGold = c.Int(nullable: false),
                        PriceType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Web_ClothLog",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                        ClothID = c.Int(nullable: false),
                        LogName = c.String(nullable: false, maxLength: 50, unicode: false),
                        Price = c.Long(nullable: false),
                        SendTime = c.DateTime(nullable: false),
                        LogID = c.Int(),
                        LogSex = c.Int(),
                        sendLotteries = c.Long(),
                        Remark = c.String(maxLength: 20, unicode: false),
                    })
                .PrimaryKey(t => new { t.ID, t.UserID, t.ClothID, t.LogName, t.Price, t.SendTime });
            
            CreateTable(
                "dbo.Web_CompanyInfo",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ItemName = c.String(nullable: false, maxLength: 50),
                        Content = c.String(nullable: false, storeType: "ntext"),
                        Sort = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Web_Config",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        IPDisabled = c.String(nullable: false, maxLength: 2000),
                        ReRegTimeSpan = c.Int(nullable: false),
                        YeepayMsgInfo = c.String(nullable: false, unicode: false, storeType: "text"),
                        VipTransferTax = c.Int(nullable: false),
                        Yeepay_Rate_NetBank = c.Int(nullable: false),
                        Yeepay_Rate_Junnet = c.Int(nullable: false),
                        Yeepay_Rate_Szx = c.Int(nullable: false),
                        Yeepay_Rate_Unicom = c.Int(nullable: false),
                        Yeepay_Rate_YPCard = c.Int(nullable: false),
                        FreeCardCount = c.Int(nullable: false),
                        SpecialUser = c.String(nullable: false, maxLength: 20),
                        MRView = c.Boolean(nullable: false),
                        CreateBankTax = c.Int(nullable: false),
                        BankVersion = c.Int(nullable: false),
                        RobotRank = c.Int(nullable: false),
                        Ingot_MoneyChangeRate = c.Int(nullable: false),
                        Con_IngotChangeRate = c.Int(nullable: false),
                        IsPayToIngot = c.Int(nullable: false),
                        IsIngotToProp = c.Int(nullable: false),
                        IsIngotToGold = c.Int(nullable: false),
                        PartnerToCommonTax = c.Int(nullable: false),
                        PartnerToPartnerTax = c.Int(nullable: false),
                        CommToPartnerTax = c.Int(nullable: false),
                        PToCReturnTax = c.Int(nullable: false),
                        PToPReturnTax = c.Int(nullable: false),
                        TranMonBackLimit = c.Long(nullable: false),
                        BadUserName = c.String(),
                        BadNickName = c.String(),
                        MoneyToViptime = c.Int(),
                        MoneyToViptimeDay = c.Int(),
                        MoneyToViptimeWeek = c.Int(),
                        MoneyToViptimeMonth = c.Int(),
                        MoneyToViptimeHYear = c.Int(),
                        MoneyToViptimeYear = c.Int(),
                        UserobligateMoney = c.Int(),
                        TransferLessMoney = c.Long(),
                        TransferLessAllMoney = c.Long(),
                        TransferTax = c.Int(),
                        TransferMultiple = c.Int(),
                        MaxTransTax = c.Int(),
                        Con_ValidDay = c.Int(),
                        Con_OnlineTime = c.Int(),
                        Con_ValidUserAddMoney = c.Int(),
                        Con_CardInPercent = c.Int(),
                        Con_GetMoneyPercent = c.Int(),
                        Con_RegMoney = c.Int(),
                        Con_ValidUserMoney = c.Int(),
                        Con_MinClearingMoney = c.Int(),
                        Con_MoneyChangeRate = c.Int(),
                        RegWallet = c.Int(),
                        MaxTransUserMoney = c.Int(),
                        StartPresent = c.DateTime(),
                        EndPresent = c.DateTime(),
                        CoinNum = c.Int(),
                        TimeLength = c.Int(),
                        GameNameID = c.String(maxLength: 500),
                        TG_GameNameID = c.String(maxLength: 500),
                        FineryIDRegex = c.String(maxLength: 500, unicode: false),
                        FineryIDDefaultPrice = c.String(maxLength: 500, unicode: false),
                        MaxPayMoney = c.Long(),
                        UserMaxPayMoney = c.Int(),
                        SameIPRegCount = c.Int(),
                        SameCardNoRegCount = c.Int(),
                        LastLoginGameCount = c.Int(),
                        Con_PointChangeRate = c.Long(),
                        BankRate = c.Int(),
                        IsDisplayHomeGameAD = c.Boolean(),
                        IsDisplayHomeMoneyInfo = c.Boolean(),
                        IsOpenCommonTran = c.Int(),
                    })
                .PrimaryKey(t => new { t.ID, t.IPDisabled, t.ReRegTimeSpan, t.YeepayMsgInfo, t.VipTransferTax, t.Yeepay_Rate_NetBank, t.Yeepay_Rate_Junnet, t.Yeepay_Rate_Szx, t.Yeepay_Rate_Unicom, t.Yeepay_Rate_YPCard, t.FreeCardCount, t.SpecialUser, t.MRView, t.CreateBankTax, t.BankVersion, t.RobotRank, t.Ingot_MoneyChangeRate, t.Con_IngotChangeRate, t.IsPayToIngot, t.IsIngotToProp, t.IsIngotToGold, t.PartnerToCommonTax, t.PartnerToPartnerTax, t.CommToPartnerTax, t.PToCReturnTax, t.PToPReturnTax, t.TranMonBackLimit });
            
            CreateTable(
                "dbo.Web_ContestAwardConfig",
                c => new
                    {
                        AwardID = c.Int(nullable: false, identity: true),
                        MaxRank = c.Int(),
                        MinRank = c.Int(),
                        AwardMoney = c.Int(),
                        Lottery = c.Int(),
                        PropID = c.Int(),
                        PropCount = c.Int(),
                        PropID1 = c.Int(),
                        PropCount1 = c.Int(),
                        PropID2 = c.Int(),
                        PropCount2 = c.Int(),
                        AwardTypeID = c.Int(),
                    })
                .PrimaryKey(t => t.AwardID);
            
            CreateTable(
                "dbo.Web_ContestAwardLog",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        ContestID = c.Int(nullable: false),
                        AwardName = c.String(nullable: false, maxLength: 50, unicode: false),
                        UserID = c.String(nullable: false, maxLength: 10, fixedLength: true),
                        UserRank = c.Int(nullable: false),
                        RecordTime = c.DateTime(nullable: false),
                        Lottery = c.Int(),
                        AwardMoney = c.Long(),
                        PropName = c.String(maxLength: 50, unicode: false),
                        PropCount = c.Int(),
                        PropName1 = c.String(maxLength: 50, unicode: false),
                        PropCount1 = c.Int(),
                        PropName2 = c.String(maxLength: 50, unicode: false),
                        PropCount2 = c.Int(),
                    })
                .PrimaryKey(t => new { t.ID, t.ContestID, t.AwardName, t.UserID, t.UserRank, t.RecordTime });
            
            CreateTable(
                "dbo.Web_ContestAwardType",
                c => new
                    {
                        TypeID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.TypeID);
            
            CreateTable(
                "dbo.Web_ContestRank",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        DayID = c.Int(nullable: false),
                        ContestID = c.Int(nullable: false),
                        Score = c.Long(nullable: false),
                        RankNum = c.Int(nullable: false),
                        ReportTime = c.DateTime(nullable: false),
                        NickName = c.String(maxLength: 50),
                        ComName = c.String(maxLength: 50),
                        ContestCount = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Web_Count_AgencyOnline",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AgencyID = c.Int(nullable: false),
                        OnlineCount = c.Int(nullable: false),
                        InputDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Web_Count_OnlineUsers",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        InputDate = c.DateTime(nullable: false),
                        OnlineCount = c.Int(nullable: false),
                        UserType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Web_Count_RoomOnline",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        RoomID = c.Int(nullable: false),
                        OnlineCount = c.Int(nullable: false),
                        InputDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Web_CreateID",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Web_DataAnaly_Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 250),
                        LastLoginIP = c.String(maxLength: 50),
                        LastLoginTime = c.DateTime(),
                        AddTime = c.DateTime(nullable: false),
                        IsTaboo = c.Int(nullable: false),
                        LoginCount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
            CreateTable(
                "dbo.Web_DataClearLog",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AdminID = c.Int(nullable: false),
                        AdminName = c.String(nullable: false, maxLength: 50),
                        TypeID = c.Int(nullable: false),
                        TypeName = c.String(nullable: false, maxLength: 80),
                        ClearEndTime = c.DateTime(nullable: false),
                        ClearCount = c.Int(nullable: false),
                        AddTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Web_DayTaxReport",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ChangeTax = c.Long(nullable: false),
                        AddTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Web_Exchange",
                c => new
                    {
                        ExID = c.Long(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 20),
                        AddTime = c.DateTime(nullable: false),
                        ApplyMoney = c.Int(nullable: false),
                        ApplyState = c.Int(nullable: false),
                        AccountNo = c.String(nullable: false, maxLength: 100),
                        AccountName = c.String(nullable: false, maxLength: 50),
                        BankName = c.String(nullable: false, maxLength: 50),
                        BankAddress = c.String(nullable: false, maxLength: 200),
                        DisposeTime = c.DateTime(),
                        DisposeDesc = c.String(maxLength: 500),
                        AccountType = c.Int(nullable: false),
                        UserType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ExID);
            
            CreateTable(
                "dbo.Web_FasciExchangeConfig",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Con_StartTime = c.DateTime(),
                        Con_EndTime = c.DateTime(),
                        Con_Price = c.Int(nullable: false),
                        Con_ChangeLimit = c.Int(nullable: false),
                        Con_MaxMoney = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Web_FasciExchangeLog",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        ExchangeCount = c.Int(),
                        ConPrice = c.Int(),
                        InMoney = c.Int(),
                        IP = c.String(maxLength: 50, unicode: false),
                        ChangeFrontMoney = c.Long(nullable: false),
                        ChangeAfterMoney = c.Long(nullable: false),
                        AddTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Web_FineryID",
                c => new
                    {
                        FineryID = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                        IsBuy = c.Boolean(nullable: false),
                        IsUse = c.Boolean(nullable: false),
                        IsSale = c.Boolean(nullable: false),
                        IsTop = c.Boolean(nullable: false),
                        IsCopy = c.Boolean(nullable: false),
                        DateTime = c.DateTime(nullable: false),
                        UserID = c.Int(),
                        PassWord = c.String(maxLength: 50, unicode: false),
                        Explain = c.String(maxLength: 50, unicode: false),
                        DateTimeBuy = c.DateTime(),
                        DateTimeUse = c.DateTime(),
                        DateTimeCopy = c.DateTime(),
                    })
                .PrimaryKey(t => new { t.FineryID, t.Price, t.IsBuy, t.IsUse, t.IsSale, t.IsTop, t.IsCopy, t.DateTime });
            
            CreateTable(
                "dbo.Web_FriendLink",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 200),
                        Link = c.String(nullable: false, maxLength: 1000),
                        Type = c.Int(nullable: false),
                        ImagePath = c.String(nullable: false, maxLength: 1000),
                        OrderID = c.Int(nullable: false),
                        IsEnable = c.Boolean(nullable: false),
                        ShortDesc = c.String(nullable: false, maxLength: 200),
                        InputTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Web_GameGuidList",
                c => new
                    {
                        NameID = c.Int(nullable: false),
                        ID = c.Int(nullable: false, identity: true),
                        KindID = c.Int(nullable: false),
                        KindName = c.String(nullable: false, maxLength: 50),
                        GameName = c.String(nullable: false, maxLength: 50),
                        UserFlag = c.Boolean(nullable: false),
                        ParamsID = c.Int(),
                    })
                .PrimaryKey(t => t.NameID);
            
            CreateTable(
                "dbo.Web_GameInfo",
                c => new
                    {
                        Game_ID = c.Int(nullable: false),
                        Game_Name = c.String(nullable: false, maxLength: 50, unicode: false),
                        Game_Info = c.String(storeType: "ntext"),
                        Game_Rule = c.String(storeType: "ntext"),
                        Down_address = c.String(maxLength: 100),
                        Down_Num = c.Int(),
                        FileSize = c.String(maxLength: 20),
                        Provice = c.String(maxLength: 20, unicode: false),
                        Area = c.String(maxLength: 30, unicode: false),
                        Game_TypeID = c.Int(),
                        Through = c.Boolean(),
                        Image_URL = c.String(maxLength: 100),
                        UPdate_Time = c.DateTime(storeType: "smalldatetime"),
                        Game_Order = c.Int(),
                        Game_Process = c.String(maxLength: 100),
                        MatchTable = c.String(maxLength: 100),
                        IsHot = c.Boolean(nullable: false),
                        Game_SampleIntroduce = c.String(nullable: false, maxLength: 300),
                        Image_URL2 = c.String(maxLength: 100),
                        Image_URL3 = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Game_ID);
            
            CreateTable(
                "dbo.Web_GameMain",
                c => new
                    {
                        Main_ID = c.Short(nullable: false, identity: true),
                        Main_Info = c.String(maxLength: 1000, unicode: false),
                        sMain_Info = c.String(maxLength: 1000, unicode: false),
                        Main_Copy = c.String(maxLength: 50),
                        sMain_Copy = c.String(maxLength: 50),
                        Main_use = c.String(maxLength: 100),
                        sMain_use = c.String(maxLength: 100),
                        Update_Time = c.DateTime(),
                        Down_saddress = c.String(maxLength: 100),
                        Down_address = c.String(maxLength: 100),
                        Down_num = c.Int(),
                        sFileSize = c.String(maxLength: 20),
                        FileSize = c.String(maxLength: 20),
                        Image_URL = c.String(maxLength: 100),
                        sImage_URL = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Main_ID);
            
            CreateTable(
                "dbo.Web_GameType",
                c => new
                    {
                        TypeID = c.Short(nullable: false, identity: true),
                        TypeName = c.String(nullable: false, maxLength: 50, unicode: false),
                        TypeSort = c.Short(nullable: false),
                    })
                .PrimaryKey(t => t.TypeID);
            
            CreateTable(
                "dbo.Web_GUID",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Guid = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Web_IndexFlash",
                c => new
                    {
                        Flash_ID = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 100),
                        Picture = c.String(maxLength: 200),
                        URL = c.String(maxLength: 200),
                        Flash_Sort = c.Int(),
                        Through = c.Boolean(),
                    })
                .PrimaryKey(t => t.Flash_ID);
            
            CreateTable(
                "dbo.web_IngotChangeGold",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TitleName = c.String(maxLength: 60, unicode: false),
                        Ingot = c.Long(),
                        Gold = c.Long(),
                        ImgUrl = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Web_IngotChangeLog",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 50),
                        StartIngot = c.Long(nullable: false),
                        ChangeIngot = c.Long(nullable: false),
                        ChangeType = c.Int(nullable: false),
                        DateTime = c.DateTime(nullable: false),
                        Remark = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Web_IngotTransLog",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserName = c.String(maxLength: 20),
                        TransBefore = c.Long(),
                        TransAfter = c.Long(),
                        UserNameZZ = c.String(maxLength: 20),
                        ZZ_TransBefore = c.Long(),
                        ZZ_TransAfter = c.Long(),
                        TransIngot = c.Long(),
                        Tax = c.Int(),
                        TransTime = c.DateTime(storeType: "smalldatetime"),
                        IP = c.String(maxLength: 30),
                        Success = c.Boolean(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Web_Log",
                c => new
                    {
                        LogID = c.Int(nullable: false, identity: true),
                        LogUser = c.String(maxLength: 20),
                        LogIP = c.String(maxLength: 30),
                        OS = c.String(maxLength: 70),
                        Result = c.Byte(),
                        ErrorPas = c.String(maxLength: 500),
                        LoginTime = c.DateTime(storeType: "smalldatetime"),
                        IsManage = c.Boolean(),
                    })
                .PrimaryKey(t => t.LogID);
            
            CreateTable(
                "dbo.Web_LotterAward",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LotteryAwardName = c.String(nullable: false, maxLength: 50),
                        GoldRate = c.Int(nullable: false),
                        SilverRate = c.Int(nullable: false),
                        JadeRate = c.Int(nullable: false),
                        PicName = c.String(nullable: false, maxLength: 100),
                        Number = c.Int(),
                        AddDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Web_LotterConfig",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        GoldMoney = c.Long(nullable: false),
                        SilverMoney = c.Long(nullable: false),
                        JadeMoney = c.Long(nullable: false),
                        BeginTime = c.DateTime(),
                        EndTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Web_LotteriesLog",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 100),
                        LotteriesB = c.Int(nullable: false),
                        ChangeLotteries = c.Int(nullable: false),
                        LotteriesA = c.Int(nullable: false),
                        InputDate = c.DateTime(nullable: false),
                        Content = c.String(maxLength: 500),
                        ChangeType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Web_LotterLog",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        AwardID = c.Int(nullable: false),
                        AddDate = c.DateTime(nullable: false),
                        LotterType = c.Int(nullable: false),
                        ChangeMoney = c.Long(nullable: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Web_LotterSpecial",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        AwardID = c.Int(),
                        Status = c.Boolean(),
                        AddDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Web_manage_admin",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserName = c.String(maxLength: 50),
                        Password = c.String(maxLength: 50),
                        Purview = c.String(maxLength: 100),
                        UserGroup = c.Byte(),
                        LastLoginIP = c.String(maxLength: 15),
                        LastLoginTime = c.DateTime(storeType: "smalldatetime"),
                        LastLogoutTime = c.DateTime(storeType: "smalldatetime"),
                        LoginTimes = c.Int(),
                        AdminPurview_Article_T = c.Int(),
                        AdminPurview_Soft_T = c.Int(),
                        AdminPurview_Photo_T = c.Int(),
                        AdminPurview_Guest_T = c.String(maxLength: 50),
                        AdminPurview_Others_T = c.String(maxLength: 255),
                        RndPassword_T = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Web_Manage_Model",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ModelNo = c.String(nullable: false, maxLength: 50, unicode: false),
                        ModelName = c.String(nullable: false, maxLength: 200, unicode: false),
                        Remark = c.String(nullable: false, maxLength: 3000, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Web_Manage_Popedom",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AdminID = c.Int(nullable: false),
                        ModelNo = c.String(nullable: false, maxLength: 50, unicode: false),
                        HasInsert = c.Int(nullable: false),
                        HasUpdate = c.Int(nullable: false),
                        HasDel = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Web_MenuOften",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        AdminID = c.Int(nullable: false),
                        MenuID = c.Int(nullable: false),
                        SortID = c.Int(),
                    })
                .PrimaryKey(t => new { t.ID, t.AdminID, t.MenuID });
            
            CreateTable(
                "dbo.Web_MoneyChangeLog",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 50),
                        StartMoney = c.Long(nullable: false),
                        ChangeMoney = c.Long(nullable: false),
                        ChangeType = c.Int(nullable: false),
                        DateTime = c.DateTime(nullable: false),
                        Remark = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Web_MoneyStatEveryday",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        StatTime = c.DateTime(nullable: false),
                        BankMoney = c.Long(nullable: false),
                        WalletMoney = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Web_msg",
                c => new
                    {
                        msgid = c.Int(nullable: false, identity: true),
                        msgname = c.String(maxLength: 50),
                        msgtitle = c.String(maxLength: 50),
                        msgsex = c.String(maxLength: 50),
                        tel = c.String(maxLength: 50),
                        fax = c.String(maxLength: 50),
                        msgface = c.String(maxLength: 50),
                        msgtext = c.String(storeType: "ntext"),
                        msgmail = c.String(maxLength: 50),
                        msghome = c.String(maxLength: 50),
                        msgtime = c.DateTime(storeType: "smalldatetime"),
                        ip = c.String(maxLength: 50),
                        msgreplyname = c.String(maxLength: 50),
                        msgreply = c.String(storeType: "ntext"),
                        msgreplytime = c.DateTime(storeType: "smalldatetime"),
                        msgprivate = c.Int(),
                        count = c.Int(),
                        msghit = c.Int(),
                        IsPass = c.Boolean(),
                    })
                .PrimaryKey(t => t.msgid);
            
            CreateTable(
                "dbo.Web_NewsData",
                c => new
                    {
                        News_ID = c.Int(nullable: false, identity: true),
                        News_Type = c.Byte(),
                        Title = c.String(maxLength: 100),
                        TitleColor = c.String(nullable: false, maxLength: 50),
                        Keywords = c.String(maxLength: 100),
                        News_From = c.String(maxLength: 50),
                        Author = c.String(maxLength: 20),
                        Issuer = c.String(maxLength: 20),
                        Content = c.String(storeType: "ntext"),
                        News_picture = c.String(maxLength: 100),
                        Through = c.Boolean(),
                        Recommendation = c.Boolean(),
                        Istop = c.Boolean(),
                        Issue_Time = c.DateTime(storeType: "smalldatetime"),
                        Update_Time = c.DateTime(storeType: "smalldatetime"),
                        Hits = c.Int(),
                        News_Describe = c.String(nullable: false, maxLength: 300),
                    })
                .PrimaryKey(t => t.News_ID);
            
            CreateTable(
                "dbo.Web_NewsType",
                c => new
                    {
                        Typeid = c.Short(nullable: false, identity: true),
                        TypeName = c.String(maxLength: 20),
                        TypeSort = c.Short(),
                    })
                .PrimaryKey(t => t.Typeid);
            
            CreateTable(
                "dbo.Web_PayPropRecord",
                c => new
                    {
                        BuyType = c.String(nullable: false, maxLength: 10, unicode: false),
                        PriceType = c.Int(nullable: false),
                        PayPrice = c.Long(nullable: false),
                        PayNum = c.Int(nullable: false),
                        TranType = c.String(nullable: false, maxLength: 4, unicode: false),
                        PayTime = c.DateTime(nullable: false),
                        UserID = c.Int(),
                        UserName = c.String(maxLength: 20),
                        NickName = c.String(maxLength: 50),
                        GoodName = c.String(maxLength: 50),
                        Remark = c.String(maxLength: 20, unicode: false),
                    })
                .PrimaryKey(t => new { t.BuyType, t.PriceType, t.PayPrice, t.PayNum, t.TranType, t.PayTime });
            
            CreateTable(
                "dbo.Web_PConfig",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Description = c.String(nullable: false, maxLength: 2000),
                        Field1 = c.String(maxLength: 1000),
                        Field2 = c.String(maxLength: 1000),
                        Field3 = c.String(maxLength: 1000),
                        Field4 = c.String(maxLength: 1000),
                        Field5 = c.String(maxLength: 1000),
                        Field6 = c.String(maxLength: 1000),
                        Field7 = c.String(maxLength: 1000),
                        Field8 = c.String(maxLength: 1000),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Web_PlatWinLostDateReport",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ReportDate = c.DateTime(nullable: false),
                        InitPlamtformMoney = c.Long(nullable: false),
                        CurrentPlamtformMoney = c.Long(nullable: false),
                        AdminOperateMoney = c.Long(nullable: false),
                        NameID = c.Int(nullable: false),
                        WonOrLostMoney = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Web_PlayerDayReport",
                c => new
                    {
                        RecordID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 50),
                        AgencyID = c.Int(nullable: false),
                        MyPercent = c.Int(nullable: false),
                        LwMoney = c.Long(nullable: false),
                        SpareMoney = c.Long(nullable: false),
                        CountTime = c.DateTime(nullable: false),
                        RoomName = c.Int(nullable: false),
                        CountState = c.Int(nullable: false),
                        WinMoney = c.Long(nullable: false),
                        LoseMoney = c.Long(nullable: false),
                        GameNameID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RecordID);
            
            CreateTable(
                "dbo.Web_PointChangeLog",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 50),
                        OrderID = c.String(nullable: false, maxLength: 100),
                        PayMoney = c.Int(nullable: false),
                        ExchangeRate = c.Long(nullable: false),
                        InSuccess = c.Boolean(),
                        PaySuccess = c.Boolean(),
                        AddTime = c.DateTime(),
                        BackTime = c.DateTime(),
                        PayType = c.String(maxLength: 50),
                        BPoint = c.Long(nullable: false),
                        APoint = c.Long(nullable: false),
                        GameNameID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Web_ProductList",
                c => new
                    {
                        GameID = c.Int(nullable: false),
                        GameName = c.String(nullable: false, maxLength: 100),
                        MinPeople = c.Int(nullable: false),
                        MaxPeople = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.GameID);
            
            CreateTable(
                "dbo.Web_PropChangeLog",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ActionDate = c.DateTime(nullable: false),
                        AdminName = c.String(nullable: false, maxLength: 100),
                        UserID = c.Int(nullable: false),
                        PropID = c.Int(nullable: false),
                        BeforeNum = c.Int(nullable: false),
                        AfterNum = c.Int(nullable: false),
                        ChangeType = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Web_PVAndIPStat",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AgencyID = c.Int(nullable: false),
                        IP = c.String(nullable: false, maxLength: 100),
                        PageUrl = c.String(nullable: false, maxLength: 1000),
                        ReportDate = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Web_RMBCost",
                c => new
                    {
                        PayID = c.Int(nullable: false, identity: true),
                        Users_ids = c.Int(),
                        TrueName = c.String(maxLength: 30),
                        Phone = c.String(maxLength: 50),
                        UserName = c.String(maxLength: 50),
                        PayMoney = c.Int(),
                        PayType = c.Byte(),
                        TypeInfo = c.String(maxLength: 50),
                        OrderID = c.String(maxLength: 50),
                        AddTime = c.DateTime(storeType: "smalldatetime"),
                        ExchangeRate = c.Int(),
                        InMoney = c.Int(),
                        InSuccess = c.Boolean(),
                        PaySuccess = c.Boolean(),
                        BackTime = c.DateTime(storeType: "smalldatetime"),
                        EncryptStr = c.String(maxLength: 1000),
                        Info = c.String(maxLength: 1000),
                        MoneyFront = c.Long(),
                        MoneyAfter = c.Long(),
                        UpdateFlag = c.Byte(),
                        PurchaseType = c.Int(),
                        PayIP = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.PayID);
            
            CreateTable(
                "dbo.Web_Role",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Web_RoleBeAdmin",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        RoleID = c.Int(nullable: false),
                        AdminID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Web_RoleBeMenu",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        RoleID = c.Int(nullable: false),
                        MenuID = c.Int(nullable: false),
                        MenuPermission = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Web_RoleMenu",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        PID = c.Int(nullable: false),
                        ICO = c.String(maxLength: 200),
                        URL = c.String(maxLength: 250),
                        Permission = c.String(maxLength: 100),
                        SortID = c.Int(),
                        MenuType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Web_System",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ParaName = c.String(nullable: false, maxLength: 50, unicode: false),
                        ParaValue = c.String(nullable: false, storeType: "ntext"),
                        Descript = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Web_TaxStatEveryDay",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        StatTime = c.DateTime(nullable: false),
                        NameID = c.Int(nullable: false),
                        Tax = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Web_TGClearingRecord",
                c => new
                    {
                        RecordID = c.Int(nullable: false, identity: true),
                        CUserID = c.Int(),
                        TGUserID = c.Int(),
                        CMoney = c.Int(),
                        GetMoney = c.Int(),
                        AddTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.RecordID);
            
            CreateTable(
                "dbo.Web_TGPayRecord",
                c => new
                    {
                        RecordID = c.Int(nullable: false, identity: true),
                        PayUserID = c.Int(),
                        TGUserID = c.Int(),
                        PayMoney = c.Int(),
                        GetMoney = c.Int(),
                        PayType = c.String(maxLength: 50, unicode: false),
                        AddTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.RecordID);
            
            CreateTable(
                "dbo.Web_TransfersAccount",
                c => new
                    {
                        TransferID = c.Int(nullable: false, identity: true),
                        Sender = c.String(nullable: false, maxLength: 50),
                        Receiver = c.String(nullable: false, maxLength: 50),
                        TransferMoney = c.Long(nullable: false),
                        TransferFrequency = c.Int(),
                        TransferTime = c.DateTime(nullable: false),
                        ReceiverType = c.Boolean(nullable: false),
                        Remark = c.String(nullable: false, maxLength: 100),
                        SenderBFMoney = c.Long(nullable: false),
                        SenderAFMoney = c.Long(nullable: false),
                        ReceiverBFMoney = c.Long(nullable: false),
                        ReceiverAFMoney = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.TransferID);
            
            CreateTable(
                "dbo.Web_TransLog",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserName = c.String(maxLength: 20),
                        TransBefore = c.Long(),
                        TransAfter = c.Long(),
                        UserNameZZ = c.String(maxLength: 20),
                        ZZ_TransBefore = c.Long(),
                        ZZ_TransAfter = c.Long(),
                        Money = c.Long(),
                        Tax = c.Int(),
                        TransTime = c.DateTime(storeType: "smalldatetime"),
                        IP = c.String(maxLength: 30),
                        Success = c.Boolean(),
                        TranBOnceValue = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Web_TuiGuang",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(),
                        TrueName = c.String(maxLength: 20),
                        ApplyTime = c.DateTime(storeType: "smalldatetime"),
                        Phone = c.String(maxLength: 50),
                        Address = c.String(maxLength: 100),
                        Pass = c.Boolean(),
                        MoneyCount = c.Int(),
                        CountTime = c.DateTime(storeType: "smalldatetime"),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Web_TuiGuangLog",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(),
                        TG_UserID = c.Int(),
                        RegTime = c.DateTime(storeType: "smalldatetime"),
                        GameTimeCount = c.Int(),
                        GetMoney = c.Int(),
                        CalTime = c.DateTime(storeType: "smalldatetime"),
                        IsRegAward = c.Boolean(),
                        IsClearing = c.Boolean(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Web_UserAlbum",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        ColumnID = c.Int(nullable: false),
                        PicName = c.String(nullable: false, maxLength: 300),
                        PicPath = c.String(nullable: false, maxLength: 1000),
                        PicDescription = c.String(nullable: false, maxLength: 1000),
                        ShortNum = c.Int(nullable: false),
                        Enable = c.String(nullable: false, maxLength: 50),
                        InputTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Web_UserAlbumColumn",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AlbumName = c.String(nullable: false, maxLength: 50),
                        Cover = c.String(nullable: false, maxLength: 1000),
                        UserID = c.Int(nullable: false),
                        IsPublic = c.String(nullable: false, maxLength: 50),
                        InputTime = c.DateTime(nullable: false),
                        OrderID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Web_UserApplyVipRecord",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        Money = c.Int(nullable: false),
                        AddVipTime = c.Int(nullable: false),
                        AddTime = c.DateTime(nullable: false),
                        TargetUserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Web_UserEmail",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MsgID = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                        IsRead = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Web_UserModifyLog",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(),
                        OldValue = c.String(maxLength: 20),
                        NewValue = c.String(maxLength: 20),
                        MType = c.Byte(),
                        MTime = c.DateTime(storeType: "smalldatetime"),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Web_Users",
                c => new
                    {
                        UserID = c.Int(nullable: false),
                        RegisterIP = c.String(nullable: false, maxLength: 50),
                        RegisterTM = c.DateTime(nullable: false),
                        Email = c.String(nullable: false, maxLength: 50),
                        Phone = c.String(maxLength: 50, unicode: false),
                        WebLoginTime = c.Int(nullable: false),
                        Pwd_anw = c.String(maxLength: 50),
                        Pwd_ques = c.String(maxLength: 50),
                        ZJ_type = c.Short(),
                        ZJ_Number = c.String(maxLength: 50, unicode: false),
                        qqnum = c.String(maxLength: 20, unicode: false),
                        RealName = c.String(maxLength: 20, unicode: false),
                        SignDescr = c.String(maxLength: 500),
                        ZipCode = c.String(nullable: false, maxLength: 50),
                        Address = c.String(nullable: false, maxLength: 500),
                        Schooling = c.String(maxLength: 20),
                        HomePage = c.String(maxLength: 128),
                        TelNo = c.String(maxLength: 20),
                        MSNID = c.String(maxLength: 50),
                        Lotteries = c.Int(nullable: false),
                        PhoneValid = c.Short(),
                        ZJValid = c.Short(),
                        Age = c.Int(),
                        Birthday = c.DateTime(),
                        FindPwdQue_1 = c.String(maxLength: 50, unicode: false),
                        FindPwdAnw_1 = c.String(maxLength: 50, unicode: false),
                        FindPwdQue_2 = c.String(maxLength: 50, unicode: false),
                        FindPwdAnw_2 = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.UserID);
            
            CreateTable(
                "dbo.Web_VAgency_UserPayList",
                c => new
                    {
                        PayType = c.Int(nullable: false),
                        AgencyID = c.Int(nullable: false),
                        AgencyName = c.String(nullable: false, maxLength: 50),
                        OrderIDOrNum = c.String(maxLength: 50),
                        UserID = c.Int(),
                        UserName = c.String(maxLength: 50),
                        PayMoney = c.Int(),
                        AddTime = c.DateTime(storeType: "smalldatetime"),
                        PaySuccess = c.Int(),
                        MoneyFront = c.Long(),
                        MoneyAfter = c.Long(),
                    })
                .PrimaryKey(t => new { t.PayType, t.AgencyID, t.AgencyName });
            
            CreateTable(
                "dbo.Web_vAgencyAccountLog",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        AdminID = c.Int(nullable: false),
                        AgencyID = c.Int(nullable: false),
                        MoneyB = c.Long(nullable: false),
                        Range = c.Long(nullable: false),
                        MoneyA = c.Long(nullable: false),
                        InputDate = c.DateTime(nullable: false),
                        AgencyName = c.String(maxLength: 50),
                        AdminName = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => new { t.ID, t.AdminID, t.AgencyID, t.MoneyB, t.Range, t.MoneyA, t.InputDate });
            
            CreateTable(
                "dbo.Web_vAgencyAndPlayerSumPoint_List",
                c => new
                    {
                        UserID = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 50),
                        ParentID = c.Int(nullable: false),
                        IsAgency = c.Int(nullable: false),
                        SpareMoney = c.Long(),
                    })
                .PrimaryKey(t => new { t.UserID, t.UserName, t.ParentID, t.IsAgency });
            
            CreateTable(
                "dbo.Web_VAgencyBalanceLog",
                c => new
                    {
                        BaID = c.Int(nullable: false),
                        AgencyID = c.Int(nullable: false),
                        BaMoney = c.Long(nullable: false),
                        BaMoneyB = c.Long(nullable: false),
                        BaMoneyA = c.Long(nullable: false),
                        Addtime = c.DateTime(nullable: false),
                        AdminID = c.Long(nullable: false),
                        AgencyName = c.String(nullable: false, maxLength: 50),
                        AdminName = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => new { t.BaID, t.AgencyID, t.BaMoney, t.BaMoneyB, t.BaMoneyA, t.Addtime, t.AdminID, t.AgencyName });
            
            CreateTable(
                "dbo.Web_vAgencyExchange",
                c => new
                    {
                        ExID = c.Long(nullable: false),
                        UserID = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 20),
                        AddTime = c.DateTime(nullable: false),
                        ApplyMoney = c.Int(nullable: false),
                        ApplyState = c.Int(nullable: false),
                        AccountType = c.Int(nullable: false),
                        UserType = c.Int(nullable: false),
                        TrueName = c.String(nullable: false, maxLength: 50),
                        DisposeTime = c.DateTime(),
                    })
                .PrimaryKey(t => new { t.ExID, t.UserID, t.UserName, t.AddTime, t.ApplyMoney, t.ApplyState, t.AccountType, t.UserType, t.TrueName });
            
            CreateTable(
                "dbo.Web_vAgencyList",
                c => new
                    {
                        AgencyID = c.Int(nullable: false),
                        AgencyName = c.String(nullable: false, maxLength: 50),
                        ParentAgencyID = c.Int(nullable: false),
                        TrueName = c.String(nullable: false, maxLength: 50),
                        Account = c.Long(nullable: false),
                        IsTaboo = c.Byte(nullable: false),
                        SpareValue = c.Decimal(nullable: false, precision: 18, scale: 0),
                        IsAddAgency = c.Int(nullable: false),
                        IsPickUpCashToAgency = c.Int(nullable: false),
                        IsPickUpCashToPlayer = c.Int(nullable: false),
                        IsGiveToPlayer = c.Int(nullable: false),
                        IsGiveToAgency = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.AgencyID, t.AgencyName, t.ParentAgencyID, t.TrueName, t.Account, t.IsTaboo, t.SpareValue, t.IsAddAgency, t.IsPickUpCashToAgency, t.IsPickUpCashToPlayer, t.IsGiveToPlayer, t.IsGiveToAgency });
            
            CreateTable(
                "dbo.Web_vAgencySpareValue",
                c => new
                    {
                        AgencyID = c.Int(nullable: false),
                        AgencyName = c.String(nullable: false, maxLength: 50),
                        ParentID = c.Int(nullable: false),
                        ParentName = c.String(nullable: false, maxLength: 50),
                        SpareMoney = c.Long(),
                    })
                .PrimaryKey(t => new { t.AgencyID, t.AgencyName, t.ParentID, t.ParentName });
            
            CreateTable(
                "dbo.Web_vAgencySpareValueLog",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        OperaID = c.Int(nullable: false),
                        AgencyID = c.Int(nullable: false),
                        AgencyName = c.String(nullable: false, maxLength: 50),
                        BPercent = c.Int(nullable: false),
                        APercent = c.Int(nullable: false),
                        Change = c.Int(nullable: false),
                        AddTime = c.DateTime(nullable: false),
                        UserName = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => new { t.ID, t.OperaID, t.AgencyID, t.AgencyName, t.BPercent, t.APercent, t.Change, t.AddTime });
            
            CreateTable(
                "dbo.Web_ValmsDrawRecord",
                c => new
                    {
                        UserId = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 20),
                        DrawTime = c.DateTime(nullable: false),
                        DrawMoney = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserId, t.UserName, t.DrawTime, t.DrawMoney });
            
            CreateTable(
                "dbo.Web_VAnaly_AgencyDateReport",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        ReportDate = c.DateTime(nullable: false),
                        AvgOnline = c.Int(nullable: false),
                        MaxOnline = c.Int(nullable: false),
                        MinOnline = c.Int(nullable: false),
                        LoginNum = c.Int(nullable: false),
                        ActiveNum = c.Int(nullable: false),
                        ActiveGameCount = c.Int(nullable: false),
                        NewUserNum = c.Int(nullable: false),
                        PayNum = c.Int(nullable: false),
                        PayMoneyCount = c.Int(nullable: false),
                        PayCount = c.Int(nullable: false),
                        GameCount = c.Int(nullable: false),
                        TaxCount = c.Int(nullable: false),
                        AgencyName = c.String(nullable: false, maxLength: 100),
                        AgencyID = c.Int(nullable: false),
                        RegNum = c.Int(nullable: false),
                        PV = c.Int(nullable: false),
                        IP = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ID, t.ReportDate, t.AvgOnline, t.MaxOnline, t.MinOnline, t.LoginNum, t.ActiveNum, t.ActiveGameCount, t.NewUserNum, t.PayNum, t.PayMoneyCount, t.PayCount, t.GameCount, t.TaxCount, t.AgencyName, t.AgencyID, t.RegNum, t.PV, t.IP });
            
            CreateTable(
                "dbo.Web_VAnaly_DateReport",
                c => new
                    {
                        AvgOnline = c.Int(nullable: false),
                        MaxOnline = c.Int(nullable: false),
                        MinOnline = c.Int(nullable: false),
                        RegNum = c.Int(),
                        LoginNum = c.Int(),
                        ActiveNum = c.Int(),
                        ActiveGameCount = c.Int(),
                        NewUserNum = c.Int(),
                        PayNum = c.Int(),
                        PayMoneyCount = c.Int(),
                        PayCount = c.Int(),
                        GameCount = c.Int(),
                        TaxCount = c.Int(),
                        ReportDate = c.String(maxLength: 8, unicode: false),
                        Date = c.String(maxLength: 10, unicode: false),
                    })
                .PrimaryKey(t => new { t.AvgOnline, t.MaxOnline, t.MinOnline });
            
            CreateTable(
                "dbo.Web_VAnaly_GameCountAndTax",
                c => new
                    {
                        ComName = c.String(nullable: false, maxLength: 14),
                        RoomName = c.String(nullable: false, maxLength: 30),
                        RoomID = c.Int(nullable: false),
                        TaxCount = c.Long(nullable: false),
                        MaxOnline = c.Int(nullable: false),
                        MinOnline = c.Int(nullable: false),
                        AvgOnline = c.Int(nullable: false),
                        ID = c.String(maxLength: 68, unicode: false),
                        ReportDate = c.String(maxLength: 8, unicode: false),
                        GameCount = c.Int(),
                    })
                .PrimaryKey(t => new { t.ComName, t.RoomName, t.RoomID, t.TaxCount, t.MaxOnline, t.MinOnline, t.AvgOnline });
            
            CreateTable(
                "dbo.Web_VAnaly_NewUserPayList",
                c => new
                    {
                        PayMoneyCount = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 20),
                        RegisterIP = c.String(nullable: false, maxLength: 50),
                        BankMoney = c.Long(nullable: false),
                        PayCount = c.Int(),
                        RealName = c.String(maxLength: 20, unicode: false),
                        SumMoney = c.Long(),
                        AddTime = c.String(maxLength: 10, unicode: false),
                    })
                .PrimaryKey(t => new { t.PayMoneyCount, t.UserID, t.UserName, t.RegisterIP, t.BankMoney });
            
            CreateTable(
                "dbo.Web_VAnaly_NewUserReport",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        ReportDate = c.DateTime(),
                        RegNum = c.Int(),
                        LoginNum = c.Int(),
                        ActiveNum = c.Int(),
                        GameCount = c.Int(),
                        PayNum = c.Int(),
                        PayMoneyCount = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Web_VAnaly_PayList",
                c => new
                    {
                        PayType = c.Int(nullable: false),
                        AgencyName = c.String(nullable: false, maxLength: 50),
                        OrderIDOrNum = c.String(maxLength: 50),
                        UserID = c.Int(),
                        UserName = c.String(maxLength: 50),
                        PayMoney = c.Int(),
                        AddTime = c.DateTime(storeType: "smalldatetime"),
                    })
                .PrimaryKey(t => new { t.PayType, t.AgencyName });
            
            CreateTable(
                "dbo.Web_VAnaly_UserList24A",
                c => new
                    {
                        UserID = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 20),
                        BankMoney = c.Long(nullable: false),
                        AgencyName = c.String(nullable: false, maxLength: 50),
                        RegisterTM = c.DateTime(nullable: false),
                        RegisterIP = c.String(nullable: false, maxLength: 50),
                        GameCount = c.Int(nullable: false),
                        OnlineStatus = c.String(nullable: false, maxLength: 6, unicode: false),
                        RealName = c.String(maxLength: 20, unicode: false),
                        SumMoney = c.Long(),
                    })
                .PrimaryKey(t => new { t.UserID, t.UserName, t.BankMoney, t.AgencyName, t.RegisterTM, t.RegisterIP, t.GameCount, t.OnlineStatus });
            
            CreateTable(
                "dbo.Web_VAnaly_UserList24B",
                c => new
                    {
                        UserID = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 20),
                        BankMoney = c.Long(nullable: false),
                        AgencyName = c.String(nullable: false, maxLength: 50),
                        RegisterTM = c.DateTime(nullable: false),
                        RegisterIP = c.String(nullable: false, maxLength: 50),
                        GameCount = c.Int(nullable: false),
                        OnlineStatus = c.String(nullable: false, maxLength: 6, unicode: false),
                        RealName = c.String(maxLength: 20, unicode: false),
                        SumMoney = c.Long(),
                    })
                .PrimaryKey(t => new { t.UserID, t.UserName, t.BankMoney, t.AgencyName, t.RegisterTM, t.RegisterIP, t.GameCount, t.OnlineStatus });
            
            CreateTable(
                "dbo.Web_VAnaly_UserListReg",
                c => new
                    {
                        UserID = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 20),
                        BankMoney = c.Long(nullable: false),
                        AgencyName = c.String(nullable: false, maxLength: 50),
                        RegisterTM = c.DateTime(nullable: false),
                        RegisterIP = c.String(nullable: false, maxLength: 50),
                        GameCount = c.Int(nullable: false),
                        OnlineStatus = c.String(nullable: false, maxLength: 6, unicode: false),
                        RealName = c.String(maxLength: 20, unicode: false),
                        WalletMoney = c.Long(),
                        SumMoney = c.Long(),
                    })
                .PrimaryKey(t => new { t.UserID, t.UserName, t.BankMoney, t.AgencyName, t.RegisterTM, t.RegisterIP, t.GameCount, t.OnlineStatus });
            
            CreateTable(
                "dbo.Web_VAnalyData_DateOnline",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        AvgOnline = c.Int(nullable: false),
                        MaxOnline = c.Int(nullable: false),
                        MinOnline = c.Int(nullable: false),
                        ReportDate = c.DateTime(nullable: false),
                        LoginNum = c.Int(),
                        ActiveNum = c.Int(),
                        ActiveGameCount = c.Int(),
                    })
                .PrimaryKey(t => new { t.ID, t.AvgOnline, t.MaxOnline, t.MinOnline, t.ReportDate });
            
            CreateTable(
                "dbo.Web_VApplyVipRoom",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                        ApplyGameNameID = c.Int(nullable: false),
                        OpenRoomDate = c.DateTime(nullable: false),
                        AppleyDays = c.Int(nullable: false),
                        RoomName = c.String(nullable: false, maxLength: 50),
                        RoomPwd = c.String(nullable: false, maxLength: 50),
                        DeskCount = c.Int(nullable: false),
                        TaxType = c.Int(nullable: false),
                        Tax = c.Int(nullable: false),
                        MaxPeople = c.Int(nullable: false),
                        BasePoint = c.Int(nullable: false),
                        LessPoint = c.Int(nullable: false),
                        MaxPoint = c.Int(nullable: false),
                        RoomID = c.Int(nullable: false),
                        AuditStatus = c.Short(nullable: false),
                        ComName = c.String(nullable: false, maxLength: 14),
                        EveryDayRent = c.Long(nullable: false),
                        AddDate = c.DateTime(nullable: false),
                        Email = c.String(maxLength: 50),
                        QQ = c.String(maxLength: 50),
                        Mobile = c.String(maxLength: 50),
                        RoomMsg = c.String(maxLength: 1000),
                        RallWelcome = c.String(maxLength: 1000),
                        Remark = c.String(),
                        UserName = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => new { t.ID, t.UserID, t.ApplyGameNameID, t.OpenRoomDate, t.AppleyDays, t.RoomName, t.RoomPwd, t.DeskCount, t.TaxType, t.Tax, t.MaxPeople, t.BasePoint, t.LessPoint, t.MaxPoint, t.RoomID, t.AuditStatus, t.ComName, t.EveryDayRent, t.AddDate });
            
            CreateTable(
                "dbo.Web_vAwardLog",
                c => new
                    {
                        Log_ID = c.Int(nullable: false),
                        UserRemark = c.String(maxLength: 500),
                        Award_ID = c.Int(),
                        Award_Name = c.String(maxLength: 50),
                        UserID = c.Int(),
                        UserName = c.String(maxLength: 20),
                        NickName = c.String(maxLength: 50),
                        Award_MoneyCost = c.Long(),
                        IsCash = c.Boolean(),
                        AwardTime = c.DateTime(),
                        Award_OnLineTime = c.Int(),
                        TrueName = c.String(maxLength: 50, unicode: false),
                        Phone = c.String(maxLength: 50, unicode: false),
                        Address = c.String(maxLength: 200, unicode: false),
                        Award_NeedMoney = c.Long(),
                    })
                .PrimaryKey(t => t.Log_ID);
            
            CreateTable(
                "dbo.Web_vAwardRecord",
                c => new
                    {
                        Log_ID = c.Int(nullable: false),
                        Award_ID = c.Int(),
                        Award_Name = c.String(maxLength: 50),
                        UserID = c.Int(),
                        UserName = c.String(maxLength: 20),
                        NickName = c.String(maxLength: 50),
                        TrueName = c.String(maxLength: 50, unicode: false),
                        Award_MoneyCost = c.Long(),
                        Phone = c.String(maxLength: 50, unicode: false),
                        Address = c.String(maxLength: 200, unicode: false),
                        IsCash = c.Boolean(),
                        AwardTime = c.DateTime(),
                        Award_OnLineTime = c.Int(),
                    })
                .PrimaryKey(t => t.Log_ID);
            
            CreateTable(
                "dbo.Web_VBankDeposit",
                c => new
                    {
                        id = c.Int(nullable: false),
                        Userid = c.Int(nullable: false),
                        Money = c.Long(nullable: false),
                        DepositID = c.String(nullable: false, maxLength: 16),
                        DepositPassWord = c.String(nullable: false, maxLength: 16),
                        GreateTime = c.DateTime(nullable: false),
                        CDSC = c.Int(nullable: false),
                        State = c.Int(nullable: false),
                        UsedUserID = c.Int(),
                        UserName = c.String(maxLength: 20),
                        UsedUserName = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => new { t.id, t.Userid, t.Money, t.DepositID, t.DepositPassWord, t.GreateTime, t.CDSC, t.State });
            
            CreateTable(
                "dbo.Web_vBankMoneyOpera",
                c => new
                    {
                        UserID = c.Int(nullable: false),
                        MoneyInBank = c.Long(nullable: false),
                        MoneyInRoom = c.Long(nullable: false),
                        OutMoney = c.Long(nullable: false),
                        InMoney = c.Long(nullable: false),
                        TimeEx = c.DateTime(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 20),
                        NickName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => new { t.UserID, t.MoneyInBank, t.MoneyInRoom, t.OutMoney, t.InMoney, t.TimeEx, t.UserName, t.NickName });
            
            CreateTable(
                "dbo.Web_vBuyPropLog",
                c => new
                    {
                        id = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                        PropCount = c.Int(nullable: false),
                        Money = c.Int(nullable: false),
                        ActionTime = c.DateTime(nullable: false),
                        PropName = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => new { t.id, t.UserID, t.PropCount, t.Money, t.ActionTime });
            
            CreateTable(
                "dbo.Web_vBuyVipLog",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                        AddTime = c.DateTime(nullable: false),
                        AddVipTime = c.Int(nullable: false),
                        Money = c.Int(nullable: false),
                        UserName = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => new { t.ID, t.UserID, t.AddTime, t.AddVipTime, t.Money });
            
            CreateTable(
                "dbo.Web_VChangeRecord",
                c => new
                    {
                        RoomName = c.String(nullable: false, maxLength: 30),
                        ServerIP = c.String(nullable: false, maxLength: 25),
                        ServerInfoID = c.Int(nullable: false),
                        GameTypeID = c.Int(nullable: false),
                        GameKindID = c.Int(nullable: false),
                        GameNameID = c.Int(nullable: false),
                        SocketPort = c.Int(nullable: false),
                        OnlineCount = c.Int(nullable: false),
                        UpdateTime = c.DateTime(nullable: false),
                        EnableRoom = c.Short(nullable: false),
                        StopLogon = c.Short(nullable: false),
                        IDSort = c.Int(nullable: false),
                        Version = c.Int(nullable: false),
                        ServiceName = c.String(nullable: false, maxLength: 30),
                        VirtualUser = c.Int(nullable: false),
                        VirtualGameTime = c.Int(nullable: false),
                        GameTime = c.Int(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        RoomID = c.Int(nullable: false),
                        DeskIndex = c.Int(nullable: false),
                        Tax = c.Int(nullable: false),
                        ID = c.Int(nullable: false),
                        ChangeRecordUserID = c.Int(nullable: false),
                        UserIndex = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                        SrcPoint = c.Long(nullable: false),
                        SrcMoney = c.Long(nullable: false),
                        ChangePoint = c.Long(nullable: false),
                        ChangeMoney = c.Long(nullable: false),
                        ChangeTax = c.Long(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 20),
                        NickName = c.String(nullable: false, maxLength: 50),
                        AgencyID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.RoomName, t.ServerIP, t.ServerInfoID, t.GameTypeID, t.GameKindID, t.GameNameID, t.SocketPort, t.OnlineCount, t.UpdateTime, t.EnableRoom, t.StopLogon, t.IDSort, t.Version, t.ServiceName, t.VirtualUser, t.VirtualGameTime, t.GameTime, t.EndTime, t.RoomID, t.DeskIndex, t.Tax, t.ID, t.ChangeRecordUserID, t.UserIndex, t.UserID, t.SrcPoint, t.SrcMoney, t.ChangePoint, t.ChangeMoney, t.ChangeTax, t.UserName, t.NickName, t.AgencyID });
            
            CreateTable(
                "dbo.Web_VCharmExchange",
                c => new
                    {
                        id = c.Int(nullable: false),
                        CharmValue = c.Int(nullable: false),
                        PropID = c.Int(nullable: false),
                        PropCount = c.Int(nullable: false),
                        PropName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => new { t.id, t.CharmValue, t.PropID, t.PropCount, t.PropName });
            
            CreateTable(
                "dbo.Web_VClearPropLog",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        PropID = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                        InputDate = c.DateTime(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 20),
                        NickName = c.String(nullable: false, maxLength: 50),
                        PropName = c.String(nullable: false, maxLength: 50),
                        BeforeValue = c.Int(),
                        AfterValue = c.Int(),
                        PropType = c.Int(),
                        GameNameID = c.Int(),
                        GameName = c.String(maxLength: 14),
                    })
                .PrimaryKey(t => new { t.ID, t.PropID, t.UserID, t.InputDate, t.UserName, t.NickName, t.PropName });
            
            CreateTable(
                "dbo.Web_VDataList",
                c => new
                    {
                        TypeID = c.Int(nullable: false),
                        TypeName = c.String(nullable: false, maxLength: 20, unicode: false),
                        TableName = c.String(nullable: false, maxLength: 20, unicode: false),
                        CountTotal = c.Int(),
                        StartTime = c.DateTime(),
                        EndTime = c.DateTime(),
                    })
                .PrimaryKey(t => new { t.TypeID, t.TypeName, t.TableName });
            
            CreateTable(
                "dbo.Web_vExchangeFasciLog",
                c => new
                    {
                        UserName = c.String(nullable: false, maxLength: 20),
                        ID = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                        ChangeFrontMoney = c.Long(nullable: false),
                        ChangeAfterMoney = c.Long(nullable: false),
                        ExchangeCount = c.Int(),
                        ConPrice = c.Int(),
                        InMoney = c.Int(),
                        IP = c.String(maxLength: 50, unicode: false),
                        AddTime = c.DateTime(),
                    })
                .PrimaryKey(t => new { t.UserName, t.ID, t.UserID, t.ChangeFrontMoney, t.ChangeAfterMoney });
            
            CreateTable(
                "dbo.Web_vFaciSum",
                c => new
                    {
                        UserID = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 20),
                        NickName = c.String(nullable: false, maxLength: 50),
                        FasciSum = c.Int(),
                    })
                .PrimaryKey(t => new { t.UserID, t.UserName, t.NickName });
            
            CreateTable(
                "dbo.Web_VFasciClearPropLog",
                c => new
                    {
                        Title = c.String(nullable: false, maxLength: 50),
                        ID = c.Int(nullable: false),
                        PropID = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                        BeforeFasci = c.Int(nullable: false),
                        AfterFasci = c.Int(nullable: false),
                        ChangeFasci = c.Int(nullable: false),
                        BeforeMoney = c.Long(nullable: false),
                        AfterMoney = c.Long(nullable: false),
                        ChangeMoney = c.Int(nullable: false),
                        InputDate = c.DateTime(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 20),
                        NickName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => new { t.Title, t.ID, t.PropID, t.UserID, t.BeforeFasci, t.AfterFasci, t.ChangeFasci, t.BeforeMoney, t.AfterMoney, t.ChangeMoney, t.InputDate, t.UserName, t.NickName });
            
            CreateTable(
                "dbo.Web_VFasciExchangeLog",
                c => new
                    {
                        Log_ID = c.Int(nullable: false),
                        PropID = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                        PropName = c.String(nullable: false, maxLength: 50),
                        CharmValue = c.Int(nullable: false),
                        PropCount = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                        InputDate = c.DateTime(nullable: false),
                        UserName = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => new { t.Log_ID, t.PropID, t.UserID, t.PropName, t.CharmValue, t.PropCount, t.Status, t.InputDate });
            
            CreateTable(
                "dbo.Web_VGameKindList",
                c => new
                    {
                        KindID = c.Int(nullable: false),
                        KindName = c.String(nullable: false, maxLength: 14),
                        IDSort = c.Int(nullable: false),
                        Enable = c.Byte(nullable: false),
                        ParentKindID = c.Int(nullable: false),
                        KindParentName = c.String(maxLength: 14),
                    })
                .PrimaryKey(t => new { t.KindID, t.KindName, t.IDSort, t.Enable, t.ParentKindID });
            
            CreateTable(
                "dbo.Web_VGameNameInfo",
                c => new
                    {
                        NameID = c.Int(nullable: false),
                        KindID = c.Int(nullable: false),
                        ComName = c.String(nullable: false, maxLength: 14),
                        RecommendType = c.Int(nullable: false),
                        StarCount = c.Int(nullable: false),
                        ComProcess = c.String(nullable: false, maxLength: 20),
                        IDSort = c.Int(nullable: false),
                        Enable = c.Byte(nullable: false),
                        KindName = c.String(nullable: false, maxLength: 14),
                        DLLFileName = c.String(nullable: false, maxLength: 20),
                        ParentKindID = c.Int(nullable: false),
                        DeskPeople = c.Int(nullable: false),
                        EveryDayRent = c.Long(nullable: false),
                        RecommendRoom = c.Int(),
                        RoomName = c.String(maxLength: 30),
                        ParentKindName = c.String(maxLength: 14),
                    })
                .PrimaryKey(t => new { t.NameID, t.KindID, t.ComName, t.RecommendType, t.StarCount, t.ComProcess, t.IDSort, t.Enable, t.KindName, t.DLLFileName, t.ParentKindID, t.DeskPeople, t.EveryDayRent });
            
            CreateTable(
                "dbo.Web_vGameRecord",
                c => new
                    {
                        GameTime = c.Int(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        Tax = c.Int(nullable: false),
                        DeskIndex = c.Int(nullable: false),
                        SrcMoney = c.Long(nullable: false),
                        SrcPoint = c.Long(nullable: false),
                        ChangePoint = c.Long(nullable: false),
                        ChangeMoney = c.Long(nullable: false),
                        UserID = c.Int(nullable: false),
                        RoomID = c.Int(nullable: false),
                        RoomName = c.String(nullable: false, maxLength: 30),
                        UserName = c.String(nullable: false, maxLength: 20),
                        ChangeTax = c.Long(nullable: false),
                        RecordIndex = c.Int(nullable: false),
                        id = c.Int(nullable: false),
                        GameNameID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.GameTime, t.EndTime, t.Tax, t.DeskIndex, t.SrcMoney, t.SrcPoint, t.ChangePoint, t.ChangeMoney, t.UserID, t.RoomID, t.RoomName, t.UserName, t.ChangeTax, t.RecordIndex, t.id, t.GameNameID });
            
            CreateTable(
                "dbo.Web_VGameRoomInfo",
                c => new
                    {
                        id = c.Int(nullable: false),
                        RoomID = c.Int(nullable: false),
                        RoomName = c.String(nullable: false, maxLength: 30),
                        RoomTypeID = c.Int(nullable: false),
                        GameTypeID = c.Int(nullable: false),
                        GameKindID = c.Int(nullable: false),
                        GameNameID = c.Int(nullable: false),
                        OnlineCount = c.Int(nullable: false),
                        EnableRoom = c.Short(nullable: false),
                        IDSort = c.Int(nullable: false),
                        Version = c.Int(nullable: false),
                        DeskCount = c.Int(nullable: false),
                        ComName = c.String(nullable: false, maxLength: 14),
                        KindName = c.String(nullable: false, maxLength: 14),
                        RoomRule = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.id, t.RoomID, t.RoomName, t.RoomTypeID, t.GameTypeID, t.GameKindID, t.GameNameID, t.OnlineCount, t.EnableRoom, t.IDSort, t.Version, t.DeskCount, t.ComName, t.KindName, t.RoomRule });
            
            CreateTable(
                "dbo.Web_VGameRoomInfo2",
                c => new
                    {
                        id = c.Int(nullable: false),
                        RoomName = c.String(nullable: false, maxLength: 30),
                        BattleRoomName = c.String(nullable: false, maxLength: 50),
                        GameName = c.String(nullable: false, maxLength: 14),
                        BattleBeginTime = c.DateTime(nullable: false),
                        BattleEndTime = c.DateTime(nullable: false),
                        GameNameID = c.Int(nullable: false),
                        RoomID = c.Int(nullable: false),
                        BattleRoomID = c.Int(),
                        BattleMatchTable = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => new { t.id, t.RoomName, t.BattleRoomName, t.GameName, t.BattleBeginTime, t.BattleEndTime, t.GameNameID, t.RoomID });
            
            CreateTable(
                "dbo.Web_VGameRoomInfo3",
                c => new
                    {
                        RoomID = c.Int(nullable: false),
                        RoomName = c.String(nullable: false, maxLength: 30),
                        RoomTypeID = c.Int(nullable: false),
                        GameTypeID = c.Int(nullable: false),
                        GameKindID = c.Int(nullable: false),
                        GameNameID = c.Int(nullable: false),
                        OnlineCount = c.Int(nullable: false),
                        EnableRoom = c.Short(nullable: false),
                        IDSort = c.Int(nullable: false),
                        Version = c.Int(nullable: false),
                        DeskCount = c.Int(nullable: false),
                        ComName = c.String(nullable: false, maxLength: 14),
                        KindName = c.String(nullable: false, maxLength: 14),
                    })
                .PrimaryKey(t => new { t.RoomID, t.RoomName, t.RoomTypeID, t.GameTypeID, t.GameKindID, t.GameNameID, t.OnlineCount, t.EnableRoom, t.IDSort, t.Version, t.DeskCount, t.ComName, t.KindName });
            
            CreateTable(
                "dbo.Web_VGetAgencyDetail1",
                c => new
                    {
                        AgencyID = c.Int(nullable: false),
                        AgencyName = c.String(nullable: false, maxLength: 50),
                        ParentAgencyID = c.Int(nullable: false),
                        LevelID = c.Int(nullable: false),
                        Account = c.Long(nullable: false),
                        TrueName = c.String(nullable: false, maxLength: 50),
                        RegisterTime = c.DateTime(nullable: false),
                        SpareValueRate = c.Decimal(nullable: false, precision: 18, scale: 0),
                        IsTaboo = c.Byte(nullable: false),
                        NotBaMoney = c.Long(),
                        MyDownAgencyCount = c.Int(),
                        MyDownPlayerCount = c.Int(),
                        ParentAgencyName = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => new { t.AgencyID, t.AgencyName, t.ParentAgencyID, t.LevelID, t.Account, t.TrueName, t.RegisterTime, t.SpareValueRate, t.IsTaboo });
            
            CreateTable(
                "dbo.Web_VGetPlayDetail",
                c => new
                    {
                        UserID = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 20),
                        BankMoney = c.Long(nullable: false),
                        WalletMoney = c.Long(nullable: false),
                        Email = c.String(nullable: false, maxLength: 50),
                        RegisterIP = c.String(nullable: false, maxLength: 50),
                        RegisterTM = c.DateTime(nullable: false),
                        LastLoginTM = c.DateTime(nullable: false),
                        LastLoginIP = c.String(nullable: false, maxLength: 16),
                        IsRobot = c.Short(nullable: false),
                        AgencyName = c.String(nullable: false, maxLength: 50),
                        Sex = c.Short(nullable: false),
                        RealName = c.String(maxLength: 20, unicode: false),
                        qqnum = c.String(maxLength: 20, unicode: false),
                        TotalLwMoney = c.Long(),
                        Phone = c.String(maxLength: 50, unicode: false),
                        SpareMoney = c.Long(),
                        Pwd_anw = c.String(maxLength: 50),
                        Pwd_ques = c.String(maxLength: 50),
                        ZJ_type = c.Short(),
                        ZJ_Number = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => new { t.UserID, t.UserName, t.BankMoney, t.WalletMoney, t.Email, t.RegisterIP, t.RegisterTM, t.LastLoginTM, t.LastLoginIP, t.IsRobot, t.AgencyName, t.Sex });
            
            CreateTable(
                "dbo.Web_VGetUserOnline",
                c => new
                    {
                        UserID = c.Int(nullable: false),
                        WID = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 20),
                        IsRobot = c.Short(nullable: false),
                        RoomName = c.String(nullable: false, maxLength: 30),
                        GameCount = c.Int(nullable: false),
                        RegisterTM = c.DateTime(nullable: false),
                        RegisterIP = c.String(nullable: false, maxLength: 50),
                        BankMoney = c.Long(nullable: false),
                        NickName = c.String(nullable: false, maxLength: 50),
                        WalletMoney = c.Long(nullable: false),
                        ComName = c.String(nullable: false, maxLength: 14),
                        RealName = c.String(maxLength: 20, unicode: false),
                        qqnum = c.String(maxLength: 20, unicode: false),
                        SumMoney = c.Long(),
                    })
                .PrimaryKey(t => new { t.UserID, t.WID, t.UserName, t.IsRobot, t.RoomName, t.GameCount, t.RegisterTM, t.RegisterIP, t.BankMoney, t.NickName, t.WalletMoney, t.ComName });
            
            CreateTable(
                "dbo.web_vGetVipLog",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                        AddTime = c.DateTime(nullable: false),
                        AddVipTime = c.Int(nullable: false),
                        Money = c.Int(nullable: false),
                        TargetUserID = c.Int(nullable: false),
                        UserName = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => new { t.ID, t.UserID, t.AddTime, t.AddVipTime, t.Money, t.TargetUserID });
            
            CreateTable(
                "dbo.Web_vIngotTransferLog",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserName = c.String(maxLength: 20),
                        UserNameZZ = c.String(maxLength: 20),
                        TransferMoney = c.Long(),
                        ActualTransfer = c.Long(),
                        TransTime = c.DateTime(storeType: "smalldatetime"),
                        UserID = c.Int(),
                        DestUserID = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Web_VLoginRecord",
                c => new
                    {
                        UserID = c.Int(nullable: false),
                        LastLoginIP = c.String(nullable: false, maxLength: 16, fixedLength: true),
                        LastLoginTM = c.DateTime(nullable: false),
                        RegisterTM = c.DateTime(nullable: false),
                        LockMathine = c.Int(nullable: false),
                        UserName = c.String(maxLength: 20),
                        NickName = c.String(maxLength: 50),
                        Disabled = c.Int(),
                        MachineCode = c.String(maxLength: 80),
                        HardID = c.String(maxLength: 40),
                        IsLimitIP = c.Int(),
                        IsLockCode = c.Int(),
                        IsLockHard = c.Int(),
                    })
                .PrimaryKey(t => new { t.UserID, t.LastLoginIP, t.LastLoginTM, t.RegisterTM, t.LockMathine });
            
            CreateTable(
                "dbo.Web_VLotterLog",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                        AwardID = c.Int(nullable: false),
                        AddDate = c.DateTime(nullable: false),
                        LotterType = c.Int(nullable: false),
                        ChangeMoney = c.Long(nullable: false),
                        Status = c.Int(nullable: false),
                        LotteryAwardName = c.String(nullable: false, maxLength: 50),
                        UserName = c.String(nullable: false, maxLength: 20),
                        NickName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => new { t.ID, t.UserID, t.AwardID, t.AddDate, t.LotterType, t.ChangeMoney, t.Status, t.LotteryAwardName, t.UserName, t.NickName });
            
            CreateTable(
                "dbo.Web_VLotterSpecial",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                        AddDate = c.DateTime(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 20),
                        LotteryAwardName = c.String(nullable: false, maxLength: 50),
                        AwardID = c.Int(),
                        Status = c.Boolean(),
                    })
                .PrimaryKey(t => new { t.ID, t.UserID, t.AddDate, t.UserName, t.LotteryAwardName });
            
            CreateTable(
                "dbo.Web_VMatchAwardConfig",
                c => new
                    {
                        Name = c.String(nullable: false, maxLength: 50),
                        GiveNum = c.Int(nullable: false),
                        Rank = c.Int(nullable: false),
                        ID = c.Int(nullable: false),
                        TypeID = c.Int(),
                    })
                .PrimaryKey(t => new { t.Name, t.GiveNum, t.Rank, t.ID });
            
            CreateTable(
                "dbo.Web_VMatchLog",
                c => new
                    {
                        UserID = c.Int(nullable: false),
                        ContestID = c.Int(nullable: false),
                        ContestScore = c.Long(nullable: false),
                        ContestCount = c.Int(nullable: false),
                        LeftTime = c.DateTime(nullable: false),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        ComName = c.String(nullable: false, maxLength: 14),
                        UserName = c.String(nullable: false, maxLength: 20),
                        NameID = c.Int(nullable: false),
                        LowChip = c.Long(nullable: false),
                        LowCount = c.Int(nullable: false),
                        NickName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => new { t.UserID, t.ContestID, t.ContestScore, t.ContestCount, t.LeftTime, t.StartTime, t.EndTime, t.ComName, t.UserName, t.NameID, t.LowChip, t.LowCount, t.NickName });
            
            CreateTable(
                "dbo.Web_VMatchTable",
                c => new
                    {
                        UserID = c.Int(nullable: false),
                        RoomID = c.Int(nullable: false),
                        NameID = c.Int(nullable: false),
                        Point = c.Long(nullable: false),
                        Money = c.Long(nullable: false),
                        TaxCom = c.Long(nullable: false),
                        Win = c.Int(nullable: false),
                        Lost = c.Int(nullable: false),
                        Mid = c.Int(nullable: false),
                        Cut = c.Int(nullable: false),
                        PlayTimeCount = c.Int(nullable: false),
                        OnLineTimeCount = c.Int(nullable: false),
                        MasterPower = c.Int(nullable: false),
                        GamePower = c.Int(nullable: false),
                        LogonTimes = c.Int(nullable: false),
                        LogonDate = c.DateTime(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 20),
                        ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserID, t.RoomID, t.NameID, t.Point, t.Money, t.TaxCom, t.Win, t.Lost, t.Mid, t.Cut, t.PlayTimeCount, t.OnLineTimeCount, t.MasterPower, t.GamePower, t.LogonTimes, t.LogonDate, t.UserName, t.ID });
            
            CreateTable(
                "dbo.web_vMoneyChangeLog",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 50),
                        StartMoney = c.Long(nullable: false),
                        ChangeMoney = c.Long(nullable: false),
                        ChangeType = c.Int(nullable: false),
                        IsRobot = c.Short(nullable: false),
                        DateTime = c.DateTime(nullable: false),
                        Remark = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => new { t.ID, t.UserID, t.UserName, t.StartMoney, t.ChangeMoney, t.ChangeType, t.IsRobot, t.DateTime });
            
            CreateTable(
                "dbo.Web_VMoneyChangeRecord",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                        MoneyInBank = c.Long(nullable: false),
                        MoneyInRoom = c.Long(nullable: false),
                        OutMoney = c.Long(nullable: false),
                        InMoney = c.Long(nullable: false),
                        RoomID = c.Int(nullable: false),
                        TimeEx = c.DateTime(nullable: false),
                        Error = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 20),
                        NickName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => new { t.ID, t.UserID, t.MoneyInBank, t.MoneyInRoom, t.OutMoney, t.InMoney, t.RoomID, t.TimeEx, t.Error, t.UserName, t.NickName });
            
            CreateTable(
                "dbo.Web_vNewsList",
                c => new
                    {
                        News_ID = c.Int(nullable: false),
                        TitleColor = c.String(nullable: false, maxLength: 50),
                        News_Describe = c.String(nullable: false, maxLength: 300),
                        News_Type = c.Byte(),
                        Title = c.String(maxLength: 100),
                        Keywords = c.String(maxLength: 100),
                        News_From = c.String(maxLength: 50),
                        Author = c.String(maxLength: 20),
                        Issuer = c.String(maxLength: 20),
                        Content = c.String(storeType: "ntext"),
                        News_picture = c.String(maxLength: 100),
                        Through = c.Boolean(),
                        Recommendation = c.Boolean(),
                        Istop = c.Boolean(),
                        Issue_Time = c.DateTime(storeType: "smalldatetime"),
                        Update_Time = c.DateTime(storeType: "smalldatetime"),
                        Hits = c.Int(),
                        TypeName = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => new { t.News_ID, t.TitleColor, t.News_Describe });
            
            CreateTable(
                "dbo.web_VPlayerLoginLog",
                c => new
                    {
                        UserID = c.Int(nullable: false),
                        LastLoginIP = c.String(nullable: false, maxLength: 16, fixedLength: true),
                        LastLoginTM = c.DateTime(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 20),
                        AgencyID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserID, t.LastLoginIP, t.LastLoginTM, t.UserName, t.AgencyID });
            
            CreateTable(
                "dbo.Web_vPlayerSpareValue",
                c => new
                    {
                        UserID = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 20),
                        NickName = c.String(nullable: false, maxLength: 50),
                        AgencyName = c.String(nullable: false, maxLength: 50),
                        AgencyID = c.Int(nullable: false),
                        SpareMoney = c.Long(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserID, t.UserName, t.NickName, t.AgencyName, t.AgencyID, t.SpareMoney });
            
            CreateTable(
                "dbo.Web_VPropBuyGive",
                c => new
                    {
                        UserName = c.String(nullable: false, maxLength: 20),
                        id = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                        TargetID = c.Int(nullable: false),
                        PropID = c.Int(nullable: false),
                        PropCount = c.Int(nullable: false),
                        Money = c.Int(nullable: false),
                        ActionTime = c.DateTime(nullable: false),
                        PropName = c.String(nullable: false, maxLength: 50),
                        TargetUserName = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => new { t.UserName, t.id, t.UserID, t.TargetID, t.PropID, t.PropCount, t.Money, t.ActionTime, t.PropName });
            
            CreateTable(
                "dbo.Web_VReceiveMoneyLog",
                c => new
                    {
                        UserID = c.Int(nullable: false),
                        ReceiveCount = c.Int(nullable: false),
                        LastReceiveTime = c.DateTime(nullable: false),
                        ReceiveMoneyCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => new { t.UserID, t.ReceiveCount, t.LastReceiveTime, t.ReceiveMoneyCount, t.UserName });
            
            CreateTable(
                "dbo.Web_vSendMoneyRecord_New",
                c => new
                    {
                        id = c.Int(nullable: false),
                        SendType = c.Int(nullable: false),
                        SendDate = c.String(nullable: false, maxLength: 15, unicode: false),
                        SendMoney = c.Int(nullable: false),
                        RoomID = c.Int(nullable: false),
                        UserName = c.String(maxLength: 20),
                        RoomName = c.String(maxLength: 30),
                    })
                .PrimaryKey(t => new { t.id, t.SendType, t.SendDate, t.SendMoney, t.RoomID });
            
            CreateTable(
                "dbo.Web_vTaxStatEveryday",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        StatTime = c.DateTime(nullable: false),
                        NameID = c.Int(nullable: false),
                        Tax = c.Long(nullable: false),
                        ComName = c.String(nullable: false, maxLength: 14),
                        KindID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ID, t.StatTime, t.NameID, t.Tax, t.ComName, t.KindID });
            
            CreateTable(
                "dbo.Web_VTContestRoom",
                c => new
                    {
                        ContestID = c.Int(nullable: false),
                        SendTypeID = c.Int(nullable: false),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        Chip = c.Long(nullable: false),
                        LowCount = c.Int(nullable: false),
                        EntryFee = c.Long(nullable: false),
                        UpPeople = c.Int(nullable: false),
                        Message = c.String(nullable: false, maxLength: 50),
                        SendTime = c.DateTime(nullable: false),
                        ComName = c.String(maxLength: 14),
                        AwardContent = c.String(maxLength: 3000),
                        Name = c.String(maxLength: 50),
                        MatchContent = c.String(storeType: "ntext"),
                    })
                .PrimaryKey(t => new { t.ContestID, t.SendTypeID, t.StartTime, t.EndTime, t.Chip, t.LowCount, t.EntryFee, t.UpPeople, t.Message, t.SendTime });
            
            CreateTable(
                "dbo.web_VTGBalanceLog",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 20),
                        NickName = c.String(nullable: false, maxLength: 50),
                        ClearingTime = c.DateTime(storeType: "smalldatetime"),
                        Money = c.Int(),
                        IP = c.String(maxLength: 30, fixedLength: true, unicode: false),
                    })
                .PrimaryKey(t => new { t.ID, t.UserID, t.UserName, t.NickName });
            
            CreateTable(
                "dbo.Web_VTGLog",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 20),
                        TGUserName = c.String(nullable: false, maxLength: 20),
                        UserID = c.Int(),
                        TG_UserID = c.Int(),
                        RegTime = c.DateTime(storeType: "smalldatetime"),
                        GameTimeCount = c.Int(),
                        GetMoney = c.Int(),
                        CalTime = c.DateTime(storeType: "smalldatetime"),
                        IsClearing = c.Boolean(),
                        IsRegAward = c.Int(),
                    })
                .PrimaryKey(t => new { t.ID, t.UserName, t.TGUserName });
            
            CreateTable(
                "dbo.web_vTGpayClearing",
                c => new
                    {
                        RecordID = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 20),
                        RegisterTM = c.DateTime(nullable: false),
                        PlayTimeHourCount = c.Int(nullable: false),
                        PayUserID = c.Int(),
                        TGUserID = c.Int(),
                        PayMoney = c.Int(),
                        GetMoney = c.Int(),
                        PayType = c.String(maxLength: 50, unicode: false),
                        AddTime = c.DateTime(),
                    })
                .PrimaryKey(t => new { t.RecordID, t.UserName, t.RegisterTM, t.PlayTimeHourCount });
            
            CreateTable(
                "dbo.Web_vTransferLog",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserName = c.String(maxLength: 20),
                        UserNameZZ = c.String(maxLength: 20),
                        TransferMoney = c.Long(),
                        ActualTransfer = c.Long(),
                        TransTime = c.DateTime(storeType: "smalldatetime"),
                        UserID = c.Int(),
                        DestUserID = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Web_VTransLog",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        TranBOnceValue = c.Long(nullable: false),
                        UserName = c.String(maxLength: 20),
                        TransBefore = c.Long(),
                        TransAfter = c.Long(),
                        UserNameZZ = c.String(maxLength: 20),
                        ZZ_TransBefore = c.Long(),
                        ZZ_TransAfter = c.Long(),
                        Money = c.Long(),
                        Tax = c.Int(),
                        TransTime = c.DateTime(storeType: "smalldatetime"),
                        IP = c.String(maxLength: 30),
                        Success = c.Boolean(),
                        UserID = c.Int(),
                        UserZZID = c.Int(),
                    })
                .PrimaryKey(t => new { t.ID, t.TranBOnceValue });
            
            CreateTable(
                "dbo.Web_VTuiGuang",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 20),
                        NickName = c.String(nullable: false, maxLength: 50),
                        UserID = c.Int(),
                        TrueName = c.String(maxLength: 20),
                        ApplyTime = c.DateTime(storeType: "smalldatetime"),
                        Phone = c.String(maxLength: 50),
                        Address = c.String(maxLength: 100),
                        Pass = c.Boolean(),
                        MoneyCount = c.Int(),
                        CountTime = c.DateTime(storeType: "smalldatetime"),
                    })
                .PrimaryKey(t => new { t.ID, t.UserName, t.NickName });
            
            CreateTable(
                "dbo.Web_vUserAlbumColumn",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        AlbumName = c.String(nullable: false, maxLength: 50),
                        Cover = c.String(nullable: false, maxLength: 1000),
                        UserID = c.Int(nullable: false),
                        IsPublic = c.String(nullable: false, maxLength: 50),
                        InputTime = c.DateTime(nullable: false),
                        OrderID = c.Int(nullable: false),
                        UserName = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => new { t.ID, t.AlbumName, t.Cover, t.UserID, t.IsPublic, t.InputTime, t.OrderID });
            
            CreateTable(
                "dbo.Web_vUserAllMoneyChangeLog",
                c => new
                    {
                        UserID = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 50),
                        ChangeMoney = c.Long(nullable: false),
                        ChangeType = c.Int(nullable: false),
                        DateTime = c.DateTime(nullable: false),
                        StartMoney = c.Long(),
                        Remark = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => new { t.UserID, t.UserName, t.ChangeMoney, t.ChangeType, t.DateTime });
            
            CreateTable(
                "dbo.Web_VUserBattlePoint",
                c => new
                    {
                        UserName = c.String(nullable: false, maxLength: 20),
                        NickName = c.String(nullable: false, maxLength: 50),
                        UserID = c.Int(nullable: false),
                        NameID = c.Int(nullable: false),
                        Point = c.Long(nullable: false),
                        RoomID = c.Int(nullable: false),
                        Win = c.Int(nullable: false),
                        Lost = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserName, t.NickName, t.UserID, t.NameID, t.Point, t.RoomID, t.Win, t.Lost });
            
            CreateTable(
                "dbo.Web_VUserEmail",
                c => new
                    {
                        MsgID = c.Int(nullable: false),
                        SendTime = c.DateTime(nullable: false),
                        IsRead = c.Boolean(nullable: false),
                        UserID = c.Int(nullable: false),
                        MsgTitle = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => new { t.MsgID, t.SendTime, t.IsRead, t.UserID });
            
            CreateTable(
                "dbo.Web_VUserGameMoney",
                c => new
                    {
                        UserID = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 20),
                        GameID = c.Int(nullable: false),
                        WalletMoney = c.Long(nullable: false),
                        ComName = c.String(nullable: false, maxLength: 14),
                    })
                .PrimaryKey(t => new { t.UserID, t.UserName, t.GameID, t.WalletMoney, t.ComName });
            
            CreateTable(
                "dbo.Web_vUserList",
                c => new
                    {
                        UserID = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 20),
                        Pass = c.String(nullable: false, maxLength: 50),
                        TwoPassword = c.String(nullable: false, maxLength: 50),
                        LogoID = c.Int(nullable: false),
                        NickName = c.String(nullable: false, maxLength: 50),
                        LogoFileMD5 = c.String(nullable: false, maxLength: 50),
                        Token = c.String(nullable: false, maxLength: 128),
                        OnlineFlag = c.Int(nullable: false),
                        Disabled = c.Int(nullable: false),
                        Sex = c.Short(nullable: false),
                        Member = c.Int(nullable: false),
                        MatchMember = c.Int(nullable: false),
                        GamePower = c.Int(nullable: false),
                        GPLimitTime = c.DateTime(nullable: false),
                        BankMoney = c.Long(nullable: false),
                        Fascination = c.Int(nullable: false),
                        meili = c.Int(nullable: false),
                        Viptime = c.Int(nullable: false),
                        DoublePointTime = c.Int(nullable: false),
                        ProtectTime = c.Int(nullable: false),
                        LastLoginIP = c.String(nullable: false, maxLength: 16),
                        TimeIsMoney = c.Int(nullable: false),
                        AllLoginTime = c.Int(nullable: false),
                        LastLoginTM = c.DateTime(nullable: false),
                        PhoneNum = c.String(nullable: false, maxLength: 50, unicode: false),
                        AdrProvince = c.String(nullable: false, maxLength: 50, unicode: false),
                        AdrCity = c.String(nullable: false, maxLength: 50, unicode: false),
                        AdrZone = c.String(nullable: false, maxLength: 50, unicode: false),
                        OccuPation = c.String(nullable: false, maxLength: 50, unicode: false),
                        RegisterIP = c.String(nullable: false, maxLength: 50),
                        RegisterTM = c.DateTime(nullable: false),
                        Email = c.String(nullable: false, maxLength: 50),
                        WebLoginTime = c.Int(nullable: false),
                        UserType = c.Int(nullable: false),
                        ParentAgencyID = c.Int(nullable: false),
                        Lotteries = c.Int(nullable: false),
                        WalletMoney = c.Long(),
                        SumMoney = c.Long(),
                        TaxCom = c.Long(),
                        Phone = c.String(maxLength: 50, unicode: false),
                        Pwd_anw = c.String(maxLength: 50),
                        Pwd_ques = c.String(maxLength: 50),
                        ZJ_type = c.Short(),
                        ZJ_Number = c.String(maxLength: 50, unicode: false),
                        qqnum = c.String(maxLength: 20, unicode: false),
                    })
                .PrimaryKey(t => new { t.UserID, t.UserName, t.Pass, t.TwoPassword, t.LogoID, t.NickName, t.LogoFileMD5, t.Token, t.OnlineFlag, t.Disabled, t.Sex, t.Member, t.MatchMember, t.GamePower, t.GPLimitTime, t.BankMoney, t.Fascination, t.meili, t.Viptime, t.DoublePointTime, t.ProtectTime, t.LastLoginIP, t.TimeIsMoney, t.AllLoginTime, t.LastLoginTM, t.PhoneNum, t.AdrProvince, t.AdrCity, t.AdrZone, t.OccuPation, t.RegisterIP, t.RegisterTM, t.Email, t.WebLoginTime, t.UserType, t.ParentAgencyID, t.Lotteries });
            
            CreateTable(
                "dbo.Web_vUserList_New",
                c => new
                    {
                        UserID = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 20),
                        NickName = c.String(nullable: false, maxLength: 50),
                        IsRobot = c.Short(nullable: false),
                        Disabled = c.Int(nullable: false),
                        UserIngot = c.Long(nullable: false),
                        Email = c.String(nullable: false, maxLength: 50),
                        RegisterIP = c.String(nullable: false, maxLength: 50),
                        RegisterTM = c.DateTime(nullable: false),
                        AllLoginTime = c.Int(nullable: false),
                        LastLoginIP = c.String(nullable: false, maxLength: 16),
                        LastLoginTM = c.DateTime(nullable: false),
                        Lotteries = c.Long(),
                        ZJ_Number = c.String(maxLength: 50, unicode: false),
                        MyHardId = c.String(maxLength: 50),
                        AllPayMoney = c.Int(),
                        SumMoney = c.Long(),
                    })
                .PrimaryKey(t => new { t.UserID, t.UserName, t.NickName, t.IsRobot, t.Disabled, t.UserIngot, t.Email, t.RegisterIP, t.RegisterTM, t.AllLoginTime, t.LastLoginIP, t.LastLoginTM });
            
            CreateTable(
                "dbo.Web_vUserLoginList",
                c => new
                    {
                        UserID = c.Int(nullable: false),
                        LastLoginIP = c.String(nullable: false, maxLength: 16, fixedLength: true),
                        LastLoginTM = c.DateTime(nullable: false),
                        RegisterTM = c.DateTime(nullable: false),
                        LockMathine = c.Int(nullable: false),
                        UserName = c.String(maxLength: 20),
                        NickName = c.String(maxLength: 50),
                        MachineCode = c.String(maxLength: 80),
                        Disabled = c.Int(),
                        HardID = c.String(maxLength: 40),
                        IsLimitIP = c.Int(),
                        IsLockCode = c.Int(),
                        IsLockHard = c.Int(),
                    })
                .PrimaryKey(t => new { t.UserID, t.LastLoginIP, t.LastLoginTM, t.RegisterTM, t.LockMathine });
            
            CreateTable(
                "dbo.Web_vUserMoneyRank",
                c => new
                    {
                        UserID = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 20),
                        NickName = c.String(nullable: false, maxLength: 50),
                        BankMoney = c.Long(nullable: false),
                        SumMoney = c.Long(),
                    })
                .PrimaryKey(t => new { t.UserID, t.UserName, t.NickName, t.BankMoney });
            
            CreateTable(
                "dbo.Web_vUserPoint",
                c => new
                    {
                        UserID = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 20),
                        NickName = c.String(nullable: false, maxLength: 50),
                        IsRobot = c.Short(nullable: false),
                        ID = c.Int(nullable: false),
                        NameID = c.Int(nullable: false),
                        ComName = c.String(nullable: false, maxLength: 14),
                        Point = c.Long(),
                    })
                .PrimaryKey(t => new { t.UserID, t.UserName, t.NickName, t.IsRobot, t.ID, t.NameID, t.ComName });
            
            CreateTable(
                "dbo.Web_vUserPropertyAnaly",
                c => new
                    {
                        ChangeType = c.Int(nullable: false),
                        ID = c.Long(),
                        UserID = c.Int(),
                        ChangeMoney = c.Long(),
                    })
                .PrimaryKey(t => t.ChangeType);
            
            CreateTable(
                "dbo.Web_vUserPropertyReport",
                c => new
                    {
                        ChangeType = c.Int(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        ID = c.Long(),
                        UserID = c.Int(),
                        StartMoney = c.Long(),
                        ChangeMoney = c.Long(),
                        AfterMoney = c.Long(),
                        Remark = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => new { t.ChangeType, t.EndTime });
            
            CreateTable(
                "dbo.Web_VUsersList",
                c => new
                    {
                        Member = c.Int(nullable: false),
                        MatchMember = c.Int(nullable: false),
                        Master = c.Int(nullable: false),
                        GamePower = c.Int(nullable: false),
                        GPLimitTime = c.DateTime(nullable: false),
                        BankMoney = c.Long(nullable: false),
                        Fascination = c.Int(nullable: false),
                        Viptime = c.Int(nullable: false),
                        DoublePointTime = c.Int(nullable: false),
                        ProtectTime = c.Int(nullable: false),
                        LastLoginIP = c.String(nullable: false, maxLength: 16),
                        TimeIsMoney = c.Int(nullable: false),
                        AllLoginTime = c.Int(nullable: false),
                        LastLoginTM = c.DateTime(nullable: false),
                        OccuPation = c.String(nullable: false, maxLength: 50, unicode: false),
                        PhoneNum = c.String(nullable: false, maxLength: 50, unicode: false),
                        AdrProvince = c.String(nullable: false, maxLength: 50, unicode: false),
                        AdrCity = c.String(nullable: false, maxLength: 50, unicode: false),
                        AdrZone = c.String(nullable: false, maxLength: 50, unicode: false),
                        UserName = c.String(nullable: false, maxLength: 20),
                        Pass = c.String(nullable: false, maxLength: 50),
                        TwoPassword = c.String(nullable: false, maxLength: 50),
                        NickName = c.String(nullable: false, maxLength: 50),
                        LogoID = c.Int(nullable: false),
                        LogoFileMD5 = c.String(nullable: false, maxLength: 50),
                        Token = c.String(nullable: false, maxLength: 128),
                        OnlineFlag = c.Int(nullable: false),
                        Disabled = c.Int(nullable: false),
                        Sex = c.Short(nullable: false),
                        RegisterIP = c.String(nullable: false, maxLength: 50),
                        RegisterTM = c.DateTime(nullable: false),
                        Email = c.String(nullable: false, maxLength: 50),
                        WebLoginTime = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                        UserType = c.Int(nullable: false),
                        ParentAgencyID = c.Int(nullable: false),
                        IsRobot = c.Short(nullable: false),
                        Lotteries = c.Int(nullable: false),
                        UserIngot = c.Long(nullable: false),
                        WalletMoney = c.Long(),
                        SumMoney = c.Long(),
                        TaxCom = c.Long(),
                        Phone = c.String(maxLength: 50, unicode: false),
                        Pwd_anw = c.String(maxLength: 50),
                        Pwd_ques = c.String(maxLength: 50),
                        ZJ_type = c.Short(),
                        ZJ_Number = c.String(maxLength: 50, unicode: false),
                        VipTimes = c.DateTime(),
                        TrueName = c.String(maxLength: 20, unicode: false),
                    })
                .PrimaryKey(t => new { t.Member, t.MatchMember, t.Master, t.GamePower, t.GPLimitTime, t.BankMoney, t.Fascination, t.Viptime, t.DoublePointTime, t.ProtectTime, t.LastLoginIP, t.TimeIsMoney, t.AllLoginTime, t.LastLoginTM, t.OccuPation, t.PhoneNum, t.AdrProvince, t.AdrCity, t.AdrZone, t.UserName, t.Pass, t.TwoPassword, t.NickName, t.LogoID, t.LogoFileMD5, t.Token, t.OnlineFlag, t.Disabled, t.Sex, t.RegisterIP, t.RegisterTM, t.Email, t.WebLoginTime, t.UserID, t.UserType, t.ParentAgencyID, t.IsRobot, t.Lotteries, t.UserIngot });
            
            CreateTable(
                "dbo.Web_vUserTime",
                c => new
                    {
                        UserID = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 20),
                        NickName = c.String(nullable: false, maxLength: 50),
                        PlayTimeCount = c.Long(),
                        OnLineTimeCount = c.Long(),
                    })
                .PrimaryKey(t => new { t.UserID, t.UserName, t.NickName });
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TGameRoomTable", "RoomID", "dbo.TGameRoomBase");
            DropForeignKey("dbo.TGameRoomMsg", "RoomID", "dbo.TGameRoomBase");
            DropForeignKey("dbo.TContestDay", "ContestID", "dbo.TContestInfo");
            DropForeignKey("dbo.TChangeRecordUser", "RecordIndex", "dbo.TChangeRecord");
            DropForeignKey("dbo.TUserNameRule", "UserID", "dbo.TUsers");
            DropForeignKey("dbo.TUserList", "UserID", "dbo.TUsers");
            DropForeignKey("dbo.TUserInfo", "UserID", "dbo.TUsers");
            DropForeignKey("dbo.TSendMoneyRecord_New", "UserID", "dbo.TUsers");
            DropForeignKey("dbo.TSendMoneyRecord", "UserID", "dbo.TUsers");
            DropForeignKey("dbo.TRoomRecord", "UserID", "dbo.TUsers");
            DropForeignKey("dbo.TMoneyChangeRecord", "UserID", "dbo.TUsers");
            DropForeignKey("dbo.TMatchTable", "UserID", "dbo.TUsers");
            DropForeignKey("dbo.TUserCallGM", "UserID", "dbo.TUsers");
            DropForeignKey("dbo.TUserCallGM", "NameID", "dbo.TGameNameInfo");
            DropForeignKey("dbo.TMatchTable", "NameID", "dbo.TGameNameInfo");
            DropForeignKey("dbo.TGameServerInfo", "NameID", "dbo.TGameNameInfo");
            DropForeignKey("dbo.TGameRoomInfo", "GameNameID", "dbo.TGameNameInfo");
            DropForeignKey("dbo.TGameNameInfo", "KindID", "dbo.TGameKindInfo");
            DropForeignKey("dbo.TGameLock", "UserID", "dbo.TUsers");
            DropForeignKey("dbo.TFasciChangeRecord", "UserID", "dbo.TUsers");
            DropForeignKey("dbo.TUserProp", "UserID", "dbo.TUsers");
            DropForeignKey("dbo.TUserProp", "PropID", "dbo.TPropDefine");
            DropForeignKey("dbo.TPropBuyGive", "UserID", "dbo.TUsers");
            DropForeignKey("dbo.TPropBuyGive", "PropID", "dbo.TPropDefine");
            DropForeignKey("dbo.TFasciChangeRecord", "PropID", "dbo.TPropDefine");
            DropForeignKey("dbo.TChangeRecordUser", "UserID", "dbo.TUsers");
            DropIndex("dbo.TGameRoomTable", new[] { "RoomID" });
            DropIndex("dbo.TGameRoomMsg", new[] { "RoomID" });
            DropIndex("dbo.TContestDay", new[] { "ContestID" });
            DropIndex("dbo.TUserNameRule", new[] { "UserID" });
            DropIndex("dbo.TUserList", new[] { "UserID" });
            DropIndex("dbo.TUserInfo", new[] { "UserID" });
            DropIndex("dbo.TSendMoneyRecord_New", new[] { "UserID" });
            DropIndex("dbo.TSendMoneyRecord", new[] { "UserID" });
            DropIndex("dbo.TRoomRecord", new[] { "UserID" });
            DropIndex("dbo.TMoneyChangeRecord", new[] { "UserID" });
            DropIndex("dbo.TUserCallGM", new[] { "NameID" });
            DropIndex("dbo.TUserCallGM", new[] { "UserID" });
            DropIndex("dbo.TGameServerInfo", new[] { "NameID" });
            DropIndex("dbo.TGameRoomInfo", new[] { "GameNameID" });
            DropIndex("dbo.TGameNameInfo", new[] { "KindID" });
            DropIndex("dbo.TMatchTable", new[] { "NameID" });
            DropIndex("dbo.TMatchTable", new[] { "UserID" });
            DropIndex("dbo.TGameLock", new[] { "UserID" });
            DropIndex("dbo.TUserProp", new[] { "PropID" });
            DropIndex("dbo.TUserProp", new[] { "UserID" });
            DropIndex("dbo.TPropBuyGive", new[] { "PropID" });
            DropIndex("dbo.TPropBuyGive", new[] { "UserID" });
            DropIndex("dbo.TFasciChangeRecord", new[] { "PropID" });
            DropIndex("dbo.TFasciChangeRecord", new[] { "UserID" });
            DropIndex("dbo.TChangeRecordUser", new[] { "UserID" });
            DropIndex("dbo.TChangeRecordUser", new[] { "RecordIndex" });
            DropTable("dbo.Web_vUserTime");
            DropTable("dbo.Web_VUsersList");
            DropTable("dbo.Web_vUserPropertyReport");
            DropTable("dbo.Web_vUserPropertyAnaly");
            DropTable("dbo.Web_vUserPoint");
            DropTable("dbo.Web_vUserMoneyRank");
            DropTable("dbo.Web_vUserLoginList");
            DropTable("dbo.Web_vUserList_New");
            DropTable("dbo.Web_vUserList");
            DropTable("dbo.Web_VUserGameMoney");
            DropTable("dbo.Web_VUserEmail");
            DropTable("dbo.Web_VUserBattlePoint");
            DropTable("dbo.Web_vUserAllMoneyChangeLog");
            DropTable("dbo.Web_vUserAlbumColumn");
            DropTable("dbo.Web_VTuiGuang");
            DropTable("dbo.Web_VTransLog");
            DropTable("dbo.Web_vTransferLog");
            DropTable("dbo.web_vTGpayClearing");
            DropTable("dbo.Web_VTGLog");
            DropTable("dbo.web_VTGBalanceLog");
            DropTable("dbo.Web_VTContestRoom");
            DropTable("dbo.Web_vTaxStatEveryday");
            DropTable("dbo.Web_vSendMoneyRecord_New");
            DropTable("dbo.Web_VReceiveMoneyLog");
            DropTable("dbo.Web_VPropBuyGive");
            DropTable("dbo.Web_vPlayerSpareValue");
            DropTable("dbo.web_VPlayerLoginLog");
            DropTable("dbo.Web_vNewsList");
            DropTable("dbo.Web_VMoneyChangeRecord");
            DropTable("dbo.web_vMoneyChangeLog");
            DropTable("dbo.Web_VMatchTable");
            DropTable("dbo.Web_VMatchLog");
            DropTable("dbo.Web_VMatchAwardConfig");
            DropTable("dbo.Web_VLotterSpecial");
            DropTable("dbo.Web_VLotterLog");
            DropTable("dbo.Web_VLoginRecord");
            DropTable("dbo.Web_vIngotTransferLog");
            DropTable("dbo.web_vGetVipLog");
            DropTable("dbo.Web_VGetUserOnline");
            DropTable("dbo.Web_VGetPlayDetail");
            DropTable("dbo.Web_VGetAgencyDetail1");
            DropTable("dbo.Web_VGameRoomInfo3");
            DropTable("dbo.Web_VGameRoomInfo2");
            DropTable("dbo.Web_VGameRoomInfo");
            DropTable("dbo.Web_vGameRecord");
            DropTable("dbo.Web_VGameNameInfo");
            DropTable("dbo.Web_VGameKindList");
            DropTable("dbo.Web_VFasciExchangeLog");
            DropTable("dbo.Web_VFasciClearPropLog");
            DropTable("dbo.Web_vFaciSum");
            DropTable("dbo.Web_vExchangeFasciLog");
            DropTable("dbo.Web_VDataList");
            DropTable("dbo.Web_VClearPropLog");
            DropTable("dbo.Web_VCharmExchange");
            DropTable("dbo.Web_VChangeRecord");
            DropTable("dbo.Web_vBuyVipLog");
            DropTable("dbo.Web_vBuyPropLog");
            DropTable("dbo.Web_vBankMoneyOpera");
            DropTable("dbo.Web_VBankDeposit");
            DropTable("dbo.Web_vAwardRecord");
            DropTable("dbo.Web_vAwardLog");
            DropTable("dbo.Web_VApplyVipRoom");
            DropTable("dbo.Web_VAnalyData_DateOnline");
            DropTable("dbo.Web_VAnaly_UserListReg");
            DropTable("dbo.Web_VAnaly_UserList24B");
            DropTable("dbo.Web_VAnaly_UserList24A");
            DropTable("dbo.Web_VAnaly_PayList");
            DropTable("dbo.Web_VAnaly_NewUserReport");
            DropTable("dbo.Web_VAnaly_NewUserPayList");
            DropTable("dbo.Web_VAnaly_GameCountAndTax");
            DropTable("dbo.Web_VAnaly_DateReport");
            DropTable("dbo.Web_VAnaly_AgencyDateReport");
            DropTable("dbo.Web_ValmsDrawRecord");
            DropTable("dbo.Web_vAgencySpareValueLog");
            DropTable("dbo.Web_vAgencySpareValue");
            DropTable("dbo.Web_vAgencyList");
            DropTable("dbo.Web_vAgencyExchange");
            DropTable("dbo.Web_VAgencyBalanceLog");
            DropTable("dbo.Web_vAgencyAndPlayerSumPoint_List");
            DropTable("dbo.Web_vAgencyAccountLog");
            DropTable("dbo.Web_VAgency_UserPayList");
            DropTable("dbo.Web_Users");
            DropTable("dbo.Web_UserModifyLog");
            DropTable("dbo.Web_UserEmail");
            DropTable("dbo.Web_UserApplyVipRecord");
            DropTable("dbo.Web_UserAlbumColumn");
            DropTable("dbo.Web_UserAlbum");
            DropTable("dbo.Web_TuiGuangLog");
            DropTable("dbo.Web_TuiGuang");
            DropTable("dbo.Web_TransLog");
            DropTable("dbo.Web_TransfersAccount");
            DropTable("dbo.Web_TGPayRecord");
            DropTable("dbo.Web_TGClearingRecord");
            DropTable("dbo.Web_TaxStatEveryDay");
            DropTable("dbo.Web_System");
            DropTable("dbo.Web_RoleMenu");
            DropTable("dbo.Web_RoleBeMenu");
            DropTable("dbo.Web_RoleBeAdmin");
            DropTable("dbo.Web_Role");
            DropTable("dbo.Web_RMBCost");
            DropTable("dbo.Web_PVAndIPStat");
            DropTable("dbo.Web_PropChangeLog");
            DropTable("dbo.Web_ProductList");
            DropTable("dbo.Web_PointChangeLog");
            DropTable("dbo.Web_PlayerDayReport");
            DropTable("dbo.Web_PlatWinLostDateReport");
            DropTable("dbo.Web_PConfig");
            DropTable("dbo.Web_PayPropRecord");
            DropTable("dbo.Web_NewsType");
            DropTable("dbo.Web_NewsData");
            DropTable("dbo.Web_msg");
            DropTable("dbo.Web_MoneyStatEveryday");
            DropTable("dbo.Web_MoneyChangeLog");
            DropTable("dbo.Web_MenuOften");
            DropTable("dbo.Web_Manage_Popedom");
            DropTable("dbo.Web_Manage_Model");
            DropTable("dbo.Web_manage_admin");
            DropTable("dbo.Web_LotterSpecial");
            DropTable("dbo.Web_LotterLog");
            DropTable("dbo.Web_LotteriesLog");
            DropTable("dbo.Web_LotterConfig");
            DropTable("dbo.Web_LotterAward");
            DropTable("dbo.Web_Log");
            DropTable("dbo.Web_IngotTransLog");
            DropTable("dbo.Web_IngotChangeLog");
            DropTable("dbo.web_IngotChangeGold");
            DropTable("dbo.Web_IndexFlash");
            DropTable("dbo.Web_GUID");
            DropTable("dbo.Web_GameType");
            DropTable("dbo.Web_GameMain");
            DropTable("dbo.Web_GameInfo");
            DropTable("dbo.Web_GameGuidList");
            DropTable("dbo.Web_FriendLink");
            DropTable("dbo.Web_FineryID");
            DropTable("dbo.Web_FasciExchangeLog");
            DropTable("dbo.Web_FasciExchangeConfig");
            DropTable("dbo.Web_Exchange");
            DropTable("dbo.Web_DayTaxReport");
            DropTable("dbo.Web_DataClearLog");
            DropTable("dbo.Web_DataAnaly_Users");
            DropTable("dbo.Web_CreateID");
            DropTable("dbo.Web_Count_RoomOnline");
            DropTable("dbo.Web_Count_OnlineUsers");
            DropTable("dbo.Web_Count_AgencyOnline");
            DropTable("dbo.Web_ContestRank");
            DropTable("dbo.Web_ContestAwardType");
            DropTable("dbo.Web_ContestAwardLog");
            DropTable("dbo.Web_ContestAwardConfig");
            DropTable("dbo.Web_Config");
            DropTable("dbo.Web_CompanyInfo");
            DropTable("dbo.Web_ClothLog");
            DropTable("dbo.Web_Clothes");
            DropTable("dbo.Web_ClearPropLog");
            DropTable("dbo.Web_ClearingLog");
            DropTable("dbo.Web_ClearFasciPropUseLog");
            DropTable("dbo.Web_ClearFasciPropDefine");
            DropTable("dbo.Web_CheckInSet");
            DropTable("dbo.Web_CheckInLog");
            DropTable("dbo.Web_CheckInGot");
            DropTable("dbo.Web_CheckIn");
            DropTable("dbo.Web_CheckAwardList");
            DropTable("dbo.Web_CharmExchangeLog");
            DropTable("dbo.Web_CashConnection");
            DropTable("dbo.Web_Card");
            DropTable("dbo.Web_AwardLog");
            DropTable("dbo.Web_Award");
            DropTable("dbo.Web_ApplyVipRoom");
            DropTable("dbo.Web_AnalyData_DateOnline");
            DropTable("dbo.Web_Analy_NewUserReport");
            DropTable("dbo.Web_Analy_MonthReport");
            DropTable("dbo.Web_Analy_DateReport");
            DropTable("dbo.Web_AlmsDrawLog");
            DropTable("dbo.Web_AlmsConfig");
            DropTable("dbo.Web_AgencyRMBCost");
            DropTable("dbo.Web_AgencyPopeSet");
            DropTable("dbo.Web_AgencyPercentChange");
            DropTable("dbo.Web_AgencyMoneyChangeLog");
            DropTable("dbo.Web_AgencyDayReport");
            DropTable("dbo.Web_AgencyBalanceLog");
            DropTable("dbo.Web_AgencyAccountLog");
            DropTable("dbo.Web_Agency");
            DropTable("dbo.Web_AdminModifyLog");
            DropTable("dbo.Web_AdminLog");
            DropTable("dbo.Web_AdminEmail");
            DropTable("dbo.VUsersAlbum");
            DropTable("dbo.VUsers");
            DropTable("dbo.VUserProp");
            DropTable("dbo.VUserListSend");
            DropTable("dbo.VUserListReceive");
            DropTable("dbo.VUserBuy");
            DropTable("dbo.VRoomList");
            DropTable("dbo.VPropGive");
            DropTable("dbo.VChangeRecord");
            DropTable("dbo.TZLoginRecord");
            DropTable("dbo.TWLoginRecord");
            DropTable("dbo.TUserLoginGame");
            DropTable("dbo.TTransferRecord");
            DropTable("dbo.TRoomIPRule");
            DropTable("dbo.TReceiveMoneyRecord");
            DropTable("dbo.TReceiveMoneyDefind");
            DropTable("dbo.TProc_Error_Log");
            DropTable("dbo.TMoneyExceptLog");
            DropTable("dbo.TLoginRecord");
            DropTable("dbo.TLockCode");
            DropTable("dbo.TGMRecord");
            DropTable("dbo.TGM_OperationRecord");
            DropTable("dbo.TGM＿AwardType");
            DropTable("dbo.TGiveIngotRecord");
            DropTable("dbo.TGameRoomTable");
            DropTable("dbo.TGameRoomMsg");
            DropTable("dbo.TGameRoomBase");
            DropTable("dbo.TGameIPRule");
            DropTable("dbo.TGame_FlowWater");
            DropTable("dbo.TContestUserRecord");
            DropTable("dbo.TContestRecord");
            DropTable("dbo.TContestInfo");
            DropTable("dbo.TContestDay");
            DropTable("dbo.TCharmExchange");
            DropTable("dbo.TUserNameRule");
            DropTable("dbo.TUserList");
            DropTable("dbo.TUserInfo");
            DropTable("dbo.TSendMoneyRecord_New");
            DropTable("dbo.TSendMoneyRecord");
            DropTable("dbo.TRoomRecord");
            DropTable("dbo.TMoneyChangeRecord");
            DropTable("dbo.TUserCallGM");
            DropTable("dbo.TGameServerInfo");
            DropTable("dbo.TGameRoomInfo");
            DropTable("dbo.TGameKindInfo");
            DropTable("dbo.TGameNameInfo");
            DropTable("dbo.TMatchTable");
            DropTable("dbo.TGameLock");
            DropTable("dbo.TUserProp");
            DropTable("dbo.TPropBuyGive");
            DropTable("dbo.TPropDefine");
            DropTable("dbo.TFasciChangeRecord");
            DropTable("dbo.TUsers");
            DropTable("dbo.TChangeRecordUser");
            DropTable("dbo.TChangeRecord");
            DropTable("dbo.TBattleRoomInfo");
            DropTable("dbo.TBattleMatchTable");
            DropTable("dbo.TBankWallet");
            DropTable("dbo.TBankSerialResource");
            DropTable("dbo.TBankSerialRes");
            DropTable("dbo.TBankDeposit");
            DropTable("dbo.sysdiagrams");
            DropTable("dbo.Sys_ProcErrorCollection");
            DropTable("dbo.Sale_Bills");
            DropTable("dbo.Sale_BillRecord");
            DropTable("dbo.Sale_Bars");
            DropTable("dbo.Sale_Admin");
            DropTable("dbo.A_test");
        }
    }
}
