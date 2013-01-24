namespace Latvian.Vārdšķiras.DarbībasVārdi.Divdabji
{
    public class DaļējiLokāmaisDivdabis : Vārds
    {
        private DarbībasVārds darbībasVārds;

        public DaļējiLokāmaisDivdabis(DarbībasVārds vārds)
		{
			Celms = vārds.NenoteiksmesCelms;
            darbībasVārds = vārds;
		}
		
		public string NominatīvaGalotne(Dzimte dzimte, Skaitlis skaitlis)
		{
			string galotne = "dam";

            if (darbībasVārds.Tiešs)
            {
                if (skaitlis == Skaitlis.Vienskaitlis)
                {
                    galotne += dzimte == Dzimte.Vīriešu ? "s" : "a";
                }
                else
                {
                    galotne += dzimte == Dzimte.Vīriešu ? "i" : "as";
                }
            }
            else
            {
                galotne += dzimte == Dzimte.Vīriešu ? "ies" : "ās";
            }
			
			return galotne;
		}
		
		public string Nominatīvs(Dzimte dzimte, Skaitlis skaitlis)
		{
			return Celms + NominatīvaGalotne(dzimte, skaitlis);
		}
    }
}
