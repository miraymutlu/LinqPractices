using LinqPractices.DBOperations;
using LinqPractices.Entities;

namespace LinqPractices;
class Program
{
    static void Main(string[] args)
    {
        DataGenerator.Initialize();
        LinqDBContext _context = new LinqDBContext();
        var students = _context.Students.ToList<Student>();
        
        //find()
        Console.WriteLine("*** Find ***");
        var student = _context.Students.Where(student => student.StudentId == 1).FirstOrDefault();
        var student2 = _context.Students.Find(2);
        Console.WriteLine($"Student 1: {student.Name} \n"+$"Student 2: {student2.Name}");
    }
}
