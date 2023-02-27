using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Testing
    {
        public static void test()
        {
            Pack test1 = new Pack();
            bool test = Pack.shuffleCardPack(2);
            Console.WriteLine(test);
        }
    }
}
