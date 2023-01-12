// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99)
{
  Console.WriteLine((number % 10));
}
else
{
if (number >99)
    number = number / 10;
Console.Write("третьей цифры нет");    
}
