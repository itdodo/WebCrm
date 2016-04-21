namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TFasciChangeRecord")]
    public partial class TFasciChangeRecord
    {
        public int id { get; set; }

        public int UserID { get; set; }

        public int TargetID { get; set; }

        public int PropID { get; set; }

        public int FasciChange { get; set; }

        public int Money { get; set; }

        public DateTime ActionTime { get; set; }

        public virtual TPropDefine TPropDefine { get; set; }

        public virtual TUsers TUsers { get; set; }
    }
}
