//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
/*
int[] numbers = new int [10];

void FillArray(int[] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
}

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int PositivNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;

}

FillArray(numbers, 100, 1000);
WriteArray(numbers);

int count = PositivNumber(numbers);
Console.WriteLine("Четных чисел в масиве: "+ count);
*/


//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
/*


Console.WriteLine($"Введите количество элемента масива: ");
int numberElement = Convert.ToInt32(Console.ReadLine());

int RandomNumber(int numberElements, int min, int max)
{
    int[] randomNumbers = new int[numberElements];
    int sumElements = 0;
    Console.Write("получившийся масcив:");

    for (int i = 0; i < randomNumbers.Length; i++)
    {
        randomNumbers[i] = new Random().Next(min, max);
        Console.Write(randomNumbers[i] + " ");
        if (i % 2 != 1)
        {
            sumElements = sumElements + randomNumbers[i];
        }
        
    }
    return sumElements;
}

int randomNumbers = RandomNumber(numberElement, 1, 10);
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях: {randomNumbers}");

*/


//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
/*
double [] arrayDifferNumbers = new double [5];
    for (int i = 0; i < arrayDifferNumbers.Length; i++)
        {
            arrayDifferNumbers[i] = new Random().Next(1, 100);
            Console.Write(arrayDifferNumbers[i] + " ");
        }

double maxNumber = arrayDifferNumbers[0];
double minNumber = arrayDifferNumbers[0];

for (int i = 1; i < arrayDifferNumbers.Length; i++)
{
    if (maxNumber < arrayDifferNumbers[i])
    {
        maxNumber = arrayDifferNumbers[i];
    }
    if (minNumber > arrayDifferNumbers[i])
    {
        minNumber = arrayDifferNumbers[i];
    }
}

double decision = maxNumber - minNumber;

Console.WriteLine("разница между минимальным и максимальным значением: "+ decision);
*/