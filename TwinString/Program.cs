using System;
using System.Linq;

namespace Trial
{
    class Program
    {
        /*
         * Complete the function below.
         * DO NOT MODIFY CODE OUTSIDE THIS FUNCTION!
         */
        static string[] twins(string[] a, string[] b)
        {
            var response = new string[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                var areEqual = isEqual(a[i], b[i]);
                response[i] = areEqual ? "Yes" : "No";
            }
            return response;
        }

        static bool isEqual(string a, string b)
        {
            if(a == b || (a == string.Empty && b == string.Empty))
            {
                return true;
            }
            char[] CharArray = a.ToCharArray();
            char second = b[0];

            if (a[0] != second)
            {
                int index = CharArray.ToList().IndexOf(second);
                if (index > -1 && index % 2 == 0)
                {
                    var replace = a[index];
                    CharArray[index] = a[0];
                    CharArray[0] = replace;
                }
                else
                {
                    return false;
                }
            }

            if (CharArray[0] == second)
            {
                a = new string(CharArray).Substring(1, a.Length - 1);
                b = b.Substring(1, b.Length - 1);
            }
            else
            {
                return false;
            }
            return isEqual(a, b);
        }
        //DO NOT MODIFY CODE OUTSIDE THE ABOVE FUNCTION!

        static void Main(String[] args)
        {
            string[] res;

            int _a_size = 0;
            _a_size = Convert.ToInt32(Console.ReadLine());
            string[] _a = new string[_a_size];
            string _a_item;
            for (int _a_i = 0; _a_i < _a_size; _a_i++)
            {
                _a_item = Console.ReadLine();
                _a[_a_i] = _a_item;
            }


            int _b_size = 0;
            _b_size = Convert.ToInt32(Console.ReadLine());
            string[] _b = new string[_b_size];
            string _b_item;
            for (int _b_i = 0; _b_i < _b_size; _b_i++)
            {
                _b_item = Console.ReadLine();
                _b[_b_i] = _b_item;
            }

            res = twins(_a, _b);
            for (int res_i = 0; res_i < res.Length; res_i++)
            {
                Console.WriteLine(res[res_i]);
            }
            Console.ReadLine();
        }
    }
}