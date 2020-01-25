namespace task_2
{
    public interface IHandler<TRequest, TResponse> where TRequest : IRequest<TResponse>
    {
        TResponse Handle(TRequest request);
    }
}
