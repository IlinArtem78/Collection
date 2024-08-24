using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    public class TASK3
    {
        public void Task13_4_5()
        {
            Contact contact1 = new Contact("Андрей", +79992168465, "andrey@email.com");
            Contact contact2 = new Contact("Сергей", +51561161651, "andrey@email.com");
            // запускаем новый таймер
            

            Dictionary<int,Contact> PhooneBook = new Dictionary<int,Contact>();
            SortedDictionary<int, Contact> sortedDictionary = new SortedDictionary<int, Contact>();

            Console.WriteLine("Выберите тип для теста 1 - Dictionary или 2 - SortedDictionary");
            byte n = byte.Parse(Console.ReadLine());
            switch(n)
            {
                case 1:
                    var stopWatch1 = Stopwatch.StartNew();
                    PhooneBook.Add(1, contact1);
                    PhooneBook.Add(2, contact2);
                    Console.WriteLine("Новый контакт в телефонной книге");

                    PhooneBook.Add(5, new Contact("Елизавета", +79992168465, "andrey@email.com"));
                    // смотрим, сколько операция заняла, в миллисекундах
                    Console.WriteLine(stopWatch1.Elapsed.TotalMilliseconds);
                    break;
                    case 2:
                    var stopWatch2 = Stopwatch.StartNew();
                    sortedDictionary.Add(2, contact1);
                    sortedDictionary.Add(5, contact2);
                    Console.WriteLine("Новый контакт в телефонной книге");

                    sortedDictionary.Add(0, new Contact("Елизавета", +79995868465, "andrey@email.com"));
                    foreach (KeyValuePair<int, Contact> p in sortedDictionary)
                        Console.WriteLine($"{p.Key} = {p.Value}");
                    // смотрим, сколько операция заняла, в миллисекундах
                    Console.WriteLine(stopWatch2.Elapsed.TotalMilliseconds);
                    break;
            }
            
        }


    }
    public class Contact // модель класса
    {
        public Contact(string name, long phoneNumber, String email) // метод-конструктор
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public String Name { get; }
        public long PhoneNumber { get; }
        public String Email { get; }
        public int key { set; get; }
    }


}
