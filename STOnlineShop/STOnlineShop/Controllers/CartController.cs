using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.EF;
using Model.ViewModel;
using STOnlineShop.Models;
using Model.Dao;
using System.Web.Script.Serialization;

namespace STOnlineShop.Controllers
{
    public class CartController : Controller
    {
        private const  string CartSession = "CartSession";
        // GET: Cart
        public ActionResult Index()
        {
           
            var cart = Session[CartSession];
            
            var list = new List<CartItem>();

            
            if (cart != null)
            {
                list = (List<CartItem>)cart;
                

            }
            return View(list);
        }


        [HttpGet]
        public ActionResult Payment()
        {

            var cart = Session[CartSession];
            var list = new List<CartItem>();
            if (cart != null)
            {
                list = (List<CartItem>)cart;
            }
            return View(list);
        }

        [HttpPost]
        public ActionResult Payment(string name, string phone, string address, string email)
        {
            var tran = new Transaction();
            tran.userName = name;
            tran.userPhone = phone;
            tran.userAddress = address;
            tran.userMail = email;

            try
            {
                var id = new TransactionDao().Insert(tran);
                var cart = (List<CartItem>)Session[CartSession];
                var orderDao = new OrderDao();
                foreach (var item in cart)
                {
                    var order = new Oder();
                    order.productId = item.Product.productId;
                    order.tranId = id;
                    order.price = item.Product.price;
                    order.quatity = item.Quantity;
                    order.size = item.Size;
                    order.createDay = DateTime.Now;
                    orderDao.Insert(order);

                }
            }
            catch(Exception ex)
            {
                return Redirect("/loi-thanh-toan");
            }

           
            return Redirect("/hoan-thanh");
        }
        
           
        public ActionResult Success()
        {


            return View();
        }

        




        public JsonResult DeleteAll()
        {
            Session[CartSession] = null;
            return Json(new
            {
                status = true
            });
        }


        public JsonResult Delete(int id)
        {
            var sessionCart = (List<CartItem>)Session[CartSession];
            sessionCart.RemoveAll(x => x.Product.productId == id);
            Session[CartSession] = sessionCart;
            return Json(new
            {
                status = true
            });
        }

      






        public JsonResult Update(string cartModel)
        {
            var jsonCart = new JavaScriptSerializer().Deserialize<List<CartItem>>(cartModel);
            var sessionCart =(List<CartItem>) Session[CartSession];


            foreach(var item in sessionCart){
                var jsonItem = jsonCart.SingleOrDefault(x => x.Product.productId == item.Product.productId);
                if (jsonItem != null)
                {
                    item.Quantity = jsonItem.Quantity;
                    item.Size = jsonItem.Size;
                }
                
            }
            Session[CartSession] = sessionCart;
            return Json(new
            {
                status = true
            });
        }

        public ActionResult AddItem(int productId,int size, int quantity)
        {

            var product = new ProductDao().ViewDetail(productId);

            var cart = Session[CartSession];
            if (cart != null)
            {
                var list = (List<CartItem>)cart;
                if (list.Exists(x => x.Product.productId == productId))
                {
                    foreach (var item in list)
                    {
                        if (item.Product.productId == productId)
                        {
                            item.Quantity += quantity;
                        }
                    }
                }
                else
                {
                    var item = new CartItem();
                    item.Product = product;
                    item.Size = size;
                    item.Quantity = quantity;

                    list.Add(item);
                }
                Session[CartSession] = list;
            }

            else
            {
                var item = new CartItem();
                item.Product = product;
                item.Size = size;
                item.Quantity = quantity;
                var list = new List<CartItem>();
                list.Add(item);
                Session[CartSession] = list;
            }


            return RedirectToAction("Index");
        }

        //public ActionResult AddItem(int productId, int quantity)
        //{
        //    var product = new ProductDao().ViewDetail(productId);
        //    var cart = Session[CartSession];
        //    if (cart != null)
        //    {
        //        var list = (List<CartItem>)cart;
        //        if (list.Exists(x => x.Product.productId == productId))
        //        {
        //            foreach (var item in list)
        //            {
        //                if (item.Product.productId == productId)
        //                {
        //                    item.Quantity += quantity;
        //                }
        //            }
        //        }
        //        else
        //        {
        //            var item = new CartItem();
        //            item.Product = product;
        //            item.Quantity = quantity;

        //            list.Add(item);
        //        }
        //        Session[CartSession] = list;
        //    }

        //    else
        //    {
        //        var item = new CartItem();
        //        item.Product = product;
        //        item.Quantity = quantity;
        //        var list = new List<CartItem>();

        //        list.Add(item);
        //        Session[CartSession] = list;
        //    }


        //    return RedirectToAction("Index");
        //}

        


    }
}
