using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finctions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double Uv, Uz, G, Mv, Mz, Rv, Rz;
                G = 6.67 * Math.Pow(10, -11);
                Mv = 4.86 * Math.Pow(10, 27);
                Rv = 6175;
                Mz = 5.98 * Math.Pow(10, 27);
                Rz = 6371;
                Uv = Math.Sqrt(G * Mv) / Rv;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Первая космическая скорость Венеры Uv=" + Uv);
                Uz = Math.Sqrt(G * Mz) / Rz;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Первая космическая скорость Земли Uz=" + Uz);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
