using ApiAspNetCore.Model;
using System.Collections.Generic;

namespace ApiAspNetCore.ProduitData
{
    public interface IProduitData
    {
        List<Produit> GetProduits();
        Produit GetProduit(int id);
        Produit AddProduit(Produit produit);
        void DeleteProduit(Produit produit);
        Produit EditProduit(Produit produit);
    }
}
