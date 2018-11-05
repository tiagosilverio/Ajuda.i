using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ajudai.Modelo;

namespace AjudaiWeb.Controllers
{
    public class DadosClienteController : Controller
    {
        // GET: DadosCliente
        public ActionResult Cadastro()
        {
            Cliente cliente = new Cliente();

            return View();
        }
    }
}