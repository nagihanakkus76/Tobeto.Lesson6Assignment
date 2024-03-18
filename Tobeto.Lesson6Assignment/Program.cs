using Tobeto.Lesson6Assignment.Models;

Engineer engineer = new Engineer();
engineer.Id = 1;
engineer.FirstName = "Ali";
engineer.LastName = "Işık";
engineer.Age = 25;

Console.WriteLine(engineer.Id + " : " + engineer.FirstName + " " + engineer.LastName + " \nYaş:  " + engineer.Age);

Console.WriteLine();


Teacher teacher = new Teacher();
teacher.Id = 2;
teacher.FirstName = "Ayşe";
teacher.LastName = "Soner";
teacher.Age = 29;
Branch branch = new Branch();
branch.ID = 3;
branch.Name = "Fen Bilimleri";
teacher.branch = branch;

Console.WriteLine(teacher.Id + " : " + teacher.FirstName + " " + teacher.LastName + " \nYaş:  " + teacher.Age  + "\nBranş :" + teacher.branch.Name);

