using System;

namespace Latvian.Vārdšķiras.Lietvārdi
{
    /// <summary>
    /// Atgriezeniskie lietvārdi ir no atgriezeniskiem darbības vārdiem darināti lietvārdi ar izskaņām -šanās, -tājies, -tājās, -ējies, -ējās, -ājies, -umies.
    /// </summary>
    public class AtgriezenisksLietvārds : Lietvārds
    {
        public AtgriezenisksLietvārds(string vārds)
        {
            if (vārds == null)
                throw new ArgumentNullException("vārds");
            if (vārds.BeidzasAr("tājies", "tājās", "ējies", "ējās", "ājies"))
                throw new NotSupportedException();
            if (!vārds.BeidzasAr("šanās", "umies"))
                throw new ArgumentException("Lietvārdam jābūt vienskaitļa nominatīvā");

            Galotne = vārds.BeidzasAr("umies") ? "umies" : "šanās";
            Celms = vārds.AtmestGalotni(Galotne);
        }

        public override Dzimte Dzimte
        {
            get { throw new NotImplementedException(); }
        }

        public override string NominatīvaGalotne(Skaitlis skaitlis)
        {
            return Galotne;
        }

        public override string ĢenitīvaGalotne(Skaitlis skaitlis)
        {
            string galotne = null;

            if (Galotne == "šanās")
            {
                galotne = (skaitlis == Skaitlis.Vienskaitlis) ? "šanās" : "šanos";
            }

            return galotne;
        }

        public override string DatīvaGalotne(Skaitlis skaitlis)
        {
            return null;
        }

        public override string AkuzatīvaGalotne(Skaitlis skaitlis)
        {
            string galotne = Galotne;

            switch (Galotne)
            {
                case "šanās":
                    galotne = (skaitlis == Skaitlis.Vienskaitlis) ? "šanos" : "šanās";
                    break;
                case "umies":
                    galotne = "umos";
                    break;
            }

            return galotne;
        }

        public override string LokatīvaGalotne(Skaitlis skaitlis)
        {
            return null;
        }

        public override string VokatīvaGalotne(Skaitlis skaitlis)
        {
            return Galotne;
        }

        protected override string LīdzskaņuMija(Locījums locījums, Skaitlis skaitlis)
        {
            switch (locījums)
            {
                case Locījums.Ģenitīvs:
                    if (ĢenitīvaGalotne(skaitlis) == null)
                        return null;
                    break;

                case Locījums.Datīvs:
                case Locījums.Lokatīvs:
                    return null;;
            }

            return Celms;
        }
    }
}
