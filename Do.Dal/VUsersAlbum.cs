namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VUsersAlbum")]
    public partial class VUsersAlbum
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ColumnID { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(300)]
        public string PicName { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(1000)]
        public string PicPath { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(1000)]
        public string PicDescription { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ShortNum { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(50)]
        public string Enable { get; set; }

        [Key]
        [Column(Order = 8)]
        public DateTime InputTime { get; set; }

        [StringLength(20)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string AlbumName { get; set; }

        [StringLength(50)]
        public string IsPublic { get; set; }

        [StringLength(50)]
        public string NickName { get; set; }
    }
}
