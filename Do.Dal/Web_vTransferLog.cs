namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_vTransferLog
    {
        public int ID { get; set; }

        [StringLength(20)]
        public string UserName { get; set; }

        [StringLength(20)]
        public string UserNameZZ { get; set; }

        public long? TransferMoney { get; set; }

        public long? ActualTransfer { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? TransTime { get; set; }

        public int? UserID { get; set; }

        public int? DestUserID { get; set; }
    }
}
