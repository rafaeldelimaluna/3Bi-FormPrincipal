﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Produto
    {
        public int Id { get; set; }
        public int Nome { get; set; }
        
        public decimal Preco { get; set; }
        public int CategoriaId { get; set; }

        public Categoria? Categoria { get; set; }
    }
}
