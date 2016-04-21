namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_IngotTransLog
    {
        public int ID { get; set; }

        [StringLength(20)]
        public string UserName { get; set; }

        public long? TransBefore { get; set; }

        public long? TransAfter { get; set; }

        [StringLength(20)]
        public string UserNameZZ { get; set; }

        public long? ZZ_TransBefore { get; set; }

        public long? ZZ_TransAfter { get; set; }

        public long? TransIngot { get; set; }

        public int? Tax { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? TransTime { get; set; }

        [StringLength(30)]
        public string IP { get; set; }

        public bool? Success { get; set; }
    }
}
