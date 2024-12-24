using TaskManager.Communication.Requests;
using TaskManager.Communication.Responses;

namespace TaskManager.Application.UseCases.Task.Update;

public class UpdateTaskUseCase
{
    public ResponseTask? Execute(int id, RequestTask request)
    {
        return new ResponseTask()
        {
            Id = id,
            Description = request.Description,
            LimitDate = request.LimitDate,
            Status = request.Status,    
            Name = request.Name,
            Type = request.Type,    
        };

    }
}
