//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2
/*
int[] array = GetArray(10, 100, 999);
Console.WriteLine($"[{String.Join(", ", array)}]");

int count = 0;
foreach(int el in array){
    if (el % 2 == 0){
        count ++;
    }
} 
Console.WriteLine($"Количество чётных чисел в массиве равно: {count}");

//-----------------------------------------МЕТОДЫ-------------------------------------------------
int[] GetArray(int size, int minValue, int maxValue){
    int[] result = new int[size];
    for (int i=0; i<size; i++){
        result[i] = new Random().Next(minValue, maxValue+1);
    }
    return result;
}
*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях(индексы элементов должны быть нечетными(1,3,5 и тд)).

//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

/*
int[] array = GetArray(10, 1, 100);
Console.WriteLine($"[{String.Join(", ", array)}]");

int sum = 0;
for(int i=1; i < array.Length; i++){
    if (i % 2 == 1) sum += array[i];
}
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна: {sum}");

//-----------------------------------------МЕТОДЫ-------------------------------------------------
int[] GetArray(int size, int minValue, int maxValue){
    int[] result = new int[size];
    for (int i=0; i<size; i++){
        result[i] = new Random().Next(minValue, maxValue+1);
    }
    return result;
}
*/

//Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//Результат запишите в новом массиве.

//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21

/*
int[] array = GetArray(10, 1, 10);
Console.WriteLine($"[{String.Join(" ", array)}]");

int j = array.Length - 1;
for (int i = 0; i < (array.Length + 1) / 2; i++)
{
    Console.Write(array[i] * array[j] + " ");
    j--;
}
//-----------------------------------------МЕТОДЫ-------------------------------------------------
int[] GetArray(int size, int minValue, int maxValue){
    int[] result = new int[size];
    for (int i=0; i<size; i++){
        result[i] = new Random().Next(minValue, maxValue+1);
    }
    return result;
}

*/
//Задача 38: Задайте массив целых чисел от -10 до 10. Найдите разницу между максимальным и минимальным элементов массива.

int[] array = GetArray(10, -10, 10);
Console.WriteLine($"[{String.Join(" ", array)}]");

int min = 0;
int max = 0;
for (int i = 0; i < (array.Length); i++)
{
    if (array[i]> max) max = array[i];
    if (array[i]< min) min = array[i];
}
Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {(max-min)}");
//-----------------------------------------МЕТОДЫ-------------------------------------------------
int[] GetArray(int size, int minValue, int maxValue){
    int[] result = new int[size];
    for (int i=0; i<size; i++){
        result[i] = new Random().Next(minValue, maxValue+1);
    }
    return result;
}