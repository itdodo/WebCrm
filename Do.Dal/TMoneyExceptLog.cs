namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TMoneyExceptLog")]
    public partial class TMoneyExceptLog
    {
        public int id { get; set; }

        public long? BankMoney { get; set; }

        public long? WalletMoney { get; set; }

        public long? TotalMoney { get; set; }
    }
}
