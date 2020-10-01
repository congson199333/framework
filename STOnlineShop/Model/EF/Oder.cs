namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Oder
    {
        public long? tranId { get; set; }

        public int oderId { get; set; }

        public int? productId { get; set; }

        public decimal? price { get; set; }

        public int? quatity { get; set; }

        public int? size { get; set; }

        public int? statusOrder { get; set; }

        [Column(TypeName = "date")]
        public DateTime? createDay { get; set; }

        public virtual Product Product { get; set; }

        public virtual Transaction Transaction { get; set; }
    }
}
