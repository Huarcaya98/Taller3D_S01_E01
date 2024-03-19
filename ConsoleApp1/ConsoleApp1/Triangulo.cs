using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Triangulo
    {

        public void ExeTria()
        {
            float basse = 0;
            float altura = 0;
            float area = 0;

            Console.WriteLine("Ingrese la base del triangulo");
            basse = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la altura del triangulo");
            altura = float.Parse(Console.ReadLine());

            area = ((basse * altura) / 2);

            Console.WriteLine($"El area del triangulo es: {area}");



        }

    }
}
