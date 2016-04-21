namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TGameServerInfo")]
    public partial class TGameServerInfo
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ServerInfoID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(15)]
        public string GameName { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string GameTable { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NameID { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SupportType { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ServiceVer { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DeskPeople { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(20)]
        public string DLLFileName { get; set; }

        public virtual TGameNameInfo TGameNameInfo { get; set; }
    }
}
