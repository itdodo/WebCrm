namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TUsers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TUsers()
        {
            TChangeRecordUser = new HashSet<TChangeRecordUser>();
            TFasciChangeRecord = new HashSet<TFasciChangeRecord>();
            TMatchTable = new HashSet<TMatchTable>();
            TMoneyChangeRecord = new HashSet<TMoneyChangeRecord>();
            TPropBuyGive = new HashSet<TPropBuyGive>();
            TSendMoneyRecord = new HashSet<TSendMoneyRecord>();
            TSendMoneyRecord_New = new HashSet<TSendMoneyRecord_New>();
            TUserCallGM = new HashSet<TUserCallGM>();
            TRoomRecord = new HashSet<TRoomRecord>();
            TGameLock = new HashSet<TGameLock>();
            TUserList = new HashSet<TUserList>();
            TUserNameRule = new HashSet<TUserNameRule>();
            TUserProp = new HashSet<TUserProp>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }

        [Required]
        [StringLength(20)]
        public string UserName { get; set; }

        [Required]
        [StringLength(50)]
        public string Pass { get; set; }

        [Required]
        [StringLength(50)]
        public string TwoPassword { get; set; }

        [Required]
        [StringLength(50)]
        public string NickName { get; set; }

        public int LogoID { get; set; }

        [Required]
        [StringLength(50)]
        public string LogoFileMD5 { get; set; }

        [Required]
        [StringLength(128)]
        public string Token { get; set; }

        public int OnlineFlag { get; set; }

        public int Disabled { get; set; }

        public short Sex { get; set; }

        public short IsRobot { get; set; }

        public int AgencyID { get; set; }

        [StringLength(50)]
        public string Salt { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TChangeRecordUser> TChangeRecordUser { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TFasciChangeRecord> TFasciChangeRecord { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TMatchTable> TMatchTable { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TMoneyChangeRecord> TMoneyChangeRecord { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TPropBuyGive> TPropBuyGive { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSendMoneyRecord> TSendMoneyRecord { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSendMoneyRecord_New> TSendMoneyRecord_New { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TUserCallGM> TUserCallGM { get; set; }

        public virtual TUserInfo TUserInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRoomRecord> TRoomRecord { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TGameLock> TGameLock { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TUserList> TUserList { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TUserNameRule> TUserNameRule { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TUserProp> TUserProp { get; set; }
    }
}
