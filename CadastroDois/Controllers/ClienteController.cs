using CadastroDois.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.WebEncoders.Testing;

namespace CadastroDois.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            List<ClienteModel> cliente = new List<ClienteModel>();

            cliente.Id = 1;
            cliente.Nome = "Nome do Cliente";
            cliente.Email = "cliente@email.com";

            return View(cliente);
        }
    }
}
