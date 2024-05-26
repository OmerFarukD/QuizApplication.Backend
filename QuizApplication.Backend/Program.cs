using QuizApplication.Backend.Context;
using QuizApplication.Backend.Repository;
using QuizApplication.Backend.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<QuestionService>();
builder.Services.AddScoped<IQuestionRepository, QuestionRepository>();
builder.Services.AddScoped<AnswerService>();
builder.Services.AddScoped<IAnswerRepository, AnswerRepository>();
builder.Services.AddDbContext<QuizAppVeriTabaniBaglantisi>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
