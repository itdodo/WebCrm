namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_Agency
    {
        [Key]
        public int AgencyID { get; set; }

        [Required]
        [StringLength(50)]
        public string AgencyName { get; set; }

        [Required]
        [StringLength(255)]
        public string AgencyPassword { get; set; }

        public int ParentAgencyID { get; set; }

        public int LevelID { get; set; }

        [Required]
        [StringLength(50)]
        public string TrueName { get; set; }

        [Required]
        [StringLength(50)]
        public string Phone { get; set; }

        [Required]
        [StringLength(100)]
        public string Address { get; set; }

        public int PostalCode { get; set; }

        [Required]
        [StringLength(50)]
        public string QQNum { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(50)]
        public string MobilPhone { get; set; }

        [Required]
        [StringLength(50)]
        public string AccountNO { get; set; }

        public long Account { get; set; }

        [Required]
        [StringLength(50)]
        public string AccountName { get; set; }

        [Required]
        [StringLength(100)]
        public string BankName { get; set; }

        [Required]
        [StringLength(100)]
        public string BankAddress { get; set; }

        [Required]
        [StringLength(50)]
        public string PayorNo { get; set; }

        [Required]
        [StringLength(100)]
        public string TenpayNo { get; set; }

        public decimal SpareValue { get; set; }

        public DateTime RegisterTime { get; set; }

        public DateTime UpdateTime { get; set; }

        public byte IsTaboo { get; set; }

        public DateTime LastLoginDateTime { get; set; }

        [Required]
        [StringLength(20)]
        public string LastLoginIP { get; set; }

        [Required]
        [StringLength(50)]
        public string DomainUrl { get; set; }

        [Required]
        [StringLength(100)]
        public string Remark { get; set; }
    }
}
