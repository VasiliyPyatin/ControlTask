// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами

using System;
Console.Clear ();



Console.WriteLine("Введите элементы массива каждый с новой строки:");
string s;
int count = 0;
string[] arrayFirst = new string[count];

do
   {
    s = Console.ReadLine();

    if (s!="")
        {
          count++;
          string[] AS2 = new string[count];

          for (int i = 0; i < AS2.Length - 1; i++)
          AS2[i] = arrayFirst[i];
          AS2[count - 1] = s;
          arrayFirst = AS2;
        }
    } while (s != "");

for (int i = 0; i < 1; i++)
Console.Write($"[{String.Join(", ",arrayFirst)}] -> ");

string[] arrayNew = new string[arrayFirst.Length];
SecondArray(arrayFirst, arrayNew);
PrintArray(arrayNew);

void SecondArray(string[] array1, string[] array2)
{
    int cnt = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[cnt] = array1[i];
        cnt++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}