// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");


static double GetMax(int[] tab)
{
    int max = 0;
    for (int k = 0; k < tab.Length; k++)
    {
        if (tab[k] > max) max = tab[k];
    }

    return max;
}

int[] t = { 1, 2, 3, 4, 5 };
Console.WriteLine(GetMax(t));