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
    }
}
