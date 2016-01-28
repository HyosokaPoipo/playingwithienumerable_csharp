using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingwithIEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            /** CARA PERTAMA **/
            IEnumerable<int> firstIEnum = from hisoka in Enumerable.Range(1, 9) select hisoka;
            Console.WriteLine("Hasil Cara Pertama : ");
            foreach (int poipo in firstIEnum)
            {
                Console.WriteLine(poipo);
            }



            /*** CARA KEDUA ***/
            /*
             * Di sini kita pake list
             * 
             * */
            List<string> hisokaList = new List<string>();
            hisokaList.Add("Poipo");
            hisokaList.Add("Itachi");
            hisokaList.Add("Hisoka");
            hisokaList.Add("Painz");
            hisokaList.Add("TutupBotol");
            hisokaList.Add("KilluaPoipo");
            hisokaList.Add("MasterSasory");

            IEnumerable<string> hisokaIEnum1 = from poipo in hisokaList select poipo;
            Console.WriteLine("Hasil Cara Kedua : ");
            foreach (string poipo in hisokaIEnum1)
            {
                Console.WriteLine(poipo);
            }


            IEnumerable<string> hisokaIEnum2 = (IEnumerable<string>)hisokaList;
            int size = hisokaIEnum2.ToList<string>().Count;

            Console.WriteLine("\n\nHasil cara kedua part 2 : ");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(hisokaIEnum2.ElementAt(i));
            }



                Console.ReadLine();

        }
    }
}
