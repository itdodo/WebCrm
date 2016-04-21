namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_vUserLoginList
    {
        [StringLength(20)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string NickName { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }

        [StringLength(80)]
        public string MachineCode { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(16)]
        public string LastLoginIP { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime LastLoginTM { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime RegisterTM { get; set; }

        public int? Disabled { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LockMathine { get; set; }

        [StringLength(40)]
        public string HardID { get; set; }

        public int? IsLimitIP { get; set; }

        public int? IsLockCode { get; set; }

        public int? IsLockHard { get; set; }
    }
}
