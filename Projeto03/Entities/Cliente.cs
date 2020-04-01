using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto03.Entities
{
    public class Cliente
    {
        //prop + 2xtab
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}
