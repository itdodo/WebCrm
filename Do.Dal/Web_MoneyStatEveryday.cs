namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_MoneyStatEveryday
    {
        public int ID { get; set; }

        public DateTime StatTime { get; set; }

        public long BankMoney { get; set; }

        public long WalletMoney { get; set; }
    }
}
