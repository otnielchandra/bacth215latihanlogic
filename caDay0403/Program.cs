using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caDay0403
{
    public class Program
    { 
      
      
        public static void Main(string[] args)
        {
            

            Console.WriteLine("inputkan panjang persegi : ");
            int panjang = Convert.ToInt32(Console.ReadLine());

           // Console.WriteLine("inputkan panjang persegi : ");
           // int lebar = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("luas persegi : ");
            //int luas = panjang * lebar;
            int luas = panjang * panjang ;
            Console.WriteLine(luas);

            Console.ReadKey();
        }
        
        }
            
            
    }

