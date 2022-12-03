//Задача: Написать программу, которая из имеющегося массива строк 
//формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

string[] array = { "Hi", "Hello", "Welcome", "l", "happiness", "world", "ok", ";)", "2" };
string[] FindSringLength(string[] array)
{
    int length = 3;
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= length)
        {
            count++;
        }
    }
    int index = 0;
    string[] newarray = new string[count];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= length)
        {
            newarray[index] = array[i];
            index++;
        }
    }
    return newarray;
}
string[] newarray = FindSringLength(array);
for (int i = 0; i < newarray.Length; i++)
{
    Console.Write($"{newarray[i]} ");
}








