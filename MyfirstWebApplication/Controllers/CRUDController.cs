using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyfirstWebApplication.Controllers
{
    public class CRUDController : Controller
    {
        List<Book> Libros;
        //public CRUDController(){
        //    new Book
        //    {
        //        Id = ViewBag.Data['Name']
        //    };
        //}
        // GET: CRUD
        public ActionResult Index()
        {
            return View();
        }

        // GET: CRUD/Details/5
        public ActionResult Details(int id)
        {
            ViewBag.Datos = Libros[id];
            return View();
        }

        // GET: CRUD/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CRUD/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                ViewBag.Data = collection;
                for (int i = 0; i <= ViewBag.Data.length(); i++) {

                    new Book()
                    {
                        Id = i,
                        Name = ViewBag.Data["Name"],
                        Author = ViewBag.Data["Author"],
                        Actors = ViewBag.Data["Actors"],
                        Synopsis = ViewBag.Data["Synopsis"],
                        year = ViewBag.Data["year"]
                    };
                }
                //return RedirectToAction("Index");
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: CRUD/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CRUD/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CRUD/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CRUD/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }

    public class Book { 
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Actors { get; set; }
        public int year { get; set; }
        public string Synopsis { get; set; }
    }
}
