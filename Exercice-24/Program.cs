using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp;
            int max = -273;
            int min = 500;



            for (int a = 0; a < 10; a++)
            {
                Console.Write("Entré une températures n°"+a+": ");

                temp = int.Parse(Console.ReadLine());
                 
                

                if (temp > max )
                    
                {
                    max = temp;
                    Console.WriteLine(" --> Température la plus élevé :"+max);
                    


                }
                else
                { 
                    if (temp < min)

                    min = temp;
                    Console.WriteLine(" --> Température la plus petite :"+min);
                }

                

            }

            Console.WriteLine("La température maximum rentré est "+max);
            Console.WriteLine("La tmepérature minimum rentré est "+min);



            Console.ReadLine();



















        }
    }
}
