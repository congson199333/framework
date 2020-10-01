using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Model.EF;
using Model.ViewModel;

namespace STOnlineShop.Models
{
    public class CartItem
    {
        public Product Product { get; set; }
        public int Size { get; set; }
        public int Quantity { get; set; }
    }
}