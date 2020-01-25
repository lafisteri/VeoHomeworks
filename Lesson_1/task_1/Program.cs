using System;
using System.Collections.Generic;

namespace task_1
{
    /*Реализовать упрощенные аналоги методов LINQ:
-Where
-Select 
-Aggregate
-OrderBy (алгоритм сотрировки непринципиален, делайте как проще)*/

    /* Используйте делегаты в качестве параметров, yield для возвращения значений, перечисленные методы реализуйте в виде extension методов */


    public static class MyLinq
    {
        public static List<T> Where<T>(this List<T> list, Func<T, bool> filter)
        {
            var newList = new List<T>();
            foreach (var item in list)
            {
                if (filter(item))
                {
                    newList.Add(item);
                }
            }
            return newList;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
