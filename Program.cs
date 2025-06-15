using System;
using System.Linq;
class DateAnalyzer
{
    public static void Run()
    {
        Console.WriteLine("Введiть 3 дати через кому (дд.мм.рррр):");
        string input = Console.ReadLine();
        string[] parts = input.Split(',');
        DateTime[] dates = parts.Select(d => DateTime.Parse(d.Trim())).ToArray();
        int minYear = dates.Min(d => d.Year);
        Console.WriteLine("Найменший рiк: " + minYear);
        Console.WriteLine("Веснянi дати:");
        foreach (var date in dates)
        {
            if (date.Month >= 3 && date.Month <= 5)
            {
                Console.WriteLine(date.ToShortDateString());
            }
        }
        DateTime latest = dates.Max();
        Console.WriteLine("Найпiзнiша дата: " + latest.ToShortDateString());
    }
}
class Program
{
    static void Main()
    {
        DateAnalyzer.Run();
    }
}
