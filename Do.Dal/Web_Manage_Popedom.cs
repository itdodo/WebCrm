namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_Manage_Popedom
    {
        public int Id { get; set; }

        public int AdminID { get; set; }

        [Required]
        [StringLength(50)]
        public string ModelNo { get; set; }

        public int HasInsert { get; set; }

        public int HasUpdate { get; set; }

        public int HasDel { get; set; }
    }
}
