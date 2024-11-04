using GerenciamentosCrud.Data;
using GerenciamentosCrud.Models;
using Microsoft.AspNetCore.Mvc;

namespace GerenciamentosCrud.Controllers
{
    public class CustomerController : Controller
    {
        readonly private ApplicationDbContext _db;

        public CustomerController(ApplicationDbContext db)
        {
            _db = db;

        }

        public IActionResult Index()
        {
            IEnumerable<CustomerModels> customer = _db.Customer;

            return View(customer);
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

            CustomerModels customer = _db.Customer.FirstOrDefault(x => x.customer_id == id);

            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            CustomerModels customer = _db.Customer.FirstOrDefault(x => x.customer_id == id);

            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        [HttpPost]
        public IActionResult Create(CustomerModels costumer)
        {
            if (ModelState.IsValid)
            {
                _db.Customer.Add(costumer);
                _db.SaveChanges();

                TempData["MensagemSucesso"] = "Cadastro Realizado com sucesso!";

                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpPost]
        public IActionResult Edit(CustomerModels customer)
        {
            if (ModelState.IsValid)
            {
                _db.Customer.Update(customer);
                _db.SaveChanges();

                TempData["MensagemSucesso"] = "Edição Realizado com sucesso!";

                return RedirectToAction("Index");
            }

            return View(customer);
        }

        [HttpPost]
        public IActionResult Delete(CustomerModels customer)
        {
            if (customer == null)
            {
                return NotFound();
            }

            _db.Customer.Remove(customer);
            _db.SaveChanges();

            TempData["MensagemSucesso"] = "Exclusão Realizado com sucesso!";

            return RedirectToAction("Index");
        }
    }
}
