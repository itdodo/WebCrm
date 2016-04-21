namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_GameType
    {
        [Key]
        public short TypeID { get; set; }

        [Required]
        [StringLength(50)]
        public string TypeName { get; set; }

        public short TypeSort { get; set; }
    }
}
