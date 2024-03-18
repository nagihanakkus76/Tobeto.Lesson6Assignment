
using Tobeto.Lesson6Assignment.Entity;

Console.WriteLine("1- Daire \n2- Kare \n3- Üçgen");
Console.WriteLine("Lütfen bir şekil seçiniz.");
string shape = Console.ReadLine();

if (shape == "1" || shape =="Daire" || shape == "daire")
{
    Shape circle = new Circle();
    circle.Draw();
}
else if (shape == "2" || shape == "Kare" || shape == "kare")
{
    Shape square = new Square();
    square.Draw();  
}
else if (shape == "3" || shape == "Üçgen" || shape == "üçgen")
{
    Shape triangle = new Triangle();
    triangle.Draw();    
}
else {
    Console.WriteLine("Geçersiz değer girdiniz.");
}