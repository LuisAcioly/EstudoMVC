using System;
using System.Collections.Generic;

namespace EstudoMVC.Models
{
    public class Categoria
    {
        public int id{ get; set; }
        public string description { get; set; }

        public List<Produto> produtos { get; set; }
    }
}