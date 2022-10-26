// Написать программу, которая из имеющегося массива 
// строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. 
string[] GetStringArrayFromConsole()
{
    Console.Write("Введите количество строк, которые хотите ввести: ");
    int n = Convert.ToInt32(Console.ReadLine());
    string[] strarr = new string[n]; 
    for (int i = 0; i < n; i++)
    {
    Console.Write("Введите элемент массива №{0}: ", i + 1);
    strarr[i] = Console.ReadLine();
    }
    return strarr;
}
string[] GetStringArrayShorterByN(string[] arr, int N)
{
    int count = 0;
    string[] array2= new string[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length<=N)
        {
            array2[count]=arr[i];
            count++;
        }
    }
    return array2;
}
void PrintArray(string[] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
            Console.Write(arr[i] + " ");
    Console.WriteLine();
}
int GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
string[] arr1 = GetStringArrayFromConsole();
PrintArray(arr1);
int N=GetNumberFromConsole("Введите максимальное количество символов массива 2");
GetStringArrayShorterByN(arr1, N);
PrintArray(GetStringArrayShorterByN(arr1, N));