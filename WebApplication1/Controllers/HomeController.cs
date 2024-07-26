using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = GetRequestsFromSession();
            return View(model);
        }

        [HttpPost]
        public ActionResult Create(RequestFrom model)
        {
            var requests = GetRequestsFromSession();
            requests.Add(model);
            SaveRequestsToSession(requests);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Edit(int index)
        {
            var requests = GetRequestsFromSession();
            var model = requests[index];
            ViewBag.Index = index;
            return View("Index", requests);
        }

        [HttpPost]
        public ActionResult Update(RequestFrom model, int index)
        {
            var requests = GetRequestsFromSession();
            requests[index] = model;
            SaveRequestsToSession(requests);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Delete(int index)
        {
            var requests = GetRequestsFromSession();
            requests.RemoveAt(index);
            SaveRequestsToSession(requests);
            return RedirectToAction("Index");
        }

        private List<RequestFrom> GetRequestsFromSession()
        {
            return Session["Requests"] as List<RequestFrom> ?? new List<RequestFrom>();
        }

        private void SaveRequestsToSession(List<RequestFrom> requests)
        {
            Session["Requests"] = requests;
        }
    }


}
