using System;

class Program
{
    static void Main()
    {
        string[] originalArray = {"Hello","2","world",":-)"}; //Создаем исходный массива строк

        string[] newArray = new string[originalArray.Length]; //Создаем новый массив

        int Index=0;                                          //Счетчик для отслеживания текущей позиции в новом массиве


        for(int i=0; i<originalArray.Length; i++)             //Проход по каждому элементу исходного массива
        {
            if (originalArray[i].Length <=3)                  //Проверка количества символов в элементе исходного массива
            {
                newArray[Index] = originalArray[i];           //Запись элемента исходного массива в новый массив. Если элемент соответствует требованиям 
                Index++;                                      //Увеличение счетчика на один
            }

        }

        Console.WriteLine("Новый массив из строк, длина которых меньше, либо равна 3 символам:");

        for(int i = 0; i<Index; i++)
        {
            Console.WriteLine(newArray[i]);                   //Вывод нового массива на экран
        }

    }
}