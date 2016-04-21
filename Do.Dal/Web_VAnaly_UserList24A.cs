namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_VAnaly_UserList24A
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

        public long? SumMoney { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string AgencyName { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime RegisterTM { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string RegisterIP { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GameCount { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(6)]
        public string OnlineStatus { get; set; }
    }
}
