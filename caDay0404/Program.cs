using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caDay0404
{
    class Program
    {
        static void Main(string[] args)
        {
            string tampung = Console.ReadLine();

            //substring
            string huruf = tampung.Substring(0, 1);
            Console.WriteLine(huruf.ToUpper());
            //split
            string[] pemisah = {" "};
            string[] pecah = tampung.Split(pemisah, 5,StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(tampung);
            foreach (string item in pecah)
            {
                Console.WriteLine(item);
            }

            

            Console.ReadLine();
        }
    }
}
