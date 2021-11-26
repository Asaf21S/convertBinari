using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convertBinari
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter base: ");
            int form = int.Parse(Console.ReadLine());
            string bin = ""; int add, num; char current;
            while (bin != "-1")
            {
                Console.WriteLine("Enter a number in base {0}: ", form);
                bin = Console.ReadLine();
                num = 0;
                for (int i = 0; i < bin.Length; i++)
                {
                    current = bin[bin.Length - 1 - i];
                    add = 1;
                    for (int j = 0; j < i; j++)
                    {
                        add *= form;
                    }
                    if ((int)current >= 65 && (int)current <= 90)
                        add *= ((int)current - 55);
                    else if ((int)current >= 97 && (int)current <= 122)
                        add *= ((int)current - 87);
                    else
                        add *= ((int)current - 48);
                    num += add;
                }
                if (num == -1) Console.WriteLine("Number too big");
                else Console.WriteLine(num);
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
