using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


/*
 * Напишите метод, который примет на вход обе коллекции, вырежет из второй недостающие месяцы и добавит в наш список. Затем выведет результат в консоль.
 * 
 * 
 * 
 */


namespace Collection
{
    public class Task2
    {

        
    



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
            if (phoneBook[i].Name == contact.Name )
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
                if (input[i] is int )
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

            foreach (var  item in list2) {
              Console.WriteLine(item);
            }

            return list2;

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
}
