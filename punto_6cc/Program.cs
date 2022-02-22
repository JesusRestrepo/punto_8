using System;

namespace punto_6cc
{
    class Program
    {
        static void Main(string[] args)
        {

            int totVen = 0;
            double porVen = 0, salar1 = 0, salar2 = 0, salar3 = 0;

            Console.WriteLine("Ingrese valor venta departamento 1");
            int VD1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese valor venta departamento 2");
            int VD2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese valor venta departamento 3");
            int VD3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese salario");
            int salar = int.Parse(Console.ReadLine());

            totVen = VD1 + VD2 + VD3;
            porVen = 0.33 * totVen;

            if(VD1 > porVen)
            {
                salar1 = salar + 0.2 * salar;
            }
            else
            {
                salar1 = salar;
            }

            if(VD2 > porVen)
            {
                salar2 = salar + 0.2 * salar;
            }
            else
            {
                salar2 = salar;
            }
            if (VD3 > porVen)
            {
                salar3 = salar + 0.2 * salar;
            }
            else
            {
                salar3 = salar;
            }
            Console.WriteLine("Salario vendedores depto. 1: " + salar1 + " Salario vendedores dpto. 2: " + salar2 + " Salario vendedores depto. 3: " + salar3);
        }
    }
}
