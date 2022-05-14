using System;
using System.Collections.Generic;
using System. Text;
using System.Linq;
using System. Threading.Tasks;
namespace figuras


{
    class Program
    {


        static void Main(string[] args)
        {
            int b, a, area, num;
            string Y;
            do
            {
                Console.WriteLine("elija una figura geonetrica");
                Console.WriteLine("1.cuadrado");
                Console.WriteLine("2.rectangulo");
                Console.WriteLine("3.triangulo");
                Console.WriteLine("4.romboide");
                num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("ponga la base o el lado");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("ponga la altura o el lado");
                a = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        area = b * a;
                        Console.WriteLine("El area del Cuadrado es: " + area);
                        break;

                    case 2:
                        area = b * a;
                        Console.WriteLine("El area del rectangulo es: " + area);
                        break;

                    case 3:
                        area = b * a / 2;
                        Console.WriteLine("El area del triangulo es: " + area);
                        break;

                    case 4:
                        area = b * a;
                        Console.WriteLine(" El area del Romboide es: " + area);
                        break;
                }
                Console.WriteLine("Si desea volver a intentar pulse Y ");
                Y = Console.ReadLine();
            } while (Y == "Y" || Y == "y");
        }
    }
}
            

    

    
    
