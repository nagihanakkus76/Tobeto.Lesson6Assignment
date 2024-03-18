using Tobeto.Lesson6Assignment.Entity;

Console.WriteLine("\n 1- Kedi \n 2- Köpek\nLütfen bir hayvan seçiniz:");
string data =Console.ReadLine();
if (data == "1" || data == "Kedi" || data == "kedi")
{
    Animal cat = new Cat();
    cat.MakeSound();
}
else if (data == "2" || data == "Köpek" || data == "köpek")
{
    Animal dog = new Dog();
    dog.MakeSound();
}
else { Console.WriteLine("Hatalı seçim"); }