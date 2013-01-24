using System;

namespace Latvian.Vārdšķiras.Lietvārdi
{
    /// <summary>
    /// VI deklinācija.
    /// Pie VI deklinācijas pieder sieviešu dzimtes lietvārdi, kam vienskaitļa nominatīvā ir galotne -s.
    /// </summary>
    public class SestāsDeklinācijasLietvārds : DeklinējamsLietvārds
    {
        public SestāsDeklinācijasLietvārds(string vārds)
        {
            if (vārds == null)
                throw new ArgumentNullException("vārds");
            if (!vārds.BeidzasAr("s"))
                throw new ArgumentException("Lietvārdam jābūt vienskaitļa nominatīvā");

            Galotne = vārds.BeidzasAr("is") ? "is" : "s";
            Celms = vārds.AtmestGalotni(Galotne);
        }

        public override Deklinācija Deklinācija
        {
            get { return Deklinācija.VI; }
        }

        public override Dzimte Dzimte
        {
            get { return Dzimte.Sieviešu; }
        }

        public override string NominatīvaGalotne(Skaitlis skaitlis)
        {
            return (skaitlis == Skaitlis.Vienskaitlis) ? "s" : "is";
        }

        public override string ĢenitīvaGalotne(Skaitlis skaitlis)
        {
            return (skaitlis == Skaitlis.Vienskaitlis) ? "s" : "u";
        }

        public override string DatīvaGalotne(Skaitlis skaitlis)
        {
            return (skaitlis == Skaitlis.Vienskaitlis) ? "ij" : "īm";
        }

        public override string AkuzatīvaGalotne(Skaitlis skaitlis)
        {
            return (skaitlis == Skaitlis.Vienskaitlis) ? "i" : "is";
        }

        public override string LokatīvaGalotne(Skaitlis skaitlis)
        {
            return (skaitlis == Skaitlis.Vienskaitlis) ? "ī" : "īs";
        }

        public override string VokatīvaGalotne(Skaitlis skaitlis)
        {
            return (skaitlis == Skaitlis.Vienskaitlis) ? "s" : "is";
        }

        protected override string LīdzskaņuMija(Locījums locījums, Skaitlis skaitlis)
        {
            // VI deklinācijas lietvārdiem līdzskaņu mija raksturīga daudzskaitļa ģenitīvā.
            if (locījums == Locījums.Ģenitīvs && skaitlis == Skaitlis.Daudzskaitlis)
            {
                // "brokastis", "Cēsis"
                bool izņēmums = (Celms + "s").BeidzasAr(
                    "acs", "akti", "ass", "auss", "balss",
                    "dakts", "debess", "dzelzs", "kūts", "kūts", "maksts",
                    "pirts", "šalts", "takts", "uts", "valsts", "vēsts", "zoss", "žults"
                );

                if (!izņēmums)
                {
                    string arMiju = Celms;

                    arMiju = arMiju.LīdzskaņuMija("sn", "šņ")
                                   .LīdzskaņuMija("st", "š")
                                   .LīdzskaņuMija("v", "vj")
                                   .LīdzskaņuMija("t", "š")
                                   .LīdzskaņuMija("d", "ž")
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
