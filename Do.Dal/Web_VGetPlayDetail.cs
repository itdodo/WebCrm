namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_VGetPlayDetail
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string UserName { get; set; }

        [StringLength(20)]
        public string RealName { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long BankMoney { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long WalletMoney { get; set; }

        [StringLength(20)]
        public string qqnum { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string Email { get; set; }

        public long? TotalLwMoney { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string RegisterIP { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime RegisterTM { get; set; }

        [Key]
        [Column(Order = 7)]
        public DateTime LastLoginTM { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(16)]
        public string LastLoginIP { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        public long? SpareMoney { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short IsRobot { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(50)]
        public string AgencyName { get; set; }

        [StringLength(50)]
        public string Pwd_anw { get; set; }

        [StringLength(50)]
        public string Pwd_ques { get; set; }

        public short? ZJ_type { get; set; }

        [StringLength(50)]
        public string ZJ_Number { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short Sex { get; set; }
    }
}
