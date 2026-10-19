namespace skupinovi__projekt;

class Program
{
    static void Main(string[] args)
    {++
        int[] pole = { 10, 20, 30, 5, 80 };

        
        Vypocitaj(pole);
    }

    static void Vypocitaj(int[] pole)
    {
        int sucet = 0;
        int max = pole[0];

        for (int index = 0; index < pole.Length; index++)
        {
            sucet = sucet + pole[index];

            if (pole[index] > max)
            {
                max = pole[index];
            }
        }

        int priemer = sucet / pole.Length;

        Vypis(priemer, max);
    }

    static void Vypis(int priemer, int max)
    {
        Console.WriteLine("Priemer je: " + priemer);
        Console.WriteLine("Najvacsie cislo je: " + max);
    }
}