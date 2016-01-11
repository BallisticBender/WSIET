using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WSIET.Models;

namespace WSIET.Controllers
{
    public class VisitsController : Controller
    {
        // GET: Visits
        public ActionResult Index()
        {
            var ctx = new VisitsContext();
            return View(ctx.Visits);
        }


        // GET: Visits/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Visits/Create
        [HttpPost]
        public ActionResult Create(VisitModel model)
        {
            var ctx = new VisitsContext();
            try
            {
                ctx.Visits.Add(model);
                ctx.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Visits/Edit/5
        public ActionResult Edit(int id)
        {
            var ctx = new VisitsContext();
            return View(ctx.Visits.FirstOrDefault(v => v.VisitId == id));
        }

        // POST: Visits/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, VisitModel model)
        {
            try
            {
                // TODO: Add update logic here
                var ctx = new VisitsContext();
                ctx.Visits.Remove(ctx.Visits.FirstOrDefault(v => v.VisitId == id));
                ctx.Visits.Add(model);
                ctx.SaveChanges();

                return Edit(id);
            }
            catch
            {
                return RedirectToAction("Index");

            }
        }

        // GET: Visits/Delete/5
        public ActionResult Delete(int id)
        {
            var ctx = new VisitsContext();
            ctx.Visits.Remove(ctx.Visits.FirstOrDefault(v => v.VisitId == id));
            ctx.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
