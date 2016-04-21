namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_AgencyPopeSet
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string AgencyName { get; set; }

        public int IsAddAgency { get; set; }

        public int IsPickUpCashToAgency { get; set; }

        public int IsPickUpCashToPlayer { get; set; }

        public int IsGiveToAgency { get; set; }

        public int IsGiveToPlayer { get; set; }
    }
}
