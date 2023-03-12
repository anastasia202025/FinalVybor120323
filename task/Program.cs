//// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше или равна 3-м символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма.

//Пример 
//["hello","2","world",":-)"]->["2",":-)"]
//

string InputString(string position) //функция ввода строковых данных через консоль
{
    System.Console.Write($"{position} > ");
    return Convert.ToString(Console.ReadLine());
}

void InputArray(string[] array) //функция ввода значения элемента в массив
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = InputString($"Введите значение элемента");
    }
}

void ElementLength(string[] array, int index) //функция определения в массиве элемента с необходимым количеством символов
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= index) System.Console.Write($"{array[i]} "); //выводим результат в консоль
    }
}

void PrintArray(string[] array) //выводим значения массива
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.Write($"-> ");
}

int index = 3; //задаём количество символов элемента в массиве для поиска
string[] startArray = new string[4]; //задаём стартовый массив
InputArray(startArray);
PrintArray(startArray);
ElementLength(startArray, index);
