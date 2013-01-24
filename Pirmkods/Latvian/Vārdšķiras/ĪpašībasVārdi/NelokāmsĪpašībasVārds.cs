namespace Latvian.Vārdšķiras.ĪpašībasVārdi
{
	public class NelokāmsĪpašībasVārds : ĪpašībasVārds
	{
		private const string TukšāGalotne = "";

		public NelokāmsĪpašībasVārds(string vārds)
		{
            Celms = vārds;
		}

		public override string NominatīvaGalotne(Dzimte dzimte, Skaitlis skaitlis, Galotne galotne)
		{
			return TukšāGalotne;
		}

		public override string ĢenitīvaGalotne(Dzimte dzimte, Skaitlis skaitlis, Galotne galotne)
		{
			return TukšāGalotne;
		}

		public override string DatīvaGalotne(Dzimte dzimte, Skaitlis skaitlis, Galotne galotne)
		{
			return TukšāGalotne;
		}

		public override string AkuzatīvaGalotne(Dzimte dzimte, Skaitlis skaitlis, Galotne galotne)
		{
			return TukšāGalotne;
		}

		public override string LokatīvaGalotne(Dzimte dzimte, Skaitlis skaitlis, Galotne galotne)
		{
			return TukšāGalotne;
		}

		public override ĪpašībasVārds PamataPakāpe
		{
			get { return this; }
		}

		public override ĪpašībasVārds PārākāPakāpe
		{
			get { return this; }
		}

		public override ĪpašībasVārds VispārākāPakāpe
		{
			get { return this; }
		}
	}
}
