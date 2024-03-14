// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");


static double GetMax(int[] tab)
{
    int max = 0;
    for (int j = 0; j < tab.Length; j++)
    {
        if (tab[j] > max) max = tab[j];
    }

    return max;
}

int[] t = { 1, 2, 3, 4, 5 };
Console.WriteLine(GetMax(t));
Console.WriteLine("wooo");