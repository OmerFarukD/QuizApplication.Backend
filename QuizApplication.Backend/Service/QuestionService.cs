using QuizApplication.Backend.Models;
using QuizApplication.Backend.Repository;
using System.Collections.Generic;

namespace QuizApplication.Backend.Service;

public class QuestionService
{


    private IQuestionRepository _repository;

    public QuestionService(IQuestionRepository repository)
    {
        

        _repository = repository;
    }
    public string Add(Question question)
    {
        //if (question.Text.Length < 2)
        //{
        //    return "Soruların metni minimum 2 karakterli olmalıdır";
        //}

        _repository.Add(question);

        return "Soru başarıyla kaydedildi";
    }

    public List<QuestionResponseDto> GetAll()
    {
        List<QuestionResponseDto> dtos = new List<QuestionResponseDto>();

        foreach (Question question in _repository.GetAll()) 
        {
            var resposeDto = ConvertToResponseDto(question);
            dtos.Add(resposeDto);
        }
        

        return dtos;

    }

    

 

    public QuestionResponseDto GetById(int id) 
    {
        var data = _repository.GetById(id);


        return ConvertToResponseDto(data);
    }

    private QuestionResponseDto ConvertToResponseDto(Question question)
    {
        QuestionResponseDto response = new QuestionResponseDto()
        {
            Id = question.Id,
            Text = question.Text,
            Answers = question.Answers.Select(x => new AnswerResponseDto() { Id = x.Id, IsSuccess = x.IsSuccess, Text = x.Text }).ToList()
        };

        return response;
    }

}
