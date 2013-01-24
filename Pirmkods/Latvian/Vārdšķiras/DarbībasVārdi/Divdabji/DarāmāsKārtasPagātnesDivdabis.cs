using Latvian.Vārdšķiras.ĪpašībasVārdi;

namespace Latvian.Vārdšķiras.DarbībasVārdi.Divdabji
{
	public class DarāmāsKārtasPagātnesDivdabis : ĪpašībasVārds
	{
		private IDarbībasVārds darbībasVārds;

		public DarāmāsKārtasPagātnesDivdabis(IDarbībasVārds vārds)
			: base(vārds.PagātnesCelms + "s")
		{
			darbībasVārds = vārds;
		}
		
		public new string NominatīvaGalotne(Dzimte dzimte, Skaitlis skaitlis, Galotne galotne)
		{
			if (darbībasVārds.Tiešs)
			{
				if (skaitlis == Skaitlis.Vienskaitlis)
				{
					if (dzimte == Dzimte.Vīriešu)
					{
						return (galotne == ĪpašībasVārdi.Galotne.Nenoteiktā) ? "is" : "ušais";
					}
					else
					{
						return (galotne == ĪpašībasVārdi.Galotne.Nenoteiktā) ? "usi" : "usī";
					}
				}
				else
				{
					return "uš" + base.NominatīvaGalotne(dzimte, skaitlis, galotne);
				}
			}
			else
			{
				if (skaitlis == Skaitlis.Vienskaitlis)
				{
					return dzimte == Dzimte.Vīriešu ? "ies" : "usies";
				}
				else
				{
					return dzimte == Dzimte.Vīriešu ? "ušies" : "ušās";
				}
			}
		}
		
		public new string ĢenitīvaGalotne(Dzimte dzimte, Skaitlis skaitlis, Galotne galotne)
		{
			if (darbībasVārds.Tiešs)
			{
				return "uš" + ĢenitīvaGalotne(dzimte, skaitlis, galotne);
			}
			else
			{
				return "uš" + (skaitlis == Skaitlis.Vienskaitlis ? "ās" : "oš");
			}
		}
		
		public new string DatīvaGalotne(Dzimte dzimte, Skaitlis skaitlis, Galotne galotne)
		{
			if (darbībasVārds.Tiešs)
			{
				return "uš" + DatīvaGalotne(dzimte, skaitlis, galotne);
			}
			else
			{
				return "";
			}
		}
		
		public new string AkuzatīvaGalotne(Dzimte dzimte, Skaitlis skaitlis, Galotne galotne)
		{
			if (darbībasVārds.Tiešs)
			{
				return "uš" + AkuzatīvaGalotne(dzimte, skaitlis, galotne);
			}
			else
			{
				if (skaitlis == Skaitlis.Vienskaitlis)
				{
					return "uš" + "os";
				}
				else
				{
					return "uš" + (dzimte == Dzimte.Vīriešu ? "os" : "ās");
				}
			}
		}
		
		public new string LokatīvaGalotne(Dzimte dzimte, Skaitlis skaitlis, Galotne galotne)
		{
			if (darbībasVārds.Tiešs)
			{
				return "uš" + LokatīvaGalotne(dzimte, skaitlis, galotne);
			}
			else
			{
				return null;
			}
		}
		
		public new string Nominatīvs(Dzimte dzimte, Skaitlis skaitlis, Galotne galotne)
		{
			string sakne = Celms;
			
			if (skaitlis == Skaitlis.Vienskaitlis && dzimte == Dzimte.Vīriešu && (galotne == ĪpašībasVārdi.Galotne.Nenoteiktā))
			{
				sakne = sakne.LīdzskaņuMija("k", "c");
				sakne = sakne.LīdzskaņuMija("g", "dz");
			}
			else
			{
				sakne = sakne.LīdzskaņuMija("c", "k");
				sakne = sakne.LīdzskaņuMija("dz", "g");
			}
			
			return sakne + NominatīvaGalotne(dzimte, skaitlis, galotne);
		}

		public new string Datīvs(Dzimte dzimte, Skaitlis skaitlis, Galotne galotne)
		{
			if (darbībasVārds.Tiešs)
			{
				return base.Datīvs(dzimte, skaitlis, galotne);
			}
			else
			{
				return "";
			}
		}

		public new string Lokatīvs(Dzimte dzimte, Skaitlis skaitlis, Galotne galotne)
		{
			if (darbībasVārds.Tiešs)
			{
				return base.Lokatīvs(dzimte, skaitlis, galotne);
			}
			else
			{
				return "";
			}
		}
	}
}
