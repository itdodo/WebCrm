namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_ClearFasciPropUseLog
    {
        public int ID { get; set; }

        public int PropID { get; set; }

        public int UserID { get; set; }

        public int BeforeFasci { get; set; }

        public int AfterFasci { get; set; }

        public int ChangeFasci { get; set; }

        public long BeforeMoney { get; set; }

        public long AfterMoney { get; set; }

        public int ChangeMoney { get; set; }

        public DateTime InputDate { get; set; }
    }
}
