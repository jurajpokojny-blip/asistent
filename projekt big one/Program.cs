Console.WriteLine("ahoj tozo su prikazi ktore funguju\n sum = sčitanie čisel \n odm = odmocnuje čislo \n find = hlada slovo v zadanej veťe");

while (true)
{
    
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
        double vysledokodm = Math.Pow(odm1, 1.0 / exponent);
        Console.WriteLine(vysledokodm);
    }

    if (mode == "find")
    {
        Console.WriteLine("sem zadaj vetu ");
        string veta = (Console.ReadLine());
        veta = veta.ToLower();
        Console.WriteLine("sem zadaj slovo ktore hladaš ");
        string slovo = (Console.ReadLine());
        slovo = slovo.ToLower();
        if (veta.Contains(slovo))
        {
            Console.WriteLine("slovo"+ slovo);
            Console.WriteLine("sa v vete nachadza");   
        }
        else
        {
            Console.WriteLine("v vete sa nenachadza slovo"+ slovo);    
        }
    }
    if (mode == "help")
    {
        Console.WriteLine("sum = sčitanie čisel \n odm = odmocnuje čislo \n find = hlada slovo v zadanej veťe ");
    }

    if (mode == "exit")
    {
        Console.WriteLine("je koniec");
        Environment.Exit(0);
    }
    if (mode == "rect") 
        
        Console.WriteLine("zapiš stranu a ");
        double A = int.Parse(Console.ReadLine());
        Console.WriteLine("zapižš stranu b");
        double B = int.Parse(Console.ReadLine());
        Console.WriteLine("operacie ktore možeš teraz urobiť su\nobvod=obv\nobsah=obs\nprierez=pri" );
        if (A<=0 || B <= 0)
        {
            Console.WriteLine("zle čislo");
            return;
        }

        Console.WriteLine("operacie ktore možeš teraz urobiť su\nobvod=obv\nobsah=obs\nprierez=pri" );
        while (true)
        {
            double OBV;
            double OBS;
            String moder = Console.ReadLine();
            if (moder == "obs")
            {
                
                OBS = (A * B);
                Console.WriteLine(OBS);
            }
            if (moder== "obv")
            {
                
                OBV = (2*(A + B));
                Console.WriteLine(OBV);
            }
            if (moder == "pri")
            {
                double PRI = Math.Sqrt(A*A+B*B);
                Console.WriteLine(PRI);
            }

            if (moder == "exit");
        }


}