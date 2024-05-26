using QuizApplication.Backend.Context;
using QuizApplication.Backend.Models;

namespace QuizApplication.Backend.Repository;

// Repository katmanında sadece veritabanı işlemleri yapılır.
public class AnswerRepository : IAnswerRepository
{
    private QuizAppVeriTabaniBaglantisi _dbBaglantisi;

    public AnswerRepository(QuizAppVeriTabaniBaglantisi dbBaglantisi)
    {
        _dbBaglantisi = dbBaglantisi;
    }

    public void Add(Answer answer)
    {
 
       _dbBaglantisi.Answers.Add(answer);
        _dbBaglantisi.SaveChanges();
    }

    public void Delete(int id)
    {
        Answer answer = _dbBaglantisi.Answers.Find(id);
        if (answer != null)
        {
            _dbBaglantisi.Remove(answer);
            _dbBaglantisi.SaveChanges();
        }

    }

    public List<Answer> GetAll()
    {
        List<Answer> answers = _dbBaglantisi.Answers.ToList();
        return answers;
    }

    public Answer GetById(int id)
    {
        Answer answer = _dbBaglantisi.Answers.Find(id);
        return answer;
    }
}
