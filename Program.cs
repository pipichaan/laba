Console.WriteLine("Введите количество недель");
int week = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество месяцев");
int month = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество лет");
int year = Convert.ToInt32(Console.ReadLine());
int day = week * 7 + month * 30 + year * 365;
Console.WriteLine(day);

