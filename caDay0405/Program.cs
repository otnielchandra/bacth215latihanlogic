using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caDay0405
{
    class Program
    {
        static void Main(string[] args)
        {
            string tampung = Console.ReadLine();
            char[] pecah = tampung.ToCharArray();
         string[] pecah = tampung.Split(pemisah, 5, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(tampung);
            foreach (char item in pecah)
            {
                Console.WriteLine(item);
            }



            Console.ReadLine();
        }
    }
}
