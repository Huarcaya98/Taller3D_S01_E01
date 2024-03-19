using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Bisiesto  
    {
        public void ExecuteBisiesto()
        {
            int anio ;

            Console.WriteLine("Ingrese el año");
            anio = int.Parse(Console.ReadLine());

            if(anio % 4 == 0)
            {
                if(anio % 100 == 0)
                {
                    if(anio % 400 == 0)
                    {
                        Console.WriteLine($"{anio} Si es bisiesto");
                    }
                    else
                    {
                        Console.WriteLine($"{anio} No es bisiesto");
                    }
                }
                else
                {
                    Console.WriteLine($"{anio} Si es bisiesto");
                }
            }
            else 
            {
                Console.WriteLine($"{anio} No es bisiesto");           
            
            }
            

        }

    }
}
