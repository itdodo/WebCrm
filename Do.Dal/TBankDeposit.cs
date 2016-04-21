namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TBankDeposit")]
    public partial class TBankDeposit
    {
        public int id { get; set; }

        public int Userid { get; set; }

        public long Money { get; set; }

        [Required]
        [StringLength(16)]
        public string DepositID { get; set; }

        [Required]
        [StringLength(16)]
        public string DepositPassWord { get; set; }

        public DateTime GreateTime { get; set; }

        public int CDSC { get; set; }

        public int State { get; set; }

        public int? UsedUserID { get; set; }
    }
}
