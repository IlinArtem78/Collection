using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{


    //Наша задача — сравнить производительность вставки в List<T> и LinkedList<T>.Для этого используйте уже знакомый вам StopWatch.

   // На примере этого текста, выясните, какие будут различия между этими коллекциями.
    public class Task13_6_1
    {
        public void Task()
        {
            List<string> strings = new List<string>();
            LinkedList<string> list = new LinkedList<string>();
            Console.WriteLine("Выберите для тестировния список 1- list или 2 - linkedlist");
            // читаем весь файл с рабочего стола в строку текста
            byte n = byte.Parse(Console.ReadLine());
            string text = File.ReadAllText("C:\\Users\\User\\Downloads\\Text1.txt");
                switch (n)
                {
                    case 1:
                        var stopWatch1 = Stopwatch.StartNew();
                        strings.Add(text);
                        Console.WriteLine($"Время выполнения: {stopWatch1.Elapsed.TotalMilliseconds}  мс");
                        break;
                    case 2:
                        var stopWatch2 = Stopwatch.StartNew();
                        list.AddFirst(text);
                        Console.WriteLine($"Время выполнения: {stopWatch2.Elapsed.TotalMilliseconds}  мс");
                        break;

                }
            
        }

    }
}
