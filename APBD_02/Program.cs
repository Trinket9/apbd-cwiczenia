// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");


static double GetAVG(int[] tab)
{
    int sum = 0;
    for (int i = 0; i < tab.Length; i++)
    {
        sum += tab[i];
    }

    return sum / tab.Length;
}

int[] t = { 1, 2, 3, 4, 5 };
Console.WriteLine(GetAVG(t));