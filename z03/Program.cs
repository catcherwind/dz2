Console.WriteLine("Введите день недели");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(n == 6 || n == 7 ? "Это выходной" : "Это не выходной");