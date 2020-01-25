using System;

namespace task_2
{
    /*Создать инфраструктуру обработчиков запросов:
-интерфейс IRequest<TResponse>, где TResponse - тип ответа на запрос (тип возвращаемого зачения)
Интерфейс не содержит методов и используется как маркер для класса-реквеста.Реквест может содержать произвольные свойства,
используемые для того чтобы передать в обработчик необходимые для обработки данные.
-интерфейс IHandler<TRequest, TResponse>.
Реализация определенным клаccом интерфейса IHandler<TRequest, TResponse> обязывае этот класс реализовать метод Handle,
принимающий в качестве параметра TRequest и возвращающий TResponse
-создать класс GetSumReuqest, который будет содержать массив целых чисел
-создать класс обработчик GetSumRequestHandler, который будет обрабатывать запрос GetSumReuqesе и возвращать сумму переданных чисел
-создать экземпляры запроса и обработчика, обработать запрос в методе Main*/
    class Program
    {
        static void Main(string[] args)
        {
            //-создать класс GetSumRequestInt, который будет содержать массив целых чисел
            GetSumRequestInt request = new GetSumRequestInt(5);
            foreach (var item in request.Numbers)
            {
                Console.WriteLine(item);
            }


            //-создать класс обработчик GetSumRequestHandler, который будет обрабатывать запрос GetSumReuqesе и возвращать сумму переданных чисел
            GetSumRequestHandler getSum = new GetSumRequestHandler();
            Console.WriteLine("GetSumRequest " + getSum.Handle(request));
        }
    }
}
