//Задача 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите день недели: ");
int number = int.Parse(Console.ReadLine());
if (number == 6 || number == 7)
{
   Console.Write($"{number} -> да"); 
}
else if (number < 1 || number > 7)
{
    Console.Write("Неверное значение"); 
}
else if (number > 1 || number < 7)
{
   Console.Write($"{number} -> нет"); 
}
