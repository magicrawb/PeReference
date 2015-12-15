using MiracleMachine.data;
using MiracleMachine.data.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiracleMachine.Controllers
{
    public class NewTrickController : Controller
    {
        private ApplicationDbContext _db = new ApplicationDbContext();

        // GET: NewTrick
        public ActionResult Index()
        {
            return View();
        }

        // GET: NewTrick/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NewTrick/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NewTrick/Create
        [HttpPost]
        public ActionResult Create(IList<Prop> UserProps)
        {
            try
            {
                // Start by adding the props in UserPropList to the USERS prop
                // collection. This collection will be used for 'auto-fill' option
                // when the user is creating the UserProps
                PropsController pc = new PropsController();
                foreach (Prop prop in UserProps)
                {
                    prop.PropName.ToLower();
                    pc.Create(prop);
                }

                NewTrick t = new NewTrick();
                Random rndTheory = new Random();
                Random rndProp1 = new Random();
                Random rndProp2 = new Random();
                int theoryId = rndTheory.Next(0, 8);

                t.Theory = _db.Theories.Where(m => m.TheoryId == theoryId).FirstOrDefault();
                var TwoProps = new List<string>() { "Penetration", "Transformation" };

                // This chooses TWO props and adds to the prop collection if the 
                // theory is either of the two in the TwoProps list. 
                if (TwoProps.Contains(t.Theory.TheoryName))
                {
                    int prop1 = rndProp1.Next(0, 10);
                    int prop2 = rndProp2.Next(0, 10);
                    if (prop2 == prop1)
                    {
                        while (prop2 == prop1)
                        {
                            prop2 = rndProp2.Next(0, 10);
                        }
                    }

                    t.Props.Add(UserProps[prop1]);
                    t.Props.Add(UserProps[prop2]);

                    t.TrickName = t.Theory.TheoryName + " / " + prop1 + " + " + prop2;
                }
                // This chooses only one prop for any other theory 
                // and adds it to the prop collection. 
                else
                {
                    int prop1 = rndProp1.Next(0, 10);
                    t.Props.Add(UserProps[prop1]);
                    t.TrickName = t.Theory.TheoryName + " / " + prop1;
                }

                _db.NewTricks.Add(t);
                
                return View(t);
            }
            catch
            {
                return View();
            }
        }

        // GET: NewTrick/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NewTrick/Edit/5
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

        // GET: NewTrick/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NewTrick/Delete/5
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
