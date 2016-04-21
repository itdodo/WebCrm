namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TPropDefine")]
    public partial class TPropDefine
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TPropDefine()
        {
            TFasciChangeRecord = new HashSet<TFasciChangeRecord>();
            TPropBuyGive = new HashSet<TPropBuyGive>();
            TUserProp = new HashSet<TUserProp>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PropID { get; set; }

        [Required]
        [StringLength(50)]
        public string PropName { get; set; }

        public int Price { get; set; }

        public int VipPrice { get; set; }

        [Required]
        [StringLength(50)]
        public string Descript { get; set; }

        public int ActionAttribute { get; set; }

        public int ValueAttribute { get; set; }

        public int PropType { get; set; }

        public int LargessGold { get; set; }

        public int SendGold { get; set; }

        public int PriceType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TFasciChangeRecord> TFasciChangeRecord { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TPropBuyGive> TPropBuyGive { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TUserProp> TUserProp { get; set; }
    }
}
