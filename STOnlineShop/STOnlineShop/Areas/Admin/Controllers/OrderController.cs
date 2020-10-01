using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.Dao;
using Model.EF;

namespace STOnlineShop.Areas.Admin.Controllers
{
    public class OrderController : Controller
    {
        // GET: Admin/Order
        public ActionResult Index()
        {
            var dao = new OrderDao();
            var list = dao.ListAll();
            return View(list);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var order = new OrderDao().ViewDetail(id);
            return View(order);
        }

        [HttpPost]
        public ActionResult Edit(Oder order)
        {
            if (ModelState.IsValid)
            {
                var dao = new OrderDao();
                var result = dao.Update(order);

                if (result)
                {
                    return RedirectToAction("Index", "Order");

                }
                else
                {
                    ModelState.AddModelError("", "Cập sản phẩm không thành công!!!");
                }
            }
            return View("Index");
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            new OrderDao().Delete(id);

            return RedirectToAction("Index");
        }
    }
}