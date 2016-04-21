namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_Users
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }

        [Required]
        [StringLength(50)]
        public string RegisterIP { get; set; }

        public DateTime RegisterTM { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        public int WebLoginTime { get; set; }

        [StringLength(50)]
        public string Pwd_anw { get; set; }

        [StringLength(50)]
        public string Pwd_ques { get; set; }

        public short? ZJ_type { get; set; }

        [StringLength(50)]
        public string ZJ_Number { get; set; }

        [StringLength(20)]
        public string qqnum { get; set; }

        [StringLength(20)]
        public string RealName { get; set; }

        [StringLength(500)]
        public string SignDescr { get; set; }

        [Required]
        [StringLength(50)]
        public string ZipCode { get; set; }

        [Required]
        [StringLength(500)]
        public string Address { get; set; }

        [StringLength(20)]
        public string Schooling { get; set; }

        [StringLength(128)]
        public string HomePage { get; set; }

        [StringLength(20)]
        public string TelNo { get; set; }

        [StringLength(50)]
        public string MSNID { get; set; }

        public int Lotteries { get; set; }

        public short? PhoneValid { get; set; }

        public short? ZJValid { get; set; }

        public int? Age { get; set; }

        public DateTime? Birthday { get; set; }

        [StringLength(50)]
        public string FindPwdQue_1 { get; set; }

        [StringLength(50)]
        public string FindPwdAnw_1 { get; set; }

        [StringLength(50)]
        public string FindPwdQue_2 { get; set; }

        [StringLength(50)]
        public string FindPwdAnw_2 { get; set; }
    }
}
