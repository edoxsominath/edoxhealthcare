using System.Globalization;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using MCMD.ViewModel.Administration;
using MCMD.EntityModel.Administration;

namespace MCMD.Web.Controllers.Administration
{
    public class CreateUserController : Controller
    {
        // GET: CreateUser
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {


            return View();
        }
    }
}