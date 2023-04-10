using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringRelatedProblems
{
    public class OccurrencesOfCharacter
    {
        public void occurrenceCount(string str,char c)
        {
            char[] Array = str.ToCharArray();
            int Count = 0;
            foreach(char ch in Array)
            {
                if(ch==c)
                {
                    Count++;
                }
            }
            Console.WriteLine("Occurence of character '" + c + "' in string '" + str + "' is : " + Count);
        }
    }
}
