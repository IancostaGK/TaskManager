using TaskManager.Communication.Requests;
using TaskManager.Communication.Responses;

namespace TaskManager.Application.UseCases.Task.Create;

public class CreateTaskUseCase
{
    public ResponseRegisterTask Execute(RequestTask request)
    {
        var response = new ResponseRegisterTask()
        {
            Id = new Random().Next()
        };

        return response;
    }
}
