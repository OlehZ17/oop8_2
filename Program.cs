using System;

// Завдання 1: Абстрактний клас Currency
abstract class Currency
{
    protected double amount;

    public Currency(double amount)
    {
        this.amount = amount;
    }

    public abstract double ConvertToUAH();
    public abstract void DisplayAmount();
}

// Похідний клас Dollar
class Dollar : Currency
{
    public Dollar(double amount) : base(amount)
    {
    }

    public override double ConvertToUAH()
    {
        return amount * 36.9; 
    }

    public override void DisplayAmount()
    {
        Console.WriteLine($"Amount in Dollars: {amount}");
    }
}

// Похідний клас Euro
class Euro : Currency
{
    public Euro(double amount) : base(amount)
    {
    }

    public override double ConvertToUAH()
    {
        return amount * 39.8; 
    }

    public override void DisplayAmount()
    {
        Console.WriteLine($"Amount in Euros: {amount}");
    }
}

// Завдання 2: Інтерфейс для переведення валюти в іншу валюту
interface ICurrencyConverter
{
    double ConvertToUAH();
    void DisplayAmount();
}

// Інтерфейс для виведення суми
interface IAmountDisplay
{
    void DisplayAmount();
}

// Похідний клас з використанням інтерфейсів
class PLN : ICurrencyConverter, IAmountDisplay
{
    private double amount;

    public PLN(double amount)
    {
        this.amount = amount;
    }

    public double ConvertToUAH()
    {
        return amount * 8.9; 
    }

    public void DisplayAmount()
    {
        Console.WriteLine($"Amount in PLN: {amount}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Завдання 1: Використання абстрактних класів
        Currency usd = new Dollar(100);
        usd.DisplayAmount();
        Console.WriteLine($"Equivalent amount in UAH: {usd.ConvertToUAH()} UAH");

        Currency eur = new Euro(500);
        eur.DisplayAmount();
        Console.WriteLine($"Equivalent amount in UAH: {eur.ConvertToUAH()} UAH");

        Console.WriteLine();

        // Завдання 2: Використання інтерфейсів
        ICurrencyConverter pln = new PLN(300);
        pln.DisplayAmount();
        Console.WriteLine($"Equivalent amount in UAH: {pln.ConvertToUAH()} UAH");
    }
}

