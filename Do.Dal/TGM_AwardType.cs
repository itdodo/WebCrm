namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TGM＿AwardType")]
    public partial class TGM_AwardType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SeriNo { get; set; }

        public int Gold { get; set; }

        public int? PropID1 { get; set; }

        public int? PropCount1 { get; set; }

        public int? PropID2 { get; set; }

        public int? PropCount2 { get; set; }

        public int? PropID3 { get; set; }

        public int? PropCount3 { get; set; }

        public int? PropID4 { get; set; }

        public int? PropCount4 { get; set; }
    }
}
