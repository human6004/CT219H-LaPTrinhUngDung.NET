using QuanLySach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLySach.Controllers
{
    public class HomeController : Controller
    {
        DBIO db = new DBIO();

        // GET: Home
        public ActionResult Index()
        {
            List<SACH> list = db.getList_SACH();
            return View(list);
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult Create(SACH s)
        {
            db.addObject_SACH(s);
            return RedirectToAction("Index");
        }

        // GET: Home/Edit/id
        public ActionResult Edit(string id)
        {
            SACH s = db.getObject_SACH(id);
            return View(s);
        }

        // POST: Home/Edit
        [HttpPost]
        public ActionResult Edit(SACH s)
        {
            db.editObject_SACH(s);
            return RedirectToAction("Index");
        }

        // GET: Home/Delete/id
        public ActionResult Delete(string id)
        {
            SACH s = db.getObject_SACH(id);
            return View(s);
        }

        // POST: Home/Delete
        [HttpPost]
        public ActionResult Delete(SACH s)
        {
            db.deleteObject_SACH(s);
            return RedirectToAction("Index");
        }

        // GET: Home/Details/id
        //public ActionResult Details(string id)
        //{
        //    SACH s = db.getObject_SACH(id);
        //    return View(s);
        //}
        public ActionResult Details(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return RedirectToAction("Index");
            }

            SACH s = db.getObject_SACH(id);

            if (s == null)
            {
                return HttpNotFound();
            }

            return View(s);
        }
    }
}