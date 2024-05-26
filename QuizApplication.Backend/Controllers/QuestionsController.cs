using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuizApplication.Backend.Context;
using QuizApplication.Backend.Models;
using QuizApplication.Backend.Service;
// HttpGet : Veri okumaya yarar (Kaynaktan veri çekmeye yarayan istek)
// HttpPost : veri kaynağına veri eklemek için kullaılan istektir.
// HttpDelete : veri kaynağından veri silmeye yarar
// HttpPut : veri kaynağında bir güncelleme işi yapar.
namespace QuizApplication.Backend.Controllers;
[Route("api/[controller]")]
[ApiController]
// Dependency Injection (Bağımlılık enjektasyonu) : Metod, *Constructor*, Setter injection 


public class QuestionsController : ControllerBase
{

    private QuestionService _questionService;
    public QuestionsController(QuestionService questionService)
    {
        _questionService = questionService;
    }


    [HttpPost("add")]
    public IActionResult Add([FromBody] Question question)
    {
      string result = _questionService.Add(question);
        return Ok(result);
    }


    [HttpGet("getall")]
    public IActionResult GetAll()
    {
        var questions = _questionService.GetAll();
        return Ok(questions);
    }

    [HttpGet("getbyid")]
    public IActionResult GetById([FromQuery] int id)
    {
        var question = _questionService.GetById(id);
        return Ok(question);
    }

}
