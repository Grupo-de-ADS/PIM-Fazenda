using GerenciamentosCrud.Data;
using GerenciamentosCrud.Models;
using Microsoft.AspNetCore.Mvc;

namespace GerenciamentosCrud.Controllers
{
    public class ProdutosController : Controller
    {
        readonly private ApplicationDbContext _db;

        public ProdutosController(ApplicationDbContext db) 
        {
            _db = db;
        
        }
        public IActionResult Index()
        {
            IEnumerable<ProdutosModels> produtos= _db.Produtos;

            return View(produtos);
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

            ProdutosModels produtos = _db.Produtos.FirstOrDefault(x => x.Id == id);

            if (produtos == null)
            {
                return NotFound();
            }

            return View(produtos);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            ProdutosModels produtos = _db.Produtos.FirstOrDefault(x => x.Id == id);

            if (produtos == null)
            {
                return NotFound();
            }

            return View(produtos);
        }

        [HttpPost]
        public IActionResult Create(ProdutosModels produtos)
        {
            if(ModelState.IsValid)
            {
                _db.Produtos.Add(produtos);
                _db.SaveChanges();

                TempData["MensagemSucesso"] = "Cadastro Realizado com sucesso!";

                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpPost]
        public IActionResult Edit(ProdutosModels produtos)
        {
            if (ModelState.IsValid)
            {
                _db.Produtos.Update(produtos);
                _db.SaveChanges();

                TempData["MensagemSucesso"] = "Edição Realizado com sucesso!";

                return RedirectToAction("Index");
            }

            return View(produtos);
        }

        [HttpPost]
        public IActionResult Delete(ProdutosModels produtos)
        {
            if(produtos == null)
            {
                return NotFound(); 
            }

            _db.Produtos.Remove(produtos);
            _db.SaveChanges();

            TempData["MensagemSucesso"] = "Exclusão Realizado com sucesso!";

            return RedirectToAction("Index");
        }
    }
}
