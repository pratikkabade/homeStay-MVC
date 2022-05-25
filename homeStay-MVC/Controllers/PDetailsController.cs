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
    public class PDetailsController : Controller
    {
        private PDetailsContext db = new PDetailsContext();

        // GET: Owners
        public ActionResult Index()
        {
            return View(db.PDetail.ToList());
        }


        // GET: Owners/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Owners/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PersonID,FirstName,LastName,DoB,Gender,ContactNumber,Email,UserCategory")] PDetails pDetails)
        {
            if (ModelState.IsValid)
            {
                db.PDetail.Add(pDetails);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pDetails);
        }
    }
}
