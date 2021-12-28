int[] CreateArray(int lenght)
{
    return new int[lenght];
}

void FillArray(int[] array, int min, int max)
{
    string res = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
}

string PrintArray(int[] array) 
{
    string res = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        res += $"{array[i]} ";
    }
    return res;
}

int count = 0; // ставим счетчик в нулевое положение
int Counter(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count = count + 1; // если элемент изначального массива делится на два без остатка, то увеличиваем счетчик на один
    }
    return count;
}

void FillNewArray(int[] array, int[] newarray)
{
    string res = string.Empty;
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) // если элемент массива четный, то кладем его в новый массив
        {
            newarray[j] = array[i];
            j = j + 1;
        }
    }
}

int[] Array = CreateArray(9); // создаем массив определенной длины
FillArray(Array, 1, 10); // заполняем массив целыми числами из диапозона от 1 до 9
Console.WriteLine(PrintArray(Array)); // выводим массив на консоле для возмодности проверки решения
Counter(Array); // инициируем счетчик четных значений для определения длины нового массива
int[] NewArray = CreateArray(count); // создаем новый массив 
FillNewArray(Array,NewArray); // заполняем новый массив четными элементами изначального массива
Console.WriteLine(PrintArray(NewArray)); // выводим новый массив на консоль
