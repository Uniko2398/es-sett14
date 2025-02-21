using System.Security.AccessControl;
using Microsoft.AspNetCore.Mvc;

using es_sett14.Models;

namespace es_sett14.Controllers
{
    public class ProdottoController : Controller
    {
        private static List<Prodotto> prodotti = new List<Prodotto>
        {

            new Prodotto { Id = 1 ,
                Name = "Air Force one" ,
                Prezzo = 129.00,
                Description= "Scarpe Bianche classiche" ,
                ImmagineCopertina = "airforce.jpg"},

            new Prodotto { Id = 2 ,
                Name = "Balenciaga" ,
                Prezzo = 460.00 ,
                ImmagineCopertina = "balenciaga.jpg"},

            new Prodotto { Id = 3 ,
                Name = "Yeezy" ,
                Prezzo = 280.00 ,
                Description = "Scarpe prodotte da Kanye West",
                ImmagineCopertina = "yeezy.jpg"},

            new Prodotto { Id = 4,Name = "Air Jordan 4",
                Prezzo = 340.00 ,
                Description = "Scarpe prodotte da Micheal Jordan" ,
                ImmagineCopertina = "airjorda.jpg"},
        };
        public IActionResult Home()
        {
            var productsList = new ProdottoViewModel()
            {
                Prodotto = prodotti
            };

            return View(productsList);
        }

        public IActionResult Dettaglio(int id)
        {
            var prodotto = prodotti.FirstOrDefault(p => p.Id == id);
            if (prodotto == null)
            {
                return NotFound();
            }
            return View(prodotto);
        }
    }
}
