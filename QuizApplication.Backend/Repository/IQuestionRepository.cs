using QuizApplication.Backend.Models;

namespace QuizApplication.Backend.Repository;

public interface IQuestionRepository
{
    void Add(Question question);
    List<Question> GetAll();
    Question GetById(int id);
    void Delete(int id);

}
