namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_TransfersAccount
    {
        [Key]
        public int TransferID { get; set; }

        [Required]
        [StringLength(50)]
        public string Sender { get; set; }

        [Required]
        [StringLength(50)]
        public string Receiver { get; set; }

        public long TransferMoney { get; set; }

        public int? TransferFrequency { get; set; }

        public DateTime TransferTime { get; set; }

        public bool ReceiverType { get; set; }

        [Required]
        [StringLength(100)]
        public string Remark { get; set; }

        public long SenderBFMoney { get; set; }

        public long SenderAFMoney { get; set; }

        public long ReceiverBFMoney { get; set; }

        public long ReceiverAFMoney { get; set; }
    }
}
