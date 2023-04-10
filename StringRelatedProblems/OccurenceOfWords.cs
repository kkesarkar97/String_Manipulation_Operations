using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringRelatedProblems
{
    public class OccurenceOfWords
    {
        public void occurenceWord(string str,string word)
        {
            int Count = 0;
            str=str.Replace(' ',',');
            string[] str1 = str.Split(',');
            
            foreach(dynamic i in str1)
            {
                if(string.Equals(i,word))
                { 
                    Count++;
                }
            }
            Console.WriteLine("Word "+word+" in the senetence have count : "+ Count);
        }
    }
}
