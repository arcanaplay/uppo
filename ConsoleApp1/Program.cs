using System;

namespace ReceiptApp
{
    class Receipt
    {
        // Атрибуты
        public int Number { get; set; }
        public string Date { get; set; }
        public float Amount { get; set; }

        // Конструктор по умолчанию
        public Receipt()
        {
            Number = 0;
            Date = "01.01.2000";
            Amount = 0.0f;
        }

        // Конструктор с параметрами
        public Receipt(int number, string date, float amount)
        {
            Number = number;
            Date = date;
            Amount = amount;
        }

        // Метод для вывода информации о квитанции
        public void PrintReceipt()
        {
            Console.WriteLine($"Номер квитанции: {Number}");
            Console.WriteLine($"Дата: {Date}");
            Console.WriteLine($"Сумма: {Amount} руб.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Создание объекта с использованием конструктора с параметрами
            Receipt receipt1 = new Receipt(123, "10.10.2023", 1500.75f);
            receipt1.PrintReceipt();
        }
    }
}