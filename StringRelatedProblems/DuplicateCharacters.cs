using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringRelatedProblems
{
    public class DuplicateCharacters
    {
        public void removeDuplicateCharacters(string  str)
        {
            string res = string.Empty;
            for(int i=0;i<str.Length;i++)
            {
                if (!res.Contains(str[i]))
                {
                    res += str[i];
                }
            }

            Console.WriteLine("Duplicate values are :" + res);
        }
    }
}
