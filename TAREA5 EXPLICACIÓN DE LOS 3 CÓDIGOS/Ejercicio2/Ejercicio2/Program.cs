using System;
using System.Threading;

namespace Ejercicio
{
    class Program
    {
        public static void dibuja(int Cantidad)
        {
            int FF = 50;
            int CF = 100;
            int EspF = 2;
            int EspC = 2;
            int F, C, A;
            for (A = 1; A <= Cantidad; A++)
            {
                for (F = EspC; F <= CF; F++)
                {
                    Console.SetCursorPosition(F, FF); Console.Write("?");
                    Console.SetCursorPosition(F, EspF); Console.Write("?");
                }
                for (C = EspF; C <= FF; C++)
                {
                    Console.SetCursorPosition(EspC, C); Console.Write("X");
                    Console.SetCursorPosition(CF, C); Console.Write("X");
                }
                EspF = EspF + 1;
                FF = FF - 1;
                EspC = EspC + 1;
                CF = CF - 1;
            }
        }
        static void Main(string[] args)
        {
            for (int tam = 1; tam < 30; tam++)
            {
                dibuja(tam);
                Thread.Sleep(1000);


            }

        }
    }
}