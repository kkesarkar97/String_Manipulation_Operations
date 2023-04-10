using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringRelatedProblems
{
    public class ReverseString
    {
        public void reverseString(string str)
        {
            string reverseStr = "";

            for(int i=str.Length-1;i>=0;i--)
            {
                reverseStr += str[i];
            }

            Console.WriteLine("String Reversed is : "+ reverseStr);
            

        }
    }
}
