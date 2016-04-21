namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_DayTaxReport
    {
        public int ID { get; set; }

        public long ChangeTax { get; set; }

        public DateTime AddTime { get; set; }
    }
}
