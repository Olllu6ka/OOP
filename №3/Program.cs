using System;

namespace _3
{
    class BankAcount
    {
        public string AccountOpeningDate;
        public double AccountInterestRate;
        public double InvoiceAmount;
    }


    class Program
    {
        //Используя Visual Studio, создайте проект по шаблону Console Application.
        //Создайте программу в которой создайте класс «Банковский Счет».
        //В теле класса создайте следующие поля: дата открытия счета, процентная ставка по счету,
        //сумма счета.В теле метода создайте следующие методы: Метод, который рассчитывает
        //количество дней, начиная с даты открытия счета; Метод который выводит информацию о
        //количестве рассчитанных дней; Метод который рассчитывает сумму, которая будет на счете
        //через определенное количество лет(количество лет – параметр метода); Метод который
        //выводит информацию о сумме.Также продумать над конструктором класса. В методе Main()
        //создайте экземпляр класса «Банковский Счет», присвойте всем полям значение через свойства
        //доступа, а также на экземпляр класса вызовите методы для отображения количества дней и
        //суммы.

        static BankAcount Get(string DateY,string DateM, string DateD,double Rate,double Amount){
            BankAcount bankAcount = new BankAcount();
            bankAcount.AccountInterestRate = Rate;
            bankAcount.AccountOpeningDate = (DateD +"."+ DateM +"."+ DateY);
            bankAcount.InvoiceAmount = Amount;
            return bankAcount;
        }
        static void Print(BankAcount bankAcount){
            Console.WriteLine($"Account Interest Rate: {bankAcount.AccountInterestRate}");
            Console.WriteLine($"Account Opening Date: {bankAcount.AccountOpeningDate}");
            Console.WriteLine($"Invice Amount: {bankAcount.InvoiceAmount}");
        }
        static void Day(string DateD,string DateM,string DateY){
            int resultD = int.Parse(DateD);
            int resultM = int.Parse(DateM);
            int resultY = int.Parse(DateY);
            DateTime date = DateTime.Now;
            date = (date.AddDays(- resultD));
            date = (date.AddMonths(-resultM));
            date = (date.AddYears(-resultY));
            Console.WriteLine("Количество дней,месяцев и лет - лежат ваши деньги в банке: "+ date.ToShortDateString());
        }
        static void Money(string DateY, double Rate, double Amount)
        {
            double resultY = double.Parse(DateY);
            resultY = (2023 - resultY);
            double result = ((Amount * Rate) * resultY) + Amount;
            Console.WriteLine("Вот такая сумма будет на вашом счете - " + result);
            Rate = result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать !");
            Console.Write("Введите день открытия счета: (07) "); //Можете подскзать как лучше это оптимизировать ?
            string  DateD = Console.ReadLine();
            Console.Write("Введите месяц открытия счета: (05) ");
            string DateM = Console.ReadLine();
            Console.Write("Введите год открытия счета: (2015) ");
            string DateY = Console.ReadLine();
            Console.Clear();
            Console.Write("Введите поцентную ставку: ");
             double Rate = double.Parse(Console.ReadLine());
            Console.Write("Введите сумму счета: ");
            double Amount = double.Parse(Console.ReadLine());
            for (;;)
            {
                Console.Write("Меню: " + "\nБанковский Счет - 1" + "\tКоличество дней - 2" +
                "\nСумма денег которую вы получите - 3" + "\nВведите число: ");
                int Functuon = int.Parse(Console.ReadLine());
                switch (Functuon)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Банковский Счет");
                        var Int = Get(DateY, DateM, DateD, Rate, Amount);
                        Print(Int);
                        break;
                    case 2:
                        Day(DateD, DateM, DateY);
                        break;
                    case 3:
                        Money(DateY, Rate, Amount);
                        break;
                }
                Console.Write("Хотите еще раз воспользовать Банком ?" + "\nДа то + или Нет то -" + "\nВведите = ");
                string Action = Console.ReadLine();
                Console.Clear();
                if (Action == "-")
                {
                    break;
                }
            }
        }
    }
}
