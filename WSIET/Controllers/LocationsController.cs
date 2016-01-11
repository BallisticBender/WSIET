using System.Data.Entity;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Web.Mvc;
using Microsoft.Owin.Security;
using WSIET.Models;

namespace WSIET.Controllers
{
    public class LocationsController : Controller
    {
        public ActionResult Index()
        {
            var ctx = new VisitsContext();
            // grab and return all Locations
            return View(ctx.Locations);
        }

        public ActionResult Edit(int id)
        {
            var ctx = new VisitsContext();
            return View("Edit", ctx.Locations.FirstOrDefault(loc => loc.LocationId == id));
        }

        [HttpPost]
        public ActionResult Edit(LocationModel model)
        {
            var ctx = new VisitsContext();

            ctx.Locations.Remove(ctx.Locations.FirstOrDefault(loc => loc.LocationId == model.LocationId));
            ctx.Locations.Add(model);

            ctx.SaveChanges();

            return Edit(model.LocationId);
        }

        public ActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
        public ActionResult Create(LocationModel model)
        {
            var ctx = new VisitsContext();
            ctx.Locations.Add(model);
            ctx.SaveChanges();
            return View("Index", ctx.Locations);
        }

        public ActionResult Delete(int id)
        {
            var ctx = new VisitsContext();
            ctx.Locations.Remove(ctx.Locations.FirstOrDefault(loc => loc.LocationId == id));
            ctx.SaveChanges();
            return View("Index", ctx.Locations);
        }
    }
}