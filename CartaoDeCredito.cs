using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudandoOOP      //AULA 05 - AGREGAÇÃO
{
    class CartaoDeCredito
    {
        public string Numero { get; set; }
        public string DataDeValidade { get; set; }
        public Cliente Cliente { get; set; }
    }
}
