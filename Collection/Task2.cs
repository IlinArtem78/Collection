using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


/*
 * 
 * 
 * Подсчитайте, сколько уникальных символов в этом предложении, используя HashSet<T>, 
 * учитывая знаки препинания, но не учитывая пробелы в начале и в конце предложения.
 * 
 */


namespace Collection
{
    public class Task2
    {

        public void Task13_3_10()
        {
            while (true)
            {

            
            string strings = Console.ReadLine(); 

           // string strings = "Подсчитайте, сколько уникальных символов в этом предложении, используя HashSet<T>, учитывая знаки препинания, но не учитывая пробелы в начале и в конце предложения.";


            var charn = strings.ToCharArray();

            HashSet<char> hSet = new HashSet<char>(charn);
           
            foreach(var n in hSet)
            {
                hSet.Add(n);

            }

            Console.WriteLine("Длина хэш-сета " + hSet.Count);
            
            // сохраняем знаки препинания в массив Char
            var signs = new[] { ',', ' ', '.' };

            // сохраняем числовые символы в массив Char
            var numbers = new[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            //  Проверяем, есть ли цифры
            bool containsNumbers = hSet.Overlaps(numbers);
            Console.WriteLine($"Коллекция содержит цифры: {containsNumbers}");

            // Отбрасываем знаки препинания и заново считаем
            hSet.ExceptWith(signs);
            Console.WriteLine($"Символов без знаков препинания:: {hSet.Count}");



            }



        }


    




    public void ChangeList(List<string> FirstCollection, ArrayList SecondCoolection)
    {

        // инициализируем массив для 7 нужных нам недостающих элементов
        var missedArray = new string[7];

        // извлекаем эти элементы из ArrayList, и копируем в массив
        SecondCoolection.GetRange(4, 7).CopyTo(missedArray);

        // Добавляем наш массив в конец списка
        FirstCollection.AddRange(missedArray);

        // смотрим, что получилось
        foreach (var month in FirstCollection)
            Console.WriteLine(month);





    }








    public void AddUnique(Contact contact, List<Contact> phoneBook)
    {
        bool alreadyExists = false;
        for (int i = 0; i < phoneBook.Count; i++) {
            if (phoneBook[i].Name == contact.Name)
            {
                alreadyExists = true;
            }

        }
        if (!alreadyExists)
        {
            phoneBook.Add(contact);

        }


    }

    public ArrayList Met(ArrayList input)
    {
        int k = 0;
        int sum = 0;
        string st = " ";

        for (int i = 0; i < input.Count; i++)
        {
            if (input[i] is int)
            {
                sum += (int)input[i];
            }
            if (input[i] is string)
            {
                st += (string)input[i];
            }
        }

        var list2 = new ArrayList();
        list2.Add(sum);
        list2.Add(st);

        foreach (var item in list2) {
            Console.WriteLine(item);
        }

        return list2;

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
}



