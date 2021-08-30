using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiAspNetCore.Model
{
    public class Produit
    {
        [Key]
        public int idProduit { get; set; }

        [Display(Name = "Libelle"), MaxLength(80, ErrorMessage = "Taille maximal 80"), Required(ErrorMessage = "*")]
        public string Libelle { get; set; }

        [Display(Name = "Description"), MaxLength(200, ErrorMessage = "Taille maximal 80"), Required(ErrorMessage = "*")]
        public string Description { get; set; }

        [Display(Name = "Prix Unitaire"), Required(ErrorMessage = "*")]
        public int PU { get; set; }

        [Display(Name = "Quantité"), Required(ErrorMessage = "*")]
        public double QteStock { get; set; }

        [Display(Name = "Date de péremption"), DataType(DataType.DateTime), Required(ErrorMessage = "*")]
        public DateTime DatePeremption { get; set; }

    }
}
