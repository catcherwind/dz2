Console.WriteLine("Введите число");
string n = Console.ReadLine();
int n_col = int.Parse(n);
if (n_col >= 100)
    Console.WriteLine($"Третья цифра числа - {n[2]}");
else if (n_col <= -100)
    Console.WriteLine($"Третья цифра числа - {n[3]}");
else
    Console.WriteLine("Число слишком короткое, третьей цифры нет");