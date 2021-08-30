
using ApiAspNetCore.Model;
using System.Collections.Generic;

namespace ApiAspNetCore.ProduitData
{
    public class ImplProduit : IProduitData
    {
        public Produit AddProduit(Produit produit)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteProduit(Produit produit)
        {
            throw new System.NotImplementedException();
        }

        public Produit EditProduit(Produit produit)
        {
            throw new System.NotImplementedException();
        }

        public Produit GetProduit(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Produit> GetProduits()
        {
            List<Produit> produits = new List<Produit>();
            /*using (DBModel dc = new DBModel())*/
            Produit p = new Produit();
            p.idProduit = 1;
            p.Libelle = "Lait";
            p.Description = "Lait en poudre";
            produits.Add(p);

            Produit p1 = new Produit();
            p1.idProduit = 1;
            p1.Libelle = "Lait";
            p1.Description = "Lait en poudre";
            produits.Add(p1);


            return produits;
        }
    }
}
