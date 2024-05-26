using QuizApplication.Backend.Models;
using QuizApplication.Backend.Repository;

namespace QuizApplication.Backend.Service;

// Dto : Data Taransfer Object 

public class AnswerService 
{
    private IAnswerRepository _repository;

    public AnswerService(IAnswerRepository repository)
    {
        _repository = repository;
    }

    public void Add(AnswerAddDto answerdto)
    {
        Answer answer = new Answer()
        {
            IsSuccess = answerdto.IsSuccess,
            QuestionId = answerdto.QuestionId,
            Text = answerdto.Text,
        };


        _repository.Add(answer);
    }

    public Answer GetById(int id)
    {
       return _repository.GetById(id);
    }

    public List<Answer> GetAll() 
    {
        return _repository.GetAll();
    }
}
