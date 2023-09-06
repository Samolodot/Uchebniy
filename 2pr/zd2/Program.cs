Console.WriteLine("*************************");
Console.WriteLine("Банк");
Console.WriteLine("*************************");
double x;

Console.WriteLine("Было вложено");
x = double.Parse(Console.ReadLine());
Console.WriteLine("**************************");

x = (x + x * 3 / 100);
Console.WriteLine($"Вклад за год 3% = {x} рублей");
Console.WriteLine("**************************");

x = (x + x * 8 / 100);
Console.WriteLine($"Вклад за два года 8% = {x} рублей");
Console.WriteLine("**************************");
Console.WriteLine($"Денег на вашем счету за два года = {x} рублей");

Console.ReadKey();

