using System;

namespace Latvian.Vārdšķiras.Lietvārdi
{
	/// <summary>
	/// II deklinācija.
	/// Pie II deklinācijas pieder vīriešu dzimtes lietvārdi, kam vienskaitļa nominatīvā ir galotne -is,
	/// kā arī izņēmumi: mēness, akmens, asmens, rudens, ūdens, zibens, suns, sāls.
	/// </summary>
    public class OtrāsDeklinācijasLietvārds : DeklinējamsLietvārds
	{
		public OtrāsDeklinācijasLietvārds(string vārds)
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
			get { return Deklinācija.II; }
		}

		public override Dzimte Dzimte
		{
			get { return Dzimte.Vīriešu; }
		}

		public override string NominatīvaGalotne(Skaitlis skaitlis)
		{
			return (skaitlis == Skaitlis.Vienskaitlis) ? Galotne /* -is, -s */ : "i";
		}

		public override string ĢenitīvaGalotne(Skaitlis skaitlis)
		{
			// lai gan suns ir izņēmums ar -s galotni, vienskaitlī tas neuzvedas kā izņēmums
			return (skaitlis == Skaitlis.Vienskaitlis) ?
				(Galotne == "s" && !Celms.BeidzasAr("sun") ? "s" : "a") : "u";
		}

		public override string DatīvaGalotne(Skaitlis skaitlis)
		{
			return (skaitlis == Skaitlis.Vienskaitlis) ? "im" : "iem";
		}

		public override string AkuzatīvaGalotne(Skaitlis skaitlis)
		{
			return (skaitlis == Skaitlis.Vienskaitlis) ? "i" : "us";
		}

		public override string LokatīvaGalotne(Skaitlis skaitlis)
		{
			return (skaitlis == Skaitlis.Vienskaitlis) ? "ī" : "os";
		}

		public override string VokatīvaGalotne(Skaitlis skaitlis)
		{
			return (skaitlis == Skaitlis.Vienskaitlis) ? "i" : "i"; // -
		}

		protected override string LīdzskaņuMija(Locījums locījums, Skaitlis skaitlis)
		{
			// II deklinācijas lietvārdiem līdzskaņu mija raksturīga vienskaitļa ģenitīvā un visos daudzskaitļa locījumos.
			if (locījums == Locījums.Ģenitīvs || skaitlis == Skaitlis.Daudzskaitlis)
			{
				// Līdzskaņu mijas nav:
				bool bezMijas = (Celms + "is").BeidzasAr(
					"tētis", "viesis", "astis", "skatis",
					"jis", "ķis", "ģis", "ris");
				
				bool suns = skaitlis == Skaitlis.Vienskaitlis && (Celms + "s").BeidzasAr("suns");
				
				// Lietvārdiem līdzskaņu mija ir tikai daudzskaitlī.
				// (tātad nav vienskaitlī)
				bool izņēmumi = skaitlis == Skaitlis.Vienskaitlis && (Celms + "s").BeidzasAr(
					"akmens", "asmens", "rudens", "zibens", "ūdens", "mēness", "sāls");
				
				// ehhh jāuzlabo
				if (suns || (!bezMijas && !izņēmumi))
				{
					string arMiju = Celms;

					arMiju = arMiju.LīdzskaņuMija("sn", "šņ")
								   .LīdzskaņuMija("zn", "žņ")
								   .LīdzskaņuMija("sl", "šļ")
								   .LīdzskaņuMija("zl", "žļ")
								   .LīdzskaņuMija("ln", "ļņ")
								   .LīdzskaņuMija("dz", "dž")
                                   .LīdzskaņuMija("nn", "ņņ")
								   .LīdzskaņuMija("b", "bj")
								   .LīdzskaņuMija("m", "mj")
								   .LīdzskaņuMija("p", "pj")
								   .LīdzskaņuMija("v", "vj")
								   .LīdzskaņuMija("t", "š")
								   .LīdzskaņuMija("d", "ž")
								   .LīdzskaņuMija("c", "č")
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

	public class OtrāsDeklinācijasPersonvārdaLietvārds : OtrāsDeklinācijasLietvārds
	{
		public OtrāsDeklinācijasPersonvārdaLietvārds(string vārds)
			: base(vārds)
		{
		}

		protected override string LīdzskaņuMija(Locījums locījums, Skaitlis skaitlis)
		{
			// Līdzskaņu mijas nav divzilbju personvārdiem ar -tis, -dis
			// vēl - nav mijas uzvārdos, kas beidzas ar -skis un -ckis, bet, neņemot tos vērā, darbojas tāpat

			bool beidzas = Galotne == "is" && (Celms.BeidzasAr("t", "d"));
			bool divzilbju = (Celms.Length - 1) <= 3; // ja vairāk par 3 burtiem pirms -tis vai -dis, tad nav divzilbju

			bool uzvārdi = Galotne == "is" && Celms.BeidzasAr("sk", "ck");

			bool navMijas = (beidzas && divzilbju) || uzvārdi;

			if (!navMijas)
			{
				return base.LīdzskaņuMija(locījums, skaitlis);
			}

			return Celms;
		}
	}
}
