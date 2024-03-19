using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Example1
    {

        public void Execute()
        {
            bool continueFlag = true;

            while (continueFlag)
            {
                int a;
                int b;

                Console.WriteLine("Ingresar el primer numero");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero");
                b = int.Parse(Console.ReadLine());

                Console.WriteLine($"La suma de los numero es: {a + b}");

                bool ValidOption = false;

                while (!ValidOption)
                {


                    Console.WriteLine("elige una opcion");
                    Console.WriteLine("1. Volver a introducir numeros");
                    Console.WriteLine("2. Salir");
                    string option = Console.ReadLine();

                    switch (option)
                    {
                        case "1":

                            ValidOption = true;
                            break;

                        case "2":
                            
                            continueFlag = false;
                            ValidOption = true;
                            break;

                        default:

                            Console.WriteLine("Opticion invalida");
                        break;



                    }


                }
            
            }


        }

    }
}
