namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_GameMain
    {
        [Key]
        public short Main_ID { get; set; }

        [StringLength(1000)]
        public string Main_Info { get; set; }

        [StringLength(1000)]
        public string sMain_Info { get; set; }

        [StringLength(50)]
        public string Main_Copy { get; set; }

        [StringLength(50)]
        public string sMain_Copy { get; set; }

        [StringLength(100)]
        public string Main_use { get; set; }

        [StringLength(100)]
        public string sMain_use { get; set; }

        public DateTime? Update_Time { get; set; }

        [StringLength(100)]
        public string Down_saddress { get; set; }

        [StringLength(100)]
        public string Down_address { get; set; }

        public int? Down_num { get; set; }

        [StringLength(20)]
        public string sFileSize { get; set; }

        [StringLength(20)]
        public string FileSize { get; set; }

        [StringLength(100)]
        public string Image_URL { get; set; }

        [StringLength(100)]
        public string sImage_URL { get; set; }
    }
}
