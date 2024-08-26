using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{

    //Ваша задача — написать программу, которая позволит понять, какие 10 слов чаще всего встречаются в тексте.
    public class Task13_6_2
    {
       public Task13_6_2() { 
        string text = File.ReadAllText("C:\\Users\\User\\Downloads\\Text1.txt");
            int i = 0; // Индекс для отслеживания количества выводимых слов  
            Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();
            foreach (var word in text.Split(' '))
            {
                if (!keyValuePairs.ContainsKey(word))
                {
                    keyValuePairs[word] = 0;
                }

                keyValuePairs[word]++;
            }

            Console.WriteLine("10 самых частых слов:");

            

            foreach (KeyValuePair<string, int> pair in keyValuePairs)
            {
                i++;

                Console.WriteLine($"{pair.Key} встречается {pair.Value} раз");

                // Выводим только первые 10 слов
                if (i == 10)
                {
                    break;
                }
            
            


            }



        }
    }
}
