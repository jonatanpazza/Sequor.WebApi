using Sequor.ApplicationService.LES.Interfaces.Cadastro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sequor.WebMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly IClienteAppService _clienteApp;
        private readonly IWSQOLRECEBIMENTOFOLHAROSTOAppService _FolhaRostoApp;


        public HomeController(IClienteAppService clienteApp, IWSQOLRECEBIMENTOFOLHAROSTOAppService folhaRosto)
        {
            _clienteApp = clienteApp;
            _FolhaRostoApp = folhaRosto;
        }

        public HomeController()
        {
        }

        public ActionResult Index()
        {
            //using (StaraContext staraContext = new StaraContext())
            //{
            //    var teste = staraContext.Clientes.FirstOrDefault();
            //}

            //var clientes = _clienteApp.GetAll();

            var folhasRostoInspecionadas = _FolhaRostoApp.GetFolhaRostoInspecionadas(); //.GetAll().Where(P => P.STATUS == 80);

            var folhasRosto = _FolhaRostoApp.GetAll().Where(P => P.STATUS == 80);

            //var cliente1 = _clienteApp.GetById(1);

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}