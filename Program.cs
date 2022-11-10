Console.Clear();

Console.Write("Введите количество строк (слов, наборов символов), которые Вы хотите использовать: ");
string[] ArrayStrings = new string[] { };
int StringCount = int.Parse(Console.ReadLine());
ArrayStrings = new string[StringCount];
for (int i = 0; i < ArrayStrings.Length; i++)
{
    Console.Write($"Введите строку {i + 1}: ");
    ArrayStrings[i] = Console.ReadLine();
}
// задаем длину элементов массива, согласно заданию
int Setlength = 3;
// вводим переменную в которую будем присваивать вычисленный элемент массива согласно Setlength  
int numbers = CheckArray(ArrayStrings, Setlength);
// создаем массив для результатов вычислений
string[] newArrayStrings = new string[numbers];

// метод определения количества элемента массива
int CheckArray(string[] array, int Setlength)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= Setlength) result++;
    }
    return result;
}

// метод формирования нового массива
void NewArray(string[] oldArray, string[] newArray, int Setlength)
{
    int temp = 0;
    for (int i = 0; i < oldArray.Length; i++)
    {
        if (oldArray[i].Length <= Setlength)
        {
            newArray[temp] = oldArray[i];
            temp++;
        }
    }
}

// метод печати массива
string PrintArray(string[] array)
{
    string result = string.Empty;
    result = "'";
    for (int i = 0; i < array.Length; i++)
    {
        result += $"{array[i],1}";
        if (i < array.Length - 1) result += "', '";
    }
    result += "'";
    return result;
}

NewArray(ArrayStrings, newArrayStrings, Setlength);

Console.WriteLine();
Console.WriteLine("Вы ввели следующие строки:");
Console.WriteLine($"{PrintArray(ArrayStrings)}");
Console.WriteLine();
Console.WriteLine("Строки, длина которых меньше или равна 3-м символам:");
Console.WriteLine($"{PrintArray(newArrayStrings)}");
