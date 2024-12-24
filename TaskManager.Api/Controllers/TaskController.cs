using Microsoft.AspNetCore.Mvc;
using TaskManager.Application.UseCases.Task.Create;
using TaskManager.Application.UseCases.Task.Delete;
using TaskManager.Application.UseCases.Task.GetAll;
using TaskManager.Application.UseCases.Task.GetById;
using TaskManager.Application.UseCases.Task.Update;
using TaskManager.Communication.Requests;
using TaskManager.Communication.Responses;

namespace TaskManager.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TaskController : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(typeof(ResponseTaskList), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GetAll()
    {
        var response = new GetAllTasksUseCase().Execute();

        if (!response.Items.Any())
        {
            return NoContent();
        }

        return Ok(response);
    }

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponseTask), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult GetById([FromRoute] int id)
    {
        var response = new GetTaskByIdUseCase().Execute(id);

        if (response is null)
        {
            return NotFound();
        }

        return Ok(response);
    }

    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterTask), StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult Register([FromBody] RequestTask request)
    {
        var response = new CreateTaskUseCase().Execute(request);

        return Created(string.Empty, response);
    }


    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult Update([FromRoute] int id, [FromBody] RequestTask request)
    {
        new UpdateTaskUseCase().Execute(id, request);
        return NoContent();
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult Delete([FromRoute] int id)
    {
        var response = new DeleteTaskUseCase().Execute(id);

        if (response is null)
        {
            return NotFound();
        }

        return NoContent();
    }
}
