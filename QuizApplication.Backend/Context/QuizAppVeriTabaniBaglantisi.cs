using Microsoft.EntityFrameworkCore;
using QuizApplication.Backend.Models;

namespace QuizApplication.Backend.Context;

public class QuizAppVeriTabaniBaglantisi : DbContext
{

    public QuizAppVeriTabaniBaglantisi(DbContextOptions opt) : base(opt)
    {
        
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB; Database=Quiz_app_db; Trusted_Connection= true;");
    }


    public DbSet<Question> Questions { get; set; }
    public DbSet<Answer> Answers { get; set; }

    // add-migration <isim>: .net tarafında değişiklikleri algılar 
    // update-database : görülen değişikliği uygular.
}
