using MatheusinAppWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Security.Cryptography.X509Certificates;

namespace MatheusinAppWeb.Controllers
{
    public class ClienteController : Controller
    {
        public static List<ClienteModel> lista = new List<ClienteModel>();
        
        public IActionResult Lista()
        {
            return View(lista);
        }
        public IActionResult Cadastro()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SalvarDados(ClienteModel model)
        {
            if (model.Id > 0)
            {
                int indice = lista.FindIndex(a => a.Id == model.Id);
                lista[indice] = model;
            }
            else
            {
                Random random = new Random();
                model.Id = random.Next(1, 99999);
                lista.Add(model);
            }
            return RedirectToAction("Lista");
        }



        
        public IActionResult Editar(int id)
        {
            ClienteModel cliente = lista.Find(a => a.Id == id);
            if (cliente != null)
            {
                return View(cliente);
            }
            else
            {
                return RedirectToAction("Lista");
            }
        }
        public IActionResult Excluir(int id)
        {
            ClienteModel cliente = lista.Find(a => a.Id == id);
            if (cliente != null)
            {
                lista.Remove(cliente);
            }
            return RedirectToAction("Lista"); 
        }
        public IActionResult Compras(int id)
        {
            return View();
        }
    }
}
