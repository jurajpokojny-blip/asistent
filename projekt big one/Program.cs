Console.WriteLine("ahoj tozo su prikazi ktore funguju\n sum = sčitanie čisel \n odm = odmocnuje čislo \n find = hlada slovo v zadanej veťe \n rect = meranie obdĺžnika \n array = praca s poľom");

while (true)
{
    String mode = Console.ReadLine();
    if (mode == "sum")
    {
        VykonajSum();
    }
    if (mode == "odm")
    {
        VykonajOdm();
    }
    if (mode == "find")
    {
        VykonajFind();
    }
    if (mode == "help")
    {
        VykonajHelp();
    }
    if (mode == "exit")
    {
        Console.WriteLine("je koniec");
        Environment.Exit(0);
    }
    if (mode == "rect")
    {
        VykonajRect();
    }
    if (mode == "array")
    {
        VykonajArray();
    }
}

void VykonajSum()
{
    Console.WriteLine("zapiš 2 čisla ktore chceš sčiťať");
    int cislo1sum = int.Parse(Console.ReadLine());
    Console.WriteLine("+");
    int cislo2sum = int.Parse(Console.ReadLine());
    int vysledokSum = cislo1sum + cislo2sum;
    Console.WriteLine(vysledokSum);
}

void VykonajOdm()
{
    Console.WriteLine("zapiš čislo ktore chceš odmocniť a čim");
    double odm1 = double.Parse(Console.ReadLine());
    double exponent = double.Parse(Console.ReadLine());
    double vysledokodm = Math.Pow(odm1, 1.0 / exponent);
    Console.WriteLine(vysledokodm);
}

void VykonajFind()
{
    Console.WriteLine("sem zadaj vetu ");
    string veta = Console.ReadLine();
    veta = veta.ToLower();
    Console.WriteLine("sem zadaj slovo ktore hladaš ");
    string slovo = Console.ReadLine();
    slovo = slovo.ToLower();
    if (veta.Contains(slovo))
    {
        Console.WriteLine("slovo" + slovo);
        Console.WriteLine("sa v vete nachadza");
    }
    else
    {
        Console.WriteLine("v vete sa nenachadza slovo" + slovo);
    }
}

void VykonajHelp()
{
    Console.WriteLine("sum = sčitanie čisel \n odm = odmocnuje čislo \n find = hlada slovo v zadanej veťe \n rect = meranie obdĺžnika \n array = praca s poľom");
}

void VykonajRect()
{
    Console.WriteLine("zapiš stranu a ");
    double A = int.Parse(Console.ReadLine());
    Console.WriteLine("zapižš stranu b");
    double B = int.Parse(Console.ReadLine());
    Console.WriteLine("operacie ktore možeš teraz urobiť su\nobvod=obv\nobsah=obs\nprierez=pri");

    if (A <= 0 || B <= 0)
    {
        Console.WriteLine("zle čislo");
        return;
    }

    Console.WriteLine("operacie ktore mežeš teraz urobiť su\nobvod=obv\nobsah=obs\nprierez=pri");

    while (true)
    {
        String moder = Console.ReadLine();
        if (moder == "obs")
        {
            double OBS = VypocitajObsah(A, B);
            Console.WriteLine(OBS);
        }
        if (moder == "obv")
        {
            double OBV = VypocitajObvod(A, B);
            Console.WriteLine(OBV);
        }
        if (moder == "pri")
        {
            double PRI = VypocitajPrierez(A, B);
            Console.WriteLine(PRI);
        }
        if (moder == "exit")
        {
            break;
        }
    }
}

double VypocitajObsah(double A, double B)
{
    double vysledokObsah = A * B;
    return vysledokObsah;
}

double VypocitajObvod(double A, double B)
{
    double vysledokObvod = 2 * (A + B);
    return vysledokObvod;
}

double VypocitajPrierez(double A, double B)
{
    double vysledokPrierez = Math.Sqrt(A * A + B * B);
    return vysledokPrierez;
}

void VykonajArray()
{
    Console.WriteLine("zadaj pole:");
    string vstup = Console.ReadLine();
    string[] prvky = vstup.Split(' ');
    List<int> ary = new List<int>();

    for (int i = 0; i < prvky.Length; i++)
    {
        int cislo = int.Parse(prvky[i]);
        ary.Add(cislo);
    }

    Console.WriteLine("co chces robit?");

    string modearr = "";
    while (modearr != "exit")
    {
        modearr = Console.ReadLine();

        if (modearr == "find")
        {
            Console.WriteLine("co hldas?");
            int hladane = int.Parse(Console.ReadLine());
            int pozicia = ary.IndexOf(hladane);

            if (pozicia != -1)
            {
                Console.WriteLine("cislo " + hladane + " je na pozicii " + (pozicia + 1));
            }
            else
            {
                Console.WriteLine("cislo " + hladane + " tu nie je");
            }
        }

        if (modearr == "sort")
        {
            ary.Sort();
            Console.WriteLine("zotriedene: " + string.Join(" ", ary));
        }
    }
}