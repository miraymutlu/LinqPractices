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
        
        //Find()
        Console.WriteLine("*** Find ***");
        var student = _context.Students.Where(student => student.StudentId == 1).FirstOrDefault();
        var student2 = _context.Students.Find(2);
        Console.WriteLine($"Student 1: {student.Name} \n"+$"Student 2: {student2.Name}\n");
        
        //FirstOrDefault()
        Console.WriteLine("*** First Or Default ***");
        student = _context.Students.Where(student => student.Surname == "Mutlu").FirstOrDefault();
        Console.WriteLine($"Student 1: {student.Name}\n");
        
        //SingleOrDefault()
        Console.WriteLine("*** Single Or Default ***");
        student = _context.Students.Where(student => student.Surname == "Ataç").SingleOrDefault();
        Console.WriteLine($"Student 1: {student.Name}\n");

        //ToList()
        Console.WriteLine("*** To List ***");
        var studentList = _context.Students.Where(student => student.ClassId == 2).ToList();
        Console.WriteLine($"Student Count: {studentList.Count}");
        
        //OrderBy()
        Console.WriteLine("*** Order By ***");
        Console.WriteLine("List Of The Students:");
        students = _context.Students.OrderBy(students => students.StudentId).ToList();
        foreach (var st in students)
        {
            Console.WriteLine($"{st.StudentId} - {st.Name} {st.Surname}");
        }

        //OrderByDescending()
        Console.WriteLine("*** Order By Descending***");
        Console.WriteLine("List Of The Students:");
        students = _context.Students.OrderByDescending(students => students.StudentId).ToList();
        foreach (var st in students)
        {
            Console.WriteLine($"{st.StudentId} - {st.Name} {st.Surname}");
        }
    }
}
