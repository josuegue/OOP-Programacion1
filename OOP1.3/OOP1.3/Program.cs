using System;

namespace OOP1._3
{
    class Program
    {
        public static string GeneraLetra()
        {
            Random rango = new Random();
            int Numero = Convert.ToInt32(rango.Next(33, 126));//rango de numeros del 33 al 126
            string resultado = "No hay codigo ";


            if (Numero > 33 & Numero < 126) //Rango del cual se tiene que ejecutar el codigo
            {
                resultado = Convert.ToString((char)Numero)+" numero de codigo "+ Convert.ToString(Numero);
            }
            return resultado;

        } 
        static void Main(string[] args)
        {
            byte Cantidad;
            Console.Write("Cuantos numeros: ");
            Cantidad = byte.Parse(Console.ReadLine());//Convierte la cadena a byte 
            string letras = " ";
            for (int i=1; i<=Cantidad; i++)
            {
                letras = GeneraLetra();
                Console.WriteLine($"El codigo aleatorio es {letras}");
            }
                
        }
    }
}
