using TaskManager.Communication.Responses;

namespace TaskManager.Application.UseCases.Task.GetAll;

public class GetAllTasksUseCase
{
    public ResponseTaskList Execute()
    {
        return new ResponseTaskList()
        {
            Items =
            [
                new()
                {
                    Id = 1,
                    Description = "Test",
                    LimitDate = DateTime.Now,
                    Name = "Test",
                    Status = Communication.Enums.Status.InProgress,
                    Type = Communication.Enums.Priority.Mid
                },
                new() {
                    Id = 2,
                    Description = "Test 2",
                    LimitDate = DateTime.Now,
                    Name = "Test2",
                    Status = Communication.Enums.Status.Pause,
                    Type = Communication.Enums.Priority.Low
                },
            ]
        };
    }
}
