using System;

namespace Latvian.Vārdšķiras.ĪpašībasVārdi
{
	/// <summary>
	/// Īpašības vārdu leksiskā nozīme nemainās no tā, vai īpašības vārdam ir noteiktā vai nenoteiktā galotne.
	/// Šīs galotnes rāda priekšmetu pazīmi kā zināmu vai nezināmu.
	/// <see>http://www.liis.lv/latval/morfol/ipv-gal.htm</see>
	/// </summary>
	public enum Galotne
	{
		Nenoteiktā,
		Noteiktā
	}

	// lai gan sakrīt ar lietvārdu locījumiem,
	// īpašības vārdu locījumi ir atšķirīgi
	// (lietvārdiem ir vokatīvs)
	public enum Locījums
	{
		Nominatīvs,
		Ģenitīvs,
		Datīvs,
		Akuzatīvs,
		Lokatīvs
	}

	/// <summary>
	/// Īpašības vārdi ir patstāvīgi, lokāmi vārdi, kas nosauc priekšmetu vai dzīvu būtņu pazīmes.
	/// <see>http://www.liis.lv/latval/morfol/ipasibv.htm</see>
	/// </summary>
	public class ĪpašībasVārds : Vārds
	{
		/// <summary>
		/// Izveido jaunu īpašības vārdu no normālformas.
		/// </summary>
		/// <param name="vārds">Īpašības vārds pamata pakāpes vienskaitļa nominatīvā ar vīriešu dzimtes nenoteikto galotni.</param>
		public ĪpašībasVārds(string vārds)
		{
			if (vārds == null)
				throw new ArgumentNullException("vārds");
			if (!vārds.BeidzasAr("s", "š"))
				throw new ArgumentException("Īpašības vārdam jābūt pamata pakāpes vienskaitļa nominatīvā ar vīriešu dzimtes nenoteikto galotni");

			Galotne = vārds.BeidzasAr("s") ? "s" : "š";
			Celms = vārds.AtmestGalotni(Galotne);
		}

		/// <summary>
		/// Izveido jaunu īpašības vārdu, ja zināms tā celms un normālformas galotne (-s vai -š).
		/// </summary>
		/// <param name="celms">Īpašības vārda celms.</param>
		/// <param name="galotne">Īpašības vārda vīriešu dzimtes nenoteiktā galotne pamata pakāpes vienskaitļa nominatīvā.</param>
		public ĪpašībasVārds(string celms, string galotne)
		{
			if (celms == null)
				throw new ArgumentNullException("celms");
			if (galotne == null)
				throw new ArgumentNullException("galotne");
			if (!(galotne == "s" || galotne == "š"))
				throw new ArgumentException("Īpašības vārda galotnei jābūt pamata pakāpes vienskaitļa nominatīva vīriešu dzimtes nenoteiktajai galotnei");

			Celms = celms;
			Galotne = galotne;
		}

		protected ĪpašībasVārds()
		{
		}

		public virtual string NominatīvaGalotne(Dzimte dzimte, Skaitlis skaitlis, Galotne galotne)
		{
			if (skaitlis == Skaitlis.Vienskaitlis)
			{
				if (dzimte == Dzimte.Vīriešu)
				{
					return (galotne == ĪpašībasVārdi.Galotne.Nenoteiktā) ? Galotne : "ais";
				}
				else
				{
					return (galotne == ĪpašībasVārdi.Galotne.Nenoteiktā) ? "a" : "ā";
				}
			}
			else
			{
				if (dzimte == Dzimte.Vīriešu)
				{
					return (galotne == ĪpašībasVārdi.Galotne.Nenoteiktā) ? "i" : "ie";
				}
				else
				{
					return (galotne == ĪpašībasVārdi.Galotne.Nenoteiktā) ? "as" : "ās";
				}
			}
		}

		public virtual string ĢenitīvaGalotne(Dzimte dzimte, Skaitlis skaitlis, Galotne galotne)
		{
			if (skaitlis == Skaitlis.Vienskaitlis)
			{
				if (dzimte == Dzimte.Vīriešu)
				{
					return (galotne == ĪpašībasVārdi.Galotne.Nenoteiktā) ? "a" : "ā";
				}
				else
				{
					return (galotne == ĪpašībasVārdi.Galotne.Nenoteiktā) ? "as" : "ās";
				}
			}
			else
			{
				return (galotne == ĪpašībasVārdi.Galotne.Nenoteiktā) ? "u" : "o";
			}
		}

		public virtual string DatīvaGalotne(Dzimte dzimte, Skaitlis skaitlis, Galotne galotne)
		{
			if (skaitlis == Skaitlis.Vienskaitlis)
			{
				if (dzimte == Dzimte.Vīriešu)
				{
					return (galotne == ĪpašībasVārdi.Galotne.Nenoteiktā) ? "am" : "ajam";
				}
				else
				{
					return (galotne == ĪpašībasVārdi.Galotne.Nenoteiktā) ? "ai" : "ajai";
				}
			}
			else
			{
				if (dzimte == Dzimte.Vīriešu)
				{
					return (galotne == ĪpašībasVārdi.Galotne.Nenoteiktā) ? "iem" : "ajiem";
				}
				else
				{
					return (galotne == ĪpašībasVārdi.Galotne.Nenoteiktā) ? "ām" : "ajām";
				}
			}
		}

