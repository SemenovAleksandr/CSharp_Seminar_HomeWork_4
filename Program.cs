// Семинар 4

//Задача 24: принимаем на вход число А и выдаём сумму всех числе от 1 до А.

// int A = Convert.ToInt32(Console.ReadLine());

// int sum = 0;

// for (int i = 0; i <= A; i++)
// {
//     sum = sum + i;
// }

// Console.WriteLine($"сумма чисел от 1 до {A} равна {sum}");

// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

//----Решение через while
// Console.WriteLine("Введите произвольное целое число");
// int num = Convert.ToInt32(Console.ReadLine());
// int x = num;
// int count = 0;

// while (x > 0)
// {
//     x = x/10;
//     count ++;
// }

//----- Решение через метод

// Тип_метода Имя_метода (аргументы)

// int GetCountNumbers (int number)
// {
//     int count = 0;
    
//     while (number > 0)
//     {
//         number /= 10;
//         count++;
//     }
//     return count;
// }

// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(GetCountNumbers(num));



// Console.WriteLine($"В числе {num} содержится {count} цифр");

// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

// Console.WriteLine("Введите произвольное целое число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int sum = 1;

// for (int i = 1; i <= num; i++)
// {
//     sum *= i;
// }

// Console.WriteLine($"Произведение числа от 1 до {num} равно {sum}");

// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


// int[] array = new int [8];

// for (int i = 0; i < array.Length; i++)
// {
//     array [i] = new Random().Next(0, 2);
//     Console.Write(array[i]+ " ");
// }

//Console.WriteLine(array);

// ----Решение через метод

// int [] GetBinaryArray (int size)
// {

// int [] array = new int [size];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random(). Next (0, 2);
// }
// return array;
// }


// int sizeArray = Convert.ToInt32(Console.ReadLine());

// int[] resultArray = GetBinaryArray(sizeArray);
// Console.WriteLine($"результат: [ {String.Join("; ", resultArray)} ]");

// Домашнее задание к семинару 4

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.Write("Введите число А: ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число В: ");
// int B = Convert.ToInt32(Console.ReadLine());

// int mul = 1;

// for (int i = 1; i <= B; i++)
// {
//     mul = mul * A;
// }

// Console.WriteLine($"Результат возведения числа {A} в степень {B} равен {mul}");


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.Write("Введите целое число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int x = num;
// int sum = 0;

// while (x > 0)
// {
//     sum = sum + x % 10;
//     x = x/10;
// }

// Console.WriteLine($"Сумма цифр числа {num} равна {sum}");

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int [] GetArray (int size)
{

int [] array = new int [size];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random(). Next (0, 100);
}
return array;
}

Console.Write("Введите кол-во элементов в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] resultArray = GetArray(size);
Console.WriteLine($"результат: [ {String.Join("; ", resultArray)} ]");

// ????? вопрос по моему решению: я могу описать в методе переменную как "size" и потом в теле программы использовать опять описатель переменной size или лучше так не делать?????