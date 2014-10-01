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
            double V1,V2,V3,R1,R2,R3,R4,R5,IVA;
            string D1,D2,D3;

            Console.WriteLine("Dame la cantidad del primer producto");
            P1=int.Parse(Console.ReadLine());
            Console.WriteLine("Dame la descripcion");
            D1= Console.ReadLine();
            Console.WriteLine("Dame el precio unitario");
            V1=double.Parse(Console.ReadLine());

            Console.WriteLine("\n\nDame la cantidad del segundo producto");
            P2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Dame la descripcion");
            D2 = Console.ReadLine();
            Console.WriteLine("Dame el precio unitario");
            V2 = double.Parse(Console.ReadLine());

            Console.WriteLine("\n\nDame la cantidad del tercer producto");
            P3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Dame la descripcion");
            D3 = Console.ReadLine();
            Console.WriteLine("Dame el precio unitario");
            V3 = double.Parse(Console.ReadLine());

            R1 = P1 * V1;
            R2 = P2 * V2;
            R3 = P3 * V3;
            R4 = R1 + R2 + R3;
            IVA = (R4 *16) / 100;
            R5 = R4 + IVA;
            Console.WriteLine("\t" + P1 + "\t" + D1 + "\t" + R1 + "\t+");
            Console.WriteLine("\t" + P2 + "\t" + D2 + "\t" + R2 + "\t+");
            Console.WriteLine("\t" + P3 + "\t" + D3 + "\t" + R3 + "\n------------------------");
            Console.WriteLine("Subtotal "+R4);
            Console.WriteLine("Iva "+IVA);
            Console.WriteLine("Total "+R5);
            Console.WriteLine("Gracias Por Su Compra");
            Console.WriteLine("\n\n\nPresione una tecla para salir");
            Console.ReadKey(true);
        }
        static void Main(string[] args)
        {
            Acciones();
        }
    }
}
