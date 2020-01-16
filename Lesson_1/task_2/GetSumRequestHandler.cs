using System;
using System.Collections;

namespace task_2
{
    public class GetSumRequestHandler<TRequest, TResponse> : IHandler<TRequest, TResponse> where TRequest : IEnumerable
    {
        public GetSumRequestHandler()
        {
        }

        public TResponse Handle(TRequest request)
        {
            throw new NotImplementedException();

        }

        public int GetSumRequest(TRequest request)
        {
            int sum = 0;
            foreach (var item in request)
            {
                sum += (int)item;
            }
            return sum;
        }
    }
}