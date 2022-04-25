// See https://aka.ms/new-console-template for more information

DateOnly dateOnly = DateOnly.FromDateTime(DateTime.Now);
TimeOnly timeOnly = TimeOnly.FromFileTime(DateTime.Now);
Console.WriteLine(timeOnly);
