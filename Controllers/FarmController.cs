using GerenciamentosCrud.Data;
using GerenciamentosCrud.Models;
using Microsoft.AspNetCore.Mvc;

namespace GerenciamentosCrud.Controllers
{
    public class FarmController : Controller
    {
        readonly private ApplicationDbContext _db;

        public FarmController(ApplicationDbContext db)
        {
            _db = db;

        }

        public IActionResult Index()
        {
            IEnumerable<FarmModels> farm = _db.Farm;

            return View(farm);
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

            FarmModels farm = _db.Farm.FirstOrDefault(x => x.farm_id == id);

            if (farm == null)
            {
                return NotFound();
            }

            return View(farm);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            FarmModels farm = _db.Farm.FirstOrDefault(x => x.farm_id == id);

            if (farm == null)
            {
                return NotFound();
            }

            return View(farm);
        }

        [HttpPost]
        public IActionResult Create(FarmModels farm)
        {
            if (ModelState.IsValid)
            {
                _db.Farm.Add(farm);
                _db.SaveChanges();

                TempData["MensagemSucesso"] = "Cadastro Realizado com sucesso!";

                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpPost]
        public IActionResult Edit(FarmModels farm)
        {
            if (ModelState.IsValid)
            {
                _db.Farm.Update(farm);
                _db.SaveChanges();

                TempData["MensagemSucesso"] = "Edição Realizado com sucesso!";

                return RedirectToAction("Index");
            }

            return View(farm);
        }

        [HttpPost]
        public IActionResult Delete(FarmModels farm)
        {
            if (farm == null)
            {
                return NotFound();
            }

            _db.Farm.Remove(farm);
            _db.SaveChanges();

            TempData["MensagemSucesso"] = "Exclusão Realizado com sucesso!";

            return RedirectToAction("Index");
        }
    }
}
