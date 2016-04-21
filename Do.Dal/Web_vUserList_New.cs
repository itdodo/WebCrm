namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_vUserList_New
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string UserName { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string NickName { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short IsRobot { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Disabled { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long UserIngot { get; set; }

        public long? Lotteries { get; set; }

        [StringLength(50)]
        public string ZJ_Number { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string MyHardId { get; set; }

        public int? AllPayMoney { get; set; }

        public long? SumMoney { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(50)]
        public string RegisterIP { get; set; }

        [Key]
        [Column(Order = 8)]
        public DateTime RegisterTM { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AllLoginTime { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(16)]
        public string LastLoginIP { get; set; }

        [Key]
        [Column(Order = 11)]
        public DateTime LastLoginTM { get; set; }
    }
}
