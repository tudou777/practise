using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();
            d[0] = "tudou";
            d[1] = "baicai";
            d[2] = "digua";
            for (var i = 0; i < d.Count;i++ )
            {
                Console.WriteLine(d[i]);
            }

            Console.WriteLine(d.Count);
            //Console.WriteLine(d[0]);

            foreach (var item in d)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
