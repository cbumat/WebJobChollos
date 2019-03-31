using MvcChollos.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcChollos.Controllers
{
    public class ChollosController : Controller
    {
        RepositoryChollos repo;

        public ChollosController()
        {
            this.repo = new RepositoryChollos();
        }
        public ActionResult Index()
        {
            return View(this.repo.GetChollos());
        }
    }
}