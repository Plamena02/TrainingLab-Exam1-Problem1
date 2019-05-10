using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = double.Parse(Console.ReadLine())*100;
            var w = double.Parse(Console.ReadLine())*100;
            var h2 = 0.0;
            var w2 = 0.0;
            var sum = 0.0;
                h2 = Math.Truncate(h / 120);
                w2 = Math.Truncate ((w-100) / 70);
                sum = (h2 * w2) -3;
            Console.WriteLine(sum);           


        }
    }
}

