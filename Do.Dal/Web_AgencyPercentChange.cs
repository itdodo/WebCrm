namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_AgencyPercentChange
    {
        public int ID { get; set; }

        public int OperaID { get; set; }

        public int AgencyID { get; set; }

        public int BPercent { get; set; }

        public int APercent { get; set; }

        public int Change { get; set; }

        public DateTime AddTime { get; set; }

        public int OperaType { get; set; }
    }
}
