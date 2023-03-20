using System;

namespace _2
{
    class Cat{

        public int Age;
        public string Name;
        public string ColorCat;
        public string ColorEyes;
    }
    class Program
    {
        //Используя Visual Studio, создайте проект по шаблону Console Application.
        //Создайте программу в которой создайте класс «Котенок».
        //В теле класса создайте следующие поля: имя, возраст, цвет шерсти, цвет глаз.Для каждого
        //поля, создать свойство с двумя методами доступа.Также в теле класса создайте метод,
        //который будет выводить на консоль «Мяу», метод должен принимать один аргумент –
        //количество «Мяу» котенка, выводить «Мяу» соответствующее количество раз.В методе Main()
        //создайте экземпляр класса «Котенок», присвойте всем полям значение через свойства доступа, а
        //также вызовите метод с помощью которого котенок говорит «Мяу», в качестве аргумента метода
        //передайте 3.

        static Cat GetCat()
        {
            Cat cat = new Cat();
            cat.Age = 10;
            cat.ColorCat = "White";
            cat.ColorEyes = "Black";
            cat.Name = "Grisha";
            return cat;
        }
        static void Print(Cat cat, int Inter)
        {
            Console.WriteLine($"Age: {cat.Age}");
            Console.WriteLine($"ColorCat: {cat.ColorCat}");
            Console.WriteLine($"Color Eyes: {cat.ColorEyes}");
            Console.WriteLine($"Name: {cat.Name}");
            for (int i = 0; i < Inter; i++)
            {
                Console.WriteLine("Мяу");
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Введите сколько должен скзать кот - Мяу:");
            int Interation = int.Parse(Console.ReadLine());
            var Inder = GetCat();
            Print(Inder, Interation);
        }
    }
}
