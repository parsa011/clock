using System.Globalization;

Dictionary<string, string> countries = new()
{
    {"iran", "fa-IR"},
};

KeyValuePair<string, string> country = new();
if (args.Length == 1)
{
    country = countries.First();
}
else
{
    Console.WriteLine("Country Not Found");
    return;
}

CultureInfo givenCulture = CultureInfo.GetCultureInfo(country.Value);
Thread.CurrentThread.CurrentCulture = givenCulture;
Console.WriteLine($"Clock '{givenCulture.DisplayName}' : ");
Console.WriteLine("------------------------------");
Console.WriteLine(DateTime.Now);
Console.WriteLine("------------------------------");
foreach (var item in Enum.GetValues(typeof(DayOfWeek)))
{
    if (item.ToString() == DateTime.Now.DayOfWeek.ToString())
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("> ");
    }
    Console.WriteLine($"{item}");
    Console.ResetColor();
}