/*string vstup = Console.ReadLine();
 int cislo = int.TryParse(vstup);
   if (cislo % 3 == 0)
   {
       Console.WriteLine("je delitelne 3");
   }
   if (cislo % 5 == 0)
   {
       Console.WriteLine("je delitelne 5");
   }
   if (cislo % 7 == 0)
   {
       Console.WriteLine("je delitelne 7");
   }
*/
/*string vstup = Console.ReadLine();
int cislo = int.Parse(vstup);
if (cislo == 6 || cislo == 7)
{
    Console.WriteLine("vikend");
}
if (cislo == 1 || cislo == 2 || cislo == 3 || cislo == 4 || cislo == 5)
{
    Console.WriteLine("tizden");
*/
/*string vstup = Console.ReadLine();
if (vstup[0] == '#')
{
    Console.WriteLine(" veta "+ vstup +" sa začina s mriežkou");
}
else
{
    Console.WriteLine("Tvoja veta sa nema #");
}*/
/*Console.Write(" meno ") ;
string meno = Console.ReadLine();
if (meno != null || meno.Length >= 4 || meno.Length <= 12)
{
    Console.WriteLine("meno je správne");
}
else
{
    Console.WriteLine("meno je nesprávne");
}*/
/*Console.Write("Zadaj cislo najvacsieho uhla") ;
int uhol = int.Parse(Console.ReadLine());


if (uhol == 90)
{
    Console.WriteLine("Pravouhly trojuholnik");
}
else if (uhol > 90)
{
    Console.WriteLine("Tupý uhol");
}
else if (uhol < 90)
{
    Console.WriteLine("Ostrý uhol");
} */
/*Console.Write("Zadaj dve cisla a poviem ktore je vacsie") ;
int cislo1 = int.Parse(Console.ReadLine());
int cislo2 = int.Parse(Console.ReadLine());
if (cislo1 > cislo2)
{
    Console.WriteLine("Prve čislo ja vacsie");
}
else if (cislo1 < cislo2)
    Console.WriteLine("Druhe čislo ja vacsie");
else
{
    Console.WriteLine("su rovnake");  
}*/
/*Console.Write("Zadaj cislo: ");
double cislo = int.Parse(Console.ReadLine());

Console.Write("Zadaj prikaz: ");
string prikaz = Console.ReadLine();

if (prikaz == "obratena hodnota")
{
    if (cislo == 0)
    {
        Console.WriteLine("Obratena hodnota z nuly sa neda");
    }
    else
    {
        double vysledok = 1 / cislo;
        Console.WriteLine($"Obratena hodnota je: {vysledok}");
    }
}
else if (prikaz == "druha mocnina")
{
    double vysledok = Math.Pow(cislo, 2);
    Console.WriteLine($"Druha mocnina je: {vysledok}");
}
else if (prikaz == "odmocnina")
{
    if (cislo < 0)
    {
        Console.WriteLine("Odmocnina zo zaporneho cisla sa neda");
    }
    else
    {
        double vysledok = Math.Sqrt(cislo);
        Console.WriteLine($"Odmocnina je: {vysledok}");
    }
}
else
{
    Console.WriteLine("Takyto prikaz neni spravny");
}
*/
/*Console.Write("Zadaj vetu: ");
string veta = Console.ReadLine();

if (veta.Contains("the"))
{
    Console.WriteLine("Vo vete sa nachadza the");
}

 (veta.Contains("The"))
{
    Console.WriteLine("Vo vete sa nachadza the");
}

if (veta.Contains("THE"))
{
    Console.WriteLine("Vo vete sa nachadza the");
}*/
/*
string vstup = Console.ReadLine();
int cislo = int.Parse(vstup);
if (cislo >= 1 || cislo <= 17)
{
    Console.WriteLine("nemaš");
}
else
{
    Console.WriteLine("maš");
}
*/
/*string vstup = Console.ReadLine();
if (vstup[0] == '9'&& vstup[1] == '9')
{
    Console.WriteLine(" maš vip ");
}
else
{
    Console.WriteLine("skoda nemaš vip");
}  */  
/*Console.Write(" meno ") ;
string meno = Console.ReadLine();
if (meno == "ivan")
{
    Console.WriteLine(" si ivan  nemožeš");
}
else
{
    Console.WriteLine("ano ti mozeš");
}*/
/*string roky = Console.ReadLine();
string cislo = Console.ReadLine();
string meno = Console.ReadLine();
int vek = int.Parse(roky);
if (vek >= 1 || vek <= 17)
{
    Console.WriteLine("nie");
}
else
{
    Console.WriteLine("ano");
}
string vstup = Console.ReadLine();
if (vstup[0] == '9'&& vstup[1] == '9')
{
    Console.WriteLine(" ano ");
}
else
{
    Console.WriteLine("nie");
}
Console.Write(" meno ") ;

if (meno == "ivan")
{
    Console.WriteLine(" nie");
}
else
{
    Console.WriteLine("ano");
}*/
/*string vstup = Console.ReadLine();
int cislo = int.Parse(vstup);
if (cislo >= 1 || cislo <= 17)
{
    int id1 = Console.ReadLine();
    if (id1/5)
    {
        Console.WriteLine(" spravne ");
    }
    else
    {
        Console.WriteLine("nie valid");
    }
    string id2 = Console.ReadLine();
    if (id2/5)
    {
        Console.WriteLine(" spravne ");
    }
    else
    {
        Console.WriteLine("nie valid");
    }
}
else
{
    Console.WriteLine("mozes");
}*/
/*Console.WriteLine("daj cislo");
string vstup = Console.ReadLine();
int cislo = int.Parse(vstup);
for (int i = 2; i <= cislo; i += 1)
{
    if (cislo % i == 0)
    {
        Console.WriteLine(i);
    }
}*/
/*for (int i = 1; i <= 100; i += 1)
{
    Console.WriteLine($"Som trpaslík {i} a spolu je nás 100");
}*/
/*Console.WriteLine("napiš vetu");
string vstup = Console.ReadLine();
int i = 0;
    while(i < vstup.Length && vstup[i] != '!')
    {
        Console.WriteLine(vstup[i]);
        i++;
    }
if (i < vstup.Length && vstup[i] == '!')
{
Console.WriteLine("našiel som");
}*/
/*string text = Console.ReadLine();
string pismeno = Console.ReadLine();
int a = 0;
for (int i = 0; i < text.Length; i++)
{
    if (pismeno.Contains(text[i]))
    {
        a++;
    }
}
Console.WriteLine(a);*/
/*Console.WriteLine("Zadaj veľkosť");
int cislo = int.Parse(Console.ReadLine());

for (int i = 0; i < cislo; i++)
{
    for (int cislo2 = 0; cislo2 < cislo; cislo2++)
    {
        Console.Write("#"); 
    }
    
    Console.WriteLine();
}*/
/*int[] pole = { 2, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 27, 29 };
int plus = 7;
for (int index = 0; index < pole.Length; index = index + 1)
{
    int visledok = pole[index] + plus;
    Console.WriteLine(visledok);

}*/
/*int[] pole = { 2, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 27, 29 };
int visledok = 0;

for (int index = 0; index < pole.Length; index = index + 1)
{
    visledok = pole[index] + visledok;
}

Console.WriteLine("Vysledok je " + visledok);*/
/*int[] pole = { 2, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 27, 29 };

int najvacsie = pole[0];

for (int index = 1; index < pole.Length; index = index + 1)
{
    if (pole[index] > najvacsie)
    {
        najvacsie = pole[index];
    }
}

Console.WriteLine(najvacsie);
*/

