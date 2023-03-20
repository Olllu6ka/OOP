using System;

namespace OOP
{
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Создайте программу в которой создайте класс «Адрес».
    //В теле класса создайте следующие поля: страна, город, улица, дом, квартира, индекс.
    //Для каждого поля, создать свойство с двумя методами доступа.Также в классе необходимо
    //создать метод для отображения информации про адрес. В методе Main() создайте экземпляр
    //класса «Адрес», присвойте всем полям значение через свойства доступа, а также на экземпляр
    //класса вызовите метод, который выводит информацию про адрес.
    class Adres
    {
        public string Country;
        public string City;
        public string Street;
        public int House;
        public int Apartment;
        public int Index;
    }
    class Program
    {
        static Adres GetAdres(){
            Adres adres = new Adres();
            adres.Country = "Ukraine";
            adres.City = " Kyiv";
            adres.Street = "Shumsky";
            adres.House = 5;
            adres.Apartment = 22;
            adres.Index = 400138;
            return adres;
        }
        static void Print(Adres adres)
        {
            Console.WriteLine($"Country: {adres.Country}");
            Console.WriteLine($"City: {adres.City}");
            Console.WriteLine($"Street: {adres.Street}");
            Console.WriteLine($"House: {adres.House}");
            Console.WriteLine($"Apartment: {adres.Apartment}");
            Console.WriteLine($"Index: {adres.Index}");
        }
        static void Main(string[] args)
        {
            var InAdres = GetAdres();
            Print(InAdres);
            
        }
    }
}
