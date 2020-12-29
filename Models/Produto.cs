using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EstudoMVC.Models
{
    public class Produto
    {
        public int id { get; set; }
        
        [Display(Name = "Descrição")]
        public string description { get; set; }
        
        [Display(Name = "Quantidade")]
        public int qtd { get; set; }

        public int CategoriaID { get; set; }
        public Categoria categoria { get; set; }
    }
}