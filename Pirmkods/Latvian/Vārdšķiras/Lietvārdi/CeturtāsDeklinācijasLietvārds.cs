using System;

namespace Latvian.Vārdšķiras.Lietvārdi
{
    /// <summary>
    /// IV deklinācija.
    /// Pie IV deklinācijas pieder sieviešu dzimtes lietvārdi, kam vienskaitļa nominatīvā ir galotne -a,
    /// kā arī vīriešu dzimtes un kopdzimtes lietvārdi, kam vienskaitļa nominatīvā ir galotne -a.
    /// </summary>
    public class CeturtāsDeklinācijasLietvārds : DeklinējamsLietvārds
    {
        private Dzimte dzimte;

        public CeturtāsDeklinācijasLietvārds(string vārds, Dzimte dzimte = Dzimte.Sieviešu)
        {
            if (vārds == null)
                throw new ArgumentNullException("vārds");
            if (!vārds.BeidzasAr("a"))
                throw new ArgumentException("Lietvārdam jābūt vienskaitļa nominatīvā");

            this.dzimte = dzimte;

            Galotne = "a";
            Celms = vārds.AtmestGalotni(Galotne);
        }

        public override Deklinācija Deklinācija
        {
            get { return Deklinācija.IV; }
        }

        public override Dzimte Dzimte
        {
            get { return dzimte; }
        }

        public override string NominatīvaGalotne(Skaitlis skaitlis)
        {
            return (skaitlis == Skaitlis.Vienskaitlis) ? "a" : "as";
        }

        public override string ĢenitīvaGalotne(Skaitlis skaitlis)
        {
            return (skaitlis == Skaitlis.Vienskaitlis) ? "as" : "u";
        }

        public override string DatīvaGalotne(Skaitlis skaitlis)
        {
            return (skaitlis == Skaitlis.Vienskaitlis) ? (Dzimte == Dzimte.Sieviešu ? "ai" : "am") : "ām";
        }

        public override string AkuzatīvaGalotne(Skaitlis skaitlis)
        {
            return (skaitlis == Skaitlis.Vienskaitlis) ? "u" : "as";
        }

        public override string LokatīvaGalotne(Skaitlis skaitlis)
        {
            return (skaitlis == Skaitlis.Vienskaitlis) ? "ā" : "ās";
        }

        public override string VokatīvaGalotne(Skaitlis skaitlis)
        {
            return (skaitlis == Skaitlis.Vienskaitlis) ? "a" : "as"; // -
        }
    }
}
