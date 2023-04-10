using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace StringRelatedProblems
{
    public class DisplayWordMaxCharacter
    { 
        public void findOccurenceCharInWord(string str , char c )
        {
            string[] strr = new string[1];
            
            strr[0] = c.ToString();
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int Char=0;
            int word = 0;
            str = str.Replace(" ", ",");
            string[] str1 = str.Split(",");
            foreach(string i in str1)
            {
                word++;
                char[] Array = i.ToCharArray();
                for(int j=0;j<i.Length;j++)
                {
                    if (c == Array[j])
                    {
                        Char++;
                    }
                }
                dict.Add(word, Char);
                Char = 0;
            }

            int n = dict.Count;
            //int max = dict.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
            int max=dict.MaxBy(kvp => kvp.Value).Value;
            int[] key = new int[n];
            int k = 0;
            ArrayList list = new ArrayList();
            foreach (KeyValuePair<int, int> item in dict)
            {
                
                if (item.Value == max) { key[k] = item.Key;
                    list.Add(item.Key);
                }
                k++;

            }
            foreach (int i in list) {
                Console.WriteLine("Character " + strr[0] + " have maximum no of occurences " + dict[i] + " in word " + str1[i-1]);
            }
        }
    }
}
