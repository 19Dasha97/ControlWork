﻿/* Задача алгоритмически не самая сложная, однако для полноценного выполнения проверочной работы необходимо:

1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма 
(можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом 
(не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → [] */

int CountSpecialElements(string[] array)
{
    int count = 0;
    foreach (string elem in array)
    {
        if (elem.Length <= 3)
        {
            count++;
        }
    }
    return count;
}

string[] CreateNewArray(string[] array, int len)
{
    string[] new_array = new string[len];
    int i = 0;
    foreach (string elem in array)
    {
        if (elem.Length <= 3) 
        {
            new_array[i] = elem;
            i++;
        }
    }
    return new_array;
}

string[] array = {"Hello", "2", "world", ":-)"};

int count = CountSpecialElements(array);
string[] new_array = CreateNewArray(array, count);

Console.WriteLine("['" + string.Join("', '", new_array) + "']");