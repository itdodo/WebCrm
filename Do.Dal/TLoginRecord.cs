namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TLoginRecord")]
    public partial class TLoginRecord
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }

        [StringLength(80)]
        public string MachineCode { get; set; }

        [StringLength(40)]
        public string CPUID { get; set; }

        [StringLength(40)]
        public string HardID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(16)]
        public string LastLoginIP { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime LastLoginTM { get; set; }
    }
}
