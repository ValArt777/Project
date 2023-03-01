## Программа из имеющегося массива строк сформирует массив из строк длинна символов которых будет меньше или равна введенному числу.

* Программа сама разложит строку в массив . Указаны разделители : пробел , . ; ?
 
string[] StringArray(string s)
{
    char[] separators = new char[] { ' ', '.', ',', '!', ';', '?' };
    string[] subS = s.Split(separators, StringSplitOptions.RemoveEmptyEntries);
    return subS;
}

* Также сделана проверка на правильность введенных данных 

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

* Остальная информация в Program.cs
## Конец