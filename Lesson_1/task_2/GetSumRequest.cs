using System;
namespace task_2
{
    public class GetSumRequest
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

        public override string ToString()
        {
            string result = null;
            for (int i = 0; i < Numbers.Length; i++)
            {
                result += Numbers[i] + ",";
            }

            return result;
        }
    }
}
