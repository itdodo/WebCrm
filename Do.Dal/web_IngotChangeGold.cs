namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class web_IngotChangeGold
    {
        public int ID { get; set; }

        [StringLength(60)]
        public string TitleName { get; set; }

        public long? Ingot { get; set; }

        public long? Gold { get; set; }

        [StringLength(200)]
        public string ImgUrl { get; set; }
    }
}
