using site5.site5.Business;
using site5.site5.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace site5.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index()
        {
            var biz = new ProductoBiz();
            var model = biz.Listar();
            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Productos model)
        {
            if (!ModelState.IsValid)
                return View();

            try
            {
                var biz = new ProductoBiz();
                biz.Agregar(model);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                /// Que pasa con el error -> Bitacoras
                Console.WriteLine(e);
                return View(model);
            }
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var biz = new ProductoBiz();
            var model = biz.Get(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult Delete(Productos model)
        {
            var biz = new ProductoBiz();
            biz.Eliminar(model);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var biz = new ProductoBiz();
            var model = biz.Get(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(Productos model)
        {
            var biz = new ProductoBiz();
            biz.Update(model);
            return RedirectToAction("Index");
        }
    }
}