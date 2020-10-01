namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            Oders = new HashSet<Oder>();
        }

        public int productId { get; set; }

        [StringLength(50)]
        [Display(Name = "Tên sản phẩm")]
        public string productName { get; set; }

        [Display(Name = "Loại sản phẩm")]
        public int? brandId { get; set; }

        public DateTime? datem { get; set; }

        [Display(Name = "Giá")]
        public decimal? price { get; set; }

        [StringLength(200)]
        public string img { get; set; }


        public double? sale { get; set; }

        public decimal? priceSale { get; set; }

        public virtual Brand Brand { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Oder> Oders { get; set; }
    }
}
