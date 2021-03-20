using System;
using System.Threading;

namespace Ejercicio
{
    class Program
    {
        public static string Mid(string parametro, int starindex, int Lentgh)
        {
            string result = parametro.Substring(starindex, Lentgh);
            return result;
        }
        static void Main(string[] args)
        {
            string Nomcadena;
            string CaracteresCadena;
            int k = 0;
            int P = 0;
            int longcad = 0;
            int CanRecorr = 0;
            Console.Write("Ingrese su nombre");
            Nomcadena = Console.ReadLine();
            Console.SetCursorPosition(1, 12);
            Console.Write(Nomcadena);
            longcad = Nomcadena.Length;
            CanRecorr = 50;
            Nomcadena = Nomcadena.ToUpper();
            for (P = Nomcadena.Length; P >= 1; P--)
            {
                CaracteresCadena = Mid(Nomcadena, P - 1, 1);
                for (k = longcad; k <= CanRecorr; k++)
                {
                    Console.SetCursorPosition(k, 12);
                    Console.Write("" + CaracteresCadena);
                    Thread.Sleep(18);
                }
                CanRecorr = CanRecorr - 1;
                longcad = longcad - 1;

            }

        }
    }
}