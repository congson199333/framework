using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ViewModel
{
    public class ProductViewModel
    {
        public long productId { get; set; }
        public string productName { get; set; }
        public decimal? price { get; set; }
        public string img { get; set; }
        public int size { get; set; }
        public int? sl { get; set; }

       

        //public static implicit operator ProductViewModel(List<ProductViewModel> v)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
