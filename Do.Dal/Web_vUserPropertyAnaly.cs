namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_vUserPropertyAnaly
    {
        public long? ID { get; set; }

        public int? UserID { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ChangeType { get; set; }

        public long? ChangeMoney { get; set; }
    }
}
