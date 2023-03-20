using System;

namespace _5
{
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Создайте программу, в которой создайте класс «Точка» – для описания координат точки на
    //координатной прямой рис No1.В теле класса создайте следующие закрытые поля: целочисленное
    //поле для описания координаты точки X и целочисленное поле для описания координаты точки
    //Y, а также строковое поле для имени точки.Создать три свойства с методами доступа get и
    //set, а также конструктор класса, который будет инициализировать данные поля значениями
    //аргументов.Далее создайте класс «Фигура». В теле класса фигура создайте одно поле типа масив
    //«Точек» и одно строкове поле для имени фигуры и 2 конструктора, которые принимают 3
    //(треугольника) и 4 аргумента (четырехугольника). В теле класса «Фигура» создайте два метода: 1-
    //й для расчета длины стороны фигуры, метод должен принимать 2 аргумента типа «Точка» и
    //возвращать длину стороны, формула для расчета d = √(x2 − x1)2 + (y2 − y1) 2 и метод для
    //расчета периметра фигуры(подсказка – в методе циклом перебирать массив «Точек», пока в нем
    //будут элементы, и рассчитывать длину стороны). В методе Main() создать и рассчитать периметр
    //треугольника, квадрата, прямоугольника, точки выбрать произвольные.
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point();
            Figure figure = new Figure();
            Console.Write("Введите какую фигуру хотите расчитать." + "\n1)Треугольник" + "\t2)Прямоугольника" + "\t3)Квадрат" 
                + "\nВведите название фигуры которое возле фигуры: ");
            figure.NameFigure = Console.ReadLine();
            switch (figure.NameFigure)
            {
                case "Треугольник":
                    Console.WriteLine($"Сторона треугольник ");
                    Console.Write($"Введите точку х1: ");
                    double Xmain = double.Parse(Console.ReadLine());
                    Console.Write($"Введите точку y1: ");
                    double Ymain = double.Parse(Console.ReadLine());
                    Console.Write($"Введите точку х2: ");
                    double Xmain2 = double.Parse(Console.ReadLine());
                    Console.Write($"Введите точку y2: ");
                    double Ymain2 = double.Parse(Console.ReadLine());
                    Console.Write($"Введите точку х3: ");
                    double Xmain3 = double.Parse(Console.ReadLine());
                    Console.Write($"Введите точку y3: ");
                    double Ymain3 = double.Parse(Console.ReadLine());
                    figure.Mathlength(Xmain3,Xmain2, Xmain,Ymain3,Ymain2,Ymain);
                    break;
                case "Прямоугольника":
                    Console.WriteLine($"Сторона Прямоугольника ");
                    Console.Write($"Введите точку х1: ");
                    Xmain = double.Parse(Console.ReadLine());
                    Console.Write($"Введите точку y1: ");
                    Ymain = double.Parse(Console.ReadLine());
                    Console.Write($"Введите точку х2: ");
                    Xmain2 = double.Parse(Console.ReadLine());
                    Console.Write($"Введите точку y2: ");
                    Ymain2 = double.Parse(Console.ReadLine());
                    Console.Write($"Введите точку х3: ");
                    Xmain3 = double.Parse(Console.ReadLine());
                    Console.Write($"Введите точку y3: ");
                    Ymain3 = double.Parse(Console.ReadLine());
                    figure.Mathlength(Xmain3, Xmain2, Xmain, Ymain3, Ymain2, Ymain);
                    break;
                case "Квадрат":
                    Console.WriteLine($"Сторона Квадрата ");
                    Console.Write($"Введите точку х1: ");
                    Xmain = double.Parse(Console.ReadLine());
                    Console.Write($"Введите точку y1: ");
                    Ymain = double.Parse(Console.ReadLine());
                    Console.Write($"Введите точку х2: ");
                    Xmain2 = double.Parse(Console.ReadLine());
                    Console.Write($"Введите точку y2: ");
                    Ymain2 = double.Parse(Console.ReadLine());
                    Console.Write($"Введите точку х3: ");
                    Xmain3 = double.Parse(Console.ReadLine());
                    Console.Write($"Введите точку y3: ");
                    Ymain3 = double.Parse(Console.ReadLine());
                    figure.Mathlength(Xmain3, Xmain2, Xmain, Ymain3, Ymain2, Ymain);
                    break;
            } //как можно это сделать меньше ?
        }
        class Point
        {
            private double x;
            private double y;
            private string name;

            public double xGetSet {
                set { x = value; }
                get { return x; }
            }
            
            public double yGetSet {
                set { y = value; }
                get { return y; }
            }
            public string NameGetSet {
                set { name = value; }
                get { return name; }
            }
        }
        class Figure
        {

            public double[] array = new double[4];
            public string NameFigure;

            public void Triangle(double Lenght1, double Lenght2, double Lenght3)
            {
                NameFigure = "Треугольник";
                array[0] = Lenght1;
                array[1] = Lenght2;
                array[2] = Lenght3;
                Console.WriteLine("Figure - " + NameFigure + " периметр = " + (array[0]+array[1]+array[2]));

            }
            public void Quadrilateral(double Lenght1, double Lenght2)
            {
                NameFigure = "Прямоугольника";
                array[0] = Lenght1;
                array[1] = Lenght2; 
                Console.WriteLine("Figure - " + NameFigure + " периметр = " + ((array[0] + array[1])*2));
            }
            public void Square(double Lenght1, double Lenght2, double Lenght3)
            {
                NameFigure = "Квадрат";
                array[0] = Lenght1;
                array[1] = Lenght2;
                array[2] = Lenght3;
                Console.WriteLine("Figure - " + NameFigure + " периметр = " + (array[0] * 4));
            }
            public void Mathlength(double xMain3,double xMain2, double xMain1,double yMain3,double yMain2, double yMain1)
            {
                Point point = new Point();
                double Lenght1 = Math.Sqrt(((xMain2 - xMain1)*(xMain2 - xMain1)) + ((yMain2 - yMain1)*(yMain2 - yMain1)));

                double Lenght2 = Math.Sqrt(((xMain3 - xMain1) * (xMain3 - xMain1)) + ((yMain3 - yMain1) * (yMain3 - yMain1)));

                double Lenght3 = Math.Sqrt(((xMain2 - xMain3) * (xMain2 - xMain3)) + ((yMain2 - yMain3) * (yMain2 - yMain3)));

                switch (NameFigure)
                {
                    case "Треугольник":
                            Triangle(Lenght1, Lenght2, Lenght3);
                    break;
                    case "Прямоугольника":
                            Quadrilateral(Lenght1, Lenght2);
                    break;
                    case "Квадрат":
                            Quadrilateral(Lenght1, Lenght2);
                        break;

                }
            }
        }
    }
}   

