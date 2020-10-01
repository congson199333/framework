using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.EF;
using Model.Dao;
using STOnlineShop.Common;

namespace STOnlineShop.Areas.Admin.Controllers
{
    public class AdminUserController : Controller
    {
        // GET: Admin/AdminUser
        public ActionResult Index(AdminUser adminUser)
        {

            var dao = new adminDao();
            var model = dao.ViewDetail(adminUser.adminId);
            return View(model);
            
        }

       

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(AdminUser adminUser)
        {
            if (ModelState.IsValid)
            {
                var dao = new adminDao();
                long id = dao.Insert(adminUser);
                if (id > 0)
                {
                    return RedirectToAction("Index", "AdminUser");

                }
                else
                {
                    ModelState.AddModelError("","Thêm admin không thành công!!!");
                }
            }
            return View("Index");
        }

        public ActionResult Logout()
        {
            Session[CommonConstants.ADMIN_SESSION] = null;
            return Redirect("/Admin/Login/login");
        }


        
    }
}