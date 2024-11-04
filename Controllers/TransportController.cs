using GerenciamentosCrud.Data;
using GerenciamentosCrud.Models;
using Microsoft.AspNetCore.Mvc;

namespace GerenciamentosCrud.Controllers
{
    public class TransportController : Controller
    {
        readonly private ApplicationDbContext _db;

        public TransportController(ApplicationDbContext db)
        {
            _db = db;

        }
        public IActionResult Index()
        {
            IEnumerable<TransportModels> transport = _db.Transport;

            return View(transport);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            TransportModels transport = _db.Transport.FirstOrDefault(x => x.tp_id == id);

            if (transport == null)
            {
                return NotFound();
            }

            return View(transport);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            
            if (id == null || id == 0)
            {
                return NotFound();
            }

            TransportModels transport = _db.Transport.FirstOrDefault(x => x.tp_id == id);

            if (transport == null)
            {
                return NotFound();
            }

            return View(transport);
        }

        [HttpPost]
        public IActionResult Create(TransportModels transport)
        {
            if (ModelState.IsValid)
            {
                _db.Transport.Add(transport);
                _db.SaveChanges();

                TempData["MensagemSucesso"] = "Cadastro Realizado com sucesso!";

                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpPost]
        public IActionResult Edit(TransportModels transport)
        {
            if (ModelState.IsValid)
            {
                _db.Transport.Update(transport);
                _db.SaveChanges();

                TempData["MensagemSucesso"] = "Edição Realizado com sucesso!";

                return RedirectToAction("Index");
            }

            return View(transport);
        }

        [HttpPost]
        public IActionResult Delete(TransportModels transport)
        {
            if (transport == null)
            {
                return NotFound();
            }

            _db.Transport.Remove(transport);
            _db.SaveChanges();

            TempData["MensagemSucesso"] = "Exclusão Realizado com sucesso!";

            return RedirectToAction("Index");
        }
    }
}

