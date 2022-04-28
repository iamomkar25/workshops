using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leap_year
{
    internal class Leepyear
    {
        public void year()
        {
            Console.WriteLine("Please Enter a Number only 4 digit");
            int y = Convert.ToInt32(Console.ReadLine());
            if ((y % 4 == 0))
            {
                Console.WriteLine("leepYear");

            }
            else
            {
                Console.WriteLine("not leep year");

            }
        }
    }
}
