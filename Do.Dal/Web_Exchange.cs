namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_Exchange
    {
        [Key]
        public long ExID { get; set; }

        public int UserID { get; set; }

        [Required]
        [StringLength(20)]
        public string UserName { get; set; }

        public DateTime AddTime { get; set; }

        public int ApplyMoney { get; set; }

        public int ApplyState { get; set; }

        [Required]
        [StringLength(100)]
        public string AccountNo { get; set; }

        [Required]
        [StringLength(50)]
        public string AccountName { get; set; }

        [Required]
        [StringLength(50)]
        public string BankName { get; set; }

        [Required]
        [StringLength(200)]
        public string BankAddress { get; set; }

        public DateTime? DisposeTime { get; set; }

        [StringLength(500)]
        public string DisposeDesc { get; set; }

        public int AccountType { get; set; }

        public int UserType { get; set; }
    }
}
