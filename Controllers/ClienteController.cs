using System.Linq;
using Microsoft.AspNetCore.Mvc;
using vidibr.Models;
using vidibr.VidiDataContext;

namespace vidibr.Controllers
{
    public class ClienteController : Controller
    {
        private readonly AppDataContext context;

        public ClienteController(AppDataContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var clientes = context.VidiBR.ToList();
            return View(clientes);
        }

        [HttpGet]
        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(Cliente model)
        {
            if(!ModelState.IsValid) return View(model);
            context.Add(model);
            context.SaveChanges();
            return RedirectToAction("index");
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            var cliente = context.VidiBR.Find(id);
            return View(cliente);
        }

        [HttpPost]
        public IActionResult Editar(Cliente model)
        {
            if(!ModelState.IsValid) return View(model);
            context.VidiBR.Update(model);
            context.SaveChanges();
            return RedirectToAction("index");
        }


        [HttpGet]
        public IActionResult Apagar(int id)
        {
            var cliente = context.VidiBR.Find(id);
            context.VidiBR.Remove(cliente);
            context.SaveChanges();
            return RedirectToAction("index");
        }
    }
}