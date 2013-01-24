namespace Latvian.Vārdšķiras
{
    public enum Dzimte
    {
        Vīriešu,
        Sieviešu
    }

    public enum Skaitlis
    {
        Vienskaitlis,
        Daudzskaitlis
    }

    public class Vārds
    {
        /* public static readonly char[] Alfabēts = "aābcčdeēfgģhiījkķlļmnņoprsštuūvzž".ToCharArray();
        public static readonly char[] Līdzskaņi = "bcčdfgģhhjkķlļmnņprsštvzž".ToCharArray(); // TODO: dz, dž
        public static readonly char[] BalsīgieLīdzskaņi = "".ToCharArray(); // balsīgie: b, d, g, ģ, dz, dž, z, ž, j, v un visi skaneņi l, ļ, m, n, ņ, r
        public static readonly char[] NebalsīgieLīdzskaņi = "".ToCharArray(); // nebalsīgie: p, t, k, ķ, c, č, s, š, f, h
        public static readonly char[] Patskaņi = "aāeēiīouū".ToCharArray();
        public static readonly char[] ĪsiePatskaņi = "aeiou".ToCharArray();
        public static readonly char[] GariePatskaņi = "āēīū".ToCharArray(); */

        public string Celms
        {
            get;
            protected set;
        }

        public string Galotne
        {
            get;
            protected set;
        }
    }

    /// <summary>
    /// Palīgfunkcijas teksta apstrādei.
    /// </summary>
    static class TekstaFunkcijas
    {
        /// <summary>
        /// Pārbauda, vai vārds beidzas ar kādu no dotajām galotnēm.
        /// Galotnes tiek pārbaudītas secīgi, tāpēc garākajām un specifiskākajām galotnēm jābūt pirmajām.
        /// </summary>
        /// <param name="vārds">Vārds, kuram pārbaudīt galotnes</param>
        /// <param name="galotnes">Pārbaudāmās galotnes</param>
        /// <returns>Patiess, ja vārds beidzas ar kādu no galotnēm</returns>
        public static bool BeidzasAr(this string vārds, params string[] galotnes)
        {
            // return galotnes.OrderByDescending(galotne => galotne.Length).Any(galotne => vārds.EndsWith(galotne));

            foreach (string galotne in galotnes)
            {
                if (vārds.EndsWith(galotne))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Ja vārds beidzas ar galotni, to no beigām atmet.
        /// Citādi neko vārdam nemaina.
        /// </summary>
        /// <param name="vārds">Vārds, kuram atmest galotni</param>
        /// <param name="galotne">Galotne, kuru atmest</param>
        /// <returns>Vārds ar atmestu galotni</returns>
        public static string AtmestGalotni(this string vārds, string galotne)
        {
            if (vārds.BeidzasAr(galotne))
            {
                vārds = vārds.Remove(vārds.LastIndexOf(galotne), galotne.Length);
            }

            return vārds;
        }

        /// <summary>
        /// Atmet no vārda sākumā un beigām liekos burtus, ja tādi tur ir.
        /// </summary>
        /// <param name="vārds">Vārds, kuram atmest liekos burtus</param>
        /// <param name="liekais">Burti, kurus atmest</param>
        /// <param name="paKreisi">Vai atmest no vārda sākuma</param>
        /// <param name="paLabi">Vai atmest no vārda beigām</param>
        /// <returns>Vārds ar atmestajiem burtiem</returns>
        public static string Apcirpt(this string vārds, string liekais, bool paKreisi, bool paLabi)
        {
            if (paKreisi && vārds.StartsWith(liekais))
            {
                vārds = vārds.Substring(liekais.Length);
            }

            if (paLabi && vārds.BeidzasAr(liekais))
            {
                vārds = vārds.AtmestGalotni(liekais);
            }

            return vārds;
        }

        /// <summary>
        /// Ja vārds beidzas ar "no", to atmet un pievieno "uz".
        /// Citādi neko nemaina.
        /// </summary>
        /// <param name="vārds">Vārds, kuram veikt darbības</param>
        /// <param name="no">Burti, ar kuriem vārdam būtu jābeidzas</param>
        /// <param name="uz">Burti, kas tiks pievieno vārda beigās</param>
        /// <returns>Vārds bez "no" un ar "uz" vai arī pats vārds, ja nekas netika mainīts</returns>
        public static string LīdzskaņuMija(this string vārds, string no, string uz)
        {
            if (vārds.BeidzasAr(no))
            {
                vārds = vārds.AtmestGalotni(no) + uz;
            }

            return vārds;
        }
    }
}
