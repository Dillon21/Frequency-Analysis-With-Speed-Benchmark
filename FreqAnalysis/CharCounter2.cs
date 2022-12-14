using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreqAnalysis
{
    public class CharCounter2{
        private Dictionary<char,int> keyValuePairs = new Dictionary<char,int>();
        private bool capsCheck = false;

        public CharCounter2(){
            keyValuePairs = new Dictionary<char,int>();
            MapFileCharacters();
        }
        public void MapFileCharacters(){
            foreach (var line in File.ReadLines("Sample2.txt")){
                foreach(char c in line){
                    if (!char.IsWhiteSpace(c) && capsCheck == true){
                        addLetters(c);
                    }
                    else if (!char.IsWhiteSpace(c) && c.Equals(char.ToLower(c))){
                        addLetters(c);
                    } 
                }
            }

            var sort = keyValuePairs.OrderByDescending(kv => kv.Value);
            var sortedList = sort.ToDictionary(pair => pair.Key, pair => pair.Value);
            List<char> keyList = sortedList.Keys.ToList();

            for(int i = 0; i < 10; i++){
                if (keyValuePairs.ContainsKey(keyList[i])){
                   //Console.WriteLine(keyList[i] + " " + sortedList[keyList[i]]);
                }
            }
        }

        private void addLetters(char c){
            if (!keyValuePairs.ContainsKey(c)){
                keyValuePairs.Add(c, 1);
            }
            else{
                keyValuePairs[c]++;
            }
        }

    }
}
