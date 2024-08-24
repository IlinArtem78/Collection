using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{


    //Теперь измените код так, чтобы программа поддерживала команды pop и peek
    //(при вводе с консоли pop из стека должен удаляться последний элемент,
    //а команда peek должна показывать последний элемент без удаления).
    public class Task4
    {
        public static Stack<string> words = new Stack<string>();

        public Task4()
        {
            

            while (true)
            {
                Console.WriteLine("Введите слово и нажмите Enter, чтобы добавить его в стек.");
                Console.WriteLine();
                var input = Console.ReadLine();

                words.Push(input); // Изменить здесь
                Console.WriteLine("В стеке:");

                foreach (var word in words)
                {
                    Console.WriteLine(" " + word);
                }

                Console.WriteLine("Введите команду для проверки функционирования стека pop или peek");
                
                switch (input)
                {
                    //   если  команда pop - пробуем достать элемент
                    case "pop":
                        words.TryPop(out string popResult);
                        break;
                    //   если  команда peek - пробуем  просмотреть элемент
                    case "peek":
                        words.TryPeek(out string peekResult);
                        break;
                    default:
                        // если ни одна из команд не распознана - простов стек добавляем то что введено
                        words.Push(input);
                        break;
                }
               





            }
            


        }

    }
}
