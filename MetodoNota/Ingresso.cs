using System;
using System.Collections.Generic;
using System.Text;

namespace MetodoNota
{
    class Ingresso
    {
        private double Valor { get; set; }
        public Ingresso(double v)
        {
            Valor = v;
        }
        public override string ToString()
        {
            return $"O valor do ingresso é: {Valor}";
        }
    }
}
