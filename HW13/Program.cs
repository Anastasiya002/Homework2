//Задача 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
if (number < 100)
{
    Console.WriteLine($"{number} -> третьей цифры нет");
}
else 
{
int DigitCount = (int)Math.Log10(number) + 1;
int preresult = number / (int)Math.Pow(10, DigitCount - 3);
int result = preresult % 10;   
Console.WriteLine($"{number} -> {result}");
}