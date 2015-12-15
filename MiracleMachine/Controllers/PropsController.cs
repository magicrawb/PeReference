using MiracleMachine.data;
using MiracleMachine.data.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiracleMachine.Controllers
{
    public class PropsController : Controller
    {
        private ApplicationDbContext _db = new ApplicationDbContext();

        // GET: Props
        public ActionResult Index()
        {
            return View();
        }

        // GET: Props/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Props/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Props/Create
        [HttpPost]
        public void Create(Prop prop)
        {
            try
            {
                _db.Props.Add(prop);
                _db.SaveChanges();

                return;
            }
            catch
            {
                return;
            }
        }

        // GET: Props/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Props/Edit/5
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

        // GET: Props/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Props/Delete/5
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
}
