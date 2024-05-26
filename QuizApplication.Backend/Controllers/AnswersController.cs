using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuizApplication.Backend.Models;
using QuizApplication.Backend.Service;

namespace QuizApplication.Backend.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AnswersController : ControllerBase
{
    private AnswerService _answerService;
    public AnswersController(AnswerService answerService)
    {
        _answerService = answerService;
    }

    [HttpGet("getall")]
    public IActionResult GetAll()
    {
     var list =_answerService.GetAll();
        return Ok(list);
    }

    [HttpGet("getbyid")]
    public IActionResult GetById([FromQuery]int id)
    {
        var result = _answerService.GetById(id);
        return Ok(result);
    }

    [HttpPost("add")]
    public IActionResult Add(AnswerAddDto answer)
    {
        _answerService.Add(answer);
        return Ok(answer);
    }
}
