namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_VClearPropLog
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PropID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }

        public int? BeforeValue { get; set; }

        public int? AfterValue { get; set; }

        public int? PropType { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime InputDate { get; set; }

        public int? GameNameID { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(20)]
        public string UserName { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string NickName { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(50)]
        public string PropName { get; set; }

        [StringLength(14)]
        public string GameName { get; set; }
    }
}
