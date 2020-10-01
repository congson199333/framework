using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.Dao;
using STOnlineShop.Areas.Admin.Models;
using STOnlineShop.Common;

namespace STOnlineShop.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        public ActionResult login => View();

        public ActionResult Login(LoginModel model)
        {
           
            if (ModelState.IsValid)
          
            {
                var dao = new adminDao();
                var result = dao.Login(model.AdminName, model.Password);
                if (result)
                {
                    var admin = dao.GetById(model.AdminName);
                    var adminSession = new AdminLogin();
                    adminSession.AdminName = admin.adminName;
                    adminSession.AdminId = admin.adminId;
                    Session.Add(CommonConstants.ADMIN_SESSION,adminSession);
                    return RedirectToAction("Index", "Home");

                }
                else
                {
                    ModelState.AddModelError("", "Đăng nhập thất bại!");

                }

            }
            return View("login");

            

        }
    }
}