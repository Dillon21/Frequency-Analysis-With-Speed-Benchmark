using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreqAnalysis
{
    
    public class CharCounter
    {
        private Dictionary<char,int> keyValuePairs = new Dictionary<char,int>();
        private bool capsCheck = false;

        public CharCounter()
        {
            keyValuePairs = new Dictionary<char,int>();
            read();
        }

        
        public void read()
        {
            foreach (var line in File.ReadLines("Sample2.txt"))
            {
                foreach(char c in line)
                {
                    if (!char.IsWhiteSpace(c))
                    {
                        if (!keyValuePairs.ContainsKey(c))
                        {
                            keyValuePairs.Add(c, 1);
                        }else
                        {
                            keyValuePairs[c]++;
                        }

                        
                    }
                }
            }

            
            var sort = from entry in keyValuePairs orderby entry.Value descending select entry;
            var sortedList = sort.ToDictionary(pair => pair.Key, pair => pair.Value);

            List<char> keyList = sortedList.Keys.ToList();

            for(int i = 0; i < 10; i++)
            {
                if (keyValuePairs.ContainsKey(keyList[i]))
                {
                    //Console.WriteLine(keyList[i] + " " + sortedList[keyList[i]]);
                }
            }
        }

    }
}
