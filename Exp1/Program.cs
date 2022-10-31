/* 
Написать метод для поиска индекса элемента массива (тип int  в массиве)
метод должен вернуть индекс первоего найденого эдемента (если он есть)
*/

using System;

int FindIndex(int[] mass)
{
    Console.WriteLine("Какое число ищем в массиве ?");
    int number = int.Parse(Console.ReadLine());
    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i] == number)
        {
            return i;
        }
    }
    return -1;
}

void ChekOfIndex(int[] mass, int indexOfNumber)
{
    while (true)
    {
        if (indexOfNumber == -1)
        {
            Console.WriteLine("Числа нет в массиве, ищем еще ?");
            string otvet = Console.ReadLine();
            if (otvet == "да")
            {
                indexOfNumber = FindIndex(mass);
                continue;
            }
            else
            {
                Console.WriteLine("Как хочешь");
                break;
            }
        }
        else
        {
            Console.WriteLine($"Число под индексом {indexOfNumber}");
            break;
        }
    }
}

int[] GetArray(uint length,int minValue, int maxValue )
{
    int[] mass = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = rnd.Next(minValue, maxValue);
    }
    return mass;
}


int[] array = GetArray(10,1,20);
int indexOfNumber = FindIndex(array);
ChekOfIndex(array, indexOfNumber);

Console.ReadLine();