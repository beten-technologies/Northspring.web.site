using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Northspring.Web.Site.Business;

namespace Northspring.Web.Site.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Pages(string id)
        {
            Pages PageCreator = new Pages();
            string pageName = (id != null) ? id.ToString() : "";
            string actionName = "Pages";

            if (!string.IsNullOrEmpty(pageName))
                ViewBag.Title = pageName;
            else
                ViewBag.Title = "Page";

            string partialPage = PageCreator.GetDynamicPageName(pageName, action: actionName);

            ViewEngineResult result = ViewEngines.Engines.FindPartialView(ControllerContext, partialPage);

            if (result.View != null)
                ViewBag.PartialPage = partialPage;
            else
                ViewBag.PartialPage = PageCreator.GetDefaultPageName();

            return View();
        }

        public ActionResult Details(string id)
        {
            Pages PageCreator = new Pages();
            string pageName = (id != null) ? id.ToString() : "";
            string actionName = "Details";

            if (!string.IsNullOrEmpty(pageName))
                ViewBag.Title = pageName;
            else
                ViewBag.Title = "Page";

            string partialPage = PageCreator.GetDynamicPageName(pageName, action: actionName);

            ViewEngineResult result = ViewEngines.Engines.FindPartialView(ControllerContext, partialPage);

            if (result.View != null)
                ViewBag.PartialPage = partialPage;
            else
                ViewBag.PartialPage = PageCreator.GetDefaultPageName();

            return View();
        }
    }
}