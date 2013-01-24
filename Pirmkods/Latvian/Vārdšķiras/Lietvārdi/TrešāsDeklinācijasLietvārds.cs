using System;

namespace Latvian.Vārdšķiras.Lietvārdi
{
    /// <summary>
    /// III deklinācija.
    /// Pie III deklinācijas pieder vīriešu dzimtes lietvārdi, kam vienskaitļa nominatīvā ir galotne -us.
    /// </summary>
    public class TrešāsDeklinācijasLietvārds : DeklinējamsLietvārds
    {
        public TrešāsDeklinācijasLietvārds(string vārds)
        {
            if (vārds == null)
                throw new ArgumentNullException("vārds");
            if (!vārds.BeidzasAr("us"))
                throw new ArgumentException("Lietvārdam jābūt vienskaitļa nominatīvā");

            Galotne = "us";
            Celms = vārds.AtmestGalotni(Galotne);
        }

        public override Deklinācija Deklinācija
        {
            get { return Deklinācija.III; }
        }

        public override Dzimte Dzimte
        {
            get { return Dzimte.Vīriešu; }
        }

        public override string NominatīvaGalotne(Skaitlis skaitlis)
        {
            return (skaitlis == Skaitlis.Vienskaitlis) ? "us" : "i";
        }

        public override string ĢenitīvaGalotne(Skaitlis skaitlis)
        {
            return (skaitlis == Skaitlis.Vienskaitlis) ? "us" : "u";
        }

        public override string DatīvaGalotne(Skaitlis skaitlis)
        {
            return (skaitlis == Skaitlis.Vienskaitlis) ? "um" : "iem";
        }

        public override string AkuzatīvaGalotne(Skaitlis skaitlis)
        {
            return (skaitlis == Skaitlis.Vienskaitlis) ? "u" : "us";
        }

        public override string LokatīvaGalotne(Skaitlis skaitlis)
        {
            return (skaitlis == Skaitlis.Vienskaitlis) ? "ū" : "os";
        }

        public override string VokatīvaGalotne(Skaitlis skaitlis)
        {
            return (skaitlis == Skaitlis.Vienskaitlis) ? "us" : "i"; // -u
        }
    }
}
