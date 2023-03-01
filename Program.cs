void Main()
{
    Console.Clear();
    System.Console.WriteLine("Программа разложит введённую строку на массив из слов, а затем выведет те элементы массива," +
    " \nдлина которых меньше или равна числу, которое будет указано далее.");

    string inputedStr = EnterString("Введите строку: ");
    string[] arrayStr = StringArray(inputedStr);
    int countStr = EnterCount("Введите длинну строки для отбора: ");
    string[] selectArr = SelArr(arrayStr, countStr);
    PrintArray(arrayStr);
    System.Console.Write(" -> ");
    PrintArray(selectArr);
}

string[] StringArray(string s)
{
    char[] separators = new char[] { ' ', '.', ',', '!', ';', '?' };
    string[] subS = s.Split(separators, StringSplitOptions.RemoveEmptyEntries);
    return subS;
}

string EnterString(string welcomeToInput)
{
    System.Console.Write(welcomeToInput);
    return Console.ReadLine()!;
}

int EnterCount(string welcomeToInput)
{
    bool inputOk = false;
    int count = 0;
    while (!inputOk)
    {
        System.Console.Write(welcomeToInput);
        string inp = Console.ReadLine()!;
        inputOk = int.TryParse(inp, out int n);
        if (inputOk)
            count = n;
        else
            System.Console.Write("Вы ввели не число. ");
    }
     return count;
}
string[] SelArr(string[] arr, int l)
{
    int[] selectIndex = new int[arr.Length]; // массив для хранения нужных нам индексов
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= l)            // отбор по условию
            selectIndex[count++] = i;
    }

    string[] StringsArray = new string[count];  // нужный нам массив, его вернёт функция
    for (int j = 0; j < count; j++)
    {
        StringsArray[j] = arr[selectIndex[j]];
    }
    return StringsArray;
}
void PrintArray(string[] arr)
{
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write('\u0022' + arr[i] + '\u0022' + (i < arr.Length - 1 ? ", " : ""));
    }
    System.Console.Write("]");
}

 Main();
