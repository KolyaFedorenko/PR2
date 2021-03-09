using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    class Operator
    {
        public string firstname; //имя
        public string lastname; // фамилия
        public string agencyname; // название агенства
        public Operator(string f, string l, string a) { firstname = f; lastname = l; agencyname = a; }
        public void GetInfo()
        {
            Console.WriteLine($"Имя: {firstname} Фамилия: {lastname} Название агенства: {agencyname}");
        }
    }
    class Tourist
    {
        public string firstname; // имя
        public string lastname; // фамилия
        public long telephone; // телефон
        public int contractnumber; // номер контракта

        public Tourist(string firstname, string lastname, string country)
        {
            this.firstname = firstname;
            this.lastname = lastname;
        }

        public virtual void CountryInfo()
        {
            Console.WriteLine(firstname, lastname);
        }

        public Tourist(string f, string l, long t, int c) { firstname = f; lastname = l; telephone = t; contractnumber = c; }

        public void GetInfo()
        {
            Console.WriteLine($"Имя: {firstname} Фамилия: {lastname} Телефон: {telephone} Номер контракта: {contractnumber}");
        }

    }
    class Manager
    {
        public string firstname; //имя 
        public string lastname; // фамилия
        public long telephone; // телефон
        public long faxnumber; // номер факса
        public Manager(string f, string l, long t, long n) { firstname = f; lastname = l; telephone = t; faxnumber = n; }
        public void GetInfo()
        {
            Console.WriteLine($"Имя: {firstname} Фамилия: {lastname} Телефон: {telephone} Номер факса: {faxnumber}");
        }

    }
    class Carrier
    {
        public string firstname; //имя
        public string lastname; // фамилия
        public string trtype; // вид перевозки
        public Carrier(string f, string l, string t) { firstname = f; lastname = l; trtype = t; }
        public void GetInfo()
        {
            Console.WriteLine($"Имя: {firstname} Фамилия: {lastname} Вид перевозки: {trtype}");
        }
    }
    class Director
    {
        public string firstname; //имя
        public string lastname; // фамилия
        public string email; // адрес эл. почты
        public long telephone; // телефон
        public long faxnumber; // номер факса
        public Director(string f, string l, string e, long t, long n) { firstname = f; lastname = l; email = e; telephone = t; faxnumber = n; }
        public void GetInfo()
        {
            Console.WriteLine($"Имя: {firstname} Фамилия: {lastname} Эл. почта: {email} Телефон: {telephone} Номер факса: {faxnumber} ");
        }

    }
    class Citizen : Tourist
    {
        public string Country { get; set; }

        public Citizen(string firstname, string lastname, string country) : base(firstname, lastname, country)
        {
            Country = country;
        }

        public override void CountryInfo()
        {
            Console.WriteLine($"{firstname} {lastname} живет в {Country}");
        }
    }
    enum Numbers : long
    {
        Tourism = 213394,
        AmericaTour = 228472,
        TourAustralia = 238573,
        AsiaTourism = 246432,
        AviaTour24 = 257947
    }

    enum ContractNumbers : long
    {
        DenisDenisov = 3231,
        ArtyomArtemov = 2453,
        AntonAntonov = 4728,
        StepanStepanov = 6254,
        DanilDanilov = 5626
    }

    struct Agency // данные о туристическом агенстве
    {
        public string name;
        public string adress;
        public long telephone;

        public void AgencyInfo()
        {
            Console.WriteLine($"Название компании: {name} Адрес компании: {adress} Телефон агенства: {telephone}");
        }
    }

    struct Trdata // данные о перевозке
    {
        public string date;
        public string time;
        public string trtype;

        public void TransDataInfo()
        {
            Console.WriteLine($"Дата отправления: {date} Время отправления: {time} Тип перевозки: {trtype}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Operator Ilya = new Operator("Илья", "Ильев", "AviaTour24");
            Ilya.GetInfo();

            Tourist Dmitriy = new Tourist("Дмитрий", "Дмитриев", 8972647123, 3231);
            Dmitriy.GetInfo();

            Manager Denis = new Manager("Денис", "Денисов", 89374738537, 288254);
            Denis.GetInfo();

            Carrier Maxim = new Carrier("Максим", "Максимов", "Самолетом");
            Maxim.GetInfo();

            Director Victor = new Director("Виктор", "Викторов", "victorvictorov24@mail.ru", 89485737583, 258374);
            Victor.GetInfo();

            Citizen Artem = new Citizen("Дмитрий", "Дмитриев", "России");
            Artem.CountryInfo();

            Numbers AsiaTourismNumber;
            AsiaTourismNumber = Numbers.AsiaTourism;
            Console.WriteLine("Номер агенства Asia Tourism - {0}", (long)AsiaTourismNumber);

            ContractNumbers ArtyomArtemovNumber;
            ArtyomArtemovNumber = ContractNumbers.ArtyomArtemov;
            Console.WriteLine("Номер договора Дмитрия Дмитриева - {0}", (long)ArtyomArtemovNumber);

            Agency AmericaTour;
            AmericaTour.name = "America Tour";
            AmericaTour.adress = "Пушкина 48";
            AmericaTour.telephone = 228472;
            AmericaTour.AgencyInfo();

            Trdata AviaTourFlight;
            AviaTourFlight.date = "28.03.2021";
            AviaTourFlight.time = "10:00";
            AviaTourFlight.trtype = "Самолетом";
            AviaTourFlight.TransDataInfo();

            Console.ReadKey();
        }
    }
}
