using TaskManager.Communication.Responses;

namespace TaskManager.Application.UseCases.Task.GetById;

public class GetTaskByIdUseCase
{
    public ResponseTask Execute(int Id)
    {
        return new ResponseTask()
        {
            Id = Id,
            Description = "Test",
            LimitDate = DateTime.Now,
            Name = "Test",
            Status = Communication.Enums.Status.InProgress,
            Type = Communication.Enums.Priority.Mid
        };
    }
}
