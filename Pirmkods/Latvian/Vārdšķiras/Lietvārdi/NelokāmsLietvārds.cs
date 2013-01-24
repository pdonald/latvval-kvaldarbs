namespace Latvian.Vārdšķiras.Lietvārdi
{
    /// <summary>
    /// Nelokāmam lietvārdam locījumos galotne nemainās.
    /// </summary>
    public class NelokāmsLietvārds : Lietvārds
    {
        private Dzimte dzimte;

        public NelokāmsLietvārds(string vārds, Dzimte dzimte)
        {
            Celms = vārds;
            this.dzimte = dzimte;
        }

        public override Dzimte Dzimte
        {
            get { return dzimte; }
        }

        public override string NominatīvaGalotne(Skaitlis skaitlis) { return ""; }
        public override string ĢenitīvaGalotne(Skaitlis skaitlis) { return ""; }
        public override string DatīvaGalotne(Skaitlis skaitlis) { return ""; }
        public override string AkuzatīvaGalotne(Skaitlis skaitlis) { return ""; }
        public override string LokatīvaGalotne(Skaitlis skaitlis) { return ""; }
        public override string VokatīvaGalotne(Skaitlis skaitlis) { return ""; }
    }
}
