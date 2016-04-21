namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TChangeRecordUser")]
    public partial class TChangeRecordUser
    {
        public int id { get; set; }

        public int RecordIndex { get; set; }

        public int UserIndex { get; set; }

        public int UserID { get; set; }

        public long SrcPoint { get; set; }

        public long SrcMoney { get; set; }

        public long ChangePoint { get; set; }

        public long ChangeMoney { get; set; }

        public long ChangeTax { get; set; }

        public int ReportStatus { get; set; }

        public virtual TChangeRecord TChangeRecord { get; set; }

        public virtual TUsers TUsers { get; set; }
    }
}
