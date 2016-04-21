namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TGameKindInfo")]
    public partial class TGameKindInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TGameKindInfo()
        {
            TGameNameInfo = new HashSet<TGameNameInfo>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int KindID { get; set; }

        [Required]
        [StringLength(14)]
        public string KindName { get; set; }

        public int IDSort { get; set; }

        public byte Enable { get; set; }

        public int ParentKindID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TGameNameInfo> TGameNameInfo { get; set; }
    }
}
