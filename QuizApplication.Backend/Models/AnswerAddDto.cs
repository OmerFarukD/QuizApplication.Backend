namespace QuizApplication.Backend.Models;

public class AnswerAddDto
{
    public string Text { get; set; }

    public bool IsSuccess { get; set; }

    public int QuestionId { get; set; }
}
