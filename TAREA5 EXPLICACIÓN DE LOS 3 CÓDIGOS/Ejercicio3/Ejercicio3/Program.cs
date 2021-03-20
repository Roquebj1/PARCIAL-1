using System;
namespace Ejercicio
{
    class Program
    {
        public static string generaletra(int min, int max)
        {
            Random ran = new Random();
            int NUM = Convert.ToInt32(ran.Next(100));
            string LetraRespuesta = "";
            if (((NUM > min) & (NUM < max)))
            {
                LetraRespuesta = Convert.ToString((char)NUM);
            }
            return LetraRespuesta;
        }
        static void Main(string[] args)
        {
            byte CAN, K;
            string linea;
            Console.Write("Cuantos numeros?");
            linea = Console.ReadLine();
            CAN = byte.Parse(linea);

            String letra = "";
            for (K = 1; K <= CAN; K++)
            {
                letra = letra + generaletra(0, 250);
            }
            Console.WriteLine($"Token generado={letra}");
        }
    }//end main
}//end class