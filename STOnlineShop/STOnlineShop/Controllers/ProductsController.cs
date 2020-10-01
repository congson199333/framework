using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.Dao;
using PagedList;
using Model.ViewModel;

namespace STOnlineShop.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Product
        public ActionResult Shop(int page = 1, int pageSize = 6)
        {
            var dao = new ProductDao();
            var model = dao.ListAll(page, pageSize);
            return View(model);
        }

        public ActionResult  Detail(int productId)
        {
            var product = new ProductDao().ViewDetail(productId);
            
            return View(product);
        }

        public ActionResult Sale(int page = 1, int pageSize = 6)
        {
            var dao = new ProductDao();
            var model = dao.ListSale(page, pageSize);
            return View(model);
        }
        public ActionResult brand1(int page = 1, int pageSize = 6)
        {
            var dao = new ProductDao();
            var model = dao.ListProduct1(page, pageSize);
            return View(model);
        }

        public ActionResult brand2(int page = 1, int pageSize = 6)
        {
            var dao = new ProductDao();
            var model = dao.ListProduct2(page, pageSize);
            return View(model);
        }

        public ActionResult brand3(int page = 1, int pageSize = 6)
        {
            var dao = new ProductDao();
            var model = dao.ListProduct3(page, pageSize);
            return View(model);
        }


    }



}