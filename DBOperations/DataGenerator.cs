using LinqPractices.Entities;

namespace LinqPractices.DBOperations;

public class DataGenerator
{
    public static void Initialize()
    {
        using (var context = new LinqDBContext())
        {
            if (context.Students.Any())
            {
                return;
            }
            
            context.Students.AddRange(
                new Student()
                {
                    StudentId = 1,
                    Name = "Miray",
                    Surname = "Mutlu",
                    ClassId = 1
                },
                new Student()
                {
                    StudentId = 2,
                    Name = "Defne",
                    Surname = "Mutlu",
                    ClassId = 1
                },
                new Student()
                {
                    StudentId = 3,
                    Name = "Elif",
                    Surname = "Ataç",
                    ClassId = 2
                },
                new Student()
                {
                    StudentId = 4,
                    Name = "Zeynep",
                    Surname = "Köylü",
                    ClassId = 2
                });
            context.SaveChanges();
        }
    }
}