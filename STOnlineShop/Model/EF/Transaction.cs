namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Transaction
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Transaction()
        {
            Oders = new HashSet<Oder>();
        }

        [Key]
        public long tranId { get; set; }

        public int? status { get; set; }

        [StringLength(50)]
        public string userName { get; set; }

        [StringLength(50)]
        public string userMail { get; set; }

        [StringLength(20)]
        public string userPhone { get; set; }

        [StringLength(100)]
        public string userAddress { get; set; }

        [StringLength(50)]
        public string payment { get; set; }

        public decimal? total { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Oder> Oders { get; set; }
    }
}
