using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreqAnalysis
{
    public class CharCounterWithOutput{
        private Dictionary<char,int> keyValuePairs = new Dictionary<char,int>();
        private bool capsCheck = false;

        public CharCounterWithOutput(){
            MapFileCharacters();
        }
        public void MapFileCharacters(){
            foreach (var line in File.ReadLines("Sample2.txt")) {
                foreach (char c in line){
                    if (!char.IsWhiteSpace(c) && capsCheck == true){
                        addLetters(c);
                    }
                    else if (!char.IsWhiteSpace(c) && c.Equals(char.ToLower(c))) {
                        addLetters(c);
                    }
                }
            }

            //Use Linq to create list of tuples
            var sort = keyValuePairs.OrderByDescending(kv => kv.Value).Select(x => new { key = x.Key, value = x.Value }).Take(10);
            foreach (var item in sort) {
                //Console.WriteLine($"{item.key} {item.value}");
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

        static void main(string[] args){
            CharCounterWithOutput output = new CharCounterWithOutput();
        }
    }

}
