using NUnit.Framework;

using Latvian.Vārdšķiras;
using Latvian.Vārdšķiras.ĪpašībasVārdi;

namespace Latvian.Testi
{
    [TestFixture]
    public class ĪpašībasVārduTesti
    {
        #region Pakāpes
        [Test, Category("Pakāpes")]
        public void PamataPakāpe()
        {
            ĪpašībasVārds labs = new ĪpašībasVārds("labs");
            Assert.AreEqual("lab", labs.Celms);
            Assert.AreEqual("lab", labs.PamataPakāpe.Celms);
            Assert.AreEqual("labs", labs.Nominatīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("labi", labs.Nominatīvs(Dzimte.Vīriešu, Skaitlis.Daudzskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("laba", labs.Ģenitīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("labu", labs.Ģenitīvs(Dzimte.Vīriešu, Skaitlis.Daudzskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("labam", labs.Datīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("labiem", labs.Datīvs(Dzimte.Vīriešu, Skaitlis.Daudzskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("labu", labs.Akuzatīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("labus", labs.Akuzatīvs(Dzimte.Vīriešu, Skaitlis.Daudzskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("labā", labs.Lokatīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("labos", labs.Lokatīvs(Dzimte.Vīriešu, Skaitlis.Daudzskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("laba", labs.Nominatīvs(Dzimte.Sieviešu, Skaitlis.Vienskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("labas", labs.Nominatīvs(Dzimte.Sieviešu, Skaitlis.Daudzskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("labas", labs.Ģenitīvs(Dzimte.Sieviešu, Skaitlis.Vienskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("labu", labs.Ģenitīvs(Dzimte.Sieviešu, Skaitlis.Daudzskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("labai", labs.Datīvs(Dzimte.Sieviešu, Skaitlis.Vienskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("labām", labs.Datīvs(Dzimte.Sieviešu, Skaitlis.Daudzskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("labu", labs.Akuzatīvs(Dzimte.Sieviešu, Skaitlis.Vienskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("labas", labs.Akuzatīvs(Dzimte.Sieviešu, Skaitlis.Daudzskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("labā", labs.Lokatīvs(Dzimte.Sieviešu, Skaitlis.Vienskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("labās", labs.Lokatīvs(Dzimte.Sieviešu, Skaitlis.Daudzskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("labais", labs.Nominatīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("labie", labs.Nominatīvs(Dzimte.Vīriešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("labā", labs.Ģenitīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("labo", labs.Ģenitīvs(Dzimte.Vīriešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("labajam", labs.Datīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("labajiem", labs.Datīvs(Dzimte.Vīriešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("labo", labs.Akuzatīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("labos", labs.Akuzatīvs(Dzimte.Vīriešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("labajā", labs.Lokatīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("labajos", labs.Lokatīvs(Dzimte.Vīriešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("labā", labs.Nominatīvs(Dzimte.Sieviešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("labās", labs.Nominatīvs(Dzimte.Sieviešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("labās", labs.Ģenitīvs(Dzimte.Sieviešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("labo", labs.Ģenitīvs(Dzimte.Sieviešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("labajai", labs.Datīvs(Dzimte.Sieviešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("labajām", labs.Datīvs(Dzimte.Sieviešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("labo", labs.Akuzatīvs(Dzimte.Sieviešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("labās", labs.Akuzatīvs(Dzimte.Sieviešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("labajā", labs.Lokatīvs(Dzimte.Sieviešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("labajās", labs.Lokatīvs(Dzimte.Sieviešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));
        }

        [Test, Category("Pakāpes")]
        public void PārākāPakāpe()
        {
            ĪpašībasVārds labs = new ĪpašībasVārds("labs");
            Assert.AreEqual("labāk", labs.PārākāPakāpe.Celms);

            labs = labs.PārākāPakāpe;
            Assert.AreEqual("labāks", labs.Nominatīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("labāki", labs.Nominatīvs(Dzimte.Vīriešu, Skaitlis.Daudzskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("labāka", labs.Ģenitīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("labāku", labs.Ģenitīvs(Dzimte.Vīriešu, Skaitlis.Daudzskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("labākam", labs.Datīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("labākiem", labs.Datīvs(Dzimte.Vīriešu, Skaitlis.Daudzskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("labāku", labs.Akuzatīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("labākus", labs.Akuzatīvs(Dzimte.Vīriešu, Skaitlis.Daudzskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("labākā", labs.Lokatīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("labākos", labs.Lokatīvs(Dzimte.Vīriešu, Skaitlis.Daudzskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("labāka", labs.Nominatīvs(Dzimte.Sieviešu, Skaitlis.Vienskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("labākas", labs.Nominatīvs(Dzimte.Sieviešu, Skaitlis.Daudzskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("labākas", labs.Ģenitīvs(Dzimte.Sieviešu, Skaitlis.Vienskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("labāku", labs.Ģenitīvs(Dzimte.Sieviešu, Skaitlis.Daudzskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("labākai", labs.Datīvs(Dzimte.Sieviešu, Skaitlis.Vienskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("labākām", labs.Datīvs(Dzimte.Sieviešu, Skaitlis.Daudzskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("labāku", labs.Akuzatīvs(Dzimte.Sieviešu, Skaitlis.Vienskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("labākas", labs.Akuzatīvs(Dzimte.Sieviešu, Skaitlis.Daudzskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("labākā", labs.Lokatīvs(Dzimte.Sieviešu, Skaitlis.Vienskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("labākās", labs.Lokatīvs(Dzimte.Sieviešu, Skaitlis.Daudzskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("labākais", labs.Nominatīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("labākie", labs.Nominatīvs(Dzimte.Vīriešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("labākā", labs.Ģenitīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("labāko", labs.Ģenitīvs(Dzimte.Vīriešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("labākajam", labs.Datīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("labākajiem", labs.Datīvs(Dzimte.Vīriešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("labāko", labs.Akuzatīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("labākos", labs.Akuzatīvs(Dzimte.Vīriešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("labākajā", labs.Lokatīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("labākajos", labs.Lokatīvs(Dzimte.Vīriešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("labākā", labs.Nominatīvs(Dzimte.Sieviešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("labākās", labs.Nominatīvs(Dzimte.Sieviešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("labākās", labs.Ģenitīvs(Dzimte.Sieviešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("labāko", labs.Ģenitīvs(Dzimte.Sieviešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("labākajai", labs.Datīvs(Dzimte.Sieviešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("labākajām", labs.Datīvs(Dzimte.Sieviešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("labāko", labs.Akuzatīvs(Dzimte.Sieviešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("labākās", labs.Akuzatīvs(Dzimte.Sieviešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("labākajā", labs.Lokatīvs(Dzimte.Sieviešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("labākajās", labs.Lokatīvs(Dzimte.Sieviešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));
        }

        [Test, Category("Pakāpes")]
        public void VispārākāPakāpe()
        {
            ĪpašībasVārds labs = new ĪpašībasVārds("labs");
            Assert.AreEqual("vislabāk", labs.VispārākāPakāpe.Celms);

            labs = labs.VispārākāPakāpe;
            Assert.AreEqual("vislabākais", labs.Nominatīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("vislabākie", labs.Nominatīvs(Dzimte.Vīriešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("vislabākā", labs.Ģenitīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("vislabāko", labs.Ģenitīvs(Dzimte.Vīriešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("vislabākajam", labs.Datīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("vislabākajiem", labs.Datīvs(Dzimte.Vīriešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("vislabāko", labs.Akuzatīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("vislabākos", labs.Akuzatīvs(Dzimte.Vīriešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("vislabākajā", labs.Lokatīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("vislabākajos", labs.Lokatīvs(Dzimte.Vīriešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("vislabākā", labs.Nominatīvs(Dzimte.Sieviešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("vislabākās", labs.Nominatīvs(Dzimte.Sieviešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("vislabākās", labs.Ģenitīvs(Dzimte.Sieviešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("vislabāko", labs.Ģenitīvs(Dzimte.Sieviešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("vislabākajai", labs.Datīvs(Dzimte.Sieviešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("vislabākajām", labs.Datīvs(Dzimte.Sieviešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("vislabāko", labs.Akuzatīvs(Dzimte.Sieviešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("vislabākās", labs.Akuzatīvs(Dzimte.Sieviešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("vislabākajā", labs.Lokatīvs(Dzimte.Sieviešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("vislabākajās", labs.Lokatīvs(Dzimte.Sieviešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));
        }

        [Test, Category("Pakāpes")]
        public void PakāpjuCelmi()
        {
            ĪpašībasVārds labs;

            labs = new ĪpašībasVārds("labs");
            Assert.AreEqual("lab", labs.PamataPakāpe.Celms);
            Assert.AreEqual("labāk", labs.PārākāPakāpe.Celms);
            Assert.AreEqual("vislabāk", labs.VispārākāPakāpe.Celms);

            labs = labs.PārākāPakāpe;
            Assert.AreEqual("lab", labs.PamataPakāpe.Celms);
            Assert.AreEqual("labāk", labs.PārākāPakāpe.Celms);
            Assert.AreEqual("vislabāk", labs.VispārākāPakāpe.Celms);

            labs = labs.VispārākāPakāpe;
            Assert.AreEqual("lab", labs.PamataPakāpe.Celms);
            Assert.AreEqual("labāk", labs.PārākāPakāpe.Celms);
            Assert.AreEqual("vislabāk", labs.VispārākāPakāpe.Celms);
        }
        #endregion

        #region Kādības īpašības vārdi
        [Test, Category("Kādības īpašības vārdi")]
        public void Zils()
        {
            ĪpašībasVārds zils = new ĪpašībasVārds("zils");
            Assert.AreEqual("zil", zils.Celms);
            Assert.AreEqual("zil", zils.PamataPakāpe.Celms);
            Assert.AreEqual("zils", zils.Nominatīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("zili", zils.Nominatīvs(Dzimte.Vīriešu, Skaitlis.Daudzskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("zila", zils.Ģenitīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("zilu", zils.Ģenitīvs(Dzimte.Vīriešu, Skaitlis.Daudzskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("zilam", zils.Datīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("ziliem", zils.Datīvs(Dzimte.Vīriešu, Skaitlis.Daudzskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("zilu", zils.Akuzatīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("zilus", zils.Akuzatīvs(Dzimte.Vīriešu, Skaitlis.Daudzskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("zilā", zils.Lokatīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("zilos", zils.Lokatīvs(Dzimte.Vīriešu, Skaitlis.Daudzskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("zila", zils.Nominatīvs(Dzimte.Sieviešu, Skaitlis.Vienskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("zilas", zils.Nominatīvs(Dzimte.Sieviešu, Skaitlis.Daudzskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("zilas", zils.Ģenitīvs(Dzimte.Sieviešu, Skaitlis.Vienskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("zilu", zils.Ģenitīvs(Dzimte.Sieviešu, Skaitlis.Daudzskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("zilai", zils.Datīvs(Dzimte.Sieviešu, Skaitlis.Vienskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("zilām", zils.Datīvs(Dzimte.Sieviešu, Skaitlis.Daudzskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("zilu", zils.Akuzatīvs(Dzimte.Sieviešu, Skaitlis.Vienskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("zilas", zils.Akuzatīvs(Dzimte.Sieviešu, Skaitlis.Daudzskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("zilā", zils.Lokatīvs(Dzimte.Sieviešu, Skaitlis.Vienskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("zilās", zils.Lokatīvs(Dzimte.Sieviešu, Skaitlis.Daudzskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("zilais", zils.Nominatīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("zilie", zils.Nominatīvs(Dzimte.Vīriešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("zilā", zils.Ģenitīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("zilo", zils.Ģenitīvs(Dzimte.Vīriešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("zilajam", zils.Datīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("zilajiem", zils.Datīvs(Dzimte.Vīriešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("zilo", zils.Akuzatīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("zilos", zils.Akuzatīvs(Dzimte.Vīriešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("zilajā", zils.Lokatīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("zilajos", zils.Lokatīvs(Dzimte.Vīriešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("zilā", zils.Nominatīvs(Dzimte.Sieviešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("zilās", zils.Nominatīvs(Dzimte.Sieviešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("zilās", zils.Ģenitīvs(Dzimte.Sieviešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("zilo", zils.Ģenitīvs(Dzimte.Sieviešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("zilajai", zils.Datīvs(Dzimte.Sieviešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("zilajām", zils.Datīvs(Dzimte.Sieviešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("zilo", zils.Akuzatīvs(Dzimte.Sieviešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("zilās", zils.Akuzatīvs(Dzimte.Sieviešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("zilajā", zils.Lokatīvs(Dzimte.Sieviešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("zilajās", zils.Lokatīvs(Dzimte.Sieviešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));

            Assert.AreEqual("zilāk", zils.PārākāPakāpe.Celms);
            Assert.AreEqual("viszilāk", zils.VispārākāPakāpe.Celms);
        }

        [Test, Category("Kādības īpašības vārdi")]
        public void Apaļš()
        {
            ĪpašībasVārds apaļš = new ĪpašībasVārds("apaļš");
            Assert.AreEqual("apaļ", apaļš.Celms);
            Assert.AreEqual("apaļ", apaļš.PamataPakāpe.Celms);
            Assert.AreEqual("apaļš", apaļš.Nominatīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("apaļi", apaļš.Nominatīvs(Dzimte.Vīriešu, Skaitlis.Daudzskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("apaļa", apaļš.Ģenitīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("apaļu", apaļš.Ģenitīvs(Dzimte.Vīriešu, Skaitlis.Daudzskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("apaļam", apaļš.Datīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("apaļiem", apaļš.Datīvs(Dzimte.Vīriešu, Skaitlis.Daudzskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("apaļu", apaļš.Akuzatīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("apaļus", apaļš.Akuzatīvs(Dzimte.Vīriešu, Skaitlis.Daudzskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("apaļā", apaļš.Lokatīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("apaļos", apaļš.Lokatīvs(Dzimte.Vīriešu, Skaitlis.Daudzskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("apaļa", apaļš.Nominatīvs(Dzimte.Sieviešu, Skaitlis.Vienskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("apaļas", apaļš.Nominatīvs(Dzimte.Sieviešu, Skaitlis.Daudzskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("apaļas", apaļš.Ģenitīvs(Dzimte.Sieviešu, Skaitlis.Vienskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("apaļu", apaļš.Ģenitīvs(Dzimte.Sieviešu, Skaitlis.Daudzskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("apaļai", apaļš.Datīvs(Dzimte.Sieviešu, Skaitlis.Vienskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("apaļām", apaļš.Datīvs(Dzimte.Sieviešu, Skaitlis.Daudzskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("apaļu", apaļš.Akuzatīvs(Dzimte.Sieviešu, Skaitlis.Vienskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("apaļas", apaļš.Akuzatīvs(Dzimte.Sieviešu, Skaitlis.Daudzskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("apaļā", apaļš.Lokatīvs(Dzimte.Sieviešu, Skaitlis.Vienskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("apaļās", apaļš.Lokatīvs(Dzimte.Sieviešu, Skaitlis.Daudzskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("apaļais", apaļš.Nominatīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("apaļie", apaļš.Nominatīvs(Dzimte.Vīriešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("apaļā", apaļš.Ģenitīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("apaļo", apaļš.Ģenitīvs(Dzimte.Vīriešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("apaļajam", apaļš.Datīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("apaļajiem", apaļš.Datīvs(Dzimte.Vīriešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("apaļo", apaļš.Akuzatīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("apaļos", apaļš.Akuzatīvs(Dzimte.Vīriešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("apaļajā", apaļš.Lokatīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("apaļajos", apaļš.Lokatīvs(Dzimte.Vīriešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("apaļā", apaļš.Nominatīvs(Dzimte.Sieviešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("apaļās", apaļš.Nominatīvs(Dzimte.Sieviešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("apaļās", apaļš.Ģenitīvs(Dzimte.Sieviešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("apaļo", apaļš.Ģenitīvs(Dzimte.Sieviešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("apaļajai", apaļš.Datīvs(Dzimte.Sieviešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("apaļajām", apaļš.Datīvs(Dzimte.Sieviešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("apaļo", apaļš.Akuzatīvs(Dzimte.Sieviešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("apaļās", apaļš.Akuzatīvs(Dzimte.Sieviešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("apaļajā", apaļš.Lokatīvs(Dzimte.Sieviešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("apaļajās", apaļš.Lokatīvs(Dzimte.Sieviešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));

            Assert.AreEqual("apaļāk", apaļš.PārākāPakāpe.Celms);
            Assert.AreEqual("visapaļāk", apaļš.VispārākāPakāpe.Celms);
        }
        #endregion

        #region Nelokāmie īpašības vārdi
        [Test, Category("Nelokāmie īpašības vārdi")]
        public void Bordo()
        {
            ĪpašībasVārds bordo = new NelokāmsĪpašībasVārds("bordo");
            Assert.AreEqual("bordo", bordo.Celms);
            
            Assert.AreEqual("bordo", bordo.Nominatīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("bordo", bordo.Nominatīvs(Dzimte.Vīriešu, Skaitlis.Daudzskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("bordo", bordo.Ģenitīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("bordo", bordo.Ģenitīvs(Dzimte.Vīriešu, Skaitlis.Daudzskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("bordo", bordo.Datīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("bordo", bordo.Datīvs(Dzimte.Vīriešu, Skaitlis.Daudzskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("bordo", bordo.Akuzatīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("bordo", bordo.Akuzatīvs(Dzimte.Vīriešu, Skaitlis.Daudzskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("bordo", bordo.Lokatīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("bordo", bordo.Lokatīvs(Dzimte.Vīriešu, Skaitlis.Daudzskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("bordo", bordo.Nominatīvs(Dzimte.Sieviešu, Skaitlis.Vienskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("bordo", bordo.Nominatīvs(Dzimte.Sieviešu, Skaitlis.Daudzskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("bordo", bordo.Ģenitīvs(Dzimte.Sieviešu, Skaitlis.Vienskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("bordo", bordo.Ģenitīvs(Dzimte.Sieviešu, Skaitlis.Daudzskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("bordo", bordo.Datīvs(Dzimte.Sieviešu, Skaitlis.Vienskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("bordo", bordo.Datīvs(Dzimte.Sieviešu, Skaitlis.Daudzskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("bordo", bordo.Akuzatīvs(Dzimte.Sieviešu, Skaitlis.Vienskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("bordo", bordo.Akuzatīvs(Dzimte.Sieviešu, Skaitlis.Daudzskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("bordo", bordo.Lokatīvs(Dzimte.Sieviešu, Skaitlis.Vienskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("bordo", bordo.Lokatīvs(Dzimte.Sieviešu, Skaitlis.Daudzskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("bordo", bordo.Nominatīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("bordo", bordo.Nominatīvs(Dzimte.Vīriešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("bordo", bordo.Ģenitīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("bordo", bordo.Ģenitīvs(Dzimte.Vīriešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("bordo", bordo.Datīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("bordo", bordo.Datīvs(Dzimte.Vīriešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("bordo", bordo.Akuzatīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("bordo", bordo.Akuzatīvs(Dzimte.Vīriešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("bordo", bordo.Lokatīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("bordo", bordo.Lokatīvs(Dzimte.Vīriešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("bordo", bordo.Nominatīvs(Dzimte.Sieviešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("bordo", bordo.Nominatīvs(Dzimte.Sieviešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("bordo", bordo.Ģenitīvs(Dzimte.Sieviešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("bordo", bordo.Ģenitīvs(Dzimte.Sieviešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("bordo", bordo.Datīvs(Dzimte.Sieviešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("bordo", bordo.Datīvs(Dzimte.Sieviešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("bordo", bordo.Akuzatīvs(Dzimte.Sieviešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("bordo", bordo.Akuzatīvs(Dzimte.Sieviešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("bordo", bordo.Lokatīvs(Dzimte.Sieviešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("bordo", bordo.Lokatīvs(Dzimte.Sieviešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));

            Assert.AreEqual("bordo", bordo.PamataPakāpe.Celms);
            Assert.AreEqual("bordo", bordo.PārākāPakāpe.Celms);
            Assert.AreEqual("bordo", bordo.VispārākāPakāpe.Celms);
        }

        [Test, Category("Nelokāmie īpašības vārdi")]
        public void Haki()
        {
            ĪpašībasVārds haki = new NelokāmsĪpašībasVārds("haki");
            Assert.AreEqual("haki", haki.Celms);

            Assert.AreEqual("haki", haki.Nominatīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("haki", haki.Nominatīvs(Dzimte.Vīriešu, Skaitlis.Daudzskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("haki", haki.Ģenitīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("haki", haki.Ģenitīvs(Dzimte.Vīriešu, Skaitlis.Daudzskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("haki", haki.Datīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("haki", haki.Datīvs(Dzimte.Vīriešu, Skaitlis.Daudzskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("haki", haki.Akuzatīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("haki", haki.Akuzatīvs(Dzimte.Vīriešu, Skaitlis.Daudzskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("haki", haki.Lokatīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("haki", haki.Lokatīvs(Dzimte.Vīriešu, Skaitlis.Daudzskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("haki", haki.Nominatīvs(Dzimte.Sieviešu, Skaitlis.Vienskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("haki", haki.Nominatīvs(Dzimte.Sieviešu, Skaitlis.Daudzskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("haki", haki.Ģenitīvs(Dzimte.Sieviešu, Skaitlis.Vienskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("haki", haki.Ģenitīvs(Dzimte.Sieviešu, Skaitlis.Daudzskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("haki", haki.Datīvs(Dzimte.Sieviešu, Skaitlis.Vienskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("haki", haki.Datīvs(Dzimte.Sieviešu, Skaitlis.Daudzskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("haki", haki.Akuzatīvs(Dzimte.Sieviešu, Skaitlis.Vienskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("haki", haki.Akuzatīvs(Dzimte.Sieviešu, Skaitlis.Daudzskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("haki", haki.Lokatīvs(Dzimte.Sieviešu, Skaitlis.Vienskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("haki", haki.Lokatīvs(Dzimte.Sieviešu, Skaitlis.Daudzskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("haki", haki.Nominatīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("haki", haki.Nominatīvs(Dzimte.Vīriešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("haki", haki.Ģenitīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("haki", haki.Ģenitīvs(Dzimte.Vīriešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("haki", haki.Datīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("haki", haki.Datīvs(Dzimte.Vīriešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("haki", haki.Akuzatīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("haki", haki.Akuzatīvs(Dzimte.Vīriešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("haki", haki.Lokatīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("haki", haki.Lokatīvs(Dzimte.Vīriešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("haki", haki.Nominatīvs(Dzimte.Sieviešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("haki", haki.Nominatīvs(Dzimte.Sieviešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("haki", haki.Ģenitīvs(Dzimte.Sieviešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("haki", haki.Ģenitīvs(Dzimte.Sieviešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("haki", haki.Datīvs(Dzimte.Sieviešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("haki", haki.Datīvs(Dzimte.Sieviešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("haki", haki.Akuzatīvs(Dzimte.Sieviešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("haki", haki.Akuzatīvs(Dzimte.Sieviešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("haki", haki.Lokatīvs(Dzimte.Sieviešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("haki", haki.Lokatīvs(Dzimte.Sieviešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));

            Assert.AreEqual("haki", haki.PamataPakāpe.Celms);
            Assert.AreEqual("haki", haki.PārākāPakāpe.Celms);
            Assert.AreEqual("haki", haki.VispārākāPakāpe.Celms);
        }

        [Test, Category("Nelokāmie īpašības vārdi")]
        public void Rozā()
        {
            ĪpašībasVārds rozā = new NelokāmsĪpašībasVārds("rozā");
            Assert.AreEqual("rozā", rozā.Celms);

            Assert.AreEqual("rozā", rozā.Nominatīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("rozā", rozā.Nominatīvs(Dzimte.Vīriešu, Skaitlis.Daudzskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("rozā", rozā.Ģenitīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("rozā", rozā.Ģenitīvs(Dzimte.Vīriešu, Skaitlis.Daudzskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("rozā", rozā.Datīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("rozā", rozā.Datīvs(Dzimte.Vīriešu, Skaitlis.Daudzskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("rozā", rozā.Akuzatīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("rozā", rozā.Akuzatīvs(Dzimte.Vīriešu, Skaitlis.Daudzskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("rozā", rozā.Lokatīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("rozā", rozā.Lokatīvs(Dzimte.Vīriešu, Skaitlis.Daudzskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("rozā", rozā.Nominatīvs(Dzimte.Sieviešu, Skaitlis.Vienskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("rozā", rozā.Nominatīvs(Dzimte.Sieviešu, Skaitlis.Daudzskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("rozā", rozā.Ģenitīvs(Dzimte.Sieviešu, Skaitlis.Vienskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("rozā", rozā.Ģenitīvs(Dzimte.Sieviešu, Skaitlis.Daudzskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("rozā", rozā.Datīvs(Dzimte.Sieviešu, Skaitlis.Vienskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("rozā", rozā.Datīvs(Dzimte.Sieviešu, Skaitlis.Daudzskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("rozā", rozā.Akuzatīvs(Dzimte.Sieviešu, Skaitlis.Vienskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("rozā", rozā.Akuzatīvs(Dzimte.Sieviešu, Skaitlis.Daudzskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("rozā", rozā.Lokatīvs(Dzimte.Sieviešu, Skaitlis.Vienskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("rozā", rozā.Lokatīvs(Dzimte.Sieviešu, Skaitlis.Daudzskaitlis, Galotne.Nenoteiktā));
            Assert.AreEqual("rozā", rozā.Nominatīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("rozā", rozā.Nominatīvs(Dzimte.Vīriešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("rozā", rozā.Ģenitīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("rozā", rozā.Ģenitīvs(Dzimte.Vīriešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("rozā", rozā.Datīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("rozā", rozā.Datīvs(Dzimte.Vīriešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("rozā", rozā.Akuzatīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("rozā", rozā.Akuzatīvs(Dzimte.Vīriešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("rozā", rozā.Lokatīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("rozā", rozā.Lokatīvs(Dzimte.Vīriešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("rozā", rozā.Nominatīvs(Dzimte.Sieviešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("rozā", rozā.Nominatīvs(Dzimte.Sieviešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("rozā", rozā.Ģenitīvs(Dzimte.Sieviešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("rozā", rozā.Ģenitīvs(Dzimte.Sieviešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("rozā", rozā.Datīvs(Dzimte.Sieviešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("rozā", rozā.Datīvs(Dzimte.Sieviešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("rozā", rozā.Akuzatīvs(Dzimte.Sieviešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("rozā", rozā.Akuzatīvs(Dzimte.Sieviešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("rozā", rozā.Lokatīvs(Dzimte.Sieviešu, Skaitlis.Vienskaitlis, Galotne.Noteiktā));
            Assert.AreEqual("rozā", rozā.Lokatīvs(Dzimte.Sieviešu, Skaitlis.Daudzskaitlis, Galotne.Noteiktā));

            Assert.AreEqual("rozā", rozā.PamataPakāpe.Celms);
            Assert.AreEqual("rozā", rozā.PārākāPakāpe.Celms);
            Assert.AreEqual("rozā", rozā.VispārākāPakāpe.Celms);
        }
        #endregion

        [Test]
        public void Ātrdarbība()
        {
            var stopwatch = new System.Diagnostics.Stopwatch();

            var locījumi = (Locījums[])System.Enum.GetValues(typeof(Locījums));
            var skaitļi = (Skaitlis[])System.Enum.GetValues(typeof(Skaitlis));
            var galotnes = (Galotne[])System.Enum.GetValues(typeof(Galotne));
            var dzimtes = (Dzimte[])System.Enum.GetValues(typeof(Dzimte));

            stopwatch.Start();

            ĪpašībasVārds apaļš = new ĪpašībasVārds("apaļš");
            foreach (Locījums locījums in locījumi)
                foreach (Skaitlis skaitlis in skaitļi)
                    foreach (Galotne galotne in galotnes)
                        foreach (Dzimte dzimte in dzimtes)
                            apaļš.Locīt(locījums, dzimte, skaitlis, galotne);

            stopwatch.Stop();

            Assert.That(stopwatch.ElapsedMilliseconds, Is.LessThanOrEqualTo(10 * 40));
        }
    }
}
