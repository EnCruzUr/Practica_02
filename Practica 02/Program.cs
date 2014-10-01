using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_02
{
    class Program
    {
        public static void Acciones()
        {
            int P1,P2,P3;
            double V1,V2,V3;
            string D1,D2,D3;
            Console.WriteLine("Dame la cantidad del primer producto");
            P1=int.Parse(Console.ReadLine());
            Console.WriteLine("Dame la descripcion");
            D1= Console.ReadLine();
            Console.WriteLine("Dame el precio unitario");
            V1=int.Parse(Console.ReadLine());

            Console.WriteLine("Dame la cantidad del segundo producto");
            P2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Dame la descripcion");
            D2 = Console.ReadLine();
            Console.WriteLine("Dame el precio unitario");
            V2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Dame la cantidad del tercer producto");
            P3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Dame la descripcion");
            D3 = Console.ReadLine();
            Console.WriteLine("Dame el precio unitario");
            V3 = int.Parse(Console.ReadLine());


        }
        static void Main(string[] args)
        {
            Acciones();
        }
    }
}
