using NUnit.Framework;

using Latvian.Vārdšķiras;
using Latvian.Vārdšķiras.Lietvārdi;

namespace Latvian.Testi
{
    [TestFixture]
    public class LietvārduTesti
    {
        #region I deklinācija
        [Test, Category("I deklinācija")]
        public void Koks()
        {
            Lietvārds koks = new PirmāsDeklinācijasLietvārds("koks");
            Assert.AreEqual(Dzimte.Vīriešu, koks.Dzimte);
            Assert.AreEqual(Deklinācija.I, ((koks as DeklinējamsLietvārds) as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("koks", koks.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("koki", koks.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("koka", koks.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("koku", koks.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("kokam", koks.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("kokiem", koks.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("koku", koks.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("kokus", koks.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("kokā", koks.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("kokos", koks.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        [Test, Category("I deklinācija")]
        public void Burts()
        {
            Lietvārds burts = new PirmāsDeklinācijasLietvārds("burts");
            Assert.AreEqual(Dzimte.Vīriešu, burts.Dzimte);
            Assert.AreEqual(Deklinācija.I, (burts as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("burts", burts.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("burti", burts.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("burta", burts.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("burtu", burts.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("burtam", burts.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("burtiem", burts.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("burtu", burts.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("burtus", burts.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("burtā", burts.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("burtos", burts.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        [Test, Category("I deklinācija")]
        public void Vējš()
        {
            Lietvārds vējš = new PirmāsDeklinācijasLietvārds("vējš");
            Assert.AreEqual(Dzimte.Vīriešu, vējš.Dzimte);
            Assert.AreEqual(Deklinācija.I, (vējš as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("vējš", vējš.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("vēji", vējš.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("vēja", vējš.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("vēju", vējš.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("vējam", vējš.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("vējiem", vējš.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("vēju", vējš.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("vējus", vējš.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("vējā", vējš.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("vējos", vējš.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        [Test, Category("I deklinācija")]
        public void Sviests()
        {
            Lietvārds sviests = new PirmāsDeklinācijasLietvārds("sviests");
            Assert.AreEqual(Dzimte.Vīriešu, sviests.Dzimte);
            Assert.AreEqual(Deklinācija.I, (sviests as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("sviests", sviests.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("sviesta", sviests.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("sviestam", sviests.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("sviestu", sviests.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("sviestā", sviests.Lokatīvs(Skaitlis.Vienskaitlis));
        }

        [Test, Category("I deklinācija")]
        public void Milti()
        {
            Lietvārds milti = new PirmāsDeklinācijasLietvārds("milts");
            Assert.AreEqual(Dzimte.Vīriešu, milti.Dzimte);
            Assert.AreEqual(Deklinācija.I, (milti as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("milti", milti.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("miltu", milti.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("miltiem", milti.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("miltus", milti.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("miltos", milti.Lokatīvs(Skaitlis.Daudzskaitlis));
        }
        #endregion

        #region II deklinācija
        #region Līdzskaņu mijas
        [Test, Category("II deklinācija"), Category("II deklinācija / līdzskaņu mija")]
        public void Gulbis()
        {
            Lietvārds gulbis = new OtrāsDeklinācijasLietvārds("gulbis");
            Assert.AreEqual(Dzimte.Vīriešu, gulbis.Dzimte);
            Assert.AreEqual(Deklinācija.II, (gulbis as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("gulbis", gulbis.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("gulbji", gulbis.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("gulbja", gulbis.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("gulbju", gulbis.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("gulbim", gulbis.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("gulbjiem", gulbis.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("gulbi", gulbis.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("gulbjus", gulbis.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("gulbī", gulbis.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("gulbjos", gulbis.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        [Test, Category("II deklinācija"), Category("II deklinācija / līdzskaņu mija")]
        public void Kurmis()
        {
            Lietvārds kurmis = new OtrāsDeklinācijasLietvārds("kurmis");
            Assert.AreEqual(Dzimte.Vīriešu, kurmis.Dzimte);
            Assert.AreEqual(Deklinācija.II, (kurmis as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("kurmis", kurmis.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("kurmji", kurmis.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("kurmja", kurmis.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("kurmju", kurmis.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("kurmim", kurmis.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("kurmjiem", kurmis.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("kurmi", kurmis.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("kurmjus", kurmis.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("kurmī", kurmis.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("kurmjos", kurmis.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        [Test, Category("II deklinācija"), Category("II deklinācija / līdzskaņu mija")]
        public void Krupis()
        {
            Lietvārds krupis = new OtrāsDeklinācijasLietvārds("krupis");
            Assert.AreEqual(Dzimte.Vīriešu, krupis.Dzimte);
            Assert.AreEqual(Deklinācija.II, (krupis as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("krupis", krupis.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("krupji", krupis.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("krupja", krupis.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("krupju", krupis.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("krupim", krupis.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("krupjiem", krupis.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("krupi", krupis.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("krupjus", krupis.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("krupī", krupis.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("krupjos", krupis.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        [Test, Category("II deklinācija"), Category("II deklinācija / līdzskaņu mija")]
        public void Kurvis()
        {
            Lietvārds kurvis = new OtrāsDeklinācijasLietvārds("kurvis");
            Assert.AreEqual(Dzimte.Vīriešu, kurvis.Dzimte);
            Assert.AreEqual(Deklinācija.II, (kurvis as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("kurvis", kurvis.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("kurvji", kurvis.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("kurvja", kurvis.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("kurvju", kurvis.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("kurvim", kurvis.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("kurvjiem", kurvis.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("kurvi", kurvis.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("kurvjus", kurvis.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("kurvī", kurvis.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("kurvjos", kurvis.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        [Test, Category("II deklinācija"), Category("II deklinācija / līdzskaņu mija")]
        public void Zutis()
        {
            Lietvārds zutis = new OtrāsDeklinācijasLietvārds("zutis");
            Assert.AreEqual(Dzimte.Vīriešu, zutis.Dzimte);
            Assert.AreEqual(Deklinācija.II, (zutis as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("zutis", zutis.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("zuši", zutis.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("zuša", zutis.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("zušu", zutis.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("zutim", zutis.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("zušiem", zutis.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("zuti", zutis.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("zušus", zutis.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("zutī", zutis.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("zušos", zutis.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        [Test, Category("II deklinācija"), Category("II deklinācija / līdzskaņu mija")]
        public void Briedis()
        {
            Lietvārds briedis = new OtrāsDeklinācijasLietvārds("briedis");
            Assert.AreEqual(Dzimte.Vīriešu, briedis.Dzimte);
            Assert.AreEqual(Deklinācija.II, (briedis as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("briedis", briedis.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("brieži", briedis.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("brieža", briedis.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("briežu", briedis.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("briedim", briedis.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("briežiem", briedis.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("briedi", briedis.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("briežus", briedis.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("briedī", briedis.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("briežos", briedis.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        [Test, Category("II deklinācija"), Category("II deklinācija / līdzskaņu mija")]
        public void Lācis()
        {
            Lietvārds lācis = new OtrāsDeklinācijasLietvārds("lācis");
            Assert.AreEqual(Dzimte.Vīriešu, lācis.Dzimte);
            Assert.AreEqual(Deklinācija.II, (lācis as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("lācis", lācis.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("lāči", lācis.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("lāča", lācis.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("lāču", lācis.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("lācim", lācis.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("lāčiem", lācis.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("lāci", lācis.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("lāčus", lācis.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("lācī", lācis.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("lāčos", lācis.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        [Test, Category("II deklinācija"), Category("II deklinācija / līdzskaņu mija")]
        public void Dadzis()
        {
            Lietvārds dadzis = new OtrāsDeklinācijasLietvārds("dadzis");
            Assert.AreEqual(Dzimte.Vīriešu, dadzis.Dzimte);
            Assert.AreEqual(Deklinācija.II, (dadzis as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("dadzis", dadzis.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("dadži", dadzis.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("dadža", dadzis.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("dadžu", dadzis.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("dadzim", dadzis.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("dadžiem", dadzis.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("dadzi", dadzis.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("dadžus", dadzis.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("dadzī", dadzis.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("dadžos", dadzis.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        [Test, Category("II deklinācija"), Category("II deklinācija / līdzskaņu mija")]
        public void Lasis()
        {
            Lietvārds lasis = new OtrāsDeklinācijasLietvārds("lasis");
            Assert.AreEqual(Dzimte.Vīriešu, lasis.Dzimte);
            Assert.AreEqual(Deklinācija.II, (lasis as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("lasis", lasis.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("laši", lasis.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("laša", lasis.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("lašu", lasis.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("lasim", lasis.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("lašiem", lasis.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("lasi", lasis.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("lašus", lasis.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("lasī", lasis.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("lašos", lasis.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        [Test, Category("II deklinācija"), Category("II deklinācija / līdzskaņu mija")]
        public void Ezis()
        {
            Lietvārds ezis = new OtrāsDeklinācijasLietvārds("ezis");
            Assert.AreEqual(Dzimte.Vīriešu, ezis.Dzimte);
            Assert.AreEqual(Deklinācija.II, (ezis as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("ezis", ezis.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("eži", ezis.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("eža", ezis.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("ežu", ezis.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("ezim", ezis.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("ežiem", ezis.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("ezi", ezis.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("ežus", ezis.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("ezī", ezis.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("ežos", ezis.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        [Test, Category("II deklinācija"), Category("II deklinācija / līdzskaņu mija")]
        public void Sainis()
        {
            Lietvārds sainis = new OtrāsDeklinācijasLietvārds("sainis");
            Assert.AreEqual(Dzimte.Vīriešu, sainis.Dzimte);
            Assert.AreEqual(Deklinācija.II, (sainis as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("sainis", sainis.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("saiņi", sainis.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("saiņa", sainis.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("saiņu", sainis.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("sainim", sainis.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("saiņiem", sainis.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("saini", sainis.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("saiņus", sainis.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("sainī", sainis.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("saiņos", sainis.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        [Test, Category("II deklinācija"), Category("II deklinācija / līdzskaņu mija")]
        public void Valis()
        {
            Lietvārds valis = new OtrāsDeklinācijasLietvārds("valis");
            Assert.AreEqual(Dzimte.Vīriešu, valis.Dzimte);
            Assert.AreEqual(Deklinācija.II, (valis as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("valis", valis.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("vaļi", valis.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("vaļa", valis.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("vaļu", valis.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("valim", valis.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("vaļiem", valis.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("vali", valis.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("vaļus", valis.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("valī", valis.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("vaļos", valis.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        [Test, Category("II deklinācija"), Category("II deklinācija / līdzskaņu mija")]
        public void Atkusnis()
        {
            Lietvārds atkusnis = new OtrāsDeklinācijasLietvārds("atkusnis");
            Assert.AreEqual(Dzimte.Vīriešu, atkusnis.Dzimte);
            Assert.AreEqual(Deklinācija.II, (atkusnis as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("atkusnis", atkusnis.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("atkušņi", atkusnis.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("atkušņa", atkusnis.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("atkušņu", atkusnis.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("atkusnim", atkusnis.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("atkušņiem", atkusnis.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("atkusni", atkusnis.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("atkušņus", atkusnis.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("atkusnī", atkusnis.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("atkušņos", atkusnis.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        [Test, Category("II deklinācija"), Category("II deklinācija / līdzskaņu mija")]
        public void Pūznis()
        {
            Lietvārds pūznis = new OtrāsDeklinācijasLietvārds("pūznis");
            Assert.AreEqual(Dzimte.Vīriešu, pūznis.Dzimte);
            Assert.AreEqual(Deklinācija.II, (pūznis as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("pūznis", pūznis.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("pūžņi", pūznis.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("pūžņa", pūznis.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("pūžņu", pūznis.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("pūznim", pūznis.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("pūžņiem", pūznis.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("pūzni", pūznis.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("pūžņus", pūznis.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("pūznī", pūznis.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("pūžņos", pūznis.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        [Test, Category("II deklinācija"), Category("II deklinācija / līdzskaņu mija")]
        public void Kāpslis()
        {
            Lietvārds kāpslis = new OtrāsDeklinācijasLietvārds("kāpslis");
            Assert.AreEqual(Dzimte.Vīriešu, kāpslis.Dzimte);
            Assert.AreEqual(Deklinācija.II, (kāpslis as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("kāpslis", kāpslis.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("kāpšļi", kāpslis.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("kāpšļa", kāpslis.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("kāpšļu", kāpslis.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("kāpslim", kāpslis.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("kāpšļiem", kāpslis.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("kāpsli", kāpslis.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("kāpšļus", kāpslis.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("kāpslī", kāpslis.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("kāpšļos", kāpslis.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        [Test, Category("II deklinācija"), Category("II deklinācija / līdzskaņu mija")]
        public void Zizlis()
        {
            Lietvārds zizlis = new OtrāsDeklinācijasLietvārds("zizlis");
            Assert.AreEqual(Dzimte.Vīriešu, zizlis.Dzimte);
            Assert.AreEqual(Deklinācija.II, (zizlis as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("zizlis", zizlis.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("zižļi", zizlis.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("zižļa", zizlis.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("zižļu", zizlis.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("zizlim", zizlis.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("zižļiem", zizlis.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("zizli", zizlis.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("zižļus", zizlis.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("zizlī", zizlis.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("zižļos", zizlis.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        [Test, Category("II deklinācija"), Category("II deklinācija / līdzskaņu mija")]
        public void Vilnis()
        {
            Lietvārds vilnis = new OtrāsDeklinācijasLietvārds("vilnis");
            Assert.AreEqual(Dzimte.Vīriešu, vilnis.Dzimte);
            Assert.AreEqual(Deklinācija.II, (vilnis as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("vilnis", vilnis.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("viļņi", vilnis.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("viļņa", vilnis.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("viļņu", vilnis.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("vilnim", vilnis.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("viļņiem", vilnis.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("vilni", vilnis.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("viļņus", vilnis.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("vilnī", vilnis.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("viļņos", vilnis.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        [Test, Category("II deklinācija"), Category("II deklinācija / līdzskaņu mija")]
        public void Hunnis()
        {
            Lietvārds hunnis = new OtrāsDeklinācijasLietvārds("hunnis");
            Assert.AreEqual(Dzimte.Vīriešu, hunnis.Dzimte);
            Assert.AreEqual(Deklinācija.II, (hunnis as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("hunnis", hunnis.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("huņņi", hunnis.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("huņņa", hunnis.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("huņņu", hunnis.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("hunnim", hunnis.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("huņņiem", hunnis.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("hunni", hunnis.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("huņņus", hunnis.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("hunnī", hunnis.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("huņņos", hunnis.Lokatīvs(Skaitlis.Daudzskaitlis));
        }
        #endregion Līdzskaņu mijas
        
        #region Izņēmumi
        [Test, Category("II deklinācija"), Category("II deklinācija / izņēmumi")]
        public void Akmens()
        {
            Lietvārds akmens = new OtrāsDeklinācijasLietvārds("akmens");
            Assert.AreEqual(Dzimte.Vīriešu, akmens.Dzimte);
            Assert.AreEqual(Deklinācija.II, (akmens as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("akmens", akmens.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("akmeņi", akmens.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("akmens", akmens.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("akmeņu", akmens.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("akmenim", akmens.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("akmeņiem", akmens.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("akmeni", akmens.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("akmeņus", akmens.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("akmenī", akmens.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("akmeņos", akmens.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        [Test, Category("II deklinācija"), Category("II deklinācija / izņēmumi")]
        public void Asmens()
        {
            Lietvārds asmens = new OtrāsDeklinācijasLietvārds("asmens");
            Assert.AreEqual(Dzimte.Vīriešu, asmens.Dzimte);
            Assert.AreEqual(Deklinācija.II, (asmens as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("asmens", asmens.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("asmeņi", asmens.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("asmens", asmens.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("asmeņu", asmens.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("asmenim", asmens.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("asmeņiem", asmens.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("asmeni", asmens.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("asmeņus", asmens.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("asmenī", asmens.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("asmeņos", asmens.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        [Test, Category("II deklinācija"), Category("II deklinācija / izņēmumi")]
        public void Rudens()
        {
            Lietvārds rudens = new OtrāsDeklinācijasLietvārds("rudens");
            Assert.AreEqual(Dzimte.Vīriešu, rudens.Dzimte);
            Assert.AreEqual(Deklinācija.II, (rudens as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("rudens", rudens.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("rudeņi", rudens.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("rudens", rudens.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("rudeņu", rudens.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("rudenim", rudens.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("rudeņiem", rudens.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("rudeni", rudens.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("rudeņus", rudens.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("rudenī", rudens.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("rudeņos", rudens.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        [Test, Category("II deklinācija"), Category("II deklinācija / izņēmumi")]
        public void Zibens()
        {
            Lietvārds zibens = new OtrāsDeklinācijasLietvārds("zibens");
            Assert.AreEqual(Dzimte.Vīriešu, zibens.Dzimte);
            Assert.AreEqual(Deklinācija.II, (zibens as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("zibens", zibens.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("zibeņi", zibens.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("zibens", zibens.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("zibeņu", zibens.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("zibenim", zibens.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("zibeņiem", zibens.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("zibeni", zibens.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("zibeņus", zibens.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("zibenī", zibens.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("zibeņos", zibens.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        [Test, Category("II deklinācija"), Category("II deklinācija / izņēmumi")]
        public void Ūdens()
        {
            Lietvārds ūdens = new OtrāsDeklinācijasLietvārds("ūdens");
            Assert.AreEqual(Dzimte.Vīriešu, ūdens.Dzimte);
            Assert.AreEqual(Deklinācija.II, (ūdens as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("ūdens", ūdens.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("ūdeņi", ūdens.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("ūdens", ūdens.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("ūdeņu", ūdens.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("ūdenim", ūdens.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("ūdeņiem", ūdens.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("ūdeni", ūdens.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("ūdeņus", ūdens.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("ūdenī", ūdens.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("ūdeņos", ūdens.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        [Test, Category("II deklinācija"), Category("II deklinācija / izņēmumi")]
        public void Mēness()
        {
            Lietvārds mēness = new OtrāsDeklinācijasLietvārds("mēness");
            Assert.AreEqual(Dzimte.Vīriešu, mēness.Dzimte);
            Assert.AreEqual(Deklinācija.II, (mēness as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("mēness", mēness.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("mēneši", mēness.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("mēness", mēness.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("mēnešu", mēness.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("mēnesim", mēness.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("mēnešiem", mēness.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("mēnesi", mēness.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("mēnešus", mēness.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("mēnesī", mēness.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("mēnešos", mēness.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        [Test, Category("II deklinācija"), Category("II deklinācija / izņēmumi")]
        public void Sāls()
        {
            Lietvārds sāls = new OtrāsDeklinācijasLietvārds("sāls");
            Assert.AreEqual(Dzimte.Vīriešu, sāls.Dzimte);
            Assert.AreEqual(Deklinācija.II, (sāls as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("sāls", sāls.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("sāļi", sāls.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("sāls", sāls.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("sāļu", sāls.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("sālim", sāls.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("sāļiem", sāls.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("sāli", sāls.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("sāļus", sāls.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("sālī", sāls.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("sāļos", sāls.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        [Test, Category("II deklinācija"), Category("II deklinācija / izņēmumi")]
        public void Suns()
        {
            Lietvārds suns = new OtrāsDeklinācijasLietvārds("suns");
            Assert.AreEqual(Dzimte.Vīriešu, suns.Dzimte);
            Assert.AreEqual(Deklinācija.II, (suns as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("suns", suns.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("suņi", suns.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("suņa", suns.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("suņu", suns.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("sunim", suns.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("suņiem", suns.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("suni", suns.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("suņus", suns.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("sunī", suns.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("suņos", suns.Lokatīvs(Skaitlis.Daudzskaitlis));
        }
        #endregion Izņēmumi
        
        #region Bez līdzskaņu mijas
        [Test, Category("II deklinācija"), Category("II deklinācija / bez līdzskaņu mijas")]
        public void Tētis()
        {
            Lietvārds tētis = new OtrāsDeklinācijasLietvārds("tētis");
            Assert.AreEqual(Dzimte.Vīriešu, tētis.Dzimte);
            Assert.AreEqual(Deklinācija.II, (tētis as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("tētis", tētis.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("tēti", tētis.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("tēta", tētis.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("tētu", tētis.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("tētim", tētis.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("tētiem", tētis.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("tēti", tētis.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("tētus", tētis.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("tētī", tētis.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("tētos", tētis.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        [Test, Category("II deklinācija"), Category("II deklinācija / bez līdzskaņu mijas")]
        public void Viesis()
        {
            Lietvārds viesis = new OtrāsDeklinācijasLietvārds("viesis");
            Assert.AreEqual(Dzimte.Vīriešu, viesis.Dzimte);
            Assert.AreEqual(Deklinācija.II, (viesis as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("viesis", viesis.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("viesi", viesis.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("viesa", viesis.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("viesu", viesis.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("viesim", viesis.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("viesiem", viesis.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("viesi", viesis.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("viesus", viesis.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("viesī", viesis.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("viesos", viesis.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        [Test, Category("II deklinācija"), Category("II deklinācija / bez līdzskaņu mijas")]
        public void Strupastis()
        {
            Lietvārds strupastis = new OtrāsDeklinācijasLietvārds("strupastis");
            Assert.AreEqual(Dzimte.Vīriešu, strupastis.Dzimte);
            Assert.AreEqual(Deklinācija.II, (strupastis as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("strupastis", strupastis.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("strupasti", strupastis.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("strupasta", strupastis.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("strupastu", strupastis.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("strupastim", strupastis.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("strupastiem", strupastis.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("strupasti", strupastis.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("strupastus", strupastis.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("strupastī", strupastis.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("strupastos", strupastis.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        [Test, Category("II deklinācija"), Category("II deklinācija / bez līdzskaņu mijas")]
        public void Simtkājis()
        {
            Lietvārds simtkājis = new OtrāsDeklinācijasLietvārds("simtkājis");
            Assert.AreEqual(Dzimte.Vīriešu, simtkājis.Dzimte);
            Assert.AreEqual(Deklinācija.II, (simtkājis as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("simtkājis", simtkājis.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("simtkāji", simtkājis.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("simtkāja", simtkājis.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("simtkāju", simtkājis.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("simtkājim", simtkājis.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("simtkājiem", simtkājis.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("simtkāji", simtkājis.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("simtkājus", simtkājis.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("simtkājī", simtkājis.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("simtkājos", simtkājis.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        [Test, Category("II deklinācija"), Category("II deklinācija / bez līdzskaņu mijas")]
        public void Kaķis()
        {
            Lietvārds kaķis = new OtrāsDeklinācijasLietvārds("kaķis");
            Assert.AreEqual(Dzimte.Vīriešu, kaķis.Dzimte);
            Assert.AreEqual(Deklinācija.II, (kaķis as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("kaķis", kaķis.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("kaķi", kaķis.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("kaķa", kaķis.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("kaķu", kaķis.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("kaķim", kaķis.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("kaķiem", kaķis.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("kaķi", kaķis.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("kaķus", kaķis.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("kaķī", kaķis.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("kaķos", kaķis.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        [Test, Category("II deklinācija"), Category("II deklinācija / bez līdzskaņu mijas")]
        public void Skauģis()
        {
            Lietvārds skauģis = new OtrāsDeklinācijasLietvārds("skauģis");
            Assert.AreEqual(Dzimte.Vīriešu, skauģis.Dzimte);
            Assert.AreEqual(Deklinācija.II, (skauģis as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("skauģis", skauģis.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("skauģi", skauģis.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("skauģa", skauģis.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("skauģu", skauģis.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("skauģim", skauģis.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("skauģiem", skauģis.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("skauģi", skauģis.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("skauģus", skauģis.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("skauģī", skauģis.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("skauģos", skauģis.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        [Test, Category("II deklinācija"), Category("II deklinācija / bez līdzskaņu mijas")]
        public void Mūris()
        {
            Lietvārds mūris = new OtrāsDeklinācijasLietvārds("mūris");
            Assert.AreEqual(Dzimte.Vīriešu, mūris.Dzimte);
            Assert.AreEqual(Deklinācija.II, (mūris as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("mūris", mūris.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("mūri", mūris.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("mūra", mūris.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("mūru", mūris.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("mūrim", mūris.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("mūriem", mūris.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("mūri", mūris.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("mūrus", mūris.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("mūrī", mūris.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("mūros", mūris.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        [Test, Category("II deklinācija"), Category("II deklinācija / bez līdzskaņu mijas")]
        public void Tālskatis()
        {
            Lietvārds tālskatis = new OtrāsDeklinācijasLietvārds("tālskatis");
            Assert.AreEqual(Dzimte.Vīriešu, tālskatis.Dzimte);
            Assert.AreEqual(Deklinācija.II, (tālskatis as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("tālskatis", tālskatis.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("tālskati", tālskatis.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("tālskata", tālskatis.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("tālskatu", tālskatis.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("tālskatim", tālskatis.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("tālskatiem", tālskatis.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("tālskati", tālskatis.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("tālskatus", tālskatis.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("tālskatī", tālskatis.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("tālskatos", tālskatis.Lokatīvs(Skaitlis.Daudzskaitlis));
        }
        #endregion Bez līdzskaņu mijas

        #region Personvārdi
        [Test, Category("II deklinācija"), Category("II deklinācija / personvārdi")]
        public void Turavskis()
        {
            Lietvārds Turavskis = new OtrāsDeklinācijasLietvārds("Turavskis");
            Assert.AreEqual(Dzimte.Vīriešu, Turavskis.Dzimte);
            Assert.AreEqual(Deklinācija.II, (Turavskis as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("Turavskis", Turavskis.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("Turavski", Turavskis.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("Turavska", Turavskis.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("Turavsku", Turavskis.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("Turavskim", Turavskis.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("Turavskiem", Turavskis.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("Turavski", Turavskis.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("Turavskus", Turavskis.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("Turavskī", Turavskis.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("Turavskos", Turavskis.Lokatīvs(Skaitlis.Daudzskaitlis));

            Turavskis = new OtrāsDeklinācijasPersonvārdaLietvārds("Turavskis");
            Assert.AreEqual(Dzimte.Vīriešu, Turavskis.Dzimte);
            Assert.AreEqual(Deklinācija.II, (Turavskis as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("Turavskis", Turavskis.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("Turavski", Turavskis.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("Turavska", Turavskis.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("Turavsku", Turavskis.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("Turavskim", Turavskis.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("Turavskiem", Turavskis.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("Turavski", Turavskis.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("Turavskus", Turavskis.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("Turavskī", Turavskis.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("Turavskos", Turavskis.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        [Test, Category("II deklinācija"), Category("II deklinācija / personvārdi")]
        public void Visockis()
        {
            Lietvārds Visockis = new OtrāsDeklinācijasLietvārds("Visockis");
            Assert.AreEqual(Dzimte.Vīriešu, Visockis.Dzimte);
            Assert.AreEqual(Deklinācija.II, (Visockis as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("Visockis", Visockis.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("Visocki", Visockis.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("Visocka", Visockis.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("Visocku", Visockis.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("Visockim", Visockis.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("Visockiem", Visockis.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("Visocki", Visockis.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("Visockus", Visockis.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("Visockī", Visockis.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("Visockos", Visockis.Lokatīvs(Skaitlis.Daudzskaitlis));

            Visockis = new OtrāsDeklinācijasPersonvārdaLietvārds("Visockis");
            Assert.AreEqual(Dzimte.Vīriešu, Visockis.Dzimte);
            Assert.AreEqual(Deklinācija.II, (Visockis as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("Visockis", Visockis.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("Visocki", Visockis.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("Visocka", Visockis.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("Visocku", Visockis.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("Visockim", Visockis.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("Visockiem", Visockis.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("Visocki", Visockis.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("Visockus", Visockis.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("Visockī", Visockis.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("Visockos", Visockis.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        [Test, Category("II deklinācija"), Category("II deklinācija / personvārdi")]
        public void Gatis()
        {
            Lietvārds Gatis = new OtrāsDeklinācijasPersonvārdaLietvārds("Gatis");
            Assert.AreEqual(Dzimte.Vīriešu, Gatis.Dzimte);
            Assert.AreEqual(Deklinācija.II, (Gatis as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("Gatis", Gatis.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("Gati", Gatis.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("Gata", Gatis.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("Gatu", Gatis.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("Gatim", Gatis.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("Gatiem", Gatis.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("Gati", Gatis.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("Gatus", Gatis.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("Gatī", Gatis.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("Gatos", Gatis.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        [Test, Category("II deklinācija"), Category("II deklinācija / personvārdi")]
        public void Aldis()
        {
            Lietvārds Aldis = new OtrāsDeklinācijasPersonvārdaLietvārds("Aldis");
            Assert.AreEqual(Dzimte.Vīriešu, Aldis.Dzimte);
            Assert.AreEqual(Deklinācija.II, (Aldis as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("Aldis", Aldis.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("Aldi", Aldis.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("Alda", Aldis.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("Aldu", Aldis.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("Aldim", Aldis.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("Aldiem", Aldis.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("Aldi", Aldis.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("Aldus", Aldis.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("Aldī", Aldis.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("Aldos", Aldis.Lokatīvs(Skaitlis.Daudzskaitlis));
        }
        #endregion
        #endregion

        #region III deklinācija
        [Test, Category("III deklinācija")]
        public void Medus()
        {
            Lietvārds medus = new TrešāsDeklinācijasLietvārds("medus");
            Assert.AreEqual(Dzimte.Vīriešu, medus.Dzimte);
            Assert.AreEqual(Deklinācija.III, (medus as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("medus", medus.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("medi", medus.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("medus", medus.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("medu", medus.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("medum", medus.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("mediem", medus.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("medu", medus.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("medus", medus.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("medū", medus.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("medos", medus.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        [Test, Category("III deklinācija")]
        public void Tirgus()
        {
            Lietvārds tirgus = new TrešāsDeklinācijasLietvārds("tirgus");
            Assert.AreEqual(Dzimte.Vīriešu, tirgus.Dzimte);
            Assert.AreEqual(Deklinācija.III, (tirgus as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("tirgus", tirgus.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("tirgi", tirgus.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("tirgus", tirgus.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("tirgu", tirgus.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("tirgum", tirgus.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("tirgiem", tirgus.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("tirgu", tirgus.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("tirgus", tirgus.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("tirgū", tirgus.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("tirgos", tirgus.Lokatīvs(Skaitlis.Daudzskaitlis));
        }
        #endregion

        #region IV deklinācija
        [Test, Category("IV deklinācija")]
        public void Māja()
        {
            Lietvārds māja = new CeturtāsDeklinācijasLietvārds("māja");
            Assert.AreEqual(Dzimte.Sieviešu, māja.Dzimte);
            Assert.AreEqual(Deklinācija.IV, ((māja as DeklinējamsLietvārds) as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("māja", māja.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("mājas", māja.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("mājas", māja.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("māju", māja.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("mājai", māja.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("mājām", māja.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("māju", māja.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("mājas", māja.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("mājā", māja.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("mājās", māja.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        [Test, Category("IV deklinācija")]
        public void Vara()
        {
            Lietvārds vara = new CeturtāsDeklinācijasLietvārds("vara");
            Assert.AreEqual(Dzimte.Sieviešu, vara.Dzimte);
            Assert.AreEqual(Deklinācija.IV, (vara as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("vara", vara.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("varas", vara.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("varas", vara.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("varu", vara.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("varai", vara.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("varām", vara.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("varu", vara.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("varas", vara.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("varā", vara.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("varās", vara.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        [Test, Category("IV deklinācija")]
        public void Paziņa()
        {
            Lietvārds paziņa = new CeturtāsDeklinācijasLietvārds("paziņa");
            Assert.AreEqual(Dzimte.Sieviešu, paziņa.Dzimte);
            Assert.AreEqual(Deklinācija.IV, (paziņa as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("paziņa", paziņa.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("paziņas", paziņa.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("paziņas", paziņa.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("paziņu", paziņa.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("paziņai", paziņa.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("paziņām", paziņa.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("paziņu", paziņa.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("paziņas", paziņa.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("paziņā", paziņa.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("paziņās", paziņa.Lokatīvs(Skaitlis.Daudzskaitlis));

            paziņa = new CeturtāsDeklinācijasLietvārds("paziņa", Dzimte.Vīriešu);
            Assert.AreEqual(Dzimte.Vīriešu, paziņa.Dzimte);
            Assert.AreEqual(Deklinācija.IV, (paziņa as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("paziņa", paziņa.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("paziņas", paziņa.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("paziņas", paziņa.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("paziņu", paziņa.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("paziņam", paziņa.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("paziņām", paziņa.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("paziņu", paziņa.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("paziņas", paziņa.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("paziņā", paziņa.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("paziņās", paziņa.Lokatīvs(Skaitlis.Daudzskaitlis));
        }
        #endregion

        #region V deklinācija
        #region Līdzskaņu mija
        public void Piekabe()
        {
            Lietvārds piekabe = new PiektāsDeklinācijasLietvārds("piekabe");
            Assert.AreEqual(Dzimte.Sieviešu, piekabe.Dzimte);
            Assert.AreEqual(Deklinācija.V, (piekabe as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("piekabe", piekabe.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("piekabes", piekabe.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("piekabes", piekabe.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("piekabju", piekabe.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("piekabei", piekabe.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("piekabēm", piekabe.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("piekabi", piekabe.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("piekabes", piekabe.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("piekabē", piekabe.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("piekabēs", piekabe.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        public void Zeme()
        {
            Lietvārds zeme = new PiektāsDeklinācijasLietvārds("zeme");
            Assert.AreEqual(Dzimte.Sieviešu, zeme.Dzimte);
            Assert.AreEqual(Deklinācija.V, (zeme as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("zeme", zeme.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("zemes", zeme.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("zemes", zeme.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("zemju", zeme.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("zemei", zeme.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("zemēm", zeme.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("zemi", zeme.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("zemes", zeme.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("zemē", zeme.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("zemēs", zeme.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        public void Tulpe()
        {
            Lietvārds tulpe = new PiektāsDeklinācijasLietvārds("tulpe");
            Assert.AreEqual(Dzimte.Sieviešu, tulpe.Dzimte);
            Assert.AreEqual(Deklinācija.V, (tulpe as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("tulpe", tulpe.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("tulpes", tulpe.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("tulpes", tulpe.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("tulpju", tulpe.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("tulpei", tulpe.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("tulpēm", tulpe.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("tulpi", tulpe.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("tulpes", tulpe.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("tulpē", tulpe.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("tulpēs", tulpe.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        public void Virve()
        {
            Lietvārds virve = new PiektāsDeklinācijasLietvārds("virve");
            Assert.AreEqual(Dzimte.Sieviešu, virve.Dzimte);
            Assert.AreEqual(Deklinācija.V, (virve as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("virve", virve.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("virves", virve.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("virves", virve.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("virvju", virve.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("virvei", virve.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("virvēm", virve.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("virvi", virve.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("virves", virve.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("virvē", virve.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("virvēs", virve.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        public void Skolniece()
        {
            Lietvārds skolniece = new PiektāsDeklinācijasLietvārds("skolniece");
            Assert.AreEqual(Dzimte.Sieviešu, skolniece.Dzimte);
            Assert.AreEqual(Deklinācija.V, (skolniece as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("skolniece", skolniece.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("skolnieces", skolniece.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("skolnieces", skolniece.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("skolnieču", skolniece.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("skolniecei", skolniece.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("skolniecēm", skolniece.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("skolnieci", skolniece.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("skolnieces", skolniece.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("skolniecē", skolniece.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("skolniecēs", skolniece.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        public void Bite()
        {
            Lietvārds bite = new PiektāsDeklinācijasLietvārds("bite");
            Assert.AreEqual(Dzimte.Sieviešu, bite.Dzimte);
            Assert.AreEqual(Deklinācija.V, (bite as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("bite", bite.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("bites", bite.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("bites", bite.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("bišu", bite.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("bitei", bite.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("bitēm", bite.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("biti", bite.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("bites", bite.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("bitē", bite.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("bitēs", bite.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        public void Bilde()
        {
            Lietvārds bilde = new PiektāsDeklinācijasLietvārds("bilde");
            Assert.AreEqual(Dzimte.Sieviešu, bilde.Dzimte);
            Assert.AreEqual(Deklinācija.V, (bilde as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("bilde", bilde.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("bildes", bilde.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("bildes", bilde.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("bilžu", bilde.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("bildei", bilde.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("bildēm", bilde.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("bildi", bilde.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("bildes", bilde.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("bildē", bilde.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("bildēs", bilde.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        public void Draudze()
        {
            Lietvārds draudze = new PiektāsDeklinācijasLietvārds("draudze");
            Assert.AreEqual(Dzimte.Sieviešu, draudze.Dzimte);
            Assert.AreEqual(Deklinācija.V, (draudze as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("draudze", draudze.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("draudzes", draudze.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("draudzes", draudze.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("draudžu", draudze.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("draudzei", draudze.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("draudzēm", draudze.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("draudzi", draudze.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("draudzes", draudze.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("draudzē", draudze.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("draudzēs", draudze.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        public void Tase()
        {
            Lietvārds tase = new PiektāsDeklinācijasLietvārds("tase");
            Assert.AreEqual(Dzimte.Sieviešu, tase.Dzimte);
            Assert.AreEqual(Deklinācija.V, (tase as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("tase", tase.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("tases", tase.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("tases", tase.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("tašu", tase.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("tasei", tase.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("tasēm", tase.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("tasi", tase.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("tases", tase.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("tasē", tase.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("tasēs", tase.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        public void Krūze()
        {
            Lietvārds krūze = new PiektāsDeklinācijasLietvārds("krūze");
            Assert.AreEqual(Dzimte.Sieviešu, krūze.Dzimte);
            Assert.AreEqual(Deklinācija.V, (krūze as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("krūze", krūze.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("krūzes", krūze.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("krūzes", krūze.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("krūžu", krūze.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("krūzei", krūze.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("krūzēm", krūze.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("krūzi", krūze.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("krūzes", krūze.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("krūzē", krūze.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("krūzēs", krūze.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        public void Sēne()
        {
            Lietvārds sēne = new PiektāsDeklinācijasLietvārds("sēne");
            Assert.AreEqual(Dzimte.Sieviešu, sēne.Dzimte);
            Assert.AreEqual(Deklinācija.V, (sēne as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("sēne", sēne.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("sēnes", sēne.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("sēnes", sēne.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("sēņu", sēne.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("sēnei", sēne.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("sēnēm", sēne.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("sēni", sēne.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("sēnes", sēne.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("sēnē", sēne.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("sēnēs", sēne.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        public void Zāle()
        {
            Lietvārds zāle = new PiektāsDeklinācijasLietvārds("zāle");
            Assert.AreEqual(Dzimte.Sieviešu, zāle.Dzimte);
            Assert.AreEqual(Deklinācija.V, (zāle as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("zāle", zāle.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("zāles", zāle.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("zāles", zāle.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("zāļu", zāle.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("zālei", zāle.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("zālēm", zāle.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("zāli", zāle.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("zāles", zāle.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("zālē", zāle.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("zālēs", zāle.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        public void Loksne()
        {
            Lietvārds loksne = new PiektāsDeklinācijasLietvārds("loksne");
            Assert.AreEqual(Dzimte.Sieviešu, loksne.Dzimte);
            Assert.AreEqual(Deklinācija.V, (loksne as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("loksne", loksne.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("loksnes", loksne.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("loksnes", loksne.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("lokšņu", loksne.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("loksnei", loksne.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("loksnēm", loksne.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("loksni", loksne.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("loksnes", loksne.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("loksnē", loksne.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("loksnēs", loksne.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        public void Zvaigzne()
        {
            Lietvārds zvaigzne = new PiektāsDeklinācijasLietvārds("zvaigzne");
            Assert.AreEqual(Dzimte.Sieviešu, zvaigzne.Dzimte);
            Assert.AreEqual(Deklinācija.V, (zvaigzne as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("zvaigzne", zvaigzne.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("zvaigznes", zvaigzne.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("zvaigznes", zvaigzne.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("zvaigžņu", zvaigzne.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("zvaigznei", zvaigzne.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("zvaigznēm", zvaigzne.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("zvaigzni", zvaigzne.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("zvaigznes", zvaigzne.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("zvaigznē", zvaigzne.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("zvaigznēs", zvaigzne.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        public void Rīkste()
        {
            Lietvārds rīkste = new PiektāsDeklinācijasLietvārds("rīkste");
            Assert.AreEqual(Dzimte.Sieviešu, rīkste.Dzimte);
            Assert.AreEqual(Deklinācija.V, (rīkste as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("rīkste", rīkste.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("rīkstes", rīkste.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("rīkstes", rīkste.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("rīkšu", rīkste.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("rīkstei", rīkste.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("rīkstēm", rīkste.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("rīksti", rīkste.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("rīkstes", rīkste.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("rīkstē", rīkste.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("rīkstēs", rīkste.Lokatīvs(Skaitlis.Daudzskaitlis));
        }
        #endregion Līdzskaņu mija

        #region Bez līdzskaņu mijas
        [Test, Category("V deklinācija"), Category("V deklinācija / bez līdzskaņu mijas")]
        public void Strupaste()
        {
            Lietvārds strupaste = new PiektāsDeklinācijasLietvārds("strupaste");
            Assert.AreEqual(Dzimte.Sieviešu, strupaste.Dzimte);
            Assert.AreEqual(Deklinācija.V, (strupaste as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("strupaste", strupaste.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("strupastes", strupaste.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("strupastes", strupaste.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("strupastu", strupaste.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("strupastei", strupaste.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("strupastēm", strupaste.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("strupasti", strupaste.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("strupastes", strupaste.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("strupastē", strupaste.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("strupastēs", strupaste.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        [Test, Category("V deklinācija"), Category("V deklinācija / bez līdzskaņu mijas")]
        public void Žirafe()
        {
            Lietvārds žirafe = new PiektāsDeklinācijasLietvārds("žirafe");
            Assert.AreEqual(Dzimte.Sieviešu, žirafe.Dzimte);
            Assert.AreEqual(Deklinācija.V, (žirafe as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("žirafe", žirafe.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("žirafes", žirafe.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("žirafes", žirafe.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("žirafu", žirafe.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("žirafei", žirafe.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("žirafēm", žirafe.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("žirafi", žirafe.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("žirafes", žirafe.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("žirafē", žirafe.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("žirafēs", žirafe.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        [Test, Category("V deklinācija"), Category("V deklinācija / bez līdzskaņu mijas")]
        public void Zeķe()
        {
            Lietvārds zeķe = new PiektāsDeklinācijasLietvārds("zeķe");
            Assert.AreEqual(Dzimte.Sieviešu, zeķe.Dzimte);
            Assert.AreEqual(Deklinācija.V, (zeķe as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("zeķe", zeķe.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("zeķes", zeķe.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("zeķes", zeķe.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("zeķu", zeķe.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("zeķei", zeķe.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("zeķēm", zeķe.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("zeķi", zeķe.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("zeķes", zeķe.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("zeķē", zeķe.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("zeķēs", zeķe.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        [Test, Category("V deklinācija"), Category("V deklinācija / bez līdzskaņu mijas")]
        public void Gaišmate()
        {
            Lietvārds gaišmate = new PiektāsDeklinācijasLietvārds("gaišmate");
            Assert.AreEqual(Dzimte.Sieviešu, gaišmate.Dzimte);
            Assert.AreEqual(Deklinācija.V, (gaišmate as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("gaišmate", gaišmate.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("gaišmates", gaišmate.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("gaišmates", gaišmate.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("gaišmatu", gaišmate.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("gaišmatei", gaišmate.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("gaišmatēm", gaišmate.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("gaišmati", gaišmate.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("gaišmates", gaišmate.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("gaišmatē", gaišmate.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("gaišmatēs", gaišmate.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        [Test, Category("V deklinācija"), Category("V deklinācija / bez līdzskaņu mijas")]
        public void Logopēde()
        {
            Lietvārds logopēde = new PiektāsDeklinācijasLietvārds("logopēde");
            Assert.AreEqual(Dzimte.Sieviešu, logopēde.Dzimte);
            Assert.AreEqual(Deklinācija.V, (logopēde as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("logopēde", logopēde.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("logopēdes", logopēde.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("logopēdes", logopēde.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("logopēdu", logopēde.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("logopēdei", logopēde.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("logopēdēm", logopēde.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("logopēdi", logopēde.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("logopēdes", logopēde.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("logopēdē", logopēde.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("logopēdēs", logopēde.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        [Test, Category("V deklinācija"), Category("V deklinācija / bez līdzskaņu mijas")]
        public void Ārste()
        {
            Lietvārds ārste = new PiektāsDeklinācijasLietvārds("ārste");
            Assert.AreEqual(Dzimte.Sieviešu, ārste.Dzimte);
            Assert.AreEqual(Deklinācija.V, (ārste as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("ārste", ārste.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("ārstes", ārste.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("ārstes", ārste.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("ārstu", ārste.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("ārstei", ārste.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("ārstēm", ārste.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("ārsti", ārste.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("ārstes", ārste.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("ārstē", ārste.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("ārstēs", ārste.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        [Test, Category("V deklinācija"), Category("V deklinācija / bez līdzskaņu mijas")]
        public void Aste()
        {
            Lietvārds aste = new PiektāsDeklinācijasLietvārds("aste");
            Assert.AreEqual(Dzimte.Sieviešu, aste.Dzimte);
            Assert.AreEqual(Deklinācija.V, (aste as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("aste", aste.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("astes", aste.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("astes", aste.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("astu", aste.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("astei", aste.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("astēm", aste.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("asti", aste.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("astes", aste.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("astē", aste.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("astēs", aste.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        [Test, Category("V deklinācija"), Category("V deklinācija / bez līdzskaņu mijas")]
        public void Tūriste()
        {
            Lietvārds tūriste = new PiektāsDeklinācijasLietvārds("tūriste");
            Assert.AreEqual(Dzimte.Sieviešu, tūriste.Dzimte);
            Assert.AreEqual(Deklinācija.V, (tūriste as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("tūriste", tūriste.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("tūristes", tūriste.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("tūristes", tūriste.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("tūristu", tūriste.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("tūristei", tūriste.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("tūristēm", tūriste.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("tūristi", tūriste.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("tūristes", tūriste.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("tūristē", tūriste.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("tūristēs", tūriste.Lokatīvs(Skaitlis.Daudzskaitlis));
        }
        #endregion Bez līdzskaņu mijas

        #region Izņēmumi
        [Test, Category("V deklinācija"), Category("V deklinācija / izņēmumi")]
        public void Apaļmute()
        {
            Lietvārds apaļmute = new PiektāsDeklinācijasLietvārds("apaļmute");
            Assert.AreEqual(Dzimte.Sieviešu, apaļmute.Dzimte);
            Assert.AreEqual(Deklinācija.V, (apaļmute as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("apaļmute", apaļmute.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("apaļmutes", apaļmute.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("apaļmutes", apaļmute.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("apaļmutu", apaļmute.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("apaļmutei", apaļmute.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("apaļmutēm", apaļmute.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("apaļmuti", apaļmute.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("apaļmutes", apaļmute.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("apaļmutē", apaļmute.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("apaļmutēs", apaļmute.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        [Test, Category("V deklinācija"), Category("V deklinācija / izņēmumi")]
        public void Balle()
        {
            Lietvārds balle = new PiektāsDeklinācijasLietvārds("balle");
            Assert.AreEqual(Dzimte.Sieviešu, balle.Dzimte);
            Assert.AreEqual(Deklinācija.V, (balle as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("balle", balle.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("balles", balle.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("balles", balle.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("ballu", balle.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("ballei", balle.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("ballēm", balle.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("balli", balle.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("balles", balle.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("ballē", balle.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("ballēs", balle.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        [Test, Category("V deklinācija"), Category("V deklinācija / izņēmumi")]
        public void Pase()
        {
            Lietvārds pase = new PiektāsDeklinācijasLietvārds("pase");
            Assert.AreEqual(Dzimte.Sieviešu, pase.Dzimte);
            Assert.AreEqual(Deklinācija.V, (pase as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("pase", pase.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("pases", pase.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("pases", pase.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("pasu", pase.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("pasei", pase.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("pasēm", pase.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("pasi", pase.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("pases", pase.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("pasē", pase.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("pasēs", pase.Lokatīvs(Skaitlis.Daudzskaitlis));
        }
        #endregion Izņēmumi

        [Test, Category("V deklinācija")]
        public void Bende()
        {
            Lietvārds bende = new PiektāsDeklinācijasLietvārds("bende");
            Assert.AreEqual(Dzimte.Sieviešu, bende.Dzimte);
            Assert.AreEqual(Deklinācija.V, (bende as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("bende", bende.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("bendes", bende.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("bendes", bende.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("benžu", bende.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("bendei", bende.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("bendēm", bende.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("bendi", bende.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("bendes", bende.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("bendē", bende.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("bendēs", bende.Lokatīvs(Skaitlis.Daudzskaitlis));

            bende = new PiektāsDeklinācijasLietvārds("bende", Dzimte.Vīriešu);
            Assert.AreEqual(Dzimte.Vīriešu, bende.Dzimte);
            Assert.AreEqual(Deklinācija.V, (bende as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("bende", bende.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("bendes", bende.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("bendes", bende.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("benžu", bende.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("bendem", bende.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("bendēm", bende.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("bendi", bende.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("bendes", bende.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("bendē", bende.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("bendēs", bende.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        [Test, Category("V deklinācija"), Category("V deklinācija / izņēmumi")]
        public void Torte()
        {
            Lietvārds torte = new PiektāsDeklinācijasLietvārds("torte");
            Assert.AreEqual(Dzimte.Sieviešu, torte.Dzimte);
            Assert.AreEqual(Deklinācija.V, (torte as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("torte", torte.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("tortes", torte.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("tortes", torte.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("toršu", torte.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("tortei", torte.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("tortēm", torte.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("torti", torte.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("tortes", torte.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("tortē", torte.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("tortēs", torte.Lokatīvs(Skaitlis.Daudzskaitlis));
        }
        #endregion

        #region VI deklinācija
        #region Līdzskaņu mija
        [Test, Category("VI deklinācija"), Category("VI deklinācija / līdzskaņu mija")]
        public void Zivs()
        {
            Lietvārds zivs = new SestāsDeklinācijasLietvārds("zivs");
            Assert.AreEqual(Dzimte.Sieviešu, zivs.Dzimte);
            Assert.AreEqual(Deklinācija.VI, (zivs as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("zivs", zivs.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("zivis", zivs.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("zivs", zivs.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("zivju", zivs.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("zivij", zivs.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("zivīm", zivs.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("zivi", zivs.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("zivis", zivs.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("zivī", zivs.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("zivīs", zivs.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        [Test, Category("VI deklinācija"), Category("VI deklinācija / līdzskaņu mija")]
        public void Nakts()
        {
            Lietvārds nakts = new SestāsDeklinācijasLietvārds("nakts");
            Assert.AreEqual(Dzimte.Sieviešu, nakts.Dzimte);
            Assert.AreEqual(Deklinācija.VI, (nakts as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("nakts", nakts.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("naktis", nakts.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("nakts", nakts.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("nakšu", nakts.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("naktij", nakts.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("naktīm", nakts.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("nakti", nakts.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("naktis", nakts.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("naktī", nakts.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("naktīs", nakts.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        [Test, Category("VI deklinācija"), Category("VI deklinācija / līdzskaņu mija")]
        public void Sirds()
        {
            Lietvārds sirds = new SestāsDeklinācijasLietvārds("sirds");
            Assert.AreEqual(Dzimte.Sieviešu, sirds.Dzimte);
            Assert.AreEqual(Deklinācija.VI, (sirds as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("sirds", sirds.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("sirdis", sirds.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("sirds", sirds.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("siržu", sirds.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("sirdij", sirds.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("sirdīm", sirds.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("sirdi", sirds.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("sirdis", sirds.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("sirdī", sirds.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("sirdīs", sirds.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        [Test, Category("VI deklinācija"), Category("VI deklinācija / līdzskaņu mija")]
        public void Krūts()
        {
            Lietvārds krūts = new SestāsDeklinācijasLietvārds("krūts");
            Assert.AreEqual(Dzimte.Sieviešu, krūts.Dzimte);
            Assert.AreEqual(Deklinācija.VI, (krūts as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("krūts", krūts.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("krūtis", krūts.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("krūts", krūts.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("krūšu", krūts.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("krūtij", krūts.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("krūtīm", krūts.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("krūti", krūts.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("krūtis", krūts.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("krūtī", krūts.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("krūtīs", krūts.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        [Test, Category("VI deklinācija"), Category("VI deklinācija / līdzskaņu mija")]
        public void Birzs()
        {
            Lietvārds birzs = new SestāsDeklinācijasLietvārds("birzs");
            Assert.AreEqual(Dzimte.Sieviešu, birzs.Dzimte);
            Assert.AreEqual(Deklinācija.VI, (birzs as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("birzs", birzs.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("birzis", birzs.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("birzs", birzs.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("biržu", birzs.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("birzij", birzs.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("birzīm", birzs.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("birzi", birzs.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("birzis", birzs.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("birzī", birzs.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("birzīs", birzs.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        [Test, Category("VI deklinācija"), Category("VI deklinācija / līdzskaņu mija")]
        public void Asins()
        {
            Lietvārds asins = new SestāsDeklinācijasLietvārds("asins");
            Assert.AreEqual(Dzimte.Sieviešu, asins.Dzimte);
            Assert.AreEqual(Deklinācija.VI, (asins as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("asins", asins.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("asinis", asins.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("asins", asins.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("asiņu", asins.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("asinij", asins.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("asinīm", asins.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("asini", asins.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("asinis", asins.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("asinī", asins.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("asinīs", asins.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        [Test, Category("VI deklinācija"), Category("VI deklinācija / līdzskaņu mija")]
        public void Pils()
        {
            Lietvārds pils = new SestāsDeklinācijasLietvārds("pils");
            Assert.AreEqual(Dzimte.Sieviešu, pils.Dzimte);
            Assert.AreEqual(Deklinācija.VI, (pils as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("pils", pils.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("pilis", pils.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("pils", pils.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("piļu", pils.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("pilij", pils.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("pilīm", pils.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("pili", pils.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("pilis", pils.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("pilī", pils.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("pilīs", pils.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        [Test, Category("VI deklinācija"), Category("VI deklinācija / līdzskaņu mija")]
        public void Krāsns()
        {
            Lietvārds krāsns = new SestāsDeklinācijasLietvārds("krāsns");
            Assert.AreEqual(Dzimte.Sieviešu, krāsns.Dzimte);
            Assert.AreEqual(Deklinācija.VI, (krāsns as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("krāsns", krāsns.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("krāsnis", krāsns.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("krāsns", krāsns.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("krāšņu", krāsns.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("krāsnij", krāsns.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("krāsnīm", krāsns.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("krāsni", krāsns.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("krāsnis", krāsns.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("krāsnī", krāsns.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("krāsnīs", krāsns.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        [Test, Category("VI deklinācija"), Category("VI deklinācija / līdzskaņu mija")]
        public void Pāksts()
        {
            Lietvārds pāksts = new SestāsDeklinācijasLietvārds("pāksts");
            Assert.AreEqual(Dzimte.Sieviešu, pāksts.Dzimte);
            Assert.AreEqual(Deklinācija.VI, (pāksts as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("pāksts", pāksts.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("pākstis", pāksts.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("pāksts", pāksts.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("pākšu", pāksts.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("pākstij", pāksts.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("pākstīm", pāksts.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("pāksti", pāksts.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("pākstis", pāksts.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("pākstī", pāksts.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("pākstīs", pāksts.Lokatīvs(Skaitlis.Daudzskaitlis));
        }
        #endregion Līdzskaņu mija

        #region Bez līdzskaņu mijas
        [Test, Category("VI deklinācija"), Category("VI deklinācija / bez līdzskaņu mijas")]
        public void Acs()
        {
            Lietvārds acs = new SestāsDeklinācijasLietvārds("acs");
            Assert.AreEqual(Dzimte.Sieviešu, acs.Dzimte);
            Assert.AreEqual(Deklinācija.VI, (acs as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("acs", acs.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("acis", acs.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("acs", acs.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("acu", acs.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("acij", acs.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("acīm", acs.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("aci", acs.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("acis", acs.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("acī", acs.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("acīs", acs.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        [Test, Category("VI deklinācija"), Category("VI deklinācija / bez līdzskaņu mijas")]
        public void Ass()
        {
            Lietvārds ass = new SestāsDeklinācijasLietvārds("ass");
            Assert.AreEqual(Dzimte.Sieviešu, ass.Dzimte);
            Assert.AreEqual(Deklinācija.VI, (ass as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("ass", ass.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("asis", ass.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("ass", ass.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("asu", ass.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("asij", ass.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("asīm", ass.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("asi", ass.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("asis", ass.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("asī", ass.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("asīs", ass.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        [Test, Category("VI deklinācija"), Category("VI deklinācija / bez līdzskaņu mijas")]
        public void Debess()
        {
            Lietvārds debess = new SestāsDeklinācijasLietvārds("debess");
            Assert.AreEqual(Dzimte.Sieviešu, debess.Dzimte);
            Assert.AreEqual(Deklinācija.VI, (debess as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("debess", debess.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("debesis", debess.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("debess", debess.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("debesu", debess.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("debesij", debess.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("debesīm", debess.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("debesi", debess.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("debesis", debess.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("debesī", debess.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("debesīs", debess.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        [Test, Category("VI deklinācija"), Category("VI deklinācija / bez līdzskaņu mijas")]
        public void Dzelzs()
        {
            Lietvārds dzelzs = new SestāsDeklinācijasLietvārds("dzelzs");
            Assert.AreEqual(Dzimte.Sieviešu, dzelzs.Dzimte);
            Assert.AreEqual(Deklinācija.VI, (dzelzs as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("dzelzs", dzelzs.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("dzelzis", dzelzs.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("dzelzs", dzelzs.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("dzelzu", dzelzs.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("dzelzij", dzelzs.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("dzelzīm", dzelzs.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("dzelzi", dzelzs.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("dzelzis", dzelzs.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("dzelzī", dzelzs.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("dzelzīs", dzelzs.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        [Test, Category("VI deklinācija"), Category("VI deklinācija / bez līdzskaņu mijas")]
        public void Šalts()
        {
            Lietvārds šalts = new SestāsDeklinācijasLietvārds("šalts");
            Assert.AreEqual(Dzimte.Sieviešu, šalts.Dzimte);
            Assert.AreEqual(Deklinācija.VI, (šalts as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("šalts", šalts.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("šaltis", šalts.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("šalts", šalts.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("šaltu", šalts.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("šaltij", šalts.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("šaltīm", šalts.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("šalti", šalts.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("šaltis", šalts.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("šaltī", šalts.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("šaltīs", šalts.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        [Test, Category("VI deklinācija"), Category("VI deklinācija / bez līdzskaņu mijas")]
        public void Valsts()
        {
            Lietvārds valsts = new SestāsDeklinācijasLietvārds("valsts");
            Assert.AreEqual(Dzimte.Sieviešu, valsts.Dzimte);
            Assert.AreEqual(Deklinācija.VI, (valsts as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("valsts", valsts.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("valstis", valsts.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("valsts", valsts.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("valstu", valsts.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("valstij", valsts.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("valstīm", valsts.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("valsti", valsts.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("valstis", valsts.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("valstī", valsts.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("valstīs", valsts.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        [Test, Category("VI deklinācija"), Category("VI deklinācija / bez līdzskaņu mijas")]
        public void Zoss()
        {
            Lietvārds zoss = new SestāsDeklinācijasLietvārds("zoss");
            Assert.AreEqual(Dzimte.Sieviešu, zoss.Dzimte);
            Assert.AreEqual(Deklinācija.VI, (zoss as DeklinējamsLietvārds).Deklinācija);
            Assert.AreEqual("zoss", zoss.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("zosis", zoss.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("zoss", zoss.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("zosu", zoss.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("zosij", zoss.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("zosīm", zoss.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("zosi", zoss.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("zosis", zoss.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("zosī", zoss.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("zosīs", zoss.Lokatīvs(Skaitlis.Daudzskaitlis));
        }
        #endregion Bez līdzskaņu mijas
        #endregion

        #region Atgriezeniskie lietvārdi
        [Test, Category("Atgriezeniskie lietvārdi")]
        public void Smiešanās()
        {
            Lietvārds smiešanās = new AtgriezenisksLietvārds("smiešanās");
            //Assert.AreEqual(Dzimte.Sieviešu, smiešanās.Dzimte);
            Assert.AreEqual("smiešanās", smiešanās.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("smiešanās", smiešanās.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("smiešanās", smiešanās.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("smiešanos", smiešanās.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("", smiešanās.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("", smiešanās.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("smiešanos", smiešanās.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("smiešanās", smiešanās.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("", smiešanās.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("", smiešanās.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        [Test, Category("Atgriezeniskie lietvārdi")]
        public void Vēlējumies()
        {
            Lietvārds vēlējumies = new AtgriezenisksLietvārds("vēlējumies");
            //Assert.AreEqual(Dzimte.Sieviešu, vēlējumies.Dzimte);
            Assert.AreEqual("vēlējumies", vēlējumies.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("vēlējumies", vēlējumies.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("", vēlējumies.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("", vēlējumies.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("", vēlējumies.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("", vēlējumies.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("vēlējumos", vēlējumies.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("vēlējumos", vēlējumies.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("", vēlējumies.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("", vēlējumies.Lokatīvs(Skaitlis.Daudzskaitlis));
        }
        #endregion

        #region Nelokāmie lietvārdi
        [Test, Category("Nelokāmie lietvārdi")]
        public void Auto()
        {
            Lietvārds auto = new NelokāmsLietvārds("auto", Dzimte.Vīriešu);
            Assert.AreEqual(Dzimte.Vīriešu, auto.Dzimte);
            Assert.AreEqual("auto", auto.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("auto", auto.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("auto", auto.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("auto", auto.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("auto", auto.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("auto", auto.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("auto", auto.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("auto", auto.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("auto", auto.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("auto", auto.Lokatīvs(Skaitlis.Daudzskaitlis));
        }

        [Test, Category("Nelokāmie lietvārdi")]
        public void Foajē()
        {
            Lietvārds foajē = new NelokāmsLietvārds("foajē", Dzimte.Vīriešu);
            Assert.AreEqual(Dzimte.Vīriešu, foajē.Dzimte);
            Assert.AreEqual("foajē", foajē.Nominatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("foajē", foajē.Nominatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("foajē", foajē.Ģenitīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("foajē", foajē.Ģenitīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("foajē", foajē.Datīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("foajē", foajē.Datīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("foajē", foajē.Akuzatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("foajē", foajē.Akuzatīvs(Skaitlis.Daudzskaitlis));
            Assert.AreEqual("foajē", foajē.Lokatīvs(Skaitlis.Vienskaitlis));
            Assert.AreEqual("foajē", foajē.Lokatīvs(Skaitlis.Daudzskaitlis));
        }
        #endregion

        [Test]
        public void Ātrdarbība()
        {
            var stopwatch = new System.Diagnostics.Stopwatch();

            var locījumi = (Locījums[])System.Enum.GetValues(typeof(Locījums));
            var skaitļi = (Skaitlis[])System.Enum.GetValues(typeof(Skaitlis));

            stopwatch.Start();

            Lietvārds torte = new PiektāsDeklinācijasLietvārds("torte");
            foreach (Locījums locījums in locījumi)
                foreach (Skaitlis skaitlis in skaitļi)
                    torte.Locīt(locījums, skaitlis);

            stopwatch.Stop();

            Assert.That(stopwatch.ElapsedMilliseconds, Is.LessThanOrEqualTo(10 * 10));
        }
    }
}
