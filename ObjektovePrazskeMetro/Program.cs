using ObjektovePrazskeMetro;

string[] poleLinkaA = { "Nemocnice Motol", "Petřiny", "Nádraží Veleslavní", "Bořislavka", "Dejvická", "Hradčanská", "Malostranská", "Staroměstská",
          "Můstek", "Muzeum", "Náměstí míru", "Jiřího z Poděbrad", "Flora", "Želivského", "Strašnická", "Skalka", "Depo Hostivař" };
string[] poleLinkaB = { "Zličín", "Stodůlky", "Luka", "Lužiny", "Hůrka", "Nové Butovice", "Jinonice", "Radlická", "Smíchovské nádraží", "Anděl", "Karlovo náměstí",
          "Národní třída", "Můstek", "Náměstí Republiky", "Florenc", "Křížova", "Invalidovna", "Českomoravská", "Vysočasnská", "Kolbenova", "Hloubětín", "Rajská zahrada", "Černý Most"};
string[] poleLinkaC = {"Letňany", "Prosek", "Střížkov", "Ládví", "Kobylisy", "Nádraží Holešovice", "Vltavská", "Florenc", "Hlavní nádraží", "Muzeum",
          "I. P. Pavlova", "Vyšehrad", "Pražského povstání", "Pankrác", "Budějovická", "Kačerov", "Roztyly", "Chodov", "Opatov", "Háje"};
string[] poleLinkaD = { "Depo Písnice", "Písnice", "Libuš", "Nové Dvory", "Nemocnice Krč", "Nádraží Krč", "Olbrachtova", "Pankrác", "Náměstí Bratří Synků", "Náměstí Míru" };

Console.WriteLine("Zadej linku kterou chceš využít: (A/B/C/D)");
string volbaLinky = Console.ReadLine();
if(volbaLinky == "A")
{
    LinkaMetra linkaA = new LinkaMetra() 
    { NazevLinky = "A", Barva = "zelená", Aktivni = true, Stanice = poleLinkaA };
    linkaA.NastavLinku();
    Console.WriteLine("Chcete vypsat 1. všechny stanice | 2. první a poslední | 3. zjistit čas cesty");
    string volba = Console.ReadLine();
    if(volba == "1")
    {
        linkaA.VypisVsechnyStanice();
    }
    else if(volba == "2")
    {
        linkaA.VypisPrvniPosledni();
    }
}
