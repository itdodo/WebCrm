namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_manage_admin
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        [StringLength(100)]
        public string Purview { get; set; }

        public byte? UserGroup { get; set; }

        [StringLength(15)]
        public string LastLoginIP { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? LastLoginTime { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? LastLogoutTime { get; set; }

        public int? LoginTimes { get; set; }

        public int? AdminPurview_Article_T { get; set; }

        public int? AdminPurview_Soft_T { get; set; }

        public int? AdminPurview_Photo_T { get; set; }

        [StringLength(50)]
        public string AdminPurview_Guest_T { get; set; }

        [StringLength(255)]
        public string AdminPurview_Others_T { get; set; }

        [StringLength(50)]
        public string RndPassword_T { get; set; }
    }
}
