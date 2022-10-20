// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


int day = new Random().Next(1, 8);

if(day < 6)
{
    Console.WriteLine(day + " - рабочий");
}

else
{
    Console.WriteLine(day + " - выходной");
}



// Это извращенский вариант с вводом вручную и разными вариантами. Вроде даже работает)

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int day = 0;

// if(num < 1)
// {
//     Console.WriteLine("Мы тут дни недели считаем, так что давайте сначала, и пусть число будет не меньше 1");
// }

// else
// {
//     if(num > 7)
//     {
//         int week = num / 7;
//         day = num % 7;
//         Console.WriteLine($"Получается {week} недель и {day} дней");               
//     }

//     else
//     {
//         day = num;
//     }
// }


// if((day < 6)&(day > 0))
// {
//     Console.WriteLine(day + " - рабочий");
// }

// else
// {
//     Console.WriteLine(day + " - выходной");
// }