using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using homeStay_MVC.DAL;
using homeStay_MVC.Models;

namespace homeStay_MVC.Controllers
{
    public class InfoController : Controller
    {
        private InfoContext db = new InfoContext();

        // GET: Infos
        public ActionResult Index()
        {
            return View(db.Infos.ToList());
        }


        // GET: Infos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Info info = db.Infos.Find(id);
            if (info == null)
            {
                return HttpNotFound();
            }
            return View(info);
        }

        // GET: Infos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Infos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PersonID,FirstName,LastName,DoB,Gender,ContactNumber,Email,UserCategory")] Info info)
        {
            if (ModelState.IsValid)
            {
                db.Infos.Add(info);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(info);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
