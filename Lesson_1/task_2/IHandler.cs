using System;
namespace task_2
{
    public interface IHandler<TRequest, TResponse>
    {
        TResponse Handle(TRequest request);
    }
}
