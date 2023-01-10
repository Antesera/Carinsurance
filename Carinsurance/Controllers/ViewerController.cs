using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Carinsurance.Controllers
{
    public class ViewerController : Controller
    {
        // GET: Viewer
        public ActionResult Add()
        {
            return View();
        }
    }
}