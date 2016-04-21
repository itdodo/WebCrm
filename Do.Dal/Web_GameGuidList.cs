namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_GameGuidList
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NameID { get; set; }

        public int KindID { get; set; }

        [Required]
        [StringLength(50)]
        public string KindName { get; set; }

        [Required]
        [StringLength(50)]
        public string GameName { get; set; }

        public bool UserFlag { get; set; }

        public int? ParamsID { get; set; }
    }
}
