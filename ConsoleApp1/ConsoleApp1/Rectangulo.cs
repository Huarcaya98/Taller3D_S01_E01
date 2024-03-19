using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Rectangulo
    {
        public void ExcuteRect()
        {
            float basse= 0;
            float altura= 0;
            float area = 0;
            float perimetro = 0;

            Console.WriteLine("Ingrese la base del rectangulo");
            basse = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la altura del rectangulo");
            altura = float.Parse(Console.ReadLine());
            
            

            area = basse * altura;
            perimetro = 2*(basse * altura);

            Console.WriteLine($"El area del rectangulo es: {area}");
            Console.WriteLine($"El perimetro del rectangulo es: {perimetro}");


                

        }

    }
}
