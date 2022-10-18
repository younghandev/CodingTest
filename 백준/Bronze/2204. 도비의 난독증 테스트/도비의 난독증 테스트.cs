using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

class Program
{
    static void Main() {
        while(true) {
            int n = Convert.ToInt32(ReadLine());
            
            if (n == 0) return;
            
            var words = new Dictionary<string, string>();
            
            for (int i = 0; i < n; i++) {
                string word = ReadLine();
                
                words.Add(word, word.ToLower());
            }
            
            var answer = words.OrderBy(x => x.Value);
            
            WriteLine(answer.First().Key);
        }
    }
}