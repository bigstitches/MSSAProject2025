using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekTen
{
    // declare delegate
    public delegate bool MyDelegate(int n);
    class TuesdayLINQ
    {
        public static void DoDelegatePractice()
        {
            var result = CheckNum(40); // normal function call
            // variable of MyDelegate type
            MyDelegate resultAsObject = new MyDelegate(CheckNum);

            var newresult = resultAsObject(50); // calling function via delegate

            // anonymous method
            MyDelegate pointer1 = delegate (int num)
            {
                return (num > 500);
            };
            var result1 = pointer1(50);

            //MyDelegate expects an int, so x is an integer
            //lambda expression, also anonymous
            MyDelegate pointer2 = (x => x > 500);

            var result2 = pointer2(50);
        }
        static bool CheckNum(int num)
        {
            if (num > 500) return true;
            return false;
        }
    }
}
