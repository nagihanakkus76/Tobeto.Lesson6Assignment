using Tobeto.Lesson6Assignment.Entity;

var studentRepo = new GenericRepository<Student>();
var teacherRepo = new GenericRepository<Teacher>();


studentRepo.Add(new Student() { ID =10, FirstName="Zeki", LastName="Çiçek", SchoolNumber="4334"});

foreach (var student in studentRepo.GetAll())
{
    Console.WriteLine(student.ID + " " + student.FirstName + " " + student.LastName + "  No: " +student.SchoolNumber);
}
Console.WriteLine();
Console.WriteLine();

foreach (var teacher in teacherRepo.GetAll())
{
    Console.WriteLine(teacher.ID + " " + teacher.FirstName + " " + teacher.LastName + "  Branş: " + teacher.Branch);
}


