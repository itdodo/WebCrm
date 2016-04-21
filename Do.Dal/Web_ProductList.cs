namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_ProductList
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GameID { get; set; }

        [Required]
        [StringLength(100)]
        public string GameName { get; set; }

        public int MinPeople { get; set; }

        public int MaxPeople { get; set; }
    }
}