/*
List<string> names = new List<string>();
names.Add("svetozar");
names.Add("max");
names.Add("ivan");
names.Add("sano");
names.Add("juraj");
names.Add("aron");
names.Sort();
for (int i=0 ; i < names.Count; i++)
{
Console.WriteLine(names[i]);
}
*/
/*int cislo = 1;
int cislo2 = 1;

void Repeat(int cislo, int cislo2)
{
    List<int> list1 = new List<int>();
    List<int> list2 = new List<int>();
    List<int> list3 = new List<int>();

    list1.Add(cislo);
    list2.Add(cislo2);

    list3.AddRange(list1);
    list3.AddRange(list2);

    Console.WriteLine(list3[1]);
}
*/
/*List<string> mena = new List<string> { "Anton", "Mojmir", "Gregor", "Lucius" };
List<int> veky = new List<int> { 17, 29, 8, 12 };

Console.Write("Kolko ma rokov ten koho hladame? ");
int hladany_vek = int.Parse(Console.ReadLine());

int pozicia = veky.IndexOf(hladany_vek);

Console.WriteLine(mena[pozicia]);
*/ /*List<string> mena = new List<string> { "Anton", "Mojmir", "Gregor", "Lucius" };
List<int> veky = new List<int> { 17, 29, 8, 12 };
Console.Write("Kolko ma rokov ten koho hladame? ");
int hladany_vek = int.Parse(Console.ReadLine());
int pozicia = veky.IndexOf(hladany_vek);
if (pozicia != -1)
{
    Console.WriteLine(mena[pozicia]);
}
else
{
    Console.WriteLine("Taký vek sa v zozname nenachádza.");
}
*/
/*List<string> mena = new List<string> { "Anton", "Mojmir", "Gregor", "Lucius" };
List<int> veky = new List<int> { 17, 29, 8, 12 };
Console.Write("Koho chceme vymazat? Zadaj vek: ");
int hladany_vek = int.Parse(Console.ReadLine());
int pozicia = veky.IndexOf(hladany_vek);
if (pozicia != -1)
{
    mena.RemoveAt(pozicia);
    veky.RemoveAt(pozicia);

    Console.WriteLine("Clovek bol vymazany.");
}
else
{
    Console.WriteLine("neni tu.");
}*/
int[] cisla = { 10, 2, 70, 9 };

Array.Sort(cisla);
for (int i = [0]; cisla[i] < cisla[]; cisla[i]++)
{
    if ()
    {
        
    }
}

