namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_DataAnaly_Users
    {
        [Key]
        public int UserID { get; set; }

        [Required]
        [StringLength(50)]
        public string UserName { get; set; }

        [Required]
        [StringLength(250)]
        public string Password { get; set; }

        [StringLength(50)]
        public string LastLoginIP { get; set; }

        public DateTime? LastLoginTime { get; set; }

        public DateTime AddTime { get; set; }

        public int IsTaboo { get; set; }

        public int LoginCount { get; set; }
    }
}
