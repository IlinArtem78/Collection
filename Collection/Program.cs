// See https://aka.ms/new-console-template for more information
using Collection;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
     //   Task1 task1 = new Task1();
        Task2 task2 = new Task2();
        var arrListOut = new ArrayList();   
        var arrListIn = new ArrayList()
        {
           1,
               "Самая ",
               "лучшая ",
               "коллекция",
               300,

        };
        arrListOut = task2.Met(arrListIn); 
    }
}