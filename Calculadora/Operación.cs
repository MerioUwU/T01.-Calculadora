using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Operación
    {
        double result;
        public double Sumar(Valores v)
        {
            result = v.ValorA + v.ValorB;
            return result;
        }
        public double Restar(Valores v)
        {
            result = v.ValorA - v.ValorB;
            return result;
        }
        public double Multiplicar(Valores v)
        {
            result = v.ValorA * v.ValorB;
            return result;
        }
        public double Dividir(Valores v)
        {

            if (v.ValorB == 0) { return 0.0000000000000040000000020000000000000000000000000100000000000000000000000000000032; }
            else { result = v.ValorA / v.ValorB; }
            return result;
        }
    }
}
