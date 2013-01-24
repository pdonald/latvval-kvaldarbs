using System;

namespace Latvian.Vārdšķiras.Lietvārdi
{
    /// <summary>
    /// I deklinācija.
    /// Pie I deklinācijas pieder vīriešu dzimtes lietvārdi, kam vienskaitļa nominatīvā ir galotne -s vai -š.
    /// </summary>
    public class PirmāsDeklinācijasLietvārds : DeklinējamsLietvārds
    {
        public PirmāsDeklinācijasLietvārds(string vārds)
        {
            if (vārds == null)
                throw new ArgumentNullException("vārds");
            if (!vārds.BeidzasAr("s", "š"))
                throw new ArgumentException("Lietvārdam jābūt vienskaitļa nominatīvā");

            Galotne = vārds.BeidzasAr("š") ? "š" : "s";
            Celms = vārds.AtmestGalotni(Galotne);
        }

        public override Deklinācija Deklinācija
        {
            get { return Deklinācija.I; }
        }

        public override Dzimte Dzimte
        {
            get { return Dzimte.Vīriešu; }
        }

        public override string NominatīvaGalotne(Skaitlis skaitlis)
        {
            return (skaitlis == Skaitlis.Vienskaitlis) ? Galotne /* -s, -š */ : "i"; 
        }

        public override string ĢenitīvaGalotne(Skaitlis skaitlis)
        {
            return (skaitlis == Skaitlis.Vienskaitlis) ? "a" : "u";
        }

        public override string DatīvaGalotne(Skaitlis skaitlis)
        {
            return (skaitlis == Skaitlis.Vienskaitlis) ? "am" : "iem";
        }

        public override string AkuzatīvaGalotne(Skaitlis skaitlis)
        {
            return (skaitlis == Skaitlis.Vienskaitlis) ? "u" : "us";
        }

        public override string LokatīvaGalotne(Skaitlis skaitlis)
        {
            return (skaitlis == Skaitlis.Vienskaitlis) ? "ā" : "os";
        }

        public override string VokatīvaGalotne(Skaitlis skaitlis)
        {
            return (skaitlis == Skaitlis.Vienskaitlis) ? Galotne /* -s, -š, - */ : "i";
        }
    }
}
