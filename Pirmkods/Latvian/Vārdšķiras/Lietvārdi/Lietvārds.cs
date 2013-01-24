namespace Latvian.Vārdšķiras.Lietvārdi
{
	/// <summary>
	/// Ņemot vērā lietvārdu dzimti un locījumu galotnes, tie tiek iedalīti sešās deklinācijās.
	/// Ir sastopami arī nelokāmi lietvārdi.
	/// </summary>
	public enum Deklinācija
	{
		I, II, III,
		IV, V, VI
	}

	public enum Locījums
	{
		Nominatīvs,
		Ģenitīvs,
		Datīvs,
		Akuzatīvs,
		Lokatīvs,
		Vokatīvs
	}

	/// <summary>
	/// Lietvārdi ir patstāvīgi vārdi, kas priekšmetiskā veidā nosauc dažādas īstenības parādības.
	/// <see>http://www.liis.lv/latval/morfol/lietv.htm</see>
	/// </summary>
	public abstract class Lietvārds : Vārds
	{
		/// <summary>
		/// Lietvārda dzimte.
		/// Daži IV un V deklinācijas lietvārdi var būt ar vīriešu dzimtes galotni datīva locījumā.
		/// </summary>
		public abstract Dzimte Dzimte { get; }

		public abstract string NominatīvaGalotne(Skaitlis skaitlis);
		public abstract string ĢenitīvaGalotne(Skaitlis skaitlis);
		public abstract string DatīvaGalotne(Skaitlis skaitlis);
		public abstract string AkuzatīvaGalotne(Skaitlis skaitlis);
		public abstract string LokatīvaGalotne(Skaitlis skaitlis);
		public abstract string VokatīvaGalotne(Skaitlis skaitlis);

		/// <summary>
		/// Nominatīvs – atbild uz jautājumu kas?
		/// </summary>
		public string Nominatīvs(Skaitlis skaitlis = Skaitlis.Vienskaitlis)
		{
			return LīdzskaņuMija(Locījums.Nominatīvs, skaitlis) + NominatīvaGalotne(skaitlis);
		}

		/// <summary>
		/// Ģenitīvs – atbild uz jautājumu kā?
		/// </summary>
		public string Ģenitīvs(Skaitlis skaitlis = Skaitlis.Vienskaitlis)
		{
			return LīdzskaņuMija(Locījums.Ģenitīvs, skaitlis) + ĢenitīvaGalotne(skaitlis);
		}

		/// <summary>
		/// Datīvs – atbild uz jautājumu kam?
		/// </summary>
		public string Datīvs(Skaitlis skaitlis = Skaitlis.Vienskaitlis)
		{
			return LīdzskaņuMija(Locījums.Datīvs, skaitlis) + DatīvaGalotne(skaitlis);
		}

		/// <summary>
		/// Akuzatīvs – atbild uz jautājumu ko?
		/// </summary>
		public string Akuzatīvs(Skaitlis skaitlis = Skaitlis.Vienskaitlis)
		{
			return LīdzskaņuMija(Locījums.Akuzatīvs, skaitlis) + AkuzatīvaGalotne(skaitlis);
		}

		/// <summary>
		/// Lokatīvs – atbild uz jautājumu kur?
		/// </summary>
		public string Lokatīvs(Skaitlis skaitlis = Skaitlis.Vienskaitlis)
		{
			return LīdzskaņuMija(Locījums.Lokatīvs, skaitlis) + LokatīvaGalotne(skaitlis);
		}

		/// <summary>
		/// Vokatīvs – bez jautājuma
		/// </summary>
		public string Vokatīvs(Skaitlis skaitlis = Skaitlis.Vienskaitlis)
		{
			return LīdzskaņuMija(Locījums.Vokatīvs, skaitlis) + VokatīvaGalotne(skaitlis);
		}

		public string Locīt(Locījums locījums = Locījums.Nominatīvs, Skaitlis skaitlis = Skaitlis.Vienskaitlis)
		{
			switch (locījums)
			{
				default:
				case Locījums.Nominatīvs:
					return Nominatīvs(skaitlis);
				case Locījums.Ģenitīvs:
					return Ģenitīvs(skaitlis);
				case Locījums.Datīvs:
					return Datīvs(skaitlis);
				case Locījums.Akuzatīvs:
					return Akuzatīvs(skaitlis);
				case Locījums.Lokatīvs:
					return Lokatīvs(skaitlis);
				case Locījums.Vokatīvs:
					return Vokatīvs(skaitlis);
			}
		}

		/// <summary>
		/// II, V un VI deklinācijas lietvārdiem dažos locījumos raksturīga līdzskaņu mija.
		/// <see>http://www.liis.lv/latval/morfol/lietv-mija.htm</see>
		/// </summary>
		protected virtual string LīdzskaņuMija(Locījums locījums, Skaitlis skaitlis)
		{
			return Celms;
		}
	}

    public abstract class DeklinējamsLietvārds : Lietvārds
    {
        /// <summary>
        /// Lietvārda deklinācija.
        /// </summary>
        public abstract Deklinācija Deklinācija { get; }
    }
}