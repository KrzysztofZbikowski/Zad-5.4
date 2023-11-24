class zad
{
    static int[] mnozTab1(int x, int[] tab)
    {
        int[] wyj = new int[tab.Length];
        for (int i = 0; i < tab.Length; i++)
        {
            wyj[i] = tab[i] * x;
        }
        return (wyj);
    }
    static void mnozTab2(int x, int[] tab)
    {
        for (int i = 0; i < tab.Length; i++)
        {
            tab[i] = tab[i] * x;
        }
    }
    static void Main(string[] args)
    {
        int[] tab = { 4, 6, 3, 5 };
        int[] nowa = new int[tab.Length];
        int x;
        Console.WriteLine("Podaj ilukrotnie pomnożyć twoją tablicę");
        x = int.Parse(Console.ReadLine());
        nowa = mnozTab1(x, tab);
        Console.WriteLine("Twoja nowa tablica 1");
        for (int i = 0; i < tab.Length; i++)
        {
            Console.Write(nowa[i] + " ");
        }
        Console.WriteLine();
        mnozTab2(x, tab);
        Console.WriteLine("Twoja nowa tablica 2");
        for (int i = 0; i < tab.Length; i++)
        {
            Console.Write(tab[i] + " ");
        }
        Console.ReadKey();
    }
}