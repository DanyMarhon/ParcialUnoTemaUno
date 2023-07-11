using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcialDanielMarhon
{
    internal class Program
    {
        static void Main(string[] args)
            {
                double radio, altura;
                int cantidadCilindros = 0;

                while (true)
                {
                    Console.WriteLine("Ingrese el radio del cilindro (0 para salir):");
                    if (!double.TryParse(Console.ReadLine(), out radio) || radio < 0)
                    {
                        Console.WriteLine("El valor del radio debe ser un número mayor o igual a cero");
                        continue;
                    }

                    Console.WriteLine("Ingrese la altura del cilindro (0 para salir):");
                    if (!double.TryParse(Console.ReadLine(), out altura) || altura < 0)
                    {
                        Console.WriteLine("El valor de la altura debe ser un número mayor o igual a cero");
                        continue;
                    }

                    if (radio == 0 && altura == 0)
                        break;

                    cantidadCilindros++;

                    double area = CalcularArea(radio, altura);
                    double volumen = CalcularVolumen(radio, altura);
                    double baseCilindro = CalcularBase(radio);

                    Console.WriteLine("El área del cilindro es: " + area);
                    Console.WriteLine("El volumen del cilindro es: " + volumen);
                    Console.WriteLine();
                }

                Console.WriteLine($"Se ingresaron {cantidadCilindros} cilindros.");

                Console.WriteLine("Presione una tecla para salir");
                Console.ReadKey();
            }

            static double CalcularArea(double radio, double altura)
            {
                return 2 * Math.PI * radio * (radio + altura);
            }
            static double CalcularVolumen(double radio, double altura)
            {
                return Math.PI * radio * radio * altura;
            }
            static double CalcularBase(double radio)
            {
                return Math.PI * radio * radio;
            }
        }
    }