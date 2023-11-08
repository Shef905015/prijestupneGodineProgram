using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prijestupneGodine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pocetnagodina;
            int zadnjagodina;

            Console.WriteLine("Unesite vašu početnu godinu");
            pocetnagodina = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Unesite vašu završnu godinu");
            zadnjagodina = Convert.ToInt32(Console.ReadLine());

            Console.Write("----------------------------\n");
            Console.WriteLine("Prijestupne godine od " + pocetnagodina + " do " + zadnjagodina); 

            for(int i=pocetnagodina; i<zadnjagodina+1; i++)
            {

                if(i % 4 == 0 && i % 100 != 0 || i % 400 == 0)
                {

                    Console.WriteLine(i);

                }

            }





            Console.ReadKey();

        }
    }
}
