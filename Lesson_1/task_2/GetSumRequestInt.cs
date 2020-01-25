using System;
namespace task_2
{
    public class GetSumRequestInt : IRequest<int>//запрос на который нужно вернуть int
    {
        public int[] Numbers { get; }

        public GetSumRequestInt(int size)
        {
            var randNumber = new Random();
            Numbers = new int[size];
            for (int i = 0; i < Numbers.Length; i++)
            {
                Numbers[i] = randNumber.Next(20);
            }
        }
    }
}
