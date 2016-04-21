namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_Award
    {
        [Key]
        public int Award_ID { get; set; }

        [StringLength(50)]
        public string Award_Name { get; set; }

        [Column(TypeName = "ntext")]
        public string Award_Info { get; set; }

        [StringLength(50)]
        public string Award_Pic { get; set; }

        public int? Award_Num { get; set; }

        public long? Award_MoneyCost { get; set; }

        public int? Award_MoneyGet { get; set; }

        public int? Award_Type { get; set; }

        public DateTime? Award_AddDate { get; set; }

        public bool? Award_Hot { get; set; }

        public int? Award_OnLineTime { get; set; }

        public long? Award_NeedMoney { get; set; }
    }
}
