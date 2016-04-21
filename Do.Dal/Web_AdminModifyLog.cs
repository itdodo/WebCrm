namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_AdminModifyLog
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string AdminName { get; set; }

        [Required]
        [StringLength(50)]
        public string IP { get; set; }

        [StringLength(50)]
        public string System { get; set; }

        [StringLength(2000)]
        public string Description { get; set; }

        public bool State { get; set; }

        public DateTime AddTime { get; set; }

        public int OperateType { get; set; }
    }
}
