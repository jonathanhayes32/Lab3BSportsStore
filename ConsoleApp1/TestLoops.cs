using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class TestLoops
    {
        public void Run()
        {
            Console.WriteLine(AddRecursive(7, 9));
            Console.WriteLine(AddWhile(-7, 9));
            Console.WriteLine(AddDo(7, 9));
            Console.WriteLine(AddFor(7, 9));
        }
        private int AddFor(int v1, int v2)
        {
            throw new NotImplementedException();
        }


        private int AddDo(int v1, int v2)
        {
            throw new NotImplementedException();
        }

        private int AddWhile(int accum, int v2)
        {
            while (v2 != 0)

            {
                accum += 1;
                v2 -= 1;
            }
            return accum;
        }

        private uint AddRecursive(uint accum, uint v2)
        {
            if (v2 == 0)
            {
               return accum;
            }
            // base case
            // tells us when to exit


            else
            {
                
                return AddRecursive(accum + 1, v2 - 1);
            }
        }
    }


}
