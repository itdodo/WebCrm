namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_Manage_Model
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string ModelNo { get; set; }

        [Required]
        [StringLength(200)]
        public string ModelName { get; set; }

        [Required]
        [StringLength(3000)]
        public string Remark { get; set; }
    }
}
