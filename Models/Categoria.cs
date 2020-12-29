using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EstudoMVC.Models
{
    public class Categoria
    {
        public int id{ get; set; }
        
        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "O campo descrição é obrigatório")]
        public string description { get; set; }
         public List<Produto> produtos { get; set; }
    }
}