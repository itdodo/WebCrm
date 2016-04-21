namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_FasciExchangeConfig
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public DateTime? Con_StartTime { get; set; }

        public DateTime? Con_EndTime { get; set; }

        public int Con_Price { get; set; }

        public int Con_ChangeLimit { get; set; }

        public int Con_MaxMoney { get; set; }
    }
}
