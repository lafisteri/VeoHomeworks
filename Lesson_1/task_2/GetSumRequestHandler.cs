namespace task_2
{
    public class GetSumRequestHandler : IHandler<GetSumRequestInt, int>
    {
        public int Handle(GetSumRequestInt request)
        {
            int sum = 0;
            foreach (var item in request.Numbers)
            {
                sum += item;
            }
            return sum;
        }
    }
}