		public virtual string AkuzatīvaGalotne(Dzimte dzimte, Skaitlis skaitlis, Galotne galotne)
		{
			if (skaitlis == Skaitlis.Vienskaitlis)
			{
				return (galotne == ĪpašībasVārdi.Galotne.Nenoteiktā) ? "u" : "o";
			}
			else
			{
				if (dzimte == Dzimte.Vīriešu)
				{
					return (galotne == ĪpašībasVārdi.Galotne.Nenoteiktā) ? "us" : "os";
				}
				else
				{
					return (galotne == ĪpašībasVārdi.Galotne.Nenoteiktā) ? "as" : "ās";
				}
			}
		}

		public virtual string LokatīvaGalotne(Dzimte dzimte, Skaitlis skaitlis, Galotne galotne)
		{
			if (skaitlis == Skaitlis.Vienskaitlis)
			{
				return (galotne == ĪpašībasVārdi.Galotne.Nenoteiktā) ? "ā" : "ajā";
			}
			else
			{
				if (dzimte == Dzimte.Vīriešu)
				{
					return (galotne == ĪpašībasVārdi.Galotne.Nenoteiktā) ? "os" : "ajos";
				}
				else
				{
					return (galotne == ĪpašībasVārdi.Galotne.Nenoteiktā) ? "ās" : "ajās";
				}
			}
		}

		public string Nominatīvs(Dzimte dzimte = Dzimte.Vīriešu, Skaitlis skaitlis = Skaitlis.Vienskaitlis, Galotne galotne = ĪpašībasVārdi.Galotne.Nenoteiktā)
		{
			return Celms + NominatīvaGalotne(dzimte, skaitlis, galotne);
		}

		public string Ģenitīvs(Dzimte dzimte = Dzimte.Vīriešu, Skaitlis skaitlis = Skaitlis.Vienskaitlis, Galotne galotne = ĪpašībasVārdi.Galotne.Nenoteiktā)
		{
			return Celms + ĢenitīvaGalotne(dzimte, skaitlis, galotne);
		}

		public string Datīvs(Dzimte dzimte = Dzimte.Vīriešu, Skaitlis skaitlis = Skaitlis.Vienskaitlis, Galotne galotne = ĪpašībasVārdi.Galotne.Nenoteiktā)
		{
			return Celms + DatīvaGalotne(dzimte, skaitlis, galotne);
		}

		public string Akuzatīvs(Dzimte dzimte = Dzimte.Vīriešu, Skaitlis skaitlis = Skaitlis.Vienskaitlis, Galotne galotne = ĪpašībasVārdi.Galotne.Nenoteiktā)
		{
			return Celms + AkuzatīvaGalotne(dzimte, skaitlis, galotne);
		}
		
		public string Lokatīvs(Dzimte dzimte = Dzimte.Vīriešu, Skaitlis skaitlis = Skaitlis.Vienskaitlis, Galotne galotne = ĪpašībasVārdi.Galotne.Nenoteiktā)
		{
			return Celms + LokatīvaGalotne(dzimte, skaitlis, galotne);
		}

		public string Locīt(Locījums locījums = Locījums.Nominatīvs, Dzimte dzimte = Dzimte.Vīriešu, Skaitlis skaitlis = Skaitlis.Vienskaitlis, Galotne galotne = ĪpašībasVārdi.Galotne.Nenoteiktā)
		{
			switch (locījums)
			{
				default:
				case Locījums.Nominatīvs:
					return Nominatīvs(dzimte, skaitlis, galotne);
				case Locījums.Ģenitīvs:
					return Ģenitīvs(dzimte, skaitlis, galotne);
				case Locījums.Datīvs:
					return Datīvs(dzimte, skaitlis, galotne);
				case Locījums.Akuzatīvs:
					return Akuzatīvs(dzimte, skaitlis, galotne);
				case Locījums.Lokatīvs:
					return Lokatīvs(dzimte, skaitlis, galotne);
			}
		}

		#region Salīdzināmās pakāpes
		/// <summary>
		/// Īpašības vārds pamata pakāpē nosauc īpašību kā neatkarīgu, patstāvīgu.
		/// </summary>
		public virtual ĪpašībasVārds PamataPakāpe
		{
			get { return new ĪpašībasVārds(Celms.Apcirpt("vis", paKreisi: true, paLabi: false).Apcirpt("āk", paKreisi: false, paLabi: true), Galotne); }
		}

		/// <summary>
		/// Īpašības vārds pārākajā pakāpē norāda, ka īpašība priekšmetam vai parādībai piemīt lielākā vai mazākā mērā nekā kādam citam līdzīgam priekšmetam vai parādībai.
		/// </summary>
		public virtual ĪpašībasVārds PārākāPakāpe
		{
			// Pārākās pakāpes formu darina no īpašības vārda celma, pievienojot tam piedēkli -āk-.
			get { return new ĪpašībasVārds(PamataPakāpe.Celms + "āk", Galotne); }
		}

		/// <summary>
		/// Īpašības vārds vispārākajā pakāpē norāda, ka īpašība kādam priekšmetam vai parādībai piemīt vislielākajā pakāpē salīdzinājumā ar citiem līdzīgiem priekšmetiem vai parādībām.
		/// </summary>
		public virtual ĪpašībasVārds VispārākāPakāpe
		{
			// Vispārākās pakāpes formu darina, pievienojot priedēkli vis- pārākās pakāpes formai ar noteikto galotni.
			get { return new ĪpašībasVārds("vis" + PārākāPakāpe.Celms, Galotne); }
		}
		#endregion
	}
}
