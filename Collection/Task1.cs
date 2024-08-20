using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Давайте повторим работу с файлами (и без массивов скорее всего не обойдётся).

По ссылке доступна для скачивания книга в текстовом формате. 

Ваша задача — скачать файл и написать программу, которая подсчитает количество слов в нём.

В качестве разделителей используйте следующие символы: ' ' — символ пробела, \r и \n — символы переноса строки.
 * 
 * 
 * */



namespace Collection
{
    internal class Task1
    {
        public Task1()
        {
            // читаем весь файл с рабочего стола в строку текста
            string text = File.ReadAllText("C:\\Users\\User\\Downloads\\cdev_Text.txt");

            // Сохраняем символы-разделители в массив
            char[] delimiters = new char[] { ' ', '\r', '\n' };

            // разбиваем нашу строку текста, используя ранее перечисленные символы-разделители
            var words = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            // выводим количество
            Console.WriteLine(words.Length);
        }
    }
}
