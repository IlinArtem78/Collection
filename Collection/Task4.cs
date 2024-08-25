using System;
using System.Collections.Concurrent;
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
/*
        public Task4()
        {


            Console.WriteLine("Введите слово и нажмите Enter, чтобы добавить его в стек.");
            Console.WriteLine();

            while (true)
            {
                var input = Console.ReadLine();

                words.Push(input); // Изменить здесь
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

                Console.WriteLine();
                Console.WriteLine("В стеке:");

                foreach (var word in words)
                {
                    Console.WriteLine(" " + word);
                }
            }


            


        } 
  */
            
        public void HowQueWork()
        {
            // создаем очередь
            Queue<int> q = new Queue<int>();

            // добавляем в нее целые числа от 0 до 10
            for (int i = 0; i <= 10; i++)
            {
                q.Enqueue(i);
                Console.WriteLine($"{i} зашёл в очередь");
            }

            // Посмотрим, кто первый в очереди
            Console.WriteLine($"Первый элемент:   {q.Peek()}");

            // Обратите внимание, после  вызова Peek() элемент остается в очереди

            //  Посмотрим всю очередь
            Console.WriteLine("Элементы в очереди");
            foreach (int i in q)
                Console.Write(i + " ");

            Console.WriteLine();
            Console.WriteLine($"В очереди  {q.Count} элементов");
            // обработаем очередь -
            // достанем из неё элементы один за другим
            var queueLength = q.Count;
            for (int i = 0; i < queueLength; i++)
                Console.WriteLine($"{q.Dequeue()} вышел из очереди");
            //  Посмотрим, сколько элементов осталось
            Console.WriteLine($"В очереди  {q.Count} элементов");
        }

        // объявим потокобезопасную очередь (полностью идентична обычной очереди, но
        // позволяет безопасный доступ
        // из разных потоков)
        public static ConcurrentQueue<string> words1 = new ConcurrentQueue<string>();

        public void Task13_5_8() {
            Console.WriteLine("Введите слово и нажмите Enter, чтобы добавить его в очередь.");
            Console.WriteLine();

            //  запустим обработку очереди в отдельном потоке
            StartQueueProcessing();

            while (true)
            {
                var input = Console.ReadLine();
                //Теперь попробуйте изменить программу так, чтобы при вводе команды peek нам было показано, кто крайний в очереди.
                words1.Enqueue(input); // ИЗМЕНИТЬ ЗДЕСЬ
                if (input == "peek")
                {
                    if (words1.TryPeek(out var elem))
                        Console.WriteLine(elem);
                }
                else
                {
                    // если не введена - ставим элемент в очередь, как и обычно
                    words1.Enqueue(input);
                }
                // Посмотрим, кто первый в очереди
             //   Console.WriteLine($"Первый элемент:   {words1.TryPeek(out var output)}");
            }
        }

        // метод, который обрабатывает и разбирает нашу очередь в отдельном потоке
        // ( для выполнения задания изменять его не нужно )
        static void StartQueueProcessing()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;

                while (true)
                {
                    Thread.Sleep(5000);
                    if (words1.TryDequeue(out var element))
                        Console.WriteLine("======>  " + element + " прошел очередь");
                }

            }).Start();
        }
    }

}

 

