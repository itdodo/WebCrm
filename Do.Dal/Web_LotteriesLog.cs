namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_LotteriesLog
    {
        public int ID { get; set; }

        public int UserID { get; set; }

        [Required]
        [StringLength(100)]
        public string UserName { get; set; }

        public int LotteriesB { get; set; }

        public int ChangeLotteries { get; set; }

        public int LotteriesA { get; set; }

        public DateTime InputDate { get; set; }

        [StringLength(500)]
        public string Content { get; set; }

        public int ChangeType { get; set; }
    }
}
