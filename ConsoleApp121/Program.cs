using System;

namespace ConsoleApp121
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ===== Задание 1: Книга =====
            Console.WriteLine("=== Задание 1: Книга ===");
            Book b1 = new Book("Война и мир", "Лев Толстой", 1869);
            Book b2 = new Book("Мастер и Маргарита", "Михаил Булгаков", 1967);
            Book b3 = new Book("Преступление и наказание", "Фёдор Достоевский", 1866);
            b1.PrintInfo();
            b2.PrintInfo();
            b3.PrintInfo();
            Console.WriteLine();

            // ===== Задание 2: Прямоугольник =====
            Console.WriteLine("=== Задание 2: Прямоугольник ===");
            Rectangle rect = new Rectangle();
            rect.Width = 5;
            rect.Height = 3;
            Console.WriteLine($"Ширина: {rect.Width}, высота: {rect.Height}");
            Console.WriteLine($"Площадь: {rect.CalculateArea()}");
            Console.WriteLine($"Периметр: {rect.CalculatePerimeter()}");
            Console.WriteLine();

            // ===== Задание 3: Студент =====
            Console.WriteLine("=== Задание 3: Студент ===");
            Student[] students =
            {
                new Student("Иван", 18, 5),
                new Student("Мария", 19, 4),
                new Student("Пётр", 20, 5),
                new Student("Анна", 18, 3)
            };
            foreach (Student s in students)
            {
                if (s.IsExcellent())
                    Console.WriteLine($"{s.Name} ({s.Age} лет, оценка {s.Grade}) — отличник");
                else
                    Console.WriteLine($"{s.Name} ({s.Age} лет, оценка {s.Grade}) — не отличник");
            }
            Console.WriteLine();

            // ===== Задание 4: Счётчик =====
            Console.WriteLine("=== Задание 4: Счётчик ===");
            Counter counter = new Counter();
            Console.WriteLine($"Начальное значение: {counter.GetCount()}");
            counter.Increment();
            counter.Increment();
            counter.Increment();
            Console.WriteLine($"После 3 вызовов Increment(): {counter.GetCount()}");
            counter.Decrement();
            Console.WriteLine($"После 1 вызова Decrement(): {counter.GetCount()}");
            Console.WriteLine();

            // ===== Задание 5: Кошелёк =====
            Console.WriteLine("=== Задание 5: Кошелёк ===");
            Wallet wallet = new Wallet();
            Console.WriteLine($"Начальный баланс: {wallet.GetBalance()}");
            wallet.AddMoney(1000);
            Console.WriteLine($"Пополнили на 1000, баланс: {wallet.GetBalance()}");
            wallet.SpendMoney(300);
            Console.WriteLine($"Потратили 300, баланс: {wallet.GetBalance()}");
            wallet.SpendMoney(5000); // денег не хватит
            Console.WriteLine($"Баланс после неудачной покупки: {wallet.GetBalance()}");

            Console.ReadKey();
        }
    }

    // ===== Задание 1 =====
    public class Book
    {
        public string Title;
        public string Author;
        public int Year;

        public Book(string title, string author, int year)
        {
            Title = title;
            Author = author;
            Year = year;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Название: {Title}, автор: {Author}, год издания: {Year}");
        }
    }

    // ===== Задание 2 =====
    public class Rectangle
    {
        public double Width;
        public double Height;

        public double CalculateArea()
        {
            return Width * Height;
        }

        public double CalculatePerimeter()
        {
            return 2 * (Width + Height);
        }
    }

    // ===== Задание 3 =====
    public class Student
    {
        public string Name;
        public int Age;
        public int Grade; // от 1 до 5

        public Student(string name, int age, int grade)
        {
            Name = name;
            Age = age;
            Grade = grade;
        }

        public bool IsExcellent()
        {
            return Grade == 5;
        }
    }

    // ===== Задание 4 =====
    public class Counter
    {
        private int count = 0;

        public void Increment()
        {
            count++;
        }

        public void Decrement()
        {
            count--;
        }

        public int GetCount()
        {
            return count;
        }
    }

    // ===== Задание 5 =====
    public class Wallet
    {
        private int balance = 0;

        public void AddMoney(int amount)
        {
            balance += amount;
        }

        public void SpendMoney(int amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine($"Недостаточно средств: нужно {amount}, а на балансе {balance}");
            }
        }

        public int GetBalance()
        {
            return balance;
        }
    }
}
