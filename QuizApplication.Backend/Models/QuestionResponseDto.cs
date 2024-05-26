namespace QuizApplication.Backend.Models;

public class QuestionResponseDto
{
    public int Id { get; set; }
    public string Text { get; set; }
    public List<AnswerResponseDto> Answers { get; set; }

}
