using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrisonDBApp
{
    class ValidationClass
    {
        public static Object isPositiveInteger(String input, StringBuilder err)
        {
            Object returnData = null;
            try
            {
                int x = Convert.ToInt32(input);
                if (x < 0)
                {
                    err.Append("Input " + input + " is a negative number");
                }
                else
                {
                    returnData = x;
                }
            }
            catch
            {
                err.Append("Input " + input + " is not a valid integer");
            }
            return returnData;
        }


    }
}
