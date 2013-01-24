using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Latvian.Vārdšķiras.Lietvārdi;
using Latvian.Vārdšķiras;
using Latvian.Vārdšķiras.DarbībasVārdi;

namespace Lietošana
{
    class Program
    {
        static void Main(string[] args)
        {
            var locījumi = (Locījums[])System.Enum.GetValues(typeof(Locījums));
            var skaitļi = (Skaitlis[])System.Enum.GetValues(typeof(Skaitlis));

            Lietvārds lietvārds = LietvārduBūvnīca.Jauns("kāposts");

            Console.WriteLine("Lietvārda locīšana: " + lietvārds.Nominatīvs());

            foreach (Locījums locījums in locījumi)
                foreach (Skaitlis skaitlis in skaitļi)
                    Console.WriteLine(locījums + ", " + skaitlis + ": " + lietvārds.Locīt(locījums, skaitlis));

            List<string> lietvārdaLocījumi = new List<string>();
            foreach (Locījums locījums in locījumi)
                foreach (Skaitlis skaitlis in skaitļi)
                    lietvārdaLocījumi.Add(lietvārds.Locīt(locījums, skaitlis));

            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Tiks meklēts visos locījumos pēc: " + string.Join(" ", lietvārdaLocījumi.Distinct()));

            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Personvārdu locīšana");

            var personvārdi = new Dictionary<string, Dzimte> {
                { "Pēteris Ņikiforovs", Dzimte.Vīriešu },
                { "Māris Dreimanis", Dzimte.Vīriešu },
                { "Juris Borzovs", Dzimte.Vīriešu },
                { "Ieva Ābele",  Dzimte.Sieviešu },
                { "Jānis Roze", Dzimte.Vīriešu }
            };

            foreach (var personvārds in personvārdi)
            {
                string[] vārdi = personvārds.Key.Split(' ');
                Console.WriteLine(personvārds + " => " + LietvārduBūvnīca.Jauns(vārdi[0]).Datīvs() + " " + LietvārduBūvnīca.Jauns(vārdi[1], personvārds.Value).Datīvs());
            }

            Console.ReadLine();
            Console.WriteLine();

            Lietvārds suns = new OtrāsDeklinācijasLietvārds("suns");
            Lietvārds kaķis = new OtrāsDeklinācijasLietvārds("kaķis");
            DarbībasVārds ieraudzīt = new DarbībasVārds("ieraudzīt", "ieraugu", "ieraudzīju", Konjugācija.III, 1);

            Console.WriteLine("Izloki vārdus, lai atrisinātu captchu: {0} <{1}> <{2}>:",
                suns.Nominatīvs(), ieraudzīt.Nenoteiksme, kaķis.Nominatīvs());

            string atbilde = Console.ReadLine();

            while (atbilde != "viss")
            {
                string[] atbildes = {
                    suns.Nominatīvs() + " " + ieraudzīt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaTrešāPersona) + " " + kaķis.Akuzatīvs(),
                    suns.Nominatīvs() + " " + ieraudzīt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaTrešāPersona) + " " + kaķis.Akuzatīvs(),
                    suns.Nominatīvs() + " " + ieraudzīt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona) + " " + kaķis.Akuzatīvs(),
                    suns.Nominatīvs() + " " + ieraudzīt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaTrešāPersona) + " " + kaķis.Akuzatīvs(Skaitlis.Daudzskaitlis),
                    suns.Nominatīvs() + " " + ieraudzīt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaTrešāPersona) + " " + kaķis.Akuzatīvs(Skaitlis.Daudzskaitlis),
                    suns.Nominatīvs() + " " + ieraudzīt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona) + " " + kaķis.Akuzatīvs(Skaitlis.Daudzskaitlis),
                };

                Console.WriteLine(atbildes.Contains(atbilde) ? "Pareizi!" : "Nepareizi!");
                atbilde = Console.ReadLine();
            }
        }
    }
}
