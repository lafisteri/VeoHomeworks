using System;
namespace task_2
{
    public class GetSumRequest<TResponse> : IRequest<TResponse>
    {
        public int[] Numbers { get; }

        public GetSumRequest(int size)
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
