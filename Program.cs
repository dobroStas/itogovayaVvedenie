// Задача

// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

int Prompt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}


int a = Prompt("Введите размер массива");
string[] firstArr = new string[a];


string PromptArrEl(string text)
{
    Console.WriteLine(text);
    return Console.ReadLine();
}


for (int i = 0; i < a; i++) firstArr[i] = PromptArrEl("Введите элемент массива");

int index = 0;
for (int i = 0; i < firstArr.Length; i++)
{
    if (firstArr[i].Length <= 3) index++;
}
string[] secondArr = new string[index];


void SecondArrLess3(string[] firstArr, string[] secondArr)
{
    int count = 0;
    for (int i = 0; i < firstArr.Length; i++)
    {
        if (firstArr[i].Length <= 3)
        {
            secondArr[count] = firstArr[i];
            count++;
        }
    }
}

void PrintArray(string[] secondArr)
{
    Console.Write("[");
    for (int i = 0; i < secondArr.Length; i++)
    {
        Console.Write("\"" + $"{secondArr[i]}" + "\"");
        if (i < secondArr.Length - 1) Console.Write(",");
    }
    Console.Write("]");
}

SecondArrLess3(firstArr, secondArr);
PrintArray(secondArr);