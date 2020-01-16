using System;
namespace task_2
{
    public interface IHandler<TRequest, TResponse> : IRequest<TResponse>
    {
        TResponse Handle(TRequest request);
    }
}
