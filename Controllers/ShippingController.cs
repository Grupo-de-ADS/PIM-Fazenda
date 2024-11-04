using GerenciamentosCrud.Data;
using GerenciamentosCrud.Models;
using Microsoft.AspNetCore.Mvc;

namespace GerenciamentosCrud.Controllers
{
    public class ShippingController : Controller
    {
        readonly private ApplicationDbContext _db;

        public ShippingController(ApplicationDbContext db)
        {
            _db = db;

        }

        public IActionResult Index()
        {
            IEnumerable<ShippingModels> shipping = _db.Shipping;

            return View(shipping);
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

            ShippingModels shipping = _db.Shipping.FirstOrDefault(x => x.sp_id == id);

            if (shipping == null)
            {
                return NotFound();
            }

            return View(shipping);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            ShippingModels shipping = _db.Shipping.FirstOrDefault(x => x.sp_id == id);

            if (shipping == null)
            {
                return NotFound();
            }

            return View(shipping);
        }

        [HttpPost]
        public IActionResult Create(ShippingModels shipping)
        {
            if (ModelState.IsValid)
            {
                _db.Shipping.Add(shipping);
                _db.SaveChanges();

                TempData["MensagemSucesso"] = "Cadastro Realizado com sucesso!";

                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpPost]
        public IActionResult Edit(ShippingModels shipping)
        {
            if (ModelState.IsValid)
            {
                _db.Shipping.Update(shipping);
                _db.SaveChanges();

                TempData["MensagemSucesso"] = "Edição Realizado com sucesso!";

                return RedirectToAction("Index");
            }

            return View(shipping);
        }

        [HttpPost]
        public IActionResult Delete(ShippingModels shipping)
        {
            if (shipping == null)
            {
                return NotFound();
            }

            _db.Shipping.Remove(shipping);
            _db.SaveChanges();

            TempData["MensagemSucesso"] = "Exclusão Realizado com sucesso!";

            return RedirectToAction("Index");
        }
    }
}
