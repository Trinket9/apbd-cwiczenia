// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");


static double GetMax(int[] tab)
{
    int max = 0;
    for (int i = 0; i < tab.Length; i++)
    {
        if (tab[i] > max) max = tab[i];
    }

    return max;
}

int[] t = { 1, 2, 3, 4, 5 };
Console.WriteLine(GetMax(t));
Console.WriteLine("wooo");