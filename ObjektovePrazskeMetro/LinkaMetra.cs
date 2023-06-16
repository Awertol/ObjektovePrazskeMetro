using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjektovePrazskeMetro
{
    public class LinkaMetra
    {
        public string NazevLinky { get; set; }
        public string[] Stanice { get; set; }
        public bool Aktivni { get; set; }
        public string Barva { get; set; }

        public void VypisVsechnyStanice()
        {
            if (Stanice.Length > 0) 
            {
                foreach (var jednaStanice in Stanice)
                {
                    Console.WriteLine(jednaStanice);
                }
            }
        }
        public void VypisPrvniPosledni()
        {
            if(Stanice.Length >= 2)
            {
                Console.WriteLine(Stanice[0]); //první
                Console.WriteLine(Stanice[Stanice.Length-1]); //poslední
            }
        }
        public void NastavLinku()
        {
            if(Barva == "zelená")
            {
                Console.ForegroundColor= ConsoleColor.Green;
            }
            else if(Barva == "červená")
            {
                Console.ForegroundColor= ConsoleColor.Red;
            }
            else if(Barva == "žlutá")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else if(Barva == "modrá")
            {
                Console.ForegroundColor= ConsoleColor.Blue;
            }
            Console.WriteLine($"Vítej v lince metra {NazevLinky}");
        }
        public void CasCesty()
        {
            VypisVsechnyStanice();
            Console.WriteLine("***************************");
            Console.WriteLine("Vyber 1. stanici");
            string prvniStanice = Console.ReadLine();
            int indexPrvni = Array.IndexOf(Stanice, prvniStanice); //např. 1
            Console.WriteLine("---------");

            Console.WriteLine("Vyber 2. stanici");
            string druhaStanice = Console.ReadLine();
            int indexDruhe = Array.IndexOf(Stanice, druhaStanice); //např. 4
            Console.WriteLine("---------");
            int dobaCesty = (indexPrvni - indexDruhe)*2;
            Console.WriteLine("Doba cesty: " + dobaCesty);
        }
    }
}
