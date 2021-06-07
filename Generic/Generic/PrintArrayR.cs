using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{

    class PrintArrayR<T>
    {
        private T[] array;

        public PrintArrayR(T[] array)
        {
            this.array = array;
        }
        public void ToPrint()
        {
            foreach (var F in array)
            {
                Console.WriteLine(F);
            }
        }

    }
}

