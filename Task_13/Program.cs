﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.Через строку решать нельзя.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine("Write number");
int num = Convert.ToInt32(Console.ReadLine());
if(num > 99)
{ 
    while (num < 100)
        num = num / 10;
    num = num % 10;    
    Console.WriteLine(num);   
}     
else 
    Console.WriteLine("третьей цифры нет");