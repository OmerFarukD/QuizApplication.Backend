using Microsoft.EntityFrameworkCore;
using QuizApplication.Backend.Context;
using QuizApplication.Backend.Models;

namespace QuizApplication.Backend.Repository;

// EDD: Engineering Driven Development

public class QuestionRepository : IQuestionRepository
{

    private QuizAppVeriTabaniBaglantisi _dbBaglantisi;

    public QuestionRepository(QuizAppVeriTabaniBaglantisi quizAppVeriTabani)
    {
        _dbBaglantisi = quizAppVeriTabani;
    }


    public void Add(Question question)
    {
     
        _dbBaglantisi.Questions.Add(question);
        _dbBaglantisi.SaveChanges();
    }

    public void Delete(int id)
    {
        // Delete from Questions where Id= 1
        var soru = _dbBaglantisi.Questions.Find(id);
        if (soru != null)
        {
            _dbBaglantisi.Questions.Remove(soru);
            _dbBaglantisi.SaveChanges();
        }
    }

    public List<Question> GetAll()
    {
        // Sorular gelir 
        List<Question> list = _dbBaglantisi.Questions.Include(x=>x.Answers).ToList();
        return list;

    }

    public Question GetById(int id)
    {
        //1.  LINQ
        Question question = _dbBaglantisi.Questions.Include(x=>x.Answers).SingleOrDefault(x=> x.Id==id);


        //2. Yöntem
        //Question getById = new Question();

        //foreach (Question question in _dbBaglantisi.Questions)
        //{
        //    if (question.Id==id)
        //    {
        //        getById = question;
        //    }
        //}

        //return getById;


        //13.55 te dersteyiz.
        return question;
    }
}
