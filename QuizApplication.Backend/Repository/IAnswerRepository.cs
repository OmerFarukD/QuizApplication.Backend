using QuizApplication.Backend.Models;

namespace QuizApplication.Backend.Repository;

public interface IAnswerRepository
{
    void Add(Answer answer);
    List<Answer> GetAll();
    Answer GetById(int id);
    void Delete(int id);

}
