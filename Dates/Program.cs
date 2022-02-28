// Working with dates

// DateTime
var now = DateTime.Now;

Console.WriteLine(now);

Console.WriteLine("Hour: " + now.Hour);
Console.WriteLine("Minute: " + now.Minute);

var tomorrow = now.AddDays(1);
var yesterday = now.AddDays(-1);

Console.WriteLine("Tomorrow: " + tomorrow);
Console.WriteLine("Yesterday: " + yesterday);

Console.WriteLine("\nFormatting:");
Console.WriteLine(now.ToLongDateString());
Console.WriteLine(now.ToShortDateString());
Console.WriteLine(now.ToLongTimeString());
Console.WriteLine(now.ToShortTimeString());

Console.WriteLine(now.ToString("yyyy-MM-dd"));

// TimeSpan
var timeSpan = new TimeSpan(1, 2, 3);
var timeSpan1 = new TimeSpan(1, 0, 0);

Console.WriteLine(TimeSpan.FromHours(1));

Console.WriteLine(timeSpan);
Console.WriteLine(timeSpan1);

Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));

Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));;