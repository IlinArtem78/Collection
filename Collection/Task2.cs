using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * Напишите метод, который на вход принимает любой Arraylist input, а на выходе выдает другой Arraylist с двумя элементами, 
 * где первый — число (сумма целочисленных элементов input), а второй — строка (текст, составленный из строковых элементов input).
 * 
 * 
 * 
 */


namespace Collection
{
    public class Task2
    {
           
      
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
}
