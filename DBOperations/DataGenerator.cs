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
                    Name = "Miray",
                    Surname = "Mutlu",
                    ClassId = 1
                },
                new Student()
                {
                    Name = "Defne",
                    Surname = "Mutlu",
                    ClassId = 1
                },
                new Student()
                {
                    Name = "Elif",
                    Surname = "Ataç",
                    ClassId = 2
                },
                new Student()
                {
                    Name = "Zeynep",
                    Surname = "Köylü",
                    ClassId = 2
                });
            context.SaveChanges();
        }
    }
}