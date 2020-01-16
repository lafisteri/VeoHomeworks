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
            GetSumRequest request = new GetSumRequest(5);
            //Console.WriteLine(request.ToString());
            GetSumRequestHandler<int[], int> getSum = new GetSumRequestHandler<int[], int>();
            getSum.Handle(request.Numbers);
        }
    }
}
