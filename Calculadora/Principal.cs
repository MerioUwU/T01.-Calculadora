using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Principal
    {
        Valores val = new Valores();
        public void Bienvenida()
        {
            Console.WriteLine("Bienvenido al programa, persione cualquier tecla para comenzar a capturar datos");
            Console.ReadKey();
            getvalores();

        }
        public void getvalores()
        {

            Console.WriteLine("Ingrese el valor del primer número: ");
            val.ValorA = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del segundo número: ");
            val.ValorB = double.Parse(Console.ReadLine());
            Console.WriteLine("Valores capturados. Valor 1: {0}, Valor 2:{1}, presione cualquier tecla para acceder al menú", val.ValorA, val.ValorB);
            Console.ReadKey();
            Console.Clear();
            Menu();
        }
        public void Menu()
        {
            Console.WriteLine("Valores a utilizar:\t[{0}]\t-\t[{1}],",val.ValorA,val.ValorB);
            int opc = 0;
            double result;
            Console.WriteLine("Seleccione con un número la operación a realizar:\n1.-Sumar dos números\n2.-Restar dos números\n3.-Multiplicar números\n4.-Dividir números\n5.-Cambiar valores\n6.-Salir");
            opc = int.Parse(Console.ReadLine());
            Operación op = new Operación();
            switch (opc)
            {
                case 1:
                    result = op.Sumar(val);
                    Console.WriteLine("El resultado de la suma es {0}, presione cualquier tecla para volver al menú", result);
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
                case 2:
                    result = op.Restar(val);
                    Console.WriteLine("El resultado de la resta es {0}, presione cualquier tecla para volver al menú", result);
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
                case 3:
                    result = op.Multiplicar(val);
                    Console.WriteLine("El resultado de la multiplicación es {0}, presione cualquier tecla para volver al menú", result);
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
                case 4:
                    result = op.Dividir(val);
                    if (result == 0.0000000000000040000000020000000000000000000000000100000000000000000000000000000032) { Console.WriteLine("INDETERMINADO, presione cualquier tecla para volver al menú"); }
                    else { Console.WriteLine("El resultado de la división es {0}, presione cualquier tecla para volver al menú", result); }
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
                case 5: getvalores(); break;
                case 6: System.Environment.Exit(-1); break;
                default: Console.WriteLine("Seleccione una opción válida, por favor."); Console.ReadKey(); Menu(); break;
            }
        }
    }
}
