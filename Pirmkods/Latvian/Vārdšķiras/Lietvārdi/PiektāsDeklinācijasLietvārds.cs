using System;

namespace Latvian.Vārdšķiras.Lietvārdi
{
    /// <summary>
    /// V deklinācija.
    /// Pie V deklinācijas pieder sieviešu dzimtes lietvārdi, kam vienskaitļa nominatīvā ir galotne -e,
    /// kā arī vīriešu dzimtes un kopdzimtes lietvārdi, kam vienskaitļa nominatīvā ir galotne -e.
    /// </summary>
    public class PiektāsDeklinācijasLietvārds : DeklinējamsLietvārds
    {
        private Dzimte dzimte;

        public PiektāsDeklinācijasLietvārds(string vārds, Dzimte dzimte = Dzimte.Sieviešu)
        {
            if (vārds == null)
                throw new ArgumentNullException("vārds");
            if (!vārds.BeidzasAr("e"))
                throw new ArgumentException("Lietvārdam jābūt vienskaitļa nominatīvā");

            this.dzimte = dzimte;

            Galotne = "e";
            Celms = vārds.AtmestGalotni(Galotne);
        }

        public override Deklinācija Deklinācija
        {
            get { return Deklinācija.V; }
        }

        public override Dzimte Dzimte
        {
            get { return dzimte; }
        }

        public override string NominatīvaGalotne(Skaitlis skaitlis)
        {
            return (skaitlis == Skaitlis.Vienskaitlis) ? "e" : "es";
        }

        public override string ĢenitīvaGalotne(Skaitlis skaitlis)
        {
            return (skaitlis == Skaitlis.Vienskaitlis) ? "es" : "u";
        }

        public override string DatīvaGalotne(Skaitlis skaitlis)
        {
            return (skaitlis == Skaitlis.Vienskaitlis) ? (Dzimte == Dzimte.Sieviešu ? "ei" : "em") : "ēm"; // -em
        }

        public override string AkuzatīvaGalotne(Skaitlis skaitlis)
        {
            return (skaitlis == Skaitlis.Vienskaitlis) ? "i" : "es";
        }

        public override string LokatīvaGalotne(Skaitlis skaitlis)
        {
            return (skaitlis == Skaitlis.Vienskaitlis) ? "ē" : "ēs";
        }

        public override string VokatīvaGalotne(Skaitlis skaitlis)
        {
            return (skaitlis == Skaitlis.Vienskaitlis) ? "e" : "es"; // -
        }

        protected override string LīdzskaņuMija(Locījums locījums, Skaitlis skaitlis)
        {
            // V deklinācijas lietvārdiem līdzskaņu mija raksturīga daudzskaitļa ģenitīvā.
            if (locījums == Locījums.Ģenitīvs && skaitlis == Skaitlis.Daudzskaitlis)
            {
                // Līdzskaņu mijas nav:
                bool izņēmums = (Celms + Galotne).BeidzasAr(
                    "aste", "mate", "pēde",
                    "apšaude", "piešaude", "balle", "bāze", "bise",
                    "bote", "brīze", "flote", "fronte", "gāze", "gide", "kase",
                    "kušete", "mise", "mute", "pase", "rase",
                    "sarakste", "šprote", "takse", "tirāde"
                );

                // līdzskaņu mijas nav -ste, ja pirms s nav k
                bool izņēmums2 = Celms.BeidzasAr("st") && !Celms.BeidzasAr("kst");

                if (!izņēmums && !izņēmums2)
                {
                    string arMiju = Celms;

                    arMiju = arMiju.LīdzskaņuMija("kst", "kš")
                                   .LīdzskaņuMija("sn", "šņ")
                                   .LīdzskaņuMija("zn", "žņ")
                                   .LīdzskaņuMija("dz", "dž")
                                   .LīdzskaņuMija("b", "bj")
                                   .LīdzskaņuMija("m", "mj")
                                   .LīdzskaņuMija("p", "pj")
                                   .LīdzskaņuMija("v", "vj")
                                   .LīdzskaņuMija("t", "š")
                                   .LīdzskaņuMija("d", "ž")
                                   .LīdzskaņuMija("c", "č")
                                   .LīdzskaņuMija("s", "š")
                                   .LīdzskaņuMija("z", "ž")
                                   .LīdzskaņuMija("n", "ņ")
                                   .LīdzskaņuMija("l", "ļ");

                    return arMiju;
                }
            }

            return Celms;
        }
    }
}
