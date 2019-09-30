using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caDay0406
{
    public class Program
    {
        public static void Main(string[] args)
        {
            char[] tampung = Console.ReadLine().ToCharArray();

            int i = tampung.Length;
            char c;
            for (int j = 0; j <= i - 2; j++) {
                for (int n = 0; n <= i - 2; n++)
                {
                    if (tampung[n] > tampung[n + 1])
                    {
                        c = tampung[n + 1];
                        tampung[n+1] = tampung[n];
                        tampung[n] = c;
                    }
                    
                }
                
            }

            foreach (char p in tampung)
            {
                Console.WriteLine(p + " ");
            }
            Console.ReadLine();
        }
    }
}
