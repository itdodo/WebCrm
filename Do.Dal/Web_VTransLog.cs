namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_VTransLog
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [StringLength(20)]
        public string UserName { get; set; }

        public long? TransBefore { get; set; }

        public long? TransAfter { get; set; }

        [StringLength(20)]
        public string UserNameZZ { get; set; }

        public long? ZZ_TransBefore { get; set; }

        public long? ZZ_TransAfter { get; set; }

        public long? Money { get; set; }

        public int? Tax { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? TransTime { get; set; }

        [StringLength(30)]
        public string IP { get; set; }

        public bool? Success { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TranBOnceValue { get; set; }

        public int? UserID { get; set; }

        public int? UserZZID { get; set; }
    }
}
