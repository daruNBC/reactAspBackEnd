using ApiAspNetCore.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiAspNetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProduitsController : ControllerBase
    {

        private readonly ProduitContext _context;

        public ProduitsController(ProduitContext context)
        {
            _context = context;
        }

        // GET: api/<ProduitsController>
        [HttpGet]
        public JsonResult Get()
        {
            return new JsonResult(_context.produits.ToList());
        }

        // GET api/<ProduitsController>/5
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            var produit = _context.produits.Find(id);
            return new JsonResult(produit);
        }

        // POST api/<ProduitsController>
        [HttpPost]
        public JsonResult Post([Bind("Libelle,Description,PU,QteStock,DatePeremption")] Produit produit)
        {
            _context.Add(produit);
            _context.SaveChanges();
            return new JsonResult("produit ajouté");
        }

        // PUT api/<ProduitsController>/5
        [HttpPut("{id}")]
        public JsonResult Edit(int id, [Bind("Libelle,Description,PU,QteStock,DatePeremption")] Produit produit)
        {
            if(id == produit.idProduit)
            {
                _context.Update(produit);
                _context.SaveChanges();
                return new JsonResult("produit modifié");
            }
            else
            {
                return new JsonResult("produit introuvable");
            }
        }

        // DELETE api/<ProduitsController>/5
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            var produit = _context.produits.Find(id);
            _context.produits.Remove(produit);
            _context.SaveChanges();
            return new JsonResult("produit supprimé");
        }


        /*public JsonResult lister(string Libelle, DateTime DatePeremption)
        {
            ArrayList produit = new ArrayList();
            //produit = _context.produits.ToList();
            List<Produit> produits = new List<Produit>();
            produits = produit.Find(e => e.ge == Libelle);

            for (int i = 0; i < produit.Count; i++)
            {
                if (produit[i].Libelle == Libelle && produit[i].DatePeremption == DatePeremption)
                {

                }
            }
            return new JsonResult(produit.ToList());
        }*/
    }
}
