namespace Do.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_UserApplyVipRecord
    {
        public int ID { get; set; }

        public int UserID { get; set; }

        public int Money { get; set; }

        public int AddVipTime { get; set; }

        public DateTime AddTime { get; set; }

        public int TargetUserID { get; set; }
    }
}
