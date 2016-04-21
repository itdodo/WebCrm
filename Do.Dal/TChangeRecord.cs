namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TChangeRecord")]
    public partial class TChangeRecord
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TChangeRecord()
        {
            TChangeRecordUser = new HashSet<TChangeRecordUser>();
        }

        public int ID { get; set; }

        public int GameTime { get; set; }

        public DateTime EndTime { get; set; }

        public int RoomID { get; set; }

        public int DeskIndex { get; set; }

        public int Tax { get; set; }

        public short? ModelType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TChangeRecordUser> TChangeRecordUser { get; set; }
    }
}
