using System;
using System.Collections.Generic;

namespace task_3
{
    /*
     Дан следующий код: 
namespace TmpConsole
{
class Base { }

class A : Base { }

class B : Base { }

class Program
{
    static void Main(string[] args)
    {
        var list = new List<Base>()
        {
            new A(),
            new B(),
            new A()
        };

        foreach (var item in list)
        {
            PrintType(item);
        }
    }

    private static void PrintType<T>(T item)
    {
        Console.WriteLine(typeof(T));
    }
}
}

При выполнении кода получаем следующий вывод в консоль:
TmpConsole.Base
TmpConsole.Base
TmpConsole.Base

3.1(*) - Сделать так, чтобы в консоль выводились реальные типы елементов списка (A, B, A)

3.2(**) - Аналогично заданию 3.1, но метод PrintType должен остаться без изменений
     */

    class Base { }

    class A : Base { }

    class B : Base { }

    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Base>()
            {
                new A(),
                new B(),
                new A()
            };

            Console.WriteLine("Original");
            foreach (var item in list)
            {
                PrintType(item);
            }

            Console.WriteLine("\n3.1(*)");
            foreach (var item in list)
            {
                PrintType2(item);
            }

            Console.WriteLine("\n3.2(**)");
            foreach (var item in list)
            {
                PrintType((dynamic)item);
            }
        }

        private static void PrintType<T>(T item)
        {
            Console.WriteLine(typeof(T));
        }

        private static void PrintType2<T>(T item)
        {
            Console.WriteLine(item.GetType());
        }
    }
}
