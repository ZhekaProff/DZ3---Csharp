// Найти сумму чисел от 1 до А
Console.WriteLine("Введите число а: ");
int NumberA =  int.Parse(Console.ReadLine() ?? "0");
int summa = 0;
for (int i = 0; i <= NumberA; i++)
    summa =  summa + i;

Console.WriteLine($"Сумма чисел от 1 до {NumberA} равна {summa}");
