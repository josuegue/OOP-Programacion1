using System;
using System.Threading;

namespace EjemplosOOP1
{
    class Program
    {
        public static  void dibuja (int IngresoDato)
        {
            int alto = 22;// alto del objeto 
            int largo = 77;//largo de el objeto
            int Inicializador1 = 2;// modifica la posicion de impresion de los datos
            int Inicializador2 = 2;// modifica la posicion de imprecion de los datos
            

            for (int A=1; A <= IngresoDato; A++)
            {
                for (int F=Inicializador2; F<=largo; F++)// filas 
                {
                    Console.SetCursorPosition(F, alto);Console.Write("-");//imprime abajo posicion F=2 y FF=22 hasta <=77 
                    Console.SetCursorPosition(F, Inicializador1);Console.Write("+");//imprime arriba posicion F=2 y FI=2 hasta <=77

                }
                for (int C = Inicializador1; C <= alto; C++)//columnas
                {
                    Console.SetCursorPosition(Inicializador2, C); Console.Write("Y");//izquierda posicion CI=2 y C=2 hasta <=22
                    Console.SetCursorPosition(largo, C); Console.Write("X");//derecha poscision CF=77 y C=2 hasta <=22
                }

                Inicializador1++; // se incrementa ++
                alto--;// se decrementa --
                Inicializador2++;
                largo--;
            }//for principal 
            Console.WriteLine();

        }
        static void Main(string[] args)
        {
            for (int tam=1; tam<9; tam++)
            {
                dibuja(tam);
                Thread.Sleep(1000);
            }
            Console.SetCursorPosition(25, 24);
            Console.Write("Pulse una tecla: ");
        }
    }
}
