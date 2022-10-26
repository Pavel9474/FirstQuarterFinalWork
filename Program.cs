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