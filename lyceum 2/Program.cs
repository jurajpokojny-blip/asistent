namespace lyceum_2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Zadaj text:");
        string text = Console.ReadLine();

        Console.WriteLine("Zadaj cislo:");
        int cislo = int.Parse(Console.ReadLine());

        Console.WriteLine("Zadaj prefix:");
        string prefix = Console.ReadLine();

        Console.WriteLine("Zadaj postfix:");
        string postfix = Console.ReadLine();

        string vysledok = RepeatText(text, cislo, prefix, postfix);

        Console.WriteLine(vysledok);
    }

    static string RepeatText(string text, int cislo, string prefix, string postfix)
    {
        string vysledok = "";

        for (int i = 0; i < cislo; i++)
        {
            vysledok += text;
        }

        return prefix + vysledok + postfix;
    
    }
}