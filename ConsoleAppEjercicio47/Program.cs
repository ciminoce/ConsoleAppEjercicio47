using System;

namespace ConsoleAppEjercicio47
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número entero:");
            var nroIngresado = int.Parse(Console.ReadLine());
            for (int contador = 1; contador <= 12; contador++)
            {
                var nroMultiplicado = ObtenerMultiplo(nroIngresado, contador);
                Console.WriteLine($"{nroIngresado}x{contador}={nroMultiplicado}");
            }

            Console.ReadLine();
        }

        private static int ObtenerMultiplo(int nro, int multiplicador) => nro * multiplicador;
        //{
        //    return nro * multiplicador;
        //}
    }
}
