// See https://aka.ms/new-console-template for more information
using Collection;
using System.Collections;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        try { 
        Console.WriteLine("Выберите задания 13.6.1 или 13.6.2"); 
        byte numTask = byte.Parse(Console.ReadLine());
        switch(numTask)
            {
                case 1:
                    Task13_6_1 task13_6_1 = new Task13_6_1();
                    task13_6_1.Task();
                break; 
                case 2:
                    Task13_6_2 task13_6_2 = new Task13_6_2();
                break;
                default:
                    Console.WriteLine("Выбран неверный номер"); 
                break;
            }
        }
        catch (Exception ex) {
        Console.WriteLine(ex.ToString());   
        }

    }


}