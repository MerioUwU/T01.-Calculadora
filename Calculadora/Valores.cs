using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Valores//puede ser plural porque es sólamente para capturar datos
    {
        private double valorA;
        private double valorB;

        public double ValorA { get { return valorA; } set { valorA = value; } }
        public double ValorB { get { return valorB; } set { valorB = value; } }
    }
}
