using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCoreApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace EFCoreApplication.Controllers
{
    public class ProductController : Controller
    {
        private readonly DeloitteDBContext _contex;

        public ProductController(DeloitteDBContext context)
        {
            this._contex = context;
        }
        public IActionResult Index()
        {
            return View(_contex.Product.ToList());
        }

        public IActionResult Edit(int id)
        {
            var thisProduct = _contex.Product.Where(x => x.Id == id).SingleOrDefault();
            return View(thisProduct);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int? id, [Bind("Id", "ProductName", "LaunchDate", "Category", "Price")] Product product)
        {
            if (id == null)
            {
                return NotFound();
            }
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            var thisProduct = _contex.Product.Where(x => x.Id == id).SingleOrDefault();
            return View(thisProduct);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int? id, [Bind("Id", "ProductName", "LaunchDate", "Category", "Price")] Product product)
        {
            if (id == null)
            {
                return NotFound();
            }
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int id)
        {
            var thisProduct = _contex.Product.Where(x => x.Id == id).SingleOrDefault();
            return View(thisProduct);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Details(int? id, [Bind("Id", "ProductName", "LaunchDate", "Category", "Price")] Product product)
        {
            if (id == null)
            {
                return NotFound();
            }
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            return RedirectToAction(nameof(Index));
        }

    }
}