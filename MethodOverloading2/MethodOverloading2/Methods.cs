using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading2
{
    internal class Methods
    {//create add method
        public static int Add(int x, int y)
        {
            return x + y;
        }
     //create an overload of the method that adds two decimals 
        public static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }
        public static string Add(int x, int y, bool withDollars)
        {
            if(withDollars && (x + y) != 1)
            {
                return $"{x + y} dollars";
            }
            else if(withDollars && (x + y) == 1)
            {
                return $"{x + y} dollar";
            }
            else
            {
                return $"{x + y}";
            }
        }
    }

}
