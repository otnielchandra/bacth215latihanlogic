using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caDay0407PR
{
    class Program
    {
        static void Main(string[] args)
        {
            string tampung = Console.ReadLine();

            //substring
            string huruf = tampung.Substring(0, 1);
            Console.WriteLine(huruf.ToCharArray());
            //split
            string[] pemisah = { " " };
            string[] pecah = tampung.Split(pemisah, 5, StringSplitOptions.RemoveEmptyEntries);
            Console.Write(tampung);
            foreach (string item in pecah)
            {
                Console.WriteLine(item);
            }                       
            Console.ReadLine();
        }
    }
}
