namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_CashConnection
    {
        [Required]
        [StringLength(20)]
        public string UserName { get; set; }

        [Key]
        [StringLength(40)]
        public string ConKey { get; set; }

        public DateTime CreateDate { get; set; }

        public int UserID { get; set; }
    }
}
