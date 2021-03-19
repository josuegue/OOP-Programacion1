using System;
using System.Threading;

namespace OOP1._2
{
    class Program
    {
        public static string Mid(string Cadena, int Indice, int longitud)
        {
            string resultado = Cadena.Substring(Indice, longitud);
            return resultado;
        }
        static void Main(string[] args)
        {
            string Nombre;
            string CAR;
            int Longitud = 0;
            int Desplazo= 0;
            Console.Write("Ingrese su nombre: ");
            Nombre = Console.ReadLine();
            Console.SetCursorPosition(1, 12);
            Console.Write(Nombre);
            Longitud = Nombre.Length;
            Desplazo = 70;
            Nombre = Nombre.ToUpper();
            for (int P=Nombre.Length; P>=1; P--)
            {
                CAR = Mid(Nombre, P - 1, 1);
                for (int K = Longitud; K <= Desplazo; K++)
                {
                    Console.SetCursorPosition(K, 12);
                    Console.Write(" " + CAR);
                    Thread.Sleep(50);
                }
                Desplazo--;
                Longitud--;
            }
            Console.WriteLine();
        }
    }
}
