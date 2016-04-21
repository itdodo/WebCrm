namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TReceiveMoneyDefind")]
    public partial class TReceiveMoneyDefind
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public long ReceiveMoney { get; set; }

        public long MinMoney { get; set; }

        public int SpaceTime { get; set; }
    }
}
