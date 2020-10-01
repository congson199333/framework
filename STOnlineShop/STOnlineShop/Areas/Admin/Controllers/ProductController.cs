using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.EF;
using Model.Dao;
using PagedList;
using System.Web.Script.Serialization;
using System.Xml.Linq;

namespace STOnlineShop.Areas.Admin.Controllers
{
    public class ProductController :Controller
    {
        // GET: Admin/Product

        public ActionResult Index(int page=1, int pageSize=5)
        {
            var dao = new ProductDao();
            var model = dao.ListAll(page, pageSize);
          
            return View(model);
        }


        public JsonResult SaveImages(long id,string images)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            var listImages = serializer.Deserialize<List<string>>(images);

            XElement xElement = new XElement("Images");
            foreach(var item in listImages)
            {
                xElement.Add(new XElement("Image", item));

                
            }
            ProductDao dao = new ProductDao();
            try
            {
                dao.UpdateImages(id, xElement.ToString());
                return Json(new
                {
                    status = true
                });
            }
            catch(Exception )
            {
                return Json(new
                {
                    status = false
                });
            }
           

        }
        public JsonResult LoadImages(long id)
        {
            ProductDao dao = new ProductDao();
            var product = dao.ViewDetail(id);
            var images = product.img;
            XElement xImages=XElement.Parse(images);
            List<string> listImagesReturn = new List<string>();
            
            foreach(XElement element in xImages.Elements())
            {
                listImagesReturn.Add(element.Value);
            }
            return Json(new {
                data=listImagesReturn
            },JsonRequestBehavior.AllowGet);

        }
        [HttpDelete]
        public ActionResult Delete(long id)
        {
            new ProductDao().Delete(id);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product Product)
        {
            if (ModelState.IsValid)
            {
                var dao = new ProductDao();
                long id = dao.Insert(Product);
                if (id > 0)
                {
                    return RedirectToAction("Index", "Product");

                }
                else
                {
                    ModelState.AddModelError("", "Thêm sản phẩm không thành công!!!");
                }
            }
            return View("Index");
        }
        public ActionResult Detail()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Edit(long id)
        {
            var product = new ProductDao().ViewDetail(id);
            return View(product);
        }

        [HttpPost]
        public ActionResult Edit(Product Product)
        {
            if (ModelState.IsValid)
            {
                var dao = new ProductDao();
                var result = dao.Update(Product);

                if (result)
                {
                    return RedirectToAction("Index", "Product");

                }
                else
                {
                    ModelState.AddModelError("", "Cập sản phẩm không thành công!!!");
                }
            }
            return View("Index");
        }


    }



}
    

