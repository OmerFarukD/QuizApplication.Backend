namespace QuizApplication.Backend.Models;

public class Answer
{
    public int Id { get; set; }

    public string Text { get; set; }

    public bool IsSuccess { get; set; }

    public int QuestionId { get; set; }

    public Question Question { get; set; }
}
