using System;

namespace Practica_02
{
    public class Productos
    {
        private int P1, P2, P3;
        private double V1, V2, V3, R1, R2, R3, R4, R5, IVA;
        private string D1, D2, D3;
        public Productos()
        {

        }

        public void realizarCapturaDeTresProductos()
        {
            this.capturarPrimerProducto();
            this.capturarSegundoProducto();
            this.capturarTercerProducto();
            this.realizarOperaciones();
            this.imprimirTablaDeResultados();
        }

        private void capturarPrimerProducto()
        {
            Console.WriteLine("Dame la cantidad del primer producto");
            this.P1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Dame la descripcion");
            this.D1 = Console.ReadLine();
            Console.WriteLine("Dame el precio unitario");
            this.V1 = double.Parse(Console.ReadLine());
        }

        private void capturarSegundoProducto()
        {
            Console.WriteLine("\n\nDame la cantidad del segundo producto");
            this.P2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Dame la descripcion");
            this.D2 = Console.ReadLine();
            Console.WriteLine("Dame el precio unitario");
            this.V2 = double.Parse(Console.ReadLine());
        }

        private void capturarTercerProducto()
        {
            Console.WriteLine("\n\nDame la cantidad del tercer producto");
            this.P3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Dame la descripcion");
            this.D3 = Console.ReadLine();
            Console.WriteLine("Dame el precio unitario");
            this.V3 = double.Parse(Console.ReadLine());
        }
        private void realizarOperaciones()
        {
            this.R1 = this.P1 * this.V1;
            this.R2 = this.P2 * this.V2;
            this.R3 = this.P3 * this.V3;
            this.R4 = this.R1 + this.R2 + this.R3;
            this.IVA = (this.R4 * 16) / 100;
            this.R5 = this.R4 + this.IVA;
        }
        private void imprimirTablaDeResultados()
        {
            Console.WriteLine("\n\n\n------------------------");
            Console.WriteLine(" " + this.P1 + "\t" + this.D1 + "\t" + this.R1 + "\t+");
            Console.WriteLine(" " + this.P2 + "\t" + this.D2 + "\t" + this.R2 + "\t+");
            Console.WriteLine(" " + this.P3 + "\t" + this.D3 + "\t" + this.R3 + "\n------------------------");
            Console.WriteLine("Subtotal \t" + this.R4);
            Console.WriteLine("Iva \t\t" + this.IVA);
            Console.WriteLine("Total \t\t" + this.R5);
            Console.WriteLine("Gracias Por Su Compra");
            Console.WriteLine("\n\n\nPresione una tecla para salir");
            Console.ReadKey(true);
        }
    }
}