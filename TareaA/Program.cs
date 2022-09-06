using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaA
{
    internal class Program
    {
        public static double dolar = 53.05;
        public static double euro = 52.68;

        static void Main(string[] args)
        {
            int valor;  //Para selecionar la acción del Switch
            string lector; //Para leer el texto en consola

            //Repetición para recorrer cada capítulo.
            do
            {
                Console.WriteLine("\n\n1. Capitulo 1." +
                              "\n2. Capitulo 2." +
                              "\n3. Capitulo 3." +
                              "\n4. Capitulo 4." +
                              "\n5. Salir." +
                              "\nElija una opcion: ");

                lector = LeerSoloNumeros();
                valor = Convert.ToInt32(lector);

                switch (valor)
                {
                    case 1:
                        Capitulo1();
                        break;
                    case 2:
                        Capitulo2();
                        break;
                    case 3:
                        Capitulo3();
                        break;
                    case 4:
                        Capitulo4();
                        break;
                    case 5:
                        Console.WriteLine("\n\nSaliendo...");
                        break;
                    default:
                        Console.WriteLine("\n\nOpcion no encontrada...");
                        break;
                }
            } while (valor != 5);
            //Console.ReadKey();
        }

        static string LeerSoloNumeros()
        {
            double val = 0;
            string numero = "";
            ConsoleKeyInfo chr;
            do
            {
                chr = Console.ReadKey(true);
                if (chr.Key != ConsoleKey.Backspace)
                {
                    bool control = double.TryParse(chr.KeyChar.ToString(), out val);
                    if (control)
                    {
                        numero += chr.KeyChar;
                        Console.Write(chr.KeyChar);
                    }
                }
                else
                {
                    if (chr.Key == ConsoleKey.Backspace && numero.Length > 0)
                    {
                        numero = numero.Substring(0, (numero.Length - 1));
                        Console.Write("\b \b");
                    }
                }
            }
            while (chr.Key != ConsoleKey.Enter);

            return numero;
        }
        static void Capitulo1()
        {
            Console.WriteLine("\nCapítulo 1:");

            //Ejer.1 Cree un proyecto nuevo que imprima su nombre en la ventana de la consola.
            Console.WriteLine("\nSteven Michael Javier Lopez");
            //Ejer.5 Agregue más mensajes a la aplicación que ha creado.
            Console.WriteLine("Es mi nombre y este es el proyecto que se ha creado.");
            Console.WriteLine("No tengo más mensajes de relleno...");
        }
        static void Capitulo2()
        {
            string lector;
            int lado, numeroDeLados;
            double grados, centigrados, peso;

            Console.WriteLine("\nCapítulo 2:");

            //1 Hacer un programa que calcule el perímetro de cualquier polígono regular.
            Console.WriteLine("\nEjercicio 1:");
            Console.WriteLine("\nIngrese la cantidad de lados:");
            lector = LeerSoloNumeros();
            numeroDeLados = Convert.ToInt32(lector);
            Console.WriteLine("\nIngrese el tamaño del lado:");
            lector = LeerSoloNumeros();
            lado = Convert.ToInt32(lector);
            Console.WriteLine("\nEl perímetro es de: {0}", (lado * numeroDeLados));

            //3 Hacer un programa que transforme de grados a radianes.
            Console.WriteLine("\nEjercicio 3:");
            Console.WriteLine("\nIngrese los grados:");
            lector = LeerSoloNumeros();
            grados = Convert.ToDouble(lector);
            Console.WriteLine("\nEn rádian es: {0}", (grados * Math.PI / 180));

            //4 Hacer un programa que transforme de grados centígrados a grados Fahrenheit.
            Console.WriteLine("\nEjercicio 4:");
            Console.WriteLine("\nIngrese grados centígrados:");
            lector = LeerSoloNumeros();
            centigrados = Convert.ToDouble(lector);
            Console.WriteLine("\nEn grados Fahrenheit es: {0}",((centigrados * 9/5)+32));

            //5 Hacer un programa que transforme entre dólares y euros y que también pida el tipo de cambio del día.
            Console.WriteLine("\nEjercicio 5:");
            Console.WriteLine("\nIngrese la cantidad:");
            lector = LeerSoloNumeros();
            peso = Convert.ToDouble(lector);
            Console.WriteLine("\nDe peso a dolar es: {0}\nDe peso a euro es: {1}", (peso / dolar),(peso / euro));
            Console.WriteLine("\nDe dolar a peso es: {0}\nDe euro a peso es: {1}", (peso * dolar), (peso * euro));
        }
        static void Capitulo3()
        {
            Console.WriteLine("\nCapítulo 3:");
            Console.WriteLine("\nEjercicio 1:");

        }
        static void Capitulo4()
        {
            Console.WriteLine("\nCapítulo 4:");
            Console.WriteLine("\nEjercicio 1:");
        }
    }
}
