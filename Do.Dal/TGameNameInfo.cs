namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TGameNameInfo")]
    public partial class TGameNameInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TGameNameInfo()
        {
            TGameRoomInfo = new HashSet<TGameRoomInfo>();
            TGameServerInfo = new HashSet<TGameServerInfo>();
            TMatchTable = new HashSet<TMatchTable>();
            TUserCallGM = new HashSet<TUserCallGM>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NameID { get; set; }

        public int KindID { get; set; }

        [Required]
        [StringLength(14)]
        public string ComName { get; set; }

        [Required]
        [StringLength(20)]
        public string ComProcess { get; set; }

        public int IDSort { get; set; }

        public byte Enable { get; set; }

        public long EveryDayRent { get; set; }

        public int RecommendType { get; set; }

        public int? RecommendRoom { get; set; }

        public int StarCount { get; set; }

        public virtual TGameKindInfo TGameKindInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TGameRoomInfo> TGameRoomInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TGameServerInfo> TGameServerInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TMatchTable> TMatchTable { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TUserCallGM> TUserCallGM { get; set; }
    }
}
