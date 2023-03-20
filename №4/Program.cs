using System;

namespace _4
{
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Создайте программу, в которой создайте класс «Треугольник». В теле класса создайте три
    //закрытых поля для описания сторон треугольника и три свойства для чтения и записи. Также в
    //теле класса создайте 3 метода: 1-й для расчета площади треугольника, формула для расчета S =
    //√p ∗ (p − a) ∗ (p − b) ∗ (p − c), где p - полупериметр треугольника p = (a + b + c)/2, a, b, c –
    //длины сторон треугольника, 2-й для расчета периметра треугольника, формула для расчета p =
    //(a + b + c) / 2 и 3-й для вывода информации о площади и периметре треугольника.Создайте
    //конструктор, который в качестве аргументов приминимает стороны треугольника и
    //инициализирует поля класса.В методе Main() создайте экземпляр класса «Треугольник», задайте
    //произвольное значение сторон треугольника и выведите на экран значение периметра и
    //площади треугольника.
    class Program{
        static void Main(string[] args){
            Triangle triangle = new Triangle();
            void S(double First, double Second, double Third){
                double resultS = Math.Sqrt(triangle.Ptriangle * (triangle.Ptriangle - First) * (triangle.Ptriangle - Second) * (triangle.Ptriangle - Third));
                Console.WriteLine("Площа - " + resultS);
                triangle.Striangle = resultS;
                Console.WriteLine();
            }
            void P(double First, double Second, double Third){
                double resultP = ( First + Second + Third)/2;
                Console.WriteLine("Перимет - " + resultP);
                triangle.Ptriangle = resultP;
                Console.WriteLine();
            }
            Console.Write("Введите первую сторону = ");
            double FirstMain = double.Parse(Console.ReadLine());
            Console.Write("Введите вторую сторону = ");
            double SecondMain = double.Parse(Console.ReadLine());
            Console.Write("Введите третию сторону = ");
            double ThirdMain = double.Parse(Console.ReadLine());
            triangle.firstSide = FirstMain;
            triangle.secondSide = SecondMain;
            triangle.thirdSide = ThirdMain;
            for (;;){
                Console.Write("Меню: " + "\nРасчет площади - 1" + "\tРасчет периметра - 2" +
                                "\nВвывод всех данных - 3" + "\nВведите число: ");
                int Functuon = int.Parse(Console.ReadLine());
                switch (Functuon)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Расчет площади");
                        S(FirstMain, SecondMain, ThirdMain);  
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Расчет периметра");
                        P(FirstMain, SecondMain, ThirdMain);
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Ввывод всех данных");
                        triangle.Print(triangle);
                        break;
                }
                Console.Write("Хотите еще раз воспользовать Каркулятором треугольника ?" + "\nДа то + или Нет то -" + "\nВведите = ");
                string Action = Console.ReadLine();
                Console.Clear();
                if (Action == "-"){
                    break;
                }
            }
        }
        class Triangle
        {
            private double Firstside;
            private double Secondside;
            private double Thirdside;
            private double P;
            private double S;
            public double firstSide
            {
                set{Firstside = value;}
                get { return Firstside; }
            } //Как сделать одну общую чтобы не было повторений ?
            public double secondSide
            {
                set{Secondside = value;}
                get {return Firstside;}
            }
            public double thirdSide
            {
                set { Thirdside = value;}
                get { return Firstside; }
            }
            public double Ptriangle
            {
                set { P = value;}
                get { return P; }
            }
            public double Striangle
            {
                set{ S = value; }
                get { return S; }
            }
            public void Print(Triangle triangle){
                Console.WriteLine($"Первая сторона = {triangle.Firstside}");
                Console.WriteLine($"Вторая сторона = {triangle.Secondside}");
                Console.WriteLine($"Третя сторона = {triangle.Thirdside}");
                Console.WriteLine($"Периметр треугольника = {triangle.P}");
                Console.WriteLine($"Площа треугольника = {triangle.S}");
                Console.WriteLine();
            }
        }
    }
}