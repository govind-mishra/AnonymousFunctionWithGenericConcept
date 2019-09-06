using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymousfunc
{
    public class LocalFunc
    {
        public static int getAnonymousFunc(string number)
        {
            Func<string, int> getNumberinInteger = (digit) =>
             {
                 int.TryParse(digit, out int i);//if digit is number i will return number else return zero
                 if (i != 0)
                 {
                     return i;//output parameter from int.tryparse
                 }
                 else
                 {
                     return 0;
                 }
             };

            return getNumberinInteger(number);
        }

        public static string getAnonymousFunc2<T>(T number)
        {
            Func<T, string> getNumberinInteger = (digit) =>
            {
                int.TryParse(digit.ToString(), out int i);//if digit is number i will return number else return zero
                if (i != 0)
                {
                    return "digit is number having value : " + i;//output parameter from int.tryparse
                }
                else
                {
                    return "digit is not a number";
                }
            };

            return getNumberinInteger(number);
        }

        public static T getAnonymousFunc3<T>(T number)
        {
            Func<T, T> getNumberinInteger = (digit) =>
             {
                 int.TryParse(digit.ToString(), out int i);
                 if (i!=0)
                 {
                      return (T)Convert.ChangeType("digit is number having value", typeof(T));
                 }
                 else
                 {
                     return (T)Convert.ChangeType("digit is not a number", typeof(T));
                 }
             };

            return (T)getNumberinInteger(number);
        }

    }

}

