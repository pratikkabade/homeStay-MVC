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
    public class RoomsController : Controller
    {
        private RoomContext db = new RoomContext();

        // GET: Admins
        public ActionResult Index()
        {
            return View(db.Admins.ToList());
        }


        // GET: Admins
        public ActionResult Filter()
        {
            return View(db.Admins.ToList());
        }


        // GET: Admins
        public ActionResult Star5()
        {
            return View(db.Admins.ToList());
        }

        // GET: Admins
        public ActionResult Star4()
        {
            return View(db.Admins.ToList());
        }


        // GET: Admins/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Admin admin = db.Admins.Find(id);
            if (admin == null)
            {
                return HttpNotFound();
            }
            return View(admin);
        }


    }
}
