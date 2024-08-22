// See https://aka.ms/new-console-template for more information
using Collection;
using System.Collections;
using System.Reflection;

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

        var months = new List<string>()
            {
                "Jan", "Feb", "Mar", "Apr", "May"
            };

        var missing = new ArrayList()
            {
                1, 2, 3, 5, "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"
            };
            task2.ChangeList(months, missing);




    }

  
}