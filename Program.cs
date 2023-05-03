// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
string[] array = CreateArray(size);
int newArraySize = NewArraySize(array);
string[] newArray = CreateNewArray(newArraySize, array);
PrintArray(array);
Console.WriteLine(string.Empty);
PrintArray(newArray);


string[] CreateArray(int size)
{
    string [] arr = new string [size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите значение {i + 1} элемента массива:");
        arr[i] = Console.ReadLine();
    }
    return arr;
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

string[] CreateNewArray(int neweArrSize, string[] arr)
{
    string[] newArr = new string[neweArrSize];
    int j = 0;
    for (int i = 0; i < arr.Length; i++) 
    {
        string temp = arr[i];
        if (IsEqualOrLesserThanThree(temp))
        {
            newArr[j] = temp;
            j++;
        } 
    }  
    return newArr;
}

int NewArraySize(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (IsEqualOrLesserThanThree(arr[i])) count++;
    }
    return count;
}

bool IsEqualOrLesserThanThree(string temp)
{
    return temp.Length <= 3;
}