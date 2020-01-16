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
            var sum = 0;
            foreach (var item in request)
            {
                sum += (int)item;
            }
            //var sum2 = request.GetEnumerator().ToString();


            throw new NotImplementedException();

        }
    }
}