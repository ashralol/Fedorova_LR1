using System;

namespace Fedorova
{
    // Лабораторная работа 1. Создание и использование классов
    // Вариант 22: класс служащих Employee
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Создаём объект класса Employee
            Employee emp = new Employee();

            // Задаём значения полям объекта
            emp.FIO = "Иванов";
            emp.Salary = 63500;

            // Выводим данные, хранящиеся в объекте
            emp.Show();

            // Рассчитываем годовую зарплату и выводим на экран
            decimal year = emp.YearSalary();
            Console.WriteLine($"Годовая зарплата: {year} руб.");

            Console.ReadKey();
        }
    }

    // Класс служащих
    class Employee
    {
        // Открытые поля для хранения ФИО и зарплаты
        public string FIO;
        public decimal Salary;

        // Конструктор по умолчанию
        public Employee()
        {
            FIO = "";
            Salary = 0;
        }

        // Конструктор с параметрами
        public Employee(string fio, decimal salary)
        {
            FIO = fio;
            Salary = salary;
        }

        // Метод Show() – показать на экране данные о служащем
        public void Show()
        {
            Console.WriteLine($"Служащий: {FIO}, зарплата: {Salary} руб.");
        }

        // Метод расчёта годовой зарплаты = зарплата * 12
        public decimal YearSalary()
        {
            return Salary * 12;
        }
    }
}
