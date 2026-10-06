Console.WriteLine("ahoj");
String mode = Console.ReadLine();
if (mode == "sum")
{
    Console.WriteLine("zapiš 2 čisla ktore chceš sčiťať");
    int cislo1sum = int.Parse(Console.ReadLine());
    Console.WriteLine("+");
    int cislo2sum = int.Parse(Console.ReadLine());
    Console.WriteLine(cislo1sum + cislo2sum);
}
if (mode == "odm")
{
    Console.WriteLine("zapiš čislo ktore chceš odmocniť a čim");
    double odm1 = double.Parse(Console.ReadLine());
    double exponent = double.Parse(Console.ReadLine());
    double vysledokodm = Math.Pow(odm1,1.0 / exponent);
    Console.WriteLine(vysledokodm);
}

if (mode == "find")
{
    Console.WriteLine("sem zadaj vetu ");
    string veta = string.Parse(Console.ReadLine());
    Console.WriteLine("sem zadaj slovo ktore hladaš ");
    string slovo = string.Parse(Console.ReadLine());
    veta.Contains(slovo);
}
else
{
    Console.WriteLine("vo vete sa nenachadza toto slovo");
}