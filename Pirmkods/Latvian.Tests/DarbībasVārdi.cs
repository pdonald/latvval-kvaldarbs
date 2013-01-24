using System.Collections.Generic;

using NUnit.Framework;

using Latvian.Vārdšķiras;
using Latvian.Vārdšķiras.DarbībasVārdi;

namespace Latvian.Testi
{
    [TestFixture]
    public class DarbībasVārduTesti
    {
        public struct DarbībasVārduFormas
        {
            public string Nenoteiksmē;
            public string Tagadnē;
            public string Pagātnē;
            public Konjugācija Konjugācija;
            public int Grupa;

            public DarbībasVārduFormas(string nenoteiksme, string tagadne, string pagātne, 
                Konjugācija konjugācija, int grupa)
            {
                Nenoteiksmē = nenoteiksme;
                Tagadnē = tagadne;
                Pagātnē = pagātne;
                Konjugācija = konjugācija;
                Grupa = grupa;
            }
        }

        protected List<DarbībasVārduFormas> vārdi;

        [TestFixtureSetUp]
        public void IelasītDarbībasVārdus()
        {
            vārdi = new List<DarbībasVārduFormas>();
            vārdi.Add(new DarbībasVārduFormas("celties", "ceļos", "cēlos", Konjugācija.I, 4));
            vārdi.Add(new DarbībasVārduFormas("nirt", "nirstu", "niru", Konjugācija.I, 5));
            vārdi.Add(new DarbībasVārduFormas("skatīties", "skatos", "skatījos", Konjugācija.III, 1));
            vārdi.Add(new DarbībasVārduFormas("urbt", "urbju", "urbu", Konjugācija.I, 4));
            vārdi.Add(new DarbībasVārduFormas("lemt", "lemju", "lēmu", Konjugācija.I, 4));
            vārdi.Add(new DarbībasVārduFormas("čiept", "čiepju", "čiepu", Konjugācija.I, 4));
            vārdi.Add(new DarbībasVārduFormas("dzēst", "dzēšu", "dzēsu", Konjugācija.I, 4));
            vārdi.Add(new DarbībasVārduFormas("lauzt", "laužu", "lauzu", Konjugācija.I, 4));
            vārdi.Add(new DarbībasVārduFormas("vilkt", "velku", "vilku", Konjugācija.I, 4));
            vārdi.Add(new DarbībasVārduFormas("bēgt", "bēgu", "bēgu", Konjugācija.I, 4));
            vārdi.Add(new DarbībasVārduFormas("mācēt", "māku", "mācēju", Konjugācija.III, 2));
            vārdi.Add(new DarbībasVārduFormas("mocīties", "mokos", "mocījos", Konjugācija.III, 1));
            vārdi.Add(new DarbībasVārduFormas("locīt", "loku", "locīju", Konjugācija.III, 1));
            vārdi.Add(new DarbībasVārduFormas("apraudzīt", "apraugu", "apraudzīju", Konjugācija.III, 1));
            vārdi.Add(new DarbībasVārduFormas("augt", "augu", "augu", Konjugācija.I, 1));
            vārdi.Add(new DarbībasVārduFormas("nākt", "nāku", "nācu", Konjugācija.I, 1));
            vārdi.Add(new DarbībasVārduFormas("nest", "nesu", "nesu", Konjugācija.I, 1));
            vārdi.Add(new DarbībasVārduFormas("vest", "vedu", "vedu", Konjugācija.I, 1));
            vārdi.Add(new DarbībasVārduFormas("mīt", "minu", "minu", Konjugācija.I, 1));
            vārdi.Add(new DarbībasVārduFormas("vīt", "viju", "viju", Konjugācija.I, 1));
            vārdi.Add(new DarbībasVārduFormas("liet", "leju", "lēju", Konjugācija.I, 1));
            vārdi.Add(new DarbībasVārduFormas("krimst", "kremtu", "krimtu", Konjugācija.I, 2));
            vārdi.Add(new DarbībasVārduFormas("cirpt", "cērpu", "cirpu", Konjugācija.I, 2));
            vārdi.Add(new DarbībasVārduFormas("likt", "lieku", "liku", Konjugācija.I, 2));
            vārdi.Add(new DarbībasVārduFormas("dzīt", "dzenu", "dzinu", Konjugācija.I, 2));
            vārdi.Add(new DarbībasVārduFormas("rakt", "roku", "raku", Konjugācija.I, 3));
            vārdi.Add(new DarbībasVārduFormas("krist", "krītu", "kritu", Konjugācija.I, 3));
            vārdi.Add(new DarbībasVārduFormas("just", "jūtu", "jutu", Konjugācija.I, 3));
            vārdi.Add(new DarbībasVārduFormas("skriet", "skrienu", "skrēju", Konjugācija.I, 3));
            vārdi.Add(new DarbībasVārduFormas("aut", "aunu", "āvu", Konjugācija.I, 3));
            vārdi.Add(new DarbībasVārduFormas("tikt", "tieku", "tiku", Konjugācija.I, 3));
            vārdi.Add(new DarbībasVārduFormas("celt", "ceļu", "cēlu", Konjugācija.I, 4));
            vārdi.Add(new DarbībasVārduFormas("pūst", "pūšu", "pūtu", Konjugācija.I, 4));
            vārdi.Add(new DarbībasVārduFormas("belzt", "belžu", "belzu", Konjugācija.I, 4));
            vārdi.Add(new DarbībasVārduFormas("kāpt", "kāpju", "kāpu", Konjugācija.I, 4));
            vārdi.Add(new DarbībasVārduFormas("glābt", "glābju", "glābu", Konjugācija.I, 4));
            vārdi.Add(new DarbībasVārduFormas("stumt", "stumju", "stūmu", Konjugācija.I, 4));
            vārdi.Add(new DarbībasVārduFormas("braukt", "braucu", "braucu", Konjugācija.I, 4));
            vārdi.Add(new DarbībasVārduFormas("spiest", "spiežu", "spiedu", Konjugācija.I, 4));
            vārdi.Add(new DarbībasVārduFormas("lūgt", "lūdzu", "lūdzu", Konjugācija.I, 4));
            vārdi.Add(new DarbībasVārduFormas("pļaut", "pļauju", "pļāvu", Konjugācija.I, 4));
            vārdi.Add(new DarbībasVārduFormas("šūt", "šuju", "šuvu", Konjugācija.I, 4));
            vārdi.Add(new DarbībasVārduFormas("sēt", "sēju", "sēju", Konjugācija.I, 4));
            vārdi.Add(new DarbībasVārduFormas("bērt", "beru", "bēru", Konjugācija.I, 4));
            vārdi.Add(new DarbībasVārduFormas("silt", "silstu", "silu", Konjugācija.I, 5));
            vārdi.Add(new DarbībasVārduFormas("atbilst", "atbilstu", "atbildu", Konjugācija.I, 5));
            vārdi.Add(new DarbībasVārduFormas("strādāt", "strādāju", "strādāju", Konjugācija.II, 0));
            vārdi.Add(new DarbībasVārduFormas("zīmēt", "zīmēju", "zīmēju", Konjugācija.II, 0));
            vārdi.Add(new DarbībasVārduFormas("medīt", "medīju", "medīju", Konjugācija.II, 0));
            vārdi.Add(new DarbībasVārduFormas("dejot", "dejoju", "dejoju", Konjugācija.II, 0));
            vārdi.Add(new DarbībasVārduFormas("lasīt", "lasu", "lasīju", Konjugācija.III, 1));
            vārdi.Add(new DarbībasVārduFormas("valdzināt", "valdzinu", "valdzināju", Konjugācija.III, 2));
            vārdi.Add(new DarbībasVārduFormas("gribēt", "gribu", "gribēju", Konjugācija.III, 2));
            vārdi.Add(new DarbībasVārduFormas("raudāt", "raudu", "raudāju", Konjugācija.III, 2));
            vārdi.Add(new DarbībasVārduFormas("domāt", "domāju", "domāju", Konjugācija.II, 0));
            vārdi.Add(new DarbībasVārduFormas("skatīt", "skatu", "skatīju", Konjugācija.III, 1));
            vārdi.Add(new DarbībasVārduFormas("gadīties", "gados", "gadījos", Konjugācija.III, 1));
            vārdi.Add(new DarbībasVārduFormas("smīdināt", "smīdinu", "smīdināju", Konjugācija.III, 1));
            vārdi.Add(new DarbībasVārduFormas("vicināt", "vicinu", "vicināju", Konjugācija.III, 1));
            vārdi.Add(new DarbībasVārduFormas("sasveicināties", "sasveicinos", "sasveicinājos", Konjugācija.III, 1));
            vārdi.Add(new DarbībasVārduFormas("grabināties", "grabinos", "grabinājos", Konjugācija.III, 1));
            vārdi.Add(new DarbībasVārduFormas("zināt", "zinu", "zināju", Konjugācija.III, 1));
            vārdi.Add(new DarbībasVārduFormas("dziedāt", "dziedu", "dziedāju", Konjugācija.III, 2));
            vārdi.Add(new DarbībasVārduFormas("redzēt", "redzu", "redzēju", Konjugācija.III, 2));
            vārdi.Add(new DarbībasVārduFormas("kaunēties", "kaunos", "kaunējos", Konjugācija.III, 2));
            vārdi.Add(new DarbībasVārduFormas("turēties", "turos", "turējos", Konjugācija.III, 2));
        }

        public DarbībasVārds DabūtDarbībasVārdu(string nenoteiksme)
        {
            foreach (DarbībasVārduFormas vārds in vārdi)
            {
                if (vārds.Nenoteiksmē == nenoteiksme)
                {
                    return new DarbībasVārds(vārds.Nenoteiksmē, vārds.Tagadnē, vārds.Pagātnē, vārds.Konjugācija, vārds.Grupa);
                }
            }

            return null;
        }

        [Test]
        public void ĪstenībasIzteiksmesVienkāršāTagadne()
        {
            #region Piemēri
            DarbībasVārds celties = DabūtDarbībasVārdu("celties");
            Assert.AreEqual("ceļos", celties.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("celies", celties.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("ceļamies", celties.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("ceļaties", celties.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("ceļas", celties.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("ceļas", celties.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds nirt = DabūtDarbībasVārdu("nirt");
            Assert.AreEqual("nirstu", nirt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("nirsti", nirt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("nirstam", nirt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("nirstat", nirt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("nirst", nirt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("nirst", nirt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));


            DarbībasVārds gribēt = DabūtDarbībasVārdu("gribēt");
            Assert.AreEqual("gribu", gribēt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("gribi", gribēt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("gribam", gribēt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("gribat", gribēt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("grib", gribēt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("grib", gribēt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));
            #endregion Piemēri

            #region Līdzskaņu mijas
            DarbībasVārds urbt = DabūtDarbībasVārdu("urbt");
            Assert.AreEqual("urbju", urbt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("urb", urbt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("urbjam", urbt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("urbjat", urbt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("urbj", urbt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("urbj", urbt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds lemt = DabūtDarbībasVārdu("lemt");
            Assert.AreEqual("lemju", lemt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("lem", lemt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("lemjam", lemt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("lemjat", lemt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("lemj", lemt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("lemj", lemt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds čiept = DabūtDarbībasVārdu("čiept");
            Assert.AreEqual("čiepju", čiept.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("čiep", čiept.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("čiepjam", čiept.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("čiepjat", čiept.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("čiepj", čiept.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("čiepj", čiept.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds celt = DabūtDarbībasVārdu("celt");
            Assert.AreEqual("ceļu", celt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("cel", celt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("ceļam", celt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("ceļat", celt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("ceļ", celt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("ceļ", celt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds dzēst = DabūtDarbībasVārdu("dzēst");
            Assert.AreEqual("dzēšu", dzēst.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("dzēs", dzēst.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("dzēšam", dzēst.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("dzēšat", dzēst.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("dzēš", dzēst.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("dzēš", dzēst.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds lauzt = DabūtDarbībasVārdu("lauzt");
            Assert.AreEqual("laužu", lauzt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("lauz", lauzt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("laužam", lauzt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("laužat", lauzt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("lauž", lauzt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("lauž", lauzt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds vilkt = DabūtDarbībasVārdu("vilkt");
            Assert.AreEqual("velku", vilkt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("velc", vilkt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("velkam", vilkt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("velkat", vilkt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("velk", vilkt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("velk", vilkt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds bēgt = DabūtDarbībasVārdu("bēgt");
            Assert.AreEqual("bēgu", bēgt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("bēdz", bēgt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("bēgam", bēgt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("bēgat", bēgt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("bēg", bēgt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("bēg", bēgt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds mācēt = DabūtDarbībasVārdu("mācēt");
            Assert.AreEqual("māku", mācēt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("māki", mācēt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("mākam", mācēt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("mākat", mācēt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("māk", mācēt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("māk", mācēt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds mocīties = DabūtDarbībasVārdu("mocīties");
            Assert.AreEqual("mokos", mocīties.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("mokies", mocīties.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("mokāmies", mocīties.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("mokāties", mocīties.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("mokās", mocīties.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("mokās", mocīties.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds locīt = DabūtDarbībasVārdu("locīt");
            Assert.AreEqual("loku", locīt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("loki", locīt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("lokām", locīt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("lokāt", locīt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("loka", locīt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("loka", locīt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds apraudzīt = DabūtDarbībasVārdu("apraudzīt");
            Assert.AreEqual("apraugu", apraudzīt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("apraugi", apraudzīt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("apraugām", apraudzīt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("apraugāt", apraudzīt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("aprauga", apraudzīt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("aprauga", apraudzīt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));
            #endregion Līdzskaņu mijas

            #region I konjugācija 1. grupa
            DarbībasVārds augt = DabūtDarbībasVārdu("augt");
            Assert.AreEqual("augu", augt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("audz", augt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("augam", augt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("augat", augt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("aug", augt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("aug", augt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds nākt = DabūtDarbībasVārdu("nākt");
            Assert.AreEqual("nāku", nākt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("nāc", nākt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("nākam", nākt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("nākat", nākt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("nāk", nākt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("nāk", nākt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds nest = DabūtDarbībasVārdu("nest");
            Assert.AreEqual("nesu", nest.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("nes", nest.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("nesam", nest.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("nesat", nest.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("nes", nest.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("nes", nest.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds vest = DabūtDarbībasVārdu("vest");
            Assert.AreEqual("vedu", vest.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("ved", vest.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("vedam", vest.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("vedat", vest.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("ved", vest.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("ved", vest.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds mīt = DabūtDarbībasVārdu("mīt");
            Assert.AreEqual("minu", mīt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("min", mīt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("minam", mīt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("minat", mīt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("min", mīt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("min", mīt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds vīt = DabūtDarbībasVārdu("vīt");
            Assert.AreEqual("viju", vīt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("vij", vīt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("vijam", vīt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("vijat", vīt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("vij", vīt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("vij", vīt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds liet = DabūtDarbībasVārdu("liet");
            Assert.AreEqual("leju", liet.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("lej", liet.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("lejam", liet.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("lejat", liet.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("lej", liet.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("lej", liet.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));
            #endregion I konjugācija 1. grupa

            #region I konjugācija 2. grupa
            DarbībasVārds krimst = DabūtDarbībasVārdu("krimst");
            Assert.AreEqual("kremtu", krimst.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("kremt", krimst.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("kremtam", krimst.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("kremtat", krimst.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("kremt", krimst.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("kremt", krimst.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds cirpt = DabūtDarbībasVārdu("cirpt");
            Assert.AreEqual("cērpu", cirpt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("cērp", cirpt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("cērpam", cirpt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("cērpat", cirpt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("cērp", cirpt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("cērp", cirpt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds likt = DabūtDarbībasVārdu("likt");
            Assert.AreEqual("lieku", likt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("liec", likt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("liekam", likt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("liekat", likt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("liek", likt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("liek", likt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds dzīt = DabūtDarbībasVārdu("dzīt");
            Assert.AreEqual("dzenu", dzīt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("dzen", dzīt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("dzenam", dzīt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("dzenat", dzīt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("dzen", dzīt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("dzen", dzīt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));
            #endregion I konjugācija 2. grupa

            #region I konjugācija 3. grupa
            DarbībasVārds rakt = DabūtDarbībasVārdu("rakt");
            Assert.AreEqual("roku", rakt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("roc", rakt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("rokam", rakt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("rokat", rakt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("rok", rakt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("rok", rakt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds krist = DabūtDarbībasVārdu("krist");
            Assert.AreEqual("krītu", krist.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("krīti", krist.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("krītam", krist.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("krītat", krist.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("krīt", krist.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("krīt", krist.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds just = DabūtDarbībasVārdu("just");
            Assert.AreEqual("jūtu", just.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("jūti", just.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("jūtam", just.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("jūtat", just.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("jūt", just.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("jūt", just.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds skriet = DabūtDarbībasVārdu("skriet");
            Assert.AreEqual("skrienu", skriet.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("skrien", skriet.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("skrienam", skriet.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("skrienat", skriet.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("skrien", skriet.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("skrien", skriet.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds aut = DabūtDarbībasVārdu("aut");
            Assert.AreEqual("aunu", aut.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("aun", aut.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("aunam", aut.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("aunat", aut.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("aun", aut.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("aun", aut.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds tikt = DabūtDarbībasVārdu("tikt");
            Assert.AreEqual("tieku", tikt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("tiec", tikt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("tiekam", tikt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("tiekat", tikt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("tiek", tikt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("tiek", tikt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));
            #endregion I konjugācija 3. grupa

            #region I konjugācija 4. grupa
            DarbībasVārds pūst = DabūtDarbībasVārdu("pūst");
            Assert.AreEqual("pūšu", pūst.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            //Assert.AreEqual("pūt", pūst.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("pūšam", pūst.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("pūšat", pūst.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("pūš", pūst.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("pūš", pūst.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds belzt = DabūtDarbībasVārdu("belzt");
            Assert.AreEqual("belžu", belzt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("belz", belzt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("belžam", belzt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("belžat", belzt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("belž", belzt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("belž", belzt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds kāpt = DabūtDarbībasVārdu("kāpt");
            Assert.AreEqual("kāpju", kāpt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("kāp", kāpt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("kāpjam", kāpt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("kāpjat", kāpt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("kāpj", kāpt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("kāpj", kāpt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds glābt = DabūtDarbībasVārdu("glābt");
            Assert.AreEqual("glābju", glābt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("glāb", glābt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("glābjam", glābt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("glābjat", glābt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("glābj", glābt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("glābj", glābt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds stumt = DabūtDarbībasVārdu("stumt");
            Assert.AreEqual("stumju", stumt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("stum", stumt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("stumjam", stumt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("stumjat", stumt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("stumj", stumt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("stumj", stumt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds braukt = DabūtDarbībasVārdu("braukt");
            Assert.AreEqual("braucu", braukt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("brauc", braukt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("braucam", braukt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("braucat", braukt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("brauc", braukt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("brauc", braukt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds lūgt = DabūtDarbībasVārdu("lūgt");
            Assert.AreEqual("lūdzu", lūgt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("lūdz", lūgt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("lūdzam", lūgt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("lūdzat", lūgt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("lūdz", lūgt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("lūdz", lūgt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));
            #endregion I konjugācija 4. grupa

            #region I konjugācija 5. grupa
            DarbībasVārds silt = DabūtDarbībasVārdu("silt");
            Assert.AreEqual("silstu", silt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("silsti", silt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("silstam", silt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("silstat", silt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("silst", silt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("silst", silt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds atbilst = DabūtDarbībasVārdu("atbilst");
            Assert.AreEqual("atbilstu", atbilst.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("atbilsti", atbilst.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("atbilstam", atbilst.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("atbilstat", atbilst.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("atbilst", atbilst.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("atbilst", atbilst.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));
            #endregion I konjugācija 5. grupa

            #region II konjugācija
            DarbībasVārds strādāt = DabūtDarbībasVārdu("strādāt");
            Assert.AreEqual("strādāju", strādāt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("strādā", strādāt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("strādājam", strādāt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("strādājat", strādāt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("strādā", strādāt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("strādā", strādāt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds zīmēt = DabūtDarbībasVārdu("zīmēt");
            Assert.AreEqual("zīmēju", zīmēt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("zīmē", zīmēt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("zīmējam", zīmēt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("zīmējat", zīmēt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("zīmē", zīmēt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("zīmē", zīmēt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds medīt = DabūtDarbībasVārdu("medīt");
            Assert.AreEqual("medīju", medīt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("medī", medīt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("medījam", medīt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("medījat", medīt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("medī", medīt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("medī", medīt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds dejot = DabūtDarbībasVārdu("dejot");
            Assert.AreEqual("dejoju", dejot.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("dejo", dejot.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("dejojam", dejot.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("dejojat", dejot.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("dejo", dejot.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("dejo", dejot.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds domāt = DabūtDarbībasVārdu("domāt");
            Assert.AreEqual("domāju", domāt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("domā", domāt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("domājam", domāt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("domājat", domāt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("domā", domāt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("domā", domāt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));
            #endregion II konjugācija

            #region III konjugācija 1. grupa
            DarbībasVārds lasīt = DabūtDarbībasVārdu("lasīt");
            Assert.AreEqual("lasu", lasīt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("lasi", lasīt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("lasām", lasīt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("lasāt", lasīt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("lasa", lasīt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("lasa", lasīt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds skatīt = DabūtDarbībasVārdu("skatīt");
            Assert.AreEqual("skatu", skatīt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("skati", skatīt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("skatām", skatīt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("skatāt", skatīt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("skata", skatīt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("skata", skatīt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds skatīties = DabūtDarbībasVārdu("skatīties");
            Assert.AreEqual("skatos", skatīties.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("skaties", skatīties.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("skatāmies", skatīties.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("skatāties", skatīties.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("skatās", skatīties.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("skatās", skatīties.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds gadīties = DabūtDarbībasVārdu("gadīties");
            Assert.AreEqual("gados", gadīties.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("gadies", gadīties.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("gadāmies", gadīties.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("gadāties", gadīties.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("gadās", gadīties.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("gadās", gadīties.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds smīdināt = DabūtDarbībasVārdu("smīdināt");
            Assert.AreEqual("smīdinu", smīdināt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("smīdini", smīdināt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("smīdinām", smīdināt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("smīdināt", smīdināt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("smīdina", smīdināt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("smīdina", smīdināt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds vicināt = DabūtDarbībasVārdu("vicināt");
            Assert.AreEqual("vicinu", vicināt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("vicini", vicināt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("vicinām", vicināt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("vicināt", vicināt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("vicina", vicināt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("vicina", vicināt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds sveicināties = DabūtDarbībasVārdu("sasveicināties");
            Assert.AreEqual("sasveicinos", sveicināties.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("sasveicinies", sveicināties.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("sasveicināmies", sveicināties.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("sasveicināties", sveicināties.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("sasveicinās", sveicināties.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("sasveicinās", sveicināties.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds grabināties = DabūtDarbībasVārdu("grabināties");
            Assert.AreEqual("grabinos", grabināties.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("grabinies", grabināties.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("grabināmies", grabināties.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("grabināties", grabināties.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("grabinās", grabināties.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("grabinās", grabināties.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds zināt = DabūtDarbībasVārdu("zināt");
            Assert.AreEqual("zinu", zināt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("zini", zināt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("zinām", zināt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("zināt", zināt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("zina", zināt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("zina", zināt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));
            #endregion III kongjugācija 1. grupa

            #region III konjugācija 2. grupa
            DarbībasVārds dziedāt = DabūtDarbībasVārdu("dziedāt");
            Assert.AreEqual("dziedu", dziedāt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("dziedi", dziedāt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("dziedam", dziedāt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("dziedat", dziedāt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("dzied", dziedāt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("dzied", dziedāt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds redzēt = DabūtDarbībasVārdu("redzēt");
            Assert.AreEqual("redzu", redzēt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("redzi", redzēt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("redzam", redzēt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("redzat", redzēt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("redz", redzēt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("redz", redzēt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds kaunēties = DabūtDarbībasVārdu("kaunēties");
            Assert.AreEqual("kaunos", kaunēties.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("kaunies", kaunēties.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("kaunamies", kaunēties.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("kaunaties", kaunēties.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("kaunas", kaunēties.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("kaunas", kaunēties.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds turēties = DabūtDarbībasVārdu("turēties");
            Assert.AreEqual("turos", turēties.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("turies", turēties.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("turamies", turēties.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("turaties", turēties.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("turas", turēties.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("turas", turēties.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));
            #endregion
        }

        [Test]
        public void ĪstenībasIzteiksmesVienkāršāPagātne()
        {
            #region Piemēri
            DarbībasVārds celt = DabūtDarbībasVārdu("celt");
            Assert.AreEqual("cēlu", celt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("cēli", celt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("cēlām", celt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("cēlāt", celt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("cēla", celt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("cēla", celt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds celties = DabūtDarbībasVārdu("celties");
            Assert.AreEqual("cēlos", celties.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("cēlies", celties.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("cēlāmies", celties.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("cēlāties", celties.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("cēlās", celties.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("cēlās", celties.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds nirt = DabūtDarbībasVārdu("nirt");
            Assert.AreEqual("niru", nirt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("niri", nirt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("nirām", nirt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("nirāt", nirt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("nira", nirt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("nira", nirt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds just = DabūtDarbībasVārdu("just");
            Assert.AreEqual("jutu", just.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("juti", just.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("jutām", just.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("jutāt", just.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("juta", just.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("juta", just.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds zīmēt = DabūtDarbībasVārdu("zīmēt");
            Assert.AreEqual("zīmēju", zīmēt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("zīmēji", zīmēt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("zīmējām", zīmēt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("zīmējāt", zīmēt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("zīmēja", zīmēt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("zīmēja", zīmēt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds lasīt = DabūtDarbībasVārdu("lasīt");
            Assert.AreEqual("lasīju", lasīt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("lasīji", lasīt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("lasījām", lasīt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("lasījāt", lasīt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("lasīja", lasīt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("lasīja", lasīt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds skatīties = DabūtDarbībasVārdu("skatīties");
            Assert.AreEqual("skatījos", skatīties.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("skatījies", skatīties.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("skatījāmies", skatīties.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("skatījāties", skatīties.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("skatījās", skatīties.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("skatījās", skatīties.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds gribēt = DabūtDarbībasVārdu("gribēt");
            Assert.AreEqual("gribēju", gribēt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("gribēji", gribēt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("gribējām", gribēt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("gribējāt", gribēt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("gribēja", gribēt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("gribēja", gribēt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaTrešāPersona));
            #endregion
        }

        [Test]
        public void ĪstenībasIzteiksmesVienkāršāNākotne()
        {
            #region Piemēri
            DarbībasVārds celt = DabūtDarbībasVārdu("celt");
            Assert.AreEqual("celšu", celt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("celsi", celt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("celsim", celt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("celsiet", celt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("cels", celt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("cels", celt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds celties = DabūtDarbībasVārdu("celties");
            Assert.AreEqual("celšos", celties.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("celsies", celties.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("celsimies", celties.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("celsieties", celties.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("celsies", celties.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("celsies", celties.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds nirt = DabūtDarbībasVārdu("nirt");
            Assert.AreEqual("niršu", nirt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("nirsi", nirt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("nirsim", nirt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("nirsiet", nirt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("nirs", nirt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("nirs", nirt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds zīmēt = DabūtDarbībasVārdu("zīmēt");
            Assert.AreEqual("zīmēšu", zīmēt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("zīmēsi", zīmēt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("zīmēsim", zīmēt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("zīmēsiet", zīmēt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("zīmēs", zīmēt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("zīmēs", zīmēt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds lasīt = DabūtDarbībasVārdu("lasīt");
            Assert.AreEqual("lasīšu", lasīt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("lasīsi", lasīt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("lasīsim", lasīt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("lasīsiet", lasīt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("lasīs", lasīt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("lasīs", lasīt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds skatīties = DabūtDarbībasVārdu("skatīties");
            Assert.AreEqual("skatīšos", skatīties.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("skatīsies", skatīties.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("skatīsimies", skatīties.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("skatīsieties", skatīties.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("skatīsies", skatīties.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("skatīsies", skatīties.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds gribēt = DabūtDarbībasVārdu("gribēt");
            Assert.AreEqual("gribēšu", gribēt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("gribēsi", gribēt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("gribēsim", gribēt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("gribēsiet", gribēt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("gribēs", gribēt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("gribēs", gribēt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaTrešāPersona));
            #endregion

            #region I konjugācija 1. grupa
            DarbībasVārds augt = DabūtDarbībasVārdu("augt");
            Assert.AreEqual("augšu", augt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("augsi", augt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("augsim", augt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("augsiet", augt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("augs", augt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("augs", augt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds nākt = DabūtDarbībasVārdu("nākt");
            Assert.AreEqual("nākšu", nākt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("nāksi", nākt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("nāksim", nākt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("nāksiet", nākt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("nāks", nākt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("nāks", nākt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds nest = DabūtDarbībasVārdu("nest");
            Assert.AreEqual("nesīšu", nest.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("nesīsi", nest.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("nesīsim", nest.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("nesīsiet", nest.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("nesīs", nest.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("nesīs", nest.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds vest = DabūtDarbībasVārdu("vest");
            Assert.AreEqual("vedīšu", vest.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("vedīsi", vest.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("vedīsim", vest.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("vedīsiet", vest.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("vedīs", vest.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("vedīs", vest.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds mīt = DabūtDarbībasVārdu("mīt");
            Assert.AreEqual("mīšu", mīt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("mīsi", mīt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("mīsim", mīt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("mīsiet", mīt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("mīs", mīt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("mīs", mīt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds vīt = DabūtDarbībasVārdu("vīt");
            Assert.AreEqual("vīšu", vīt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("vīsi", vīt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("vīsim", vīt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("vīsiet", vīt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("vīs", vīt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("vīs", vīt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds liet = DabūtDarbībasVārdu("liet");
            Assert.AreEqual("liešu", liet.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("liesi", liet.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("liesim", liet.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("liesiet", liet.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("lies", liet.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("lies", liet.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaTrešāPersona));
            #endregion I konjugācija 1. grupa

            #region I konjugācija 2. grupa
            DarbībasVārds krimst = DabūtDarbībasVārdu("krimst");
            Assert.AreEqual("krimtīšu", krimst.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("krimtīsi", krimst.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("krimtīsim", krimst.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("krimtīsiet", krimst.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("krimtīs", krimst.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("krimtīs", krimst.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds cirpt = DabūtDarbībasVārdu("cirpt");
            Assert.AreEqual("cirpšu", cirpt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("cirpsi", cirpt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("cirpsim", cirpt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("cirpsiet", cirpt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("cirps", cirpt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("cirps", cirpt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds likt = DabūtDarbībasVārdu("likt");
            Assert.AreEqual("likšu", likt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("liksi", likt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("liksim", likt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("liksiet", likt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("liks", likt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("liks", likt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds dzīt = DabūtDarbībasVārdu("dzīt");
            Assert.AreEqual("dzīšu", dzīt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("dzīsi", dzīt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("dzīsim", dzīt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("dzīsiet", dzīt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("dzīs", dzīt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("dzīs", dzīt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaTrešāPersona));
            #endregion I konjugācija 2. grupa

            #region I konjugācija 3. grupa
            DarbībasVārds rakt = DabūtDarbībasVārdu("rakt");
            Assert.AreEqual("rakšu", rakt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("raksi", rakt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("raksim", rakt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("raksiet", rakt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("raks", rakt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("raks", rakt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds krist = DabūtDarbībasVārdu("krist");
            Assert.AreEqual("kritīšu", krist.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("kritīsi", krist.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("kritīsim", krist.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("kritīsiet", krist.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("kritīs", krist.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("kritīs", krist.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds just = DabūtDarbībasVārdu("just");
            Assert.AreEqual("jutīšu", just.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("jutīsi", just.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("jutīsim", just.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("jutīsiet", just.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("jutīs", just.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("jutīs", just.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds skriet = DabūtDarbībasVārdu("skriet");
            Assert.AreEqual("skriešu", skriet.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("skriesi", skriet.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("skriesim", skriet.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("skriesiet", skriet.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("skries", skriet.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("skries", skriet.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds aut = DabūtDarbībasVārdu("aut");
            Assert.AreEqual("aušu", aut.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("ausi", aut.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("ausim", aut.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("ausiet", aut.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("aus", aut.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("aus", aut.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds tikt = DabūtDarbībasVārdu("tikt");
            Assert.AreEqual("tikšu", tikt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("tiksi", tikt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("tiksim", tikt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("tiksiet", tikt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("tiks", tikt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("tiks", tikt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaTrešāPersona));
            #endregion I konjugācija 3. grupa

            #region I konjugācija 4. grupa
            DarbībasVārds pūst = DabūtDarbībasVārdu("pūst");
            Assert.AreEqual("pūtīšu", pūst.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("pūtīsi", pūst.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("pūtīsim", pūst.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("pūtīsiet", pūst.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("pūtīs", pūst.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("pūtīs", pūst.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds belzt = DabūtDarbībasVārdu("belzt");
            Assert.AreEqual("belzīšu", belzt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("belzīsi", belzt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("belzīsim", belzt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("belzīsiet", belzt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("belzīs", belzt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("belzīs", belzt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds kāpt = DabūtDarbībasVārdu("kāpt");
            Assert.AreEqual("kāpšu", kāpt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("kāpsi", kāpt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("kāpsim", kāpt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("kāpsiet", kāpt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("kāps", kāpt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("kāps", kāpt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds glābt = DabūtDarbībasVārdu("glābt");
            Assert.AreEqual("glābšu", glābt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("glābsi", glābt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("glābsim", glābt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("glābsiet", glābt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("glābs", glābt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("glābs", glābt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds stumt = DabūtDarbībasVārdu("stumt");
            Assert.AreEqual("stumšu", stumt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("stumsi", stumt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("stumsim", stumt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("stumsiet", stumt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("stums", stumt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("stums", stumt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds braukt = DabūtDarbībasVārdu("braukt");
            Assert.AreEqual("braukšu", braukt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("brauksi", braukt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("brauksim", braukt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("brauksiet", braukt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("brauks", braukt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("brauks", braukt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds lūgt = DabūtDarbībasVārdu("lūgt");
            Assert.AreEqual("lūgšu", lūgt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("lūgsi", lūgt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("lūgsim", lūgt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("lūgsiet", lūgt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("lūgs", lūgt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("lūgs", lūgt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaTrešāPersona));
            #endregion I konjugācija 4. grupa

            #region I konjugācija 5. grupa
            DarbībasVārds silt = DabūtDarbībasVārdu("silt");
            Assert.AreEqual("silšu", silt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("silsi", silt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("silsim", silt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("silsiet", silt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("sils", silt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("sils", silt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaTrešāPersona));

            DarbībasVārds atbilst = DabūtDarbībasVārdu("atbilst");
            Assert.AreEqual("atbildīšu", atbilst.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("atbildīsi", atbilst.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("atbildīsim", atbilst.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("atbildīsiet", atbilst.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("atbildīs", atbilst.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("atbildīs", atbilst.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaTrešāPersona));
            #endregion I konjugācija 5. grupa
        }

        [Test]
        public void VēlējumaIzteiksmesVienkāršāTagade()
        {
            #region Piemēri
            DarbībasVārds celties = DabūtDarbībasVārdu("celties");
            Assert.AreEqual("celtos", celties.VēlējumaIzteiksmesVienkāršāTagadne());

            DarbībasVārds nirt = DabūtDarbībasVārdu("nirt");
            Assert.AreEqual("nirtu", nirt.VēlējumaIzteiksmesVienkāršāTagadne());

            DarbībasVārds gribēt = DabūtDarbībasVārdu("gribēt");
            Assert.AreEqual("gribētu", gribēt.VēlējumaIzteiksmesVienkāršāTagadne());
            #endregion Piemēri

            #region Līdzskaņu mijas
            DarbībasVārds urbt = DabūtDarbībasVārdu("urbt");
            Assert.AreEqual("urbtu", urbt.VēlējumaIzteiksmesVienkāršāTagadne());

            DarbībasVārds lemt = DabūtDarbībasVārdu("lemt");
            Assert.AreEqual("lemtu", lemt.VēlējumaIzteiksmesVienkāršāTagadne());

            DarbībasVārds čiept = DabūtDarbībasVārdu("čiept");
            Assert.AreEqual("čieptu", čiept.VēlējumaIzteiksmesVienkāršāTagadne());

            DarbībasVārds celt = DabūtDarbībasVārdu("celt");
            Assert.AreEqual("celtu", celt.VēlējumaIzteiksmesVienkāršāTagadne());

            DarbībasVārds dzēst = DabūtDarbībasVārdu("dzēst");
            Assert.AreEqual("dzēstu", dzēst.VēlējumaIzteiksmesVienkāršāTagadne());

            DarbībasVārds lauzt = DabūtDarbībasVārdu("lauzt");
            Assert.AreEqual("lauztu", lauzt.VēlējumaIzteiksmesVienkāršāTagadne());

            DarbībasVārds vilkt = DabūtDarbībasVārdu("vilkt");
            Assert.AreEqual("vilktu", vilkt.VēlējumaIzteiksmesVienkāršāTagadne());

            DarbībasVārds bēgt = DabūtDarbībasVārdu("bēgt");
            Assert.AreEqual("bēgtu", bēgt.VēlējumaIzteiksmesVienkāršāTagadne());

            DarbībasVārds mācēt = DabūtDarbībasVārdu("mācēt");
            Assert.AreEqual("mācētu", mācēt.VēlējumaIzteiksmesVienkāršāTagadne());

            DarbībasVārds mocīties = DabūtDarbībasVārdu("mocīties");
            Assert.AreEqual("mocītos", mocīties.VēlējumaIzteiksmesVienkāršāTagadne());

            DarbībasVārds locīt = DabūtDarbībasVārdu("locīt");
            Assert.AreEqual("locītu", locīt.VēlējumaIzteiksmesVienkāršāTagadne());

            DarbībasVārds apraudzīt = DabūtDarbībasVārdu("apraudzīt");
            Assert.AreEqual("apraudzītu", apraudzīt.VēlējumaIzteiksmesVienkāršāTagadne());
            #endregion Līdzskaņu mijas

            #region I konjugācija 1. grupa
            DarbībasVārds augt = DabūtDarbībasVārdu("augt");
            Assert.AreEqual("augtu", augt.VēlējumaIzteiksmesVienkāršāTagadne());

            DarbībasVārds nākt = DabūtDarbībasVārdu("nākt");
            Assert.AreEqual("nāktu", nākt.VēlējumaIzteiksmesVienkāršāTagadne());

            DarbībasVārds nest = DabūtDarbībasVārdu("nest");
            Assert.AreEqual("nestu", nest.VēlējumaIzteiksmesVienkāršāTagadne());

            DarbībasVārds vest = DabūtDarbībasVārdu("vest");
            Assert.AreEqual("vestu", vest.VēlējumaIzteiksmesVienkāršāTagadne());

            DarbībasVārds mīt = DabūtDarbībasVārdu("mīt");
            Assert.AreEqual("mītu", mīt.VēlējumaIzteiksmesVienkāršāTagadne());

            DarbībasVārds vīt = DabūtDarbībasVārdu("vīt");
            Assert.AreEqual("vītu", vīt.VēlējumaIzteiksmesVienkāršāTagadne());

            DarbībasVārds liet = DabūtDarbībasVārdu("liet");
            Assert.AreEqual("lietu", liet.VēlējumaIzteiksmesVienkāršāTagadne());
            #endregion I konjugācija 1. grupa

            #region I konjugācija 2. grupa
            DarbībasVārds krimst = DabūtDarbībasVārdu("krimst");
            Assert.AreEqual("krimstu", krimst.VēlējumaIzteiksmesVienkāršāTagadne());

            DarbībasVārds cirpt = DabūtDarbībasVārdu("cirpt");
            Assert.AreEqual("cirptu", cirpt.VēlējumaIzteiksmesVienkāršāTagadne());

            DarbībasVārds likt = DabūtDarbībasVārdu("likt");
            Assert.AreEqual("liktu", likt.VēlējumaIzteiksmesVienkāršāTagadne());

            DarbībasVārds dzīt = DabūtDarbībasVārdu("dzīt");
            Assert.AreEqual("dzītu", dzīt.VēlējumaIzteiksmesVienkāršāTagadne());
            #endregion I konjugācija 2. grupa

            #region I konjugācija 3. grupa
            DarbībasVārds rakt = DabūtDarbībasVārdu("rakt");
            Assert.AreEqual("raktu", rakt.VēlējumaIzteiksmesVienkāršāTagadne());

            DarbībasVārds krist = DabūtDarbībasVārdu("krist");
            Assert.AreEqual("kristu", krist.VēlējumaIzteiksmesVienkāršāTagadne());

            DarbībasVārds just = DabūtDarbībasVārdu("just");
            Assert.AreEqual("justu", just.VēlējumaIzteiksmesVienkāršāTagadne());

            DarbībasVārds skriet = DabūtDarbībasVārdu("skriet");
            Assert.AreEqual("skrietu", skriet.VēlējumaIzteiksmesVienkāršāTagadne());

            DarbībasVārds aut = DabūtDarbībasVārdu("aut");
            Assert.AreEqual("autu", aut.VēlējumaIzteiksmesVienkāršāTagadne());

            DarbībasVārds tikt = DabūtDarbībasVārdu("tikt");
            Assert.AreEqual("tiktu", tikt.VēlējumaIzteiksmesVienkāršāTagadne());
            #endregion I konjugācija 3. grupa

            #region I konjugācija 4. grupa
            DarbībasVārds pūst = DabūtDarbībasVārdu("pūst");
            Assert.AreEqual("pūstu", pūst.VēlējumaIzteiksmesVienkāršāTagadne());

            DarbībasVārds belzt = DabūtDarbībasVārdu("belzt");
            Assert.AreEqual("belztu", belzt.VēlējumaIzteiksmesVienkāršāTagadne());

            DarbībasVārds kāpt = DabūtDarbībasVārdu("kāpt");
            Assert.AreEqual("kāptu", kāpt.VēlējumaIzteiksmesVienkāršāTagadne());

            DarbībasVārds glābt = DabūtDarbībasVārdu("glābt");
            Assert.AreEqual("glābtu", glābt.VēlējumaIzteiksmesVienkāršāTagadne());

            DarbībasVārds stumt = DabūtDarbībasVārdu("stumt");
            Assert.AreEqual("stumtu", stumt.VēlējumaIzteiksmesVienkāršāTagadne());

            DarbībasVārds braukt = DabūtDarbībasVārdu("braukt");
            Assert.AreEqual("brauktu", braukt.VēlējumaIzteiksmesVienkāršāTagadne());

            DarbībasVārds lūgt = DabūtDarbībasVārdu("lūgt");
            Assert.AreEqual("lūgtu", lūgt.VēlējumaIzteiksmesVienkāršāTagadne());
            #endregion I konjugācija 4. grupa

            #region I konjugācija 5. grupa
            DarbībasVārds silt = DabūtDarbībasVārdu("silt");
            Assert.AreEqual("siltu", silt.VēlējumaIzteiksmesVienkāršāTagadne());

            DarbībasVārds atbilst = DabūtDarbībasVārdu("atbilst");
            Assert.AreEqual("atbilstu", atbilst.VēlējumaIzteiksmesVienkāršāTagadne());
            #endregion I konjugācija 5. grupa

            #region II konjugācija
            DarbībasVārds strādāt = DabūtDarbībasVārdu("strādāt");
            Assert.AreEqual("strādātu", strādāt.VēlējumaIzteiksmesVienkāršāTagadne());

            DarbībasVārds zīmēt = DabūtDarbībasVārdu("zīmēt");
            Assert.AreEqual("zīmētu", zīmēt.VēlējumaIzteiksmesVienkāršāTagadne());

            DarbībasVārds medīt = DabūtDarbībasVārdu("medīt");
            Assert.AreEqual("medītu", medīt.VēlējumaIzteiksmesVienkāršāTagadne());

            DarbībasVārds dejot = DabūtDarbībasVārdu("dejot");
            Assert.AreEqual("dejotu", dejot.VēlējumaIzteiksmesVienkāršāTagadne());

            DarbībasVārds domāt = DabūtDarbībasVārdu("domāt");
            Assert.AreEqual("domātu", domāt.VēlējumaIzteiksmesVienkāršāTagadne());
            #endregion II konjugācija

            #region III konjugācija 1. grupa
            DarbībasVārds lasīt = DabūtDarbībasVārdu("lasīt");
            Assert.AreEqual("lasītu", lasīt.VēlējumaIzteiksmesVienkāršāTagadne());

            DarbībasVārds skatīt = DabūtDarbībasVārdu("skatīt");
            Assert.AreEqual("skatītu", skatīt.VēlējumaIzteiksmesVienkāršāTagadne());

            DarbībasVārds skatīties = DabūtDarbībasVārdu("skatīties");
            Assert.AreEqual("skatītos", skatīties.VēlējumaIzteiksmesVienkāršāTagadne());

            DarbībasVārds gadīties = DabūtDarbībasVārdu("gadīties");
            Assert.AreEqual("gadītos", gadīties.VēlējumaIzteiksmesVienkāršāTagadne());

            DarbībasVārds smīdināt = DabūtDarbībasVārdu("smīdināt");
            Assert.AreEqual("smīdinātu", smīdināt.VēlējumaIzteiksmesVienkāršāTagadne());

            DarbībasVārds vicināt = DabūtDarbībasVārdu("vicināt");
            Assert.AreEqual("vicinātu", vicināt.VēlējumaIzteiksmesVienkāršāTagadne());

            DarbībasVārds sveicināties = DabūtDarbībasVārdu("sasveicināties");
            Assert.AreEqual("sasveicinātos", sveicināties.VēlējumaIzteiksmesVienkāršāTagadne());

            DarbībasVārds grabināties = DabūtDarbībasVārdu("grabināties");
            Assert.AreEqual("grabinātos", grabināties.VēlējumaIzteiksmesVienkāršāTagadne());

            DarbībasVārds zināt = DabūtDarbībasVārdu("zināt");
            Assert.AreEqual("zinātu", zināt.VēlējumaIzteiksmesVienkāršāTagadne());
            #endregion III kongjugācija 1. grupa

            #region III konjugācija 2. grupa
            DarbībasVārds dziedāt = DabūtDarbībasVārdu("dziedāt");
            Assert.AreEqual("dziedātu", dziedāt.VēlējumaIzteiksmesVienkāršāTagadne());

            DarbībasVārds redzēt = DabūtDarbībasVārdu("redzēt");
            Assert.AreEqual("redzētu", redzēt.VēlējumaIzteiksmesVienkāršāTagadne());

            DarbībasVārds kaunēties = DabūtDarbībasVārdu("kaunēties");
            Assert.AreEqual("kaunētos", kaunēties.VēlējumaIzteiksmesVienkāršāTagadne());

            DarbībasVārds turēties = DabūtDarbībasVārdu("turēties");
            Assert.AreEqual("turētos", turēties.VēlējumaIzteiksmesVienkāršāTagadne());
            #endregion
        }

        [Test, Category("I konjugācija 1. grupa")]
        public void Augt()
        {
            DarbībasVārds augt = new DarbībasVārds("augt", "augu", "augu", Konjugācija.I, 1);
            Assert.That(augt.Nenoteiksme, Is.EqualTo("augt"));
            Assert.That(augt.NenoteiksmesCelms, Is.EqualTo("aug"));
            Assert.That(augt.TagadnesCelms, Is.EqualTo("aug"));
            Assert.That(augt.PagātnesCelms, Is.EqualTo("aug"));
            Assert.That(augt.Tiešs, Is.EqualTo(true));
            Assert.That(augt.Atgriezenisks, Is.EqualTo(false));
            Assert.That(augt.Konjugācija, Is.EqualTo(Konjugācija.I));
            Assert.That(augt.Grupa, Is.EqualTo(1));

            Assert.AreEqual("augu", augt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("audz", augt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("augam", augt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("augat", augt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("aug", augt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("aug", augt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("augu", augt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("augi", augt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("augām", augt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("augāt", augt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("auga", augt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("auga", augt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("augšu", augt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("augsi", augt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("augsim", augt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("augsiet", augt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("augs", augt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("augs", augt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("esmu audzis", augt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esi audzis", augt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esam auguši", augt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esat auguši", augt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("ir audzis", augt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("ir auguši", augt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esmu augusi", augt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esi augusi", augt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esam augušas", augt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esat augušas", augt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("ir augusi", augt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("ir augušas", augt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("biju audzis", augt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("biji audzis", augt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bijām auguši", augt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bijāt auguši", augt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bija audzis", augt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bija auguši", augt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("biju augusi", augt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("biji augusi", augt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bijām augušas", augt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bijāt augušas", augt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bija augusi", augt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bija augušas", augt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("būšu audzis", augt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsi audzis", augt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsim auguši", augt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsiet auguši", augt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būs audzis", augt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būs auguši", augt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšu augusi", augt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsi augusi", augt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsim augušas", augt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsiet augušas", augt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būs augusi", augt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būs augušas", augt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("augot", augt.AtstāstījumaIzteiksmesVienkāršāTagadne());
            Assert.AreEqual("augšot", augt.AtstāstījumaIzteiksmesVienkāršāNākotne());

            Assert.AreEqual("esot audzis", augt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot audzis", augt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot audzis", augt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot auguši", augt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot auguši", augt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot auguši", augt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot augusi", augt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot augusi", augt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot augusi", augt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot augušas", augt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot augušas", augt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot augušas", augt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("būšot audzis", augt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot audzis", augt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot audzis", augt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot auguši", augt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot auguši", augt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot auguši", augt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot augusi", augt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot augusi", augt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot augusi", augt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot augušas", augt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot augušas", augt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot augušas", augt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("augtu", augt.VēlējumaIzteiksmesVienkāršāTagadne());

            Assert.AreEqual("būtu audzis", augt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu audzis", augt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu audzis", augt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu auguši", augt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu auguši", augt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu auguši", augt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu augusi", augt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu augusi", augt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu augusi", augt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu augušas", augt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu augušas", augt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu augušas", augt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("ir jāaug", augt.VajadzībasIzteiksmesVienkāršāTagadne());
            Assert.AreEqual("bija jāaug", augt.VajadzībasIzteiksmesVienkāršāPagātne());
            Assert.AreEqual("būs jāaug", augt.VajadzībasIzteiksmesVienkāršāNākotne());
            Assert.AreEqual("ir bijis jāaug", augt.VajadzībasIzteiksmesSaliktāTagadne());
            Assert.AreEqual("bija bijis jāaug", augt.VajadzībasIzteiksmesSaliktāPagātne());
            Assert.AreEqual("būs bijis jāaug", augt.VajadzībasIzteiksmesSaliktāNākotne());
            Assert.AreEqual("esot jāaug", augt.VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāTagadne());
            Assert.AreEqual("būšot jāaug", augt.VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāNākotne());
            Assert.AreEqual("būtu jāaug", augt.VajadzībasIzteiksmesVēlējumaPaveidaVienkāršāTagadne());
            Assert.AreEqual("būtu bijis jāaug", augt.VajadzībasIzteiksmesVēlējumaPaveidaSaliktāTagadne());

            Assert.AreEqual("augsim", augt.PavēlesIzteiksme(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("audz", augt.PavēlesIzteiksme(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("augsim", augt.PavēlesIzteiksme(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("audziet", augt.PavēlesIzteiksme(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("lai aug", augt.PavēlesIzteiksme(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("lai aug", augt.PavēlesIzteiksme(PersonasForma.DaudzskaitļaTrešāPersona));
        }

        [Test, Category("I konjugācija 1. grupa")]
        public void Nākt()
        {
            DarbībasVārds nākt = new DarbībasVārds("nākt", "nāku", "nācu", Konjugācija.I, 1);
            Assert.That(nākt.Nenoteiksme, Is.EqualTo("nākt"));
            Assert.That(nākt.NenoteiksmesCelms, Is.EqualTo("nāk"));
            Assert.That(nākt.TagadnesCelms, Is.EqualTo("nāk"));
            Assert.That(nākt.PagātnesCelms, Is.EqualTo("nāc"));
            Assert.That(nākt.Tiešs, Is.EqualTo(true));
            Assert.That(nākt.Atgriezenisks, Is.EqualTo(false));
            Assert.That(nākt.Konjugācija, Is.EqualTo(Konjugācija.I));
            Assert.That(nākt.Grupa, Is.EqualTo(1));

            Assert.AreEqual("nāku", nākt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("nāc", nākt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("nākam", nākt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("nākat", nākt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("nāk", nākt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("nāk", nākt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("nācu", nākt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("nāci", nākt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("nācām", nākt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("nācāt", nākt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("nāca", nākt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("nāca", nākt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("nākšu", nākt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("nāksi", nākt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("nāksim", nākt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("nāksiet", nākt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("nāks", nākt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("nāks", nākt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("esmu nācis", nākt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esi nācis", nākt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esam nākuši", nākt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esat nākuši", nākt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("ir nācis", nākt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("ir nākuši", nākt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esmu nākusi", nākt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esi nākusi", nākt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esam nākušas", nākt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esat nākušas", nākt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("ir nākusi", nākt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("ir nākušas", nākt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("biju nācis", nākt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("biji nācis", nākt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bijām nākuši", nākt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bijāt nākuši", nākt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bija nācis", nākt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bija nākuši", nākt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("biju nākusi", nākt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("biji nākusi", nākt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bijām nākušas", nākt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bijāt nākušas", nākt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bija nākusi", nākt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bija nākušas", nākt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("būšu nācis", nākt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsi nācis", nākt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsim nākuši", nākt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsiet nākuši", nākt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būs nācis", nākt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būs nākuši", nākt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšu nākusi", nākt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsi nākusi", nākt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsim nākušas", nākt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsiet nākušas", nākt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būs nākusi", nākt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būs nākušas", nākt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("nākot", nākt.AtstāstījumaIzteiksmesVienkāršāTagadne());
            Assert.AreEqual("nākšot", nākt.AtstāstījumaIzteiksmesVienkāršāNākotne());

            Assert.AreEqual("esot nācis", nākt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot nācis", nākt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot nācis", nākt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot nākuši", nākt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot nākuši", nākt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot nākuši", nākt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot nākusi", nākt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot nākusi", nākt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot nākusi", nākt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot nākušas", nākt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot nākušas", nākt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot nākušas", nākt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("būšot nācis", nākt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot nācis", nākt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot nācis", nākt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot nākuši", nākt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot nākuši", nākt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot nākuši", nākt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot nākusi", nākt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot nākusi", nākt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot nākusi", nākt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot nākušas", nākt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot nākušas", nākt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot nākušas", nākt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("nāktu", nākt.VēlējumaIzteiksmesVienkāršāTagadne());

            Assert.AreEqual("būtu nācis", nākt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu nācis", nākt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu nācis", nākt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu nākuši", nākt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu nākuši", nākt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu nākuši", nākt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu nākusi", nākt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu nākusi", nākt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu nākusi", nākt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu nākušas", nākt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu nākušas", nākt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu nākušas", nākt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("ir jānāk", nākt.VajadzībasIzteiksmesVienkāršāTagadne());
            Assert.AreEqual("bija jānāk", nākt.VajadzībasIzteiksmesVienkāršāPagātne());
            Assert.AreEqual("būs jānāk", nākt.VajadzībasIzteiksmesVienkāršāNākotne());
            Assert.AreEqual("ir bijis jānāk", nākt.VajadzībasIzteiksmesSaliktāTagadne());
            Assert.AreEqual("bija bijis jānāk", nākt.VajadzībasIzteiksmesSaliktāPagātne());
            Assert.AreEqual("būs bijis jānāk", nākt.VajadzībasIzteiksmesSaliktāNākotne());
            Assert.AreEqual("esot jānāk", nākt.VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāTagadne());
            Assert.AreEqual("būšot jānāk", nākt.VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāNākotne());
            Assert.AreEqual("būtu jānāk", nākt.VajadzībasIzteiksmesVēlējumaPaveidaVienkāršāTagadne());
            Assert.AreEqual("būtu bijis jānāk", nākt.VajadzībasIzteiksmesVēlējumaPaveidaSaliktāTagadne());

            Assert.AreEqual("nāksim", nākt.PavēlesIzteiksme(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("nāc", nākt.PavēlesIzteiksme(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("nāksim", nākt.PavēlesIzteiksme(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("nāciet", nākt.PavēlesIzteiksme(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("lai nāk", nākt.PavēlesIzteiksme(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("lai nāk", nākt.PavēlesIzteiksme(PersonasForma.DaudzskaitļaTrešāPersona));
        }

        [Test, Category("I konjugācija 1. grupa")]
        public void Nest()
        {
            DarbībasVārds nest = new DarbībasVārds("nest", "nesu", "nesu", Konjugācija.I, 1);
            Assert.That(nest.Nenoteiksme, Is.EqualTo("nest"));
            Assert.That(nest.NenoteiksmesCelms, Is.EqualTo("nes"));
            Assert.That(nest.TagadnesCelms, Is.EqualTo("nes"));
            Assert.That(nest.PagātnesCelms, Is.EqualTo("nes"));
            Assert.That(nest.Tiešs, Is.EqualTo(true));
            Assert.That(nest.Atgriezenisks, Is.EqualTo(false));
            Assert.That(nest.Konjugācija, Is.EqualTo(Konjugācija.I));
            Assert.That(nest.Grupa, Is.EqualTo(1));

            Assert.AreEqual("nesu", nest.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("nes", nest.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("nesam", nest.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("nesat", nest.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("nes", nest.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("nes", nest.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("nesu", nest.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("nesi", nest.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("nesām", nest.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("nesāt", nest.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("nesa", nest.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("nesa", nest.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("nesīšu", nest.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("nesīsi", nest.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("nesīsim", nest.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("nesīsiet", nest.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("nesīs", nest.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("nesīs", nest.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("esmu nesis", nest.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esi nesis", nest.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esam nesuši", nest.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esat nesuši", nest.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("ir nesis", nest.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("ir nesuši", nest.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esmu nesusi", nest.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esi nesusi", nest.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esam nesušas", nest.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esat nesušas", nest.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("ir nesusi", nest.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("ir nesušas", nest.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("biju nesis", nest.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("biji nesis", nest.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bijām nesuši", nest.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bijāt nesuši", nest.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bija nesis", nest.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bija nesuši", nest.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("biju nesusi", nest.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("biji nesusi", nest.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bijām nesušas", nest.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bijāt nesušas", nest.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bija nesusi", nest.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bija nesušas", nest.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("būšu nesis", nest.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsi nesis", nest.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsim nesuši", nest.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsiet nesuši", nest.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būs nesis", nest.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būs nesuši", nest.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšu nesusi", nest.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsi nesusi", nest.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsim nesušas", nest.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsiet nesušas", nest.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būs nesusi", nest.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būs nesušas", nest.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("nesot", nest.AtstāstījumaIzteiksmesVienkāršāTagadne());
            Assert.AreEqual("nesīšot", nest.AtstāstījumaIzteiksmesVienkāršāNākotne());

            Assert.AreEqual("esot nesis", nest.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot nesis", nest.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot nesis", nest.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot nesuši", nest.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot nesuši", nest.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot nesuši", nest.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot nesusi", nest.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot nesusi", nest.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot nesusi", nest.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot nesušas", nest.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot nesušas", nest.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot nesušas", nest.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("būšot nesis", nest.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot nesis", nest.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot nesis", nest.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot nesuši", nest.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot nesuši", nest.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot nesuši", nest.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot nesusi", nest.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot nesusi", nest.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot nesusi", nest.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot nesušas", nest.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot nesušas", nest.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot nesušas", nest.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("nestu", nest.VēlējumaIzteiksmesVienkāršāTagadne());

            Assert.AreEqual("būtu nesis", nest.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu nesis", nest.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu nesis", nest.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu nesuši", nest.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu nesuši", nest.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu nesuši", nest.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu nesusi", nest.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu nesusi", nest.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu nesusi", nest.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu nesušas", nest.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu nesušas", nest.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu nesušas", nest.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("ir jānes", nest.VajadzībasIzteiksmesVienkāršāTagadne());
            Assert.AreEqual("bija jānes", nest.VajadzībasIzteiksmesVienkāršāPagātne());
            Assert.AreEqual("būs jānes", nest.VajadzībasIzteiksmesVienkāršāNākotne());
            Assert.AreEqual("ir bijis jānes", nest.VajadzībasIzteiksmesSaliktāTagadne());
            Assert.AreEqual("bija bijis jānes", nest.VajadzībasIzteiksmesSaliktāPagātne());
            Assert.AreEqual("būs bijis jānes", nest.VajadzībasIzteiksmesSaliktāNākotne());
            Assert.AreEqual("esot jānes", nest.VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāTagadne());
            Assert.AreEqual("būšot jānes", nest.VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāNākotne());
            Assert.AreEqual("būtu jānes", nest.VajadzībasIzteiksmesVēlējumaPaveidaVienkāršāTagadne());
            Assert.AreEqual("būtu bijis jānes", nest.VajadzībasIzteiksmesVēlējumaPaveidaSaliktāTagadne());

            Assert.AreEqual("nesīsim", nest.PavēlesIzteiksme(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("nes", nest.PavēlesIzteiksme(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("nesīsim", nest.PavēlesIzteiksme(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("nesiet", nest.PavēlesIzteiksme(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("lai nes", nest.PavēlesIzteiksme(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("lai nes", nest.PavēlesIzteiksme(PersonasForma.DaudzskaitļaTrešāPersona));
        }

        [Test, Category("I konjugācija 1. grupa")]
        public void Vest()
        {
            DarbībasVārds vest = new DarbībasVārds("vest", "vedu", "vedu", Konjugācija.I, 1);
            Assert.That(vest.Nenoteiksme, Is.EqualTo("vest"));
            Assert.That(vest.NenoteiksmesCelms, Is.EqualTo("ves"));
            Assert.That(vest.TagadnesCelms, Is.EqualTo("ved"));
            Assert.That(vest.PagātnesCelms, Is.EqualTo("ved"));
            Assert.That(vest.Tiešs, Is.EqualTo(true));
            Assert.That(vest.Atgriezenisks, Is.EqualTo(false));
            Assert.That(vest.Konjugācija, Is.EqualTo(Konjugācija.I));
            Assert.That(vest.Grupa, Is.EqualTo(1));

            Assert.AreEqual("vedu", vest.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("ved", vest.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("vedam", vest.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("vedat", vest.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("ved", vest.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("ved", vest.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("vedu", vest.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("vedi", vest.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("vedām", vest.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("vedāt", vest.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("veda", vest.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("veda", vest.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("vedīšu", vest.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("vedīsi", vest.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("vedīsim", vest.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("vedīsiet", vest.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("vedīs", vest.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("vedīs", vest.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("esmu vedis", vest.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esi vedis", vest.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esam veduši", vest.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esat veduši", vest.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("ir vedis", vest.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("ir veduši", vest.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esmu vedusi", vest.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esi vedusi", vest.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esam vedušas", vest.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esat vedušas", vest.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("ir vedusi", vest.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("ir vedušas", vest.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("biju vedis", vest.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("biji vedis", vest.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bijām veduši", vest.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bijāt veduši", vest.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bija vedis", vest.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bija veduši", vest.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("biju vedusi", vest.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("biji vedusi", vest.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bijām vedušas", vest.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bijāt vedušas", vest.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bija vedusi", vest.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bija vedušas", vest.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("būšu vedis", vest.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsi vedis", vest.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsim veduši", vest.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsiet veduši", vest.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būs vedis", vest.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būs veduši", vest.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšu vedusi", vest.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsi vedusi", vest.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsim vedušas", vest.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsiet vedušas", vest.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būs vedusi", vest.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būs vedušas", vest.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("vedot", vest.AtstāstījumaIzteiksmesVienkāršāTagadne());
            Assert.AreEqual("vedīšot", vest.AtstāstījumaIzteiksmesVienkāršāNākotne());

            Assert.AreEqual("esot vedis", vest.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot vedis", vest.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot vedis", vest.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot veduši", vest.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot veduši", vest.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot veduši", vest.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot vedusi", vest.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot vedusi", vest.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot vedusi", vest.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot vedušas", vest.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot vedušas", vest.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot vedušas", vest.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("būšot vedis", vest.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot vedis", vest.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot vedis", vest.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot veduši", vest.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot veduši", vest.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot veduši", vest.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot vedusi", vest.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot vedusi", vest.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot vedusi", vest.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot vedušas", vest.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot vedušas", vest.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot vedušas", vest.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("vestu", vest.VēlējumaIzteiksmesVienkāršāTagadne());

            Assert.AreEqual("būtu vedis", vest.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu vedis", vest.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu vedis", vest.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu veduši", vest.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu veduši", vest.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu veduši", vest.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu vedusi", vest.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu vedusi", vest.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu vedusi", vest.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu vedušas", vest.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu vedušas", vest.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu vedušas", vest.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("ir jāved", vest.VajadzībasIzteiksmesVienkāršāTagadne());
            Assert.AreEqual("bija jāved", vest.VajadzībasIzteiksmesVienkāršāPagātne());
            Assert.AreEqual("būs jāved", vest.VajadzībasIzteiksmesVienkāršāNākotne());
            Assert.AreEqual("ir bijis jāved", vest.VajadzībasIzteiksmesSaliktāTagadne());
            Assert.AreEqual("bija bijis jāved", vest.VajadzībasIzteiksmesSaliktāPagātne());
            Assert.AreEqual("būs bijis jāved", vest.VajadzībasIzteiksmesSaliktāNākotne());
            Assert.AreEqual("esot jāved", vest.VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāTagadne());
            Assert.AreEqual("būšot jāved", vest.VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāNākotne());
            Assert.AreEqual("būtu jāved", vest.VajadzībasIzteiksmesVēlējumaPaveidaVienkāršāTagadne());
            Assert.AreEqual("būtu bijis jāved", vest.VajadzībasIzteiksmesVēlējumaPaveidaSaliktāTagadne());

            Assert.AreEqual("vedīsim", vest.PavēlesIzteiksme(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("ved", vest.PavēlesIzteiksme(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("vedīsim", vest.PavēlesIzteiksme(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("vediet", vest.PavēlesIzteiksme(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("lai ved", vest.PavēlesIzteiksme(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("lai ved", vest.PavēlesIzteiksme(PersonasForma.DaudzskaitļaTrešāPersona));
        }

        [Test, Category("I konjugācija 1. grupa")]
        public void Mīt()
        {
            DarbībasVārds mīt = new DarbībasVārds("mīt", "minu", "minu", Konjugācija.I, 1);
            Assert.That(mīt.Nenoteiksme, Is.EqualTo("mīt"));
            Assert.That(mīt.NenoteiksmesCelms, Is.EqualTo("mī"));
            Assert.That(mīt.TagadnesCelms, Is.EqualTo("min"));
            Assert.That(mīt.PagātnesCelms, Is.EqualTo("min"));
            Assert.That(mīt.Tiešs, Is.EqualTo(true));
            Assert.That(mīt.Atgriezenisks, Is.EqualTo(false));
            Assert.That(mīt.Konjugācija, Is.EqualTo(Konjugācija.I));
            Assert.That(mīt.Grupa, Is.EqualTo(1));

            Assert.AreEqual("minu", mīt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("min", mīt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("minam", mīt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("minat", mīt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("min", mīt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("min", mīt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("minu", mīt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("mini", mīt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("minām", mīt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("mināt", mīt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("mina", mīt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("mina", mīt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("mīšu", mīt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("mīsi", mīt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("mīsim", mīt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("mīsiet", mīt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("mīs", mīt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("mīs", mīt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("esmu minis", mīt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esi minis", mīt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esam minuši", mīt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esat minuši", mīt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("ir minis", mīt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("ir minuši", mīt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esmu minusi", mīt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esi minusi", mīt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esam minušas", mīt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esat minušas", mīt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("ir minusi", mīt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("ir minušas", mīt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("biju minis", mīt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("biji minis", mīt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bijām minuši", mīt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bijāt minuši", mīt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bija minis", mīt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bija minuši", mīt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("biju minusi", mīt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("biji minusi", mīt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bijām minušas", mīt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bijāt minušas", mīt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bija minusi", mīt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bija minušas", mīt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("būšu minis", mīt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsi minis", mīt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsim minuši", mīt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsiet minuši", mīt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būs minis", mīt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būs minuši", mīt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšu minusi", mīt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsi minusi", mīt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsim minušas", mīt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsiet minušas", mīt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būs minusi", mīt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būs minušas", mīt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("minot", mīt.AtstāstījumaIzteiksmesVienkāršāTagadne());
            Assert.AreEqual("mīšot", mīt.AtstāstījumaIzteiksmesVienkāršāNākotne());

            Assert.AreEqual("esot minis", mīt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot minis", mīt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot minis", mīt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot minuši", mīt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot minuši", mīt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot minuši", mīt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot minusi", mīt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot minusi", mīt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot minusi", mīt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot minušas", mīt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot minušas", mīt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot minušas", mīt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("būšot minis", mīt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot minis", mīt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot minis", mīt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot minuši", mīt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot minuši", mīt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot minuši", mīt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot minusi", mīt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot minusi", mīt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot minusi", mīt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot minušas", mīt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot minušas", mīt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot minušas", mīt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("mītu", mīt.VēlējumaIzteiksmesVienkāršāTagadne());

            Assert.AreEqual("būtu minis", mīt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu minis", mīt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu minis", mīt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu minuši", mīt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu minuši", mīt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu minuši", mīt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu minusi", mīt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu minusi", mīt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu minusi", mīt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu minušas", mīt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu minušas", mīt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu minušas", mīt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("ir jāmin", mīt.VajadzībasIzteiksmesVienkāršāTagadne());
            Assert.AreEqual("bija jāmin", mīt.VajadzībasIzteiksmesVienkāršāPagātne());
            Assert.AreEqual("būs jāmin", mīt.VajadzībasIzteiksmesVienkāršāNākotne());
            Assert.AreEqual("ir bijis jāmin", mīt.VajadzībasIzteiksmesSaliktāTagadne());
            Assert.AreEqual("bija bijis jāmin", mīt.VajadzībasIzteiksmesSaliktāPagātne());
            Assert.AreEqual("būs bijis jāmin", mīt.VajadzībasIzteiksmesSaliktāNākotne());
            Assert.AreEqual("esot jāmin", mīt.VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāTagadne());
            Assert.AreEqual("būšot jāmin", mīt.VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāNākotne());
            Assert.AreEqual("būtu jāmin", mīt.VajadzībasIzteiksmesVēlējumaPaveidaVienkāršāTagadne());
            Assert.AreEqual("būtu bijis jāmin", mīt.VajadzībasIzteiksmesVēlējumaPaveidaSaliktāTagadne());

            Assert.AreEqual("mīsim", mīt.PavēlesIzteiksme(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("min", mīt.PavēlesIzteiksme(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("mīsim", mīt.PavēlesIzteiksme(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("miniet", mīt.PavēlesIzteiksme(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("lai min", mīt.PavēlesIzteiksme(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("lai min", mīt.PavēlesIzteiksme(PersonasForma.DaudzskaitļaTrešāPersona));
        }

        [Test, Category("I konjugācija 1. grupa")]
        public void Vīt()
        {
            DarbībasVārds vīt = new DarbībasVārds("vīt", "viju", "viju", Konjugācija.I, 1);
            Assert.That(vīt.Nenoteiksme, Is.EqualTo("vīt"));
            Assert.That(vīt.NenoteiksmesCelms, Is.EqualTo("vī"));
            Assert.That(vīt.TagadnesCelms, Is.EqualTo("vij"));
            Assert.That(vīt.PagātnesCelms, Is.EqualTo("vij"));
            Assert.That(vīt.Tiešs, Is.EqualTo(true));
            Assert.That(vīt.Atgriezenisks, Is.EqualTo(false));
            Assert.That(vīt.Konjugācija, Is.EqualTo(Konjugācija.I));
            Assert.That(vīt.Grupa, Is.EqualTo(1));

            Assert.AreEqual("viju", vīt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("vij", vīt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("vijam", vīt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("vijat", vīt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("vij", vīt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("vij", vīt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("viju", vīt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("viji", vīt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("vijām", vīt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("vijāt", vīt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("vija", vīt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("vija", vīt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("vīšu", vīt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("vīsi", vīt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("vīsim", vīt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("vīsiet", vīt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("vīs", vīt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("vīs", vīt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("esmu vijis", vīt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esi vijis", vīt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esam vijuši", vīt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esat vijuši", vīt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("ir vijis", vīt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("ir vijuši", vīt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esmu vijusi", vīt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esi vijusi", vīt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esam vijušas", vīt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esat vijušas", vīt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("ir vijusi", vīt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("ir vijušas", vīt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("biju vijis", vīt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("biji vijis", vīt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bijām vijuši", vīt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bijāt vijuši", vīt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bija vijis", vīt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bija vijuši", vīt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("biju vijusi", vīt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("biji vijusi", vīt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bijām vijušas", vīt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bijāt vijušas", vīt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bija vijusi", vīt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bija vijušas", vīt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("būšu vijis", vīt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsi vijis", vīt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsim vijuši", vīt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsiet vijuši", vīt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būs vijis", vīt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būs vijuši", vīt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšu vijusi", vīt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsi vijusi", vīt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsim vijušas", vīt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsiet vijušas", vīt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būs vijusi", vīt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būs vijušas", vīt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("vijot", vīt.AtstāstījumaIzteiksmesVienkāršāTagadne());
            Assert.AreEqual("vīšot", vīt.AtstāstījumaIzteiksmesVienkāršāNākotne());

            Assert.AreEqual("esot vijis", vīt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot vijis", vīt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot vijis", vīt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot vijuši", vīt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot vijuši", vīt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot vijuši", vīt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot vijusi", vīt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot vijusi", vīt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot vijusi", vīt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot vijušas", vīt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot vijušas", vīt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot vijušas", vīt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("būšot vijis", vīt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot vijis", vīt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot vijis", vīt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot vijuši", vīt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot vijuši", vīt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot vijuši", vīt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot vijusi", vīt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot vijusi", vīt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot vijusi", vīt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot vijušas", vīt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot vijušas", vīt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot vijušas", vīt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("vītu", vīt.VēlējumaIzteiksmesVienkāršāTagadne());

            Assert.AreEqual("būtu vijis", vīt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu vijis", vīt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu vijis", vīt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu vijuši", vīt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu vijuši", vīt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu vijuši", vīt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu vijusi", vīt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu vijusi", vīt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu vijusi", vīt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu vijušas", vīt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu vijušas", vīt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu vijušas", vīt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("ir jāvij", vīt.VajadzībasIzteiksmesVienkāršāTagadne());
            Assert.AreEqual("bija jāvij", vīt.VajadzībasIzteiksmesVienkāršāPagātne());
            Assert.AreEqual("būs jāvij", vīt.VajadzībasIzteiksmesVienkāršāNākotne());
            Assert.AreEqual("ir bijis jāvij", vīt.VajadzībasIzteiksmesSaliktāTagadne());
            Assert.AreEqual("bija bijis jāvij", vīt.VajadzībasIzteiksmesSaliktāPagātne());
            Assert.AreEqual("būs bijis jāvij", vīt.VajadzībasIzteiksmesSaliktāNākotne());
            Assert.AreEqual("esot jāvij", vīt.VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāTagadne());
            Assert.AreEqual("būšot jāvij", vīt.VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāNākotne());
            Assert.AreEqual("būtu jāvij", vīt.VajadzībasIzteiksmesVēlējumaPaveidaVienkāršāTagadne());
            Assert.AreEqual("būtu bijis jāvij", vīt.VajadzībasIzteiksmesVēlējumaPaveidaSaliktāTagadne());

            Assert.AreEqual("vīsim", vīt.PavēlesIzteiksme(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("vij", vīt.PavēlesIzteiksme(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("vīsim", vīt.PavēlesIzteiksme(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("vijiet", vīt.PavēlesIzteiksme(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("lai vij", vīt.PavēlesIzteiksme(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("lai vij", vīt.PavēlesIzteiksme(PersonasForma.DaudzskaitļaTrešāPersona));
        }

        [Test, Category("I konjugācija 1. grupa")]
        public void Liet()
        {
            DarbībasVārds liet = new DarbībasVārds("liet", "leju", "lēju", Konjugācija.I, 1);
            Assert.That(liet.Nenoteiksme, Is.EqualTo("liet"));
            Assert.That(liet.NenoteiksmesCelms, Is.EqualTo("lie"));
            Assert.That(liet.TagadnesCelms, Is.EqualTo("lej"));
            Assert.That(liet.PagātnesCelms, Is.EqualTo("lēj"));
            Assert.That(liet.Tiešs, Is.EqualTo(true));
            Assert.That(liet.Atgriezenisks, Is.EqualTo(false));
            Assert.That(liet.Konjugācija, Is.EqualTo(Konjugācija.I));
            Assert.That(liet.Grupa, Is.EqualTo(1));

            Assert.AreEqual("leju", liet.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("lej", liet.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("lejam", liet.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("lejat", liet.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("lej", liet.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("lej", liet.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("lēju", liet.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("lēji", liet.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("lējām", liet.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("lējāt", liet.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("lēja", liet.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("lēja", liet.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("liešu", liet.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("liesi", liet.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("liesim", liet.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("liesiet", liet.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("lies", liet.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("lies", liet.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("esmu lējis", liet.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esi lējis", liet.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esam lējuši", liet.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esat lējuši", liet.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("ir lējis", liet.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("ir lējuši", liet.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esmu lējusi", liet.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esi lējusi", liet.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esam lējušas", liet.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esat lējušas", liet.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("ir lējusi", liet.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("ir lējušas", liet.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("biju lējis", liet.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("biji lējis", liet.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bijām lējuši", liet.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bijāt lējuši", liet.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bija lējis", liet.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bija lējuši", liet.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("biju lējusi", liet.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("biji lējusi", liet.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bijām lējušas", liet.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bijāt lējušas", liet.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bija lējusi", liet.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bija lējušas", liet.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("būšu lējis", liet.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsi lējis", liet.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsim lējuši", liet.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsiet lējuši", liet.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būs lējis", liet.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būs lējuši", liet.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšu lējusi", liet.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsi lējusi", liet.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsim lējušas", liet.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsiet lējušas", liet.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būs lējusi", liet.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būs lējušas", liet.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("lejot", liet.AtstāstījumaIzteiksmesVienkāršāTagadne());
            Assert.AreEqual("liešot", liet.AtstāstījumaIzteiksmesVienkāršāNākotne());

            Assert.AreEqual("esot lējis", liet.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot lējis", liet.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot lējis", liet.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot lējuši", liet.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot lējuši", liet.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot lējuši", liet.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot lējusi", liet.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot lējusi", liet.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot lējusi", liet.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot lējušas", liet.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot lējušas", liet.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot lējušas", liet.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("būšot lējis", liet.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot lējis", liet.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot lējis", liet.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot lējuši", liet.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot lējuši", liet.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot lējuši", liet.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot lējusi", liet.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot lējusi", liet.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot lējusi", liet.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot lējušas", liet.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot lējušas", liet.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot lējušas", liet.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("lietu", liet.VēlējumaIzteiksmesVienkāršāTagadne());

            Assert.AreEqual("būtu lējis", liet.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu lējis", liet.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu lējis", liet.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu lējuši", liet.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu lējuši", liet.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu lējuši", liet.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu lējusi", liet.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu lējusi", liet.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu lējusi", liet.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu lējušas", liet.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu lējušas", liet.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu lējušas", liet.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("ir jālej", liet.VajadzībasIzteiksmesVienkāršāTagadne());
            Assert.AreEqual("bija jālej", liet.VajadzībasIzteiksmesVienkāršāPagātne());
            Assert.AreEqual("būs jālej", liet.VajadzībasIzteiksmesVienkāršāNākotne());
            Assert.AreEqual("ir bijis jālej", liet.VajadzībasIzteiksmesSaliktāTagadne());
            Assert.AreEqual("bija bijis jālej", liet.VajadzībasIzteiksmesSaliktāPagātne());
            Assert.AreEqual("būs bijis jālej", liet.VajadzībasIzteiksmesSaliktāNākotne());
            Assert.AreEqual("esot jālej", liet.VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāTagadne());
            Assert.AreEqual("būšot jālej", liet.VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāNākotne());
            Assert.AreEqual("būtu jālej", liet.VajadzībasIzteiksmesVēlējumaPaveidaVienkāršāTagadne());
            Assert.AreEqual("būtu bijis jālej", liet.VajadzībasIzteiksmesVēlējumaPaveidaSaliktāTagadne());

            Assert.AreEqual("liesim", liet.PavēlesIzteiksme(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("lej", liet.PavēlesIzteiksme(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("liesim", liet.PavēlesIzteiksme(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("lejiet", liet.PavēlesIzteiksme(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("lai lej", liet.PavēlesIzteiksme(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("lai lej", liet.PavēlesIzteiksme(PersonasForma.DaudzskaitļaTrešāPersona));
        }

        [Test, Category("I konjugācija 2. grupa")]
        public void Krimst()
        {
            DarbībasVārds krimst = new DarbībasVārds("krimst", "kremtu", "krimtu", Konjugācija.I, 2);
            Assert.That(krimst.Nenoteiksme, Is.EqualTo("krimst"));
            Assert.That(krimst.NenoteiksmesCelms, Is.EqualTo("krims"));
            Assert.That(krimst.TagadnesCelms, Is.EqualTo("kremt"));
            Assert.That(krimst.PagātnesCelms, Is.EqualTo("krimt"));
            Assert.That(krimst.Tiešs, Is.EqualTo(true));
            Assert.That(krimst.Atgriezenisks, Is.EqualTo(false));
            Assert.That(krimst.Konjugācija, Is.EqualTo(Konjugācija.I));
            Assert.That(krimst.Grupa, Is.EqualTo(2));

            Assert.AreEqual("kremtu", krimst.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("kremt", krimst.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("kremtam", krimst.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("kremtat", krimst.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("kremt", krimst.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("kremt", krimst.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("krimtu", krimst.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("krimti", krimst.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("krimtām", krimst.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("krimtāt", krimst.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("krimta", krimst.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("krimta", krimst.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("krimtīšu", krimst.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("krimtīsi", krimst.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("krimtīsim", krimst.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("krimtīsiet", krimst.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("krimtīs", krimst.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("krimtīs", krimst.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("esmu krimtis", krimst.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esi krimtis", krimst.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esam krimtuši", krimst.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esat krimtuši", krimst.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("ir krimtis", krimst.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("ir krimtuši", krimst.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esmu krimtusi", krimst.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esi krimtusi", krimst.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esam krimtušas", krimst.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esat krimtušas", krimst.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("ir krimtusi", krimst.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("ir krimtušas", krimst.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("biju krimtis", krimst.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("biji krimtis", krimst.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bijām krimtuši", krimst.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bijāt krimtuši", krimst.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bija krimtis", krimst.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bija krimtuši", krimst.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("biju krimtusi", krimst.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("biji krimtusi", krimst.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bijām krimtušas", krimst.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bijāt krimtušas", krimst.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bija krimtusi", krimst.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bija krimtušas", krimst.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("būšu krimtis", krimst.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsi krimtis", krimst.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsim krimtuši", krimst.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsiet krimtuši", krimst.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būs krimtis", krimst.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būs krimtuši", krimst.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšu krimtusi", krimst.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsi krimtusi", krimst.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsim krimtušas", krimst.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsiet krimtušas", krimst.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būs krimtusi", krimst.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būs krimtušas", krimst.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("kremtot", krimst.AtstāstījumaIzteiksmesVienkāršāTagadne());
            Assert.AreEqual("krimtīšot", krimst.AtstāstījumaIzteiksmesVienkāršāNākotne());

            Assert.AreEqual("esot krimtis", krimst.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot krimtis", krimst.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot krimtis", krimst.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot krimtuši", krimst.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot krimtuši", krimst.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot krimtuši", krimst.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot krimtusi", krimst.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot krimtusi", krimst.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot krimtusi", krimst.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot krimtušas", krimst.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot krimtušas", krimst.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot krimtušas", krimst.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("būšot krimtis", krimst.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot krimtis", krimst.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot krimtis", krimst.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot krimtuši", krimst.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot krimtuši", krimst.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot krimtuši", krimst.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot krimtusi", krimst.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot krimtusi", krimst.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot krimtusi", krimst.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot krimtušas", krimst.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot krimtušas", krimst.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot krimtušas", krimst.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("krimstu", krimst.VēlējumaIzteiksmesVienkāršāTagadne());

            Assert.AreEqual("būtu krimtis", krimst.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu krimtis", krimst.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu krimtis", krimst.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu krimtuši", krimst.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu krimtuši", krimst.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu krimtuši", krimst.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu krimtusi", krimst.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu krimtusi", krimst.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu krimtusi", krimst.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu krimtušas", krimst.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu krimtušas", krimst.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu krimtušas", krimst.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("ir jākremt", krimst.VajadzībasIzteiksmesVienkāršāTagadne());
            Assert.AreEqual("bija jākremt", krimst.VajadzībasIzteiksmesVienkāršāPagātne());
            Assert.AreEqual("būs jākremt", krimst.VajadzībasIzteiksmesVienkāršāNākotne());
            Assert.AreEqual("ir bijis jākremt", krimst.VajadzībasIzteiksmesSaliktāTagadne());
            Assert.AreEqual("bija bijis jākremt", krimst.VajadzībasIzteiksmesSaliktāPagātne());
            Assert.AreEqual("būs bijis jākremt", krimst.VajadzībasIzteiksmesSaliktāNākotne());
            Assert.AreEqual("esot jākremt", krimst.VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāTagadne());
            Assert.AreEqual("būšot jākremt", krimst.VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāNākotne());
            Assert.AreEqual("būtu jākremt", krimst.VajadzībasIzteiksmesVēlējumaPaveidaVienkāršāTagadne());
            Assert.AreEqual("būtu bijis jākremt", krimst.VajadzībasIzteiksmesVēlējumaPaveidaSaliktāTagadne());

            Assert.AreEqual("krimtīsim", krimst.PavēlesIzteiksme(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("kremt", krimst.PavēlesIzteiksme(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("krimtīsim", krimst.PavēlesIzteiksme(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("kremtiet", krimst.PavēlesIzteiksme(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("lai kremt", krimst.PavēlesIzteiksme(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("lai kremt", krimst.PavēlesIzteiksme(PersonasForma.DaudzskaitļaTrešāPersona));
        }

        [Test, Category("I konjugācija 2. grupa")]
        public void Cirpt()
        {
            DarbībasVārds cirpt = new DarbībasVārds("cirpt", "cērpu", "cirpu", Konjugācija.I, 2);
            Assert.That(cirpt.Nenoteiksme, Is.EqualTo("cirpt"));
            Assert.That(cirpt.NenoteiksmesCelms, Is.EqualTo("cirp"));
            Assert.That(cirpt.TagadnesCelms, Is.EqualTo("cērp"));
            Assert.That(cirpt.PagātnesCelms, Is.EqualTo("cirp"));
            Assert.That(cirpt.Tiešs, Is.EqualTo(true));
            Assert.That(cirpt.Atgriezenisks, Is.EqualTo(false));
            Assert.That(cirpt.Konjugācija, Is.EqualTo(Konjugācija.I));
            Assert.That(cirpt.Grupa, Is.EqualTo(2));

            Assert.AreEqual("cērpu", cirpt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("cērp", cirpt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("cērpam", cirpt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("cērpat", cirpt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("cērp", cirpt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("cērp", cirpt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("cirpu", cirpt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("cirpi", cirpt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("cirpām", cirpt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("cirpāt", cirpt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("cirpa", cirpt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("cirpa", cirpt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("cirpšu", cirpt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("cirpsi", cirpt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("cirpsim", cirpt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("cirpsiet", cirpt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("cirps", cirpt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("cirps", cirpt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("esmu cirpis", cirpt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esi cirpis", cirpt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esam cirpuši", cirpt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esat cirpuši", cirpt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("ir cirpis", cirpt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("ir cirpuši", cirpt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esmu cirpusi", cirpt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esi cirpusi", cirpt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esam cirpušas", cirpt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esat cirpušas", cirpt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("ir cirpusi", cirpt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("ir cirpušas", cirpt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("biju cirpis", cirpt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("biji cirpis", cirpt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bijām cirpuši", cirpt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bijāt cirpuši", cirpt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bija cirpis", cirpt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bija cirpuši", cirpt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("biju cirpusi", cirpt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("biji cirpusi", cirpt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bijām cirpušas", cirpt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bijāt cirpušas", cirpt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bija cirpusi", cirpt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bija cirpušas", cirpt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("būšu cirpis", cirpt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsi cirpis", cirpt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsim cirpuši", cirpt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsiet cirpuši", cirpt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būs cirpis", cirpt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būs cirpuši", cirpt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšu cirpusi", cirpt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsi cirpusi", cirpt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsim cirpušas", cirpt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsiet cirpušas", cirpt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būs cirpusi", cirpt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būs cirpušas", cirpt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("cērpot", cirpt.AtstāstījumaIzteiksmesVienkāršāTagadne());
            Assert.AreEqual("cirpšot", cirpt.AtstāstījumaIzteiksmesVienkāršāNākotne());

            Assert.AreEqual("esot cirpis", cirpt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot cirpis", cirpt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot cirpis", cirpt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot cirpuši", cirpt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot cirpuši", cirpt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot cirpuši", cirpt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot cirpusi", cirpt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot cirpusi", cirpt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot cirpusi", cirpt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot cirpušas", cirpt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot cirpušas", cirpt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot cirpušas", cirpt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("būšot cirpis", cirpt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot cirpis", cirpt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot cirpis", cirpt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot cirpuši", cirpt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot cirpuši", cirpt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot cirpuši", cirpt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot cirpusi", cirpt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot cirpusi", cirpt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot cirpusi", cirpt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot cirpušas", cirpt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot cirpušas", cirpt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot cirpušas", cirpt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("cirptu", cirpt.VēlējumaIzteiksmesVienkāršāTagadne());

            Assert.AreEqual("būtu cirpis", cirpt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu cirpis", cirpt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu cirpis", cirpt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu cirpuši", cirpt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu cirpuši", cirpt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu cirpuši", cirpt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu cirpusi", cirpt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu cirpusi", cirpt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu cirpusi", cirpt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu cirpušas", cirpt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu cirpušas", cirpt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu cirpušas", cirpt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("ir jācērp", cirpt.VajadzībasIzteiksmesVienkāršāTagadne());
            Assert.AreEqual("bija jācērp", cirpt.VajadzībasIzteiksmesVienkāršāPagātne());
            Assert.AreEqual("būs jācērp", cirpt.VajadzībasIzteiksmesVienkāršāNākotne());
            Assert.AreEqual("ir bijis jācērp", cirpt.VajadzībasIzteiksmesSaliktāTagadne());
            Assert.AreEqual("bija bijis jācērp", cirpt.VajadzībasIzteiksmesSaliktāPagātne());
            Assert.AreEqual("būs bijis jācērp", cirpt.VajadzībasIzteiksmesSaliktāNākotne());
            Assert.AreEqual("esot jācērp", cirpt.VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāTagadne());
            Assert.AreEqual("būšot jācērp", cirpt.VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāNākotne());
            Assert.AreEqual("būtu jācērp", cirpt.VajadzībasIzteiksmesVēlējumaPaveidaVienkāršāTagadne());
            Assert.AreEqual("būtu bijis jācērp", cirpt.VajadzībasIzteiksmesVēlējumaPaveidaSaliktāTagadne());

            Assert.AreEqual("cirpsim", cirpt.PavēlesIzteiksme(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("cērp", cirpt.PavēlesIzteiksme(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("cirpsim", cirpt.PavēlesIzteiksme(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("cērpiet", cirpt.PavēlesIzteiksme(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("lai cērp", cirpt.PavēlesIzteiksme(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("lai cērp", cirpt.PavēlesIzteiksme(PersonasForma.DaudzskaitļaTrešāPersona));
        }

        [Test, Category("I konjugācija 2. grupa")]
        public void Likt()
        {
            DarbībasVārds likt = new DarbībasVārds("likt", "lieku", "liku", Konjugācija.I, 2);
            Assert.That(likt.Nenoteiksme, Is.EqualTo("likt"));
            Assert.That(likt.NenoteiksmesCelms, Is.EqualTo("lik"));
            Assert.That(likt.TagadnesCelms, Is.EqualTo("liek"));
            Assert.That(likt.PagātnesCelms, Is.EqualTo("lik"));
            Assert.That(likt.Tiešs, Is.EqualTo(true));
            Assert.That(likt.Atgriezenisks, Is.EqualTo(false));
            Assert.That(likt.Konjugācija, Is.EqualTo(Konjugācija.I));
            Assert.That(likt.Grupa, Is.EqualTo(2));

            Assert.AreEqual("lieku", likt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("liec", likt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("liekam", likt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("liekat", likt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("liek", likt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("liek", likt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("liku", likt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("liki", likt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("likām", likt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("likāt", likt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("lika", likt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("lika", likt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("likšu", likt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("liksi", likt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("liksim", likt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("liksiet", likt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("liks", likt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("liks", likt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("esmu licis", likt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esi licis", likt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esam likuši", likt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esat likuši", likt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("ir licis", likt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("ir likuši", likt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esmu likusi", likt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esi likusi", likt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esam likušas", likt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esat likušas", likt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("ir likusi", likt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("ir likušas", likt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("biju licis", likt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("biji licis", likt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bijām likuši", likt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bijāt likuši", likt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bija licis", likt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bija likuši", likt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("biju likusi", likt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("biji likusi", likt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bijām likušas", likt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bijāt likušas", likt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bija likusi", likt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bija likušas", likt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("būšu licis", likt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsi licis", likt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsim likuši", likt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsiet likuši", likt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būs licis", likt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būs likuši", likt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšu likusi", likt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsi likusi", likt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsim likušas", likt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsiet likušas", likt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būs likusi", likt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būs likušas", likt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("liekot", likt.AtstāstījumaIzteiksmesVienkāršāTagadne());
            Assert.AreEqual("likšot", likt.AtstāstījumaIzteiksmesVienkāršāNākotne());

            Assert.AreEqual("esot licis", likt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot licis", likt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot licis", likt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot likuši", likt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot likuši", likt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot likuši", likt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot likusi", likt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot likusi", likt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot likusi", likt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot likušas", likt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot likušas", likt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot likušas", likt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("būšot licis", likt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot licis", likt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot licis", likt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot likuši", likt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot likuši", likt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot likuši", likt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot likusi", likt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot likusi", likt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot likusi", likt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot likušas", likt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot likušas", likt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot likušas", likt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("liktu", likt.VēlējumaIzteiksmesVienkāršāTagadne());

            Assert.AreEqual("būtu licis", likt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu licis", likt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu licis", likt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu likuši", likt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu likuši", likt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu likuši", likt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu likusi", likt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu likusi", likt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu likusi", likt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu likušas", likt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu likušas", likt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu likušas", likt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("ir jāliek", likt.VajadzībasIzteiksmesVienkāršāTagadne());
            Assert.AreEqual("bija jāliek", likt.VajadzībasIzteiksmesVienkāršāPagātne());
            Assert.AreEqual("būs jāliek", likt.VajadzībasIzteiksmesVienkāršāNākotne());
            Assert.AreEqual("ir bijis jāliek", likt.VajadzībasIzteiksmesSaliktāTagadne());
            Assert.AreEqual("bija bijis jāliek", likt.VajadzībasIzteiksmesSaliktāPagātne());
            Assert.AreEqual("būs bijis jāliek", likt.VajadzībasIzteiksmesSaliktāNākotne());
            Assert.AreEqual("esot jāliek", likt.VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāTagadne());
            Assert.AreEqual("būšot jāliek", likt.VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāNākotne());
            Assert.AreEqual("būtu jāliek", likt.VajadzībasIzteiksmesVēlējumaPaveidaVienkāršāTagadne());
            Assert.AreEqual("būtu bijis jāliek", likt.VajadzībasIzteiksmesVēlējumaPaveidaSaliktāTagadne());

            Assert.AreEqual("liksim", likt.PavēlesIzteiksme(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("liec", likt.PavēlesIzteiksme(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("liksim", likt.PavēlesIzteiksme(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("lieciet", likt.PavēlesIzteiksme(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("lai liek", likt.PavēlesIzteiksme(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("lai liek", likt.PavēlesIzteiksme(PersonasForma.DaudzskaitļaTrešāPersona));
        }

        [Test, Category("I konjugācija 2. grupa")]
        public void Dzīt()
        {
            DarbībasVārds dzīt = new DarbībasVārds("dzīt", "dzenu", "dzinu", Konjugācija.I, 2);
            Assert.That(dzīt.Nenoteiksme, Is.EqualTo("dzīt"));
            Assert.That(dzīt.NenoteiksmesCelms, Is.EqualTo("dzī"));
            Assert.That(dzīt.TagadnesCelms, Is.EqualTo("dzen"));
            Assert.That(dzīt.PagātnesCelms, Is.EqualTo("dzin"));
            Assert.That(dzīt.Tiešs, Is.EqualTo(true));
            Assert.That(dzīt.Atgriezenisks, Is.EqualTo(false));
            Assert.That(dzīt.Konjugācija, Is.EqualTo(Konjugācija.I));
            Assert.That(dzīt.Grupa, Is.EqualTo(2));

            Assert.AreEqual("dzenu", dzīt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("dzen", dzīt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("dzenam", dzīt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("dzenat", dzīt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("dzen", dzīt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("dzen", dzīt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("dzinu", dzīt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("dzini", dzīt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("dzinām", dzīt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("dzināt", dzīt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("dzina", dzīt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("dzina", dzīt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("dzīšu", dzīt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("dzīsi", dzīt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("dzīsim", dzīt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("dzīsiet", dzīt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("dzīs", dzīt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("dzīs", dzīt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("esmu dzinis", dzīt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esi dzinis", dzīt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esam dzinuši", dzīt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esat dzinuši", dzīt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("ir dzinis", dzīt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("ir dzinuši", dzīt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esmu dzinusi", dzīt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esi dzinusi", dzīt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esam dzinušas", dzīt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esat dzinušas", dzīt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("ir dzinusi", dzīt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("ir dzinušas", dzīt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("biju dzinis", dzīt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("biji dzinis", dzīt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bijām dzinuši", dzīt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bijāt dzinuši", dzīt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bija dzinis", dzīt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bija dzinuši", dzīt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("biju dzinusi", dzīt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("biji dzinusi", dzīt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bijām dzinušas", dzīt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bijāt dzinušas", dzīt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bija dzinusi", dzīt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bija dzinušas", dzīt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("būšu dzinis", dzīt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsi dzinis", dzīt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsim dzinuši", dzīt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsiet dzinuši", dzīt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būs dzinis", dzīt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būs dzinuši", dzīt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšu dzinusi", dzīt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsi dzinusi", dzīt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsim dzinušas", dzīt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsiet dzinušas", dzīt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būs dzinusi", dzīt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būs dzinušas", dzīt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("dzenot", dzīt.AtstāstījumaIzteiksmesVienkāršāTagadne());
            Assert.AreEqual("dzīšot", dzīt.AtstāstījumaIzteiksmesVienkāršāNākotne());

            Assert.AreEqual("esot dzinis", dzīt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot dzinis", dzīt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot dzinis", dzīt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot dzinuši", dzīt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot dzinuši", dzīt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot dzinuši", dzīt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot dzinusi", dzīt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot dzinusi", dzīt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot dzinusi", dzīt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot dzinušas", dzīt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot dzinušas", dzīt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot dzinušas", dzīt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("būšot dzinis", dzīt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot dzinis", dzīt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot dzinis", dzīt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot dzinuši", dzīt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot dzinuši", dzīt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot dzinuši", dzīt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot dzinusi", dzīt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot dzinusi", dzīt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot dzinusi", dzīt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot dzinušas", dzīt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot dzinušas", dzīt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot dzinušas", dzīt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("dzītu", dzīt.VēlējumaIzteiksmesVienkāršāTagadne());

            Assert.AreEqual("būtu dzinis", dzīt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu dzinis", dzīt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu dzinis", dzīt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu dzinuši", dzīt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu dzinuši", dzīt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu dzinuši", dzīt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu dzinusi", dzīt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu dzinusi", dzīt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu dzinusi", dzīt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu dzinušas", dzīt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu dzinušas", dzīt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu dzinušas", dzīt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("ir jādzen", dzīt.VajadzībasIzteiksmesVienkāršāTagadne());
            Assert.AreEqual("bija jādzen", dzīt.VajadzībasIzteiksmesVienkāršāPagātne());
            Assert.AreEqual("būs jādzen", dzīt.VajadzībasIzteiksmesVienkāršāNākotne());
            Assert.AreEqual("ir bijis jādzen", dzīt.VajadzībasIzteiksmesSaliktāTagadne());
            Assert.AreEqual("bija bijis jādzen", dzīt.VajadzībasIzteiksmesSaliktāPagātne());
            Assert.AreEqual("būs bijis jādzen", dzīt.VajadzībasIzteiksmesSaliktāNākotne());
            Assert.AreEqual("esot jādzen", dzīt.VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāTagadne());
            Assert.AreEqual("būšot jādzen", dzīt.VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāNākotne());
            Assert.AreEqual("būtu jādzen", dzīt.VajadzībasIzteiksmesVēlējumaPaveidaVienkāršāTagadne());
            Assert.AreEqual("būtu bijis jādzen", dzīt.VajadzībasIzteiksmesVēlējumaPaveidaSaliktāTagadne());

            Assert.AreEqual("dzīsim", dzīt.PavēlesIzteiksme(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("dzen", dzīt.PavēlesIzteiksme(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("dzīsim", dzīt.PavēlesIzteiksme(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("dzeniet", dzīt.PavēlesIzteiksme(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("lai dzen", dzīt.PavēlesIzteiksme(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("lai dzen", dzīt.PavēlesIzteiksme(PersonasForma.DaudzskaitļaTrešāPersona));
        }

        [Test, Category("I konjugācija 3. grupa")]
        public void Rakt()
        {
            DarbībasVārds rakt = new DarbībasVārds("rakt", "roku", "raku", Konjugācija.I, 3);
            Assert.That(rakt.Nenoteiksme, Is.EqualTo("rakt"));
            Assert.That(rakt.NenoteiksmesCelms, Is.EqualTo("rak"));
            Assert.That(rakt.TagadnesCelms, Is.EqualTo("rok"));
            Assert.That(rakt.PagātnesCelms, Is.EqualTo("rak"));
            Assert.That(rakt.Tiešs, Is.EqualTo(true));
            Assert.That(rakt.Atgriezenisks, Is.EqualTo(false));
            Assert.That(rakt.Konjugācija, Is.EqualTo(Konjugācija.I));
            Assert.That(rakt.Grupa, Is.EqualTo(3));

            Assert.AreEqual("roku", rakt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("roc", rakt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("rokam", rakt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("rokat", rakt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("rok", rakt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("rok", rakt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("raku", rakt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("raki", rakt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("rakām", rakt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("rakāt", rakt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("raka", rakt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("raka", rakt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("rakšu", rakt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("raksi", rakt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("raksim", rakt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("raksiet", rakt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("raks", rakt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("raks", rakt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("esmu racis", rakt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esi racis", rakt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esam rakuši", rakt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esat rakuši", rakt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("ir racis", rakt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("ir rakuši", rakt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esmu rakusi", rakt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esi rakusi", rakt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esam rakušas", rakt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esat rakušas", rakt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("ir rakusi", rakt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("ir rakušas", rakt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("biju racis", rakt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("biji racis", rakt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bijām rakuši", rakt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bijāt rakuši", rakt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bija racis", rakt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bija rakuši", rakt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("biju rakusi", rakt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("biji rakusi", rakt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bijām rakušas", rakt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bijāt rakušas", rakt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bija rakusi", rakt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bija rakušas", rakt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("būšu racis", rakt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsi racis", rakt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsim rakuši", rakt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsiet rakuši", rakt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būs racis", rakt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būs rakuši", rakt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšu rakusi", rakt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsi rakusi", rakt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsim rakušas", rakt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsiet rakušas", rakt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būs rakusi", rakt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būs rakušas", rakt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("rokot", rakt.AtstāstījumaIzteiksmesVienkāršāTagadne());
            Assert.AreEqual("rakšot", rakt.AtstāstījumaIzteiksmesVienkāršāNākotne());

            Assert.AreEqual("esot racis", rakt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot racis", rakt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot racis", rakt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot rakuši", rakt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot rakuši", rakt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot rakuši", rakt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot rakusi", rakt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot rakusi", rakt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot rakusi", rakt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot rakušas", rakt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot rakušas", rakt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot rakušas", rakt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("būšot racis", rakt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot racis", rakt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot racis", rakt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot rakuši", rakt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot rakuši", rakt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot rakuši", rakt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot rakusi", rakt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot rakusi", rakt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot rakusi", rakt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot rakušas", rakt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot rakušas", rakt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot rakušas", rakt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("raktu", rakt.VēlējumaIzteiksmesVienkāršāTagadne());

            Assert.AreEqual("būtu racis", rakt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu racis", rakt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu racis", rakt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu rakuši", rakt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu rakuši", rakt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu rakuši", rakt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu rakusi", rakt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu rakusi", rakt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu rakusi", rakt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu rakušas", rakt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu rakušas", rakt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu rakušas", rakt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("ir jārok", rakt.VajadzībasIzteiksmesVienkāršāTagadne());
            Assert.AreEqual("bija jārok", rakt.VajadzībasIzteiksmesVienkāršāPagātne());
            Assert.AreEqual("būs jārok", rakt.VajadzībasIzteiksmesVienkāršāNākotne());
            Assert.AreEqual("ir bijis jārok", rakt.VajadzībasIzteiksmesSaliktāTagadne());
            Assert.AreEqual("bija bijis jārok", rakt.VajadzībasIzteiksmesSaliktāPagātne());
            Assert.AreEqual("būs bijis jārok", rakt.VajadzībasIzteiksmesSaliktāNākotne());
            Assert.AreEqual("esot jārok", rakt.VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāTagadne());
            Assert.AreEqual("būšot jārok", rakt.VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāNākotne());
            Assert.AreEqual("būtu jārok", rakt.VajadzībasIzteiksmesVēlējumaPaveidaVienkāršāTagadne());
            Assert.AreEqual("būtu bijis jārok", rakt.VajadzībasIzteiksmesVēlējumaPaveidaSaliktāTagadne());

            Assert.AreEqual("raksim", rakt.PavēlesIzteiksme(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("roc", rakt.PavēlesIzteiksme(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("raksim", rakt.PavēlesIzteiksme(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("rociet", rakt.PavēlesIzteiksme(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("lai rok", rakt.PavēlesIzteiksme(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("lai rok", rakt.PavēlesIzteiksme(PersonasForma.DaudzskaitļaTrešāPersona));
        }

        [Test, Category("I konjugācija 3. grupa")]
        public void Krist()
        {
            DarbībasVārds krist = new DarbībasVārds("krist", "krītu", "kritu", Konjugācija.I, 3);
            Assert.That(krist.Nenoteiksme, Is.EqualTo("krist"));
            Assert.That(krist.NenoteiksmesCelms, Is.EqualTo("kris"));
            Assert.That(krist.TagadnesCelms, Is.EqualTo("krīt"));
            Assert.That(krist.PagātnesCelms, Is.EqualTo("krit"));
            Assert.That(krist.Tiešs, Is.EqualTo(true));
            Assert.That(krist.Atgriezenisks, Is.EqualTo(false));
            Assert.That(krist.Konjugācija, Is.EqualTo(Konjugācija.I));
            Assert.That(krist.Grupa, Is.EqualTo(3));

            Assert.AreEqual("krītu", krist.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("krīti", krist.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("krītam", krist.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("krītat", krist.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("krīt", krist.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("krīt", krist.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("kritu", krist.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("kriti", krist.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("kritām", krist.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("kritāt", krist.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("krita", krist.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("krita", krist.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("kritīšu", krist.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("kritīsi", krist.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("kritīsim", krist.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("kritīsiet", krist.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("kritīs", krist.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("kritīs", krist.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("esmu kritis", krist.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esi kritis", krist.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esam krituši", krist.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esat krituši", krist.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("ir kritis", krist.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("ir krituši", krist.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esmu kritusi", krist.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esi kritusi", krist.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esam kritušas", krist.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esat kritušas", krist.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("ir kritusi", krist.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("ir kritušas", krist.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("biju kritis", krist.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("biji kritis", krist.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bijām krituši", krist.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bijāt krituši", krist.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bija kritis", krist.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bija krituši", krist.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("biju kritusi", krist.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("biji kritusi", krist.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bijām kritušas", krist.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bijāt kritušas", krist.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bija kritusi", krist.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bija kritušas", krist.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("būšu kritis", krist.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsi kritis", krist.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsim krituši", krist.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsiet krituši", krist.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būs kritis", krist.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būs krituši", krist.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšu kritusi", krist.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsi kritusi", krist.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsim kritušas", krist.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsiet kritušas", krist.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būs kritusi", krist.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būs kritušas", krist.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("krītot", krist.AtstāstījumaIzteiksmesVienkāršāTagadne());
            Assert.AreEqual("kritīšot", krist.AtstāstījumaIzteiksmesVienkāršāNākotne());

            Assert.AreEqual("esot kritis", krist.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot kritis", krist.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot kritis", krist.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot krituši", krist.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot krituši", krist.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot krituši", krist.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot kritusi", krist.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot kritusi", krist.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot kritusi", krist.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot kritušas", krist.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot kritušas", krist.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot kritušas", krist.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("būšot kritis", krist.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot kritis", krist.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot kritis", krist.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot krituši", krist.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot krituši", krist.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot krituši", krist.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot kritusi", krist.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot kritusi", krist.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot kritusi", krist.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot kritušas", krist.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot kritušas", krist.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot kritušas", krist.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("kristu", krist.VēlējumaIzteiksmesVienkāršāTagadne());

            Assert.AreEqual("būtu kritis", krist.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu kritis", krist.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu kritis", krist.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu krituši", krist.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu krituši", krist.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu krituši", krist.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu kritusi", krist.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu kritusi", krist.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu kritusi", krist.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu kritušas", krist.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu kritušas", krist.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu kritušas", krist.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("ir jākrīt", krist.VajadzībasIzteiksmesVienkāršāTagadne());
            Assert.AreEqual("bija jākrīt", krist.VajadzībasIzteiksmesVienkāršāPagātne());
            Assert.AreEqual("būs jākrīt", krist.VajadzībasIzteiksmesVienkāršāNākotne());
            Assert.AreEqual("ir bijis jākrīt", krist.VajadzībasIzteiksmesSaliktāTagadne());
            Assert.AreEqual("bija bijis jākrīt", krist.VajadzībasIzteiksmesSaliktāPagātne());
            Assert.AreEqual("būs bijis jākrīt", krist.VajadzībasIzteiksmesSaliktāNākotne());
            Assert.AreEqual("esot jākrīt", krist.VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāTagadne());
            Assert.AreEqual("būšot jākrīt", krist.VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāNākotne());
            Assert.AreEqual("būtu jākrīt", krist.VajadzībasIzteiksmesVēlējumaPaveidaVienkāršāTagadne());
            Assert.AreEqual("būtu bijis jākrīt", krist.VajadzībasIzteiksmesVēlējumaPaveidaSaliktāTagadne());

            Assert.AreEqual("kritīsim", krist.PavēlesIzteiksme(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("krīti", krist.PavēlesIzteiksme(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("kritīsim", krist.PavēlesIzteiksme(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("krītiet", krist.PavēlesIzteiksme(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("lai krīt", krist.PavēlesIzteiksme(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("lai krīt", krist.PavēlesIzteiksme(PersonasForma.DaudzskaitļaTrešāPersona));
        }

        [Test, Category("I konjugācija 3. grupa")]
        public void Just()
        {
            DarbībasVārds just = new DarbībasVārds("just", "jūtu", "jutu", Konjugācija.I, 3);
            Assert.That(just.Nenoteiksme, Is.EqualTo("just"));
            Assert.That(just.NenoteiksmesCelms, Is.EqualTo("jus"));
            Assert.That(just.TagadnesCelms, Is.EqualTo("jūt"));
            Assert.That(just.PagātnesCelms, Is.EqualTo("jut"));
            Assert.That(just.Tiešs, Is.EqualTo(true));
            Assert.That(just.Atgriezenisks, Is.EqualTo(false));
            Assert.That(just.Konjugācija, Is.EqualTo(Konjugācija.I));
            Assert.That(just.Grupa, Is.EqualTo(3));

            Assert.AreEqual("jūtu", just.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("jūti", just.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("jūtam", just.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("jūtat", just.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("jūt", just.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("jūt", just.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("jutu", just.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("juti", just.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("jutām", just.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("jutāt", just.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("juta", just.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("juta", just.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("jutīšu", just.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("jutīsi", just.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("jutīsim", just.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("jutīsiet", just.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("jutīs", just.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("jutīs", just.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("esmu jutis", just.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esi jutis", just.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esam jutuši", just.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esat jutuši", just.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("ir jutis", just.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("ir jutuši", just.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esmu jutusi", just.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esi jutusi", just.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esam jutušas", just.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esat jutušas", just.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("ir jutusi", just.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("ir jutušas", just.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("biju jutis", just.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("biji jutis", just.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bijām jutuši", just.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bijāt jutuši", just.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bija jutis", just.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bija jutuši", just.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("biju jutusi", just.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("biji jutusi", just.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bijām jutušas", just.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bijāt jutušas", just.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bija jutusi", just.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bija jutušas", just.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("būšu jutis", just.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsi jutis", just.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsim jutuši", just.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsiet jutuši", just.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būs jutis", just.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būs jutuši", just.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšu jutusi", just.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsi jutusi", just.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsim jutušas", just.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsiet jutušas", just.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būs jutusi", just.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būs jutušas", just.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("jūtot", just.AtstāstījumaIzteiksmesVienkāršāTagadne());
            Assert.AreEqual("jutīšot", just.AtstāstījumaIzteiksmesVienkāršāNākotne());

            Assert.AreEqual("esot jutis", just.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot jutis", just.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot jutis", just.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot jutuši", just.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot jutuši", just.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot jutuši", just.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot jutusi", just.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot jutusi", just.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot jutusi", just.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot jutušas", just.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot jutušas", just.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot jutušas", just.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("būšot jutis", just.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot jutis", just.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot jutis", just.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot jutuši", just.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot jutuši", just.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot jutuši", just.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot jutusi", just.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot jutusi", just.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot jutusi", just.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot jutušas", just.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot jutušas", just.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot jutušas", just.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("justu", just.VēlējumaIzteiksmesVienkāršāTagadne());

            Assert.AreEqual("būtu jutis", just.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu jutis", just.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu jutis", just.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu jutuši", just.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu jutuši", just.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu jutuši", just.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu jutusi", just.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu jutusi", just.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu jutusi", just.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu jutušas", just.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu jutušas", just.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu jutušas", just.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("ir jājūt", just.VajadzībasIzteiksmesVienkāršāTagadne());
            Assert.AreEqual("bija jājūt", just.VajadzībasIzteiksmesVienkāršāPagātne());
            Assert.AreEqual("būs jājūt", just.VajadzībasIzteiksmesVienkāršāNākotne());
            Assert.AreEqual("ir bijis jājūt", just.VajadzībasIzteiksmesSaliktāTagadne());
            Assert.AreEqual("bija bijis jājūt", just.VajadzībasIzteiksmesSaliktāPagātne());
            Assert.AreEqual("būs bijis jājūt", just.VajadzībasIzteiksmesSaliktāNākotne());
            Assert.AreEqual("esot jājūt", just.VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāTagadne());
            Assert.AreEqual("būšot jājūt", just.VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāNākotne());
            Assert.AreEqual("būtu jājūt", just.VajadzībasIzteiksmesVēlējumaPaveidaVienkāršāTagadne());
            Assert.AreEqual("būtu bijis jājūt", just.VajadzībasIzteiksmesVēlējumaPaveidaSaliktāTagadne());

            Assert.AreEqual("jutīsim", just.PavēlesIzteiksme(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("jūti", just.PavēlesIzteiksme(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("jutīsim", just.PavēlesIzteiksme(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("jūtiet", just.PavēlesIzteiksme(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("lai jūt", just.PavēlesIzteiksme(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("lai jūt", just.PavēlesIzteiksme(PersonasForma.DaudzskaitļaTrešāPersona));
        }

        [Test, Category("I konjugācija 3. grupa")]
        public void Skriet()
        {
            DarbībasVārds skriet = new DarbībasVārds("skriet", "skrienu", "skrēju", Konjugācija.I, 3);
            Assert.That(skriet.Nenoteiksme, Is.EqualTo("skriet"));
            Assert.That(skriet.NenoteiksmesCelms, Is.EqualTo("skrie"));
            Assert.That(skriet.TagadnesCelms, Is.EqualTo("skrien"));
            Assert.That(skriet.PagātnesCelms, Is.EqualTo("skrēj"));
            Assert.That(skriet.Tiešs, Is.EqualTo(true));
            Assert.That(skriet.Atgriezenisks, Is.EqualTo(false));
            Assert.That(skriet.Konjugācija, Is.EqualTo(Konjugācija.I));
            Assert.That(skriet.Grupa, Is.EqualTo(3));

            Assert.AreEqual("skrienu", skriet.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("skrien", skriet.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("skrienam", skriet.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("skrienat", skriet.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("skrien", skriet.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("skrien", skriet.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("skrēju", skriet.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("skrēji", skriet.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("skrējām", skriet.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("skrējāt", skriet.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("skrēja", skriet.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("skrēja", skriet.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("skriešu", skriet.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("skriesi", skriet.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("skriesim", skriet.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("skriesiet", skriet.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("skries", skriet.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("skries", skriet.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("esmu skrējis", skriet.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esi skrējis", skriet.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esam skrējuši", skriet.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esat skrējuši", skriet.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("ir skrējis", skriet.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("ir skrējuši", skriet.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esmu skrējusi", skriet.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esi skrējusi", skriet.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esam skrējušas", skriet.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esat skrējušas", skriet.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("ir skrējusi", skriet.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("ir skrējušas", skriet.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("biju skrējis", skriet.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("biji skrējis", skriet.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bijām skrējuši", skriet.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bijāt skrējuši", skriet.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bija skrējis", skriet.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bija skrējuši", skriet.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("biju skrējusi", skriet.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("biji skrējusi", skriet.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bijām skrējušas", skriet.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bijāt skrējušas", skriet.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bija skrējusi", skriet.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bija skrējušas", skriet.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("būšu skrējis", skriet.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsi skrējis", skriet.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsim skrējuši", skriet.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsiet skrējuši", skriet.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būs skrējis", skriet.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būs skrējuši", skriet.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšu skrējusi", skriet.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsi skrējusi", skriet.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsim skrējušas", skriet.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsiet skrējušas", skriet.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būs skrējusi", skriet.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būs skrējušas", skriet.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("skrienot", skriet.AtstāstījumaIzteiksmesVienkāršāTagadne());
            Assert.AreEqual("skriešot", skriet.AtstāstījumaIzteiksmesVienkāršāNākotne());

            Assert.AreEqual("esot skrējis", skriet.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot skrējis", skriet.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot skrējis", skriet.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot skrējuši", skriet.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot skrējuši", skriet.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot skrējuši", skriet.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot skrējusi", skriet.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot skrējusi", skriet.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot skrējusi", skriet.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot skrējušas", skriet.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot skrējušas", skriet.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot skrējušas", skriet.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("būšot skrējis", skriet.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot skrējis", skriet.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot skrējis", skriet.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot skrējuši", skriet.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot skrējuši", skriet.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot skrējuši", skriet.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot skrējusi", skriet.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot skrējusi", skriet.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot skrējusi", skriet.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot skrējušas", skriet.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot skrējušas", skriet.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot skrējušas", skriet.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("skrietu", skriet.VēlējumaIzteiksmesVienkāršāTagadne());

            Assert.AreEqual("būtu skrējis", skriet.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu skrējis", skriet.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu skrējis", skriet.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu skrējuši", skriet.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu skrējuši", skriet.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu skrējuši", skriet.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu skrējusi", skriet.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu skrējusi", skriet.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu skrējusi", skriet.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu skrējušas", skriet.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu skrējušas", skriet.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu skrējušas", skriet.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("ir jāskrien", skriet.VajadzībasIzteiksmesVienkāršāTagadne());
            Assert.AreEqual("bija jāskrien", skriet.VajadzībasIzteiksmesVienkāršāPagātne());
            Assert.AreEqual("būs jāskrien", skriet.VajadzībasIzteiksmesVienkāršāNākotne());
            Assert.AreEqual("ir bijis jāskrien", skriet.VajadzībasIzteiksmesSaliktāTagadne());
            Assert.AreEqual("bija bijis jāskrien", skriet.VajadzībasIzteiksmesSaliktāPagātne());
            Assert.AreEqual("būs bijis jāskrien", skriet.VajadzībasIzteiksmesSaliktāNākotne());
            Assert.AreEqual("esot jāskrien", skriet.VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāTagadne());
            Assert.AreEqual("būšot jāskrien", skriet.VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāNākotne());
            Assert.AreEqual("būtu jāskrien", skriet.VajadzībasIzteiksmesVēlējumaPaveidaVienkāršāTagadne());
            Assert.AreEqual("būtu bijis jāskrien", skriet.VajadzībasIzteiksmesVēlējumaPaveidaSaliktāTagadne());

            Assert.AreEqual("skriesim", skriet.PavēlesIzteiksme(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("skrien", skriet.PavēlesIzteiksme(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("skriesim", skriet.PavēlesIzteiksme(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("skrieniet", skriet.PavēlesIzteiksme(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("lai skrien", skriet.PavēlesIzteiksme(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("lai skrien", skriet.PavēlesIzteiksme(PersonasForma.DaudzskaitļaTrešāPersona));
        }

        [Test, Category("I konjugācija 3. grupa")]
        public void Aut()
        {
            DarbībasVārds aut = new DarbībasVārds("aut", "aunu", "āvu", Konjugācija.I, 3);
            Assert.That(aut.Nenoteiksme, Is.EqualTo("aut"));
            Assert.That(aut.NenoteiksmesCelms, Is.EqualTo("au"));
            Assert.That(aut.TagadnesCelms, Is.EqualTo("aun"));
            Assert.That(aut.PagātnesCelms, Is.EqualTo("āv"));
            Assert.That(aut.Tiešs, Is.EqualTo(true));
            Assert.That(aut.Atgriezenisks, Is.EqualTo(false));
            Assert.That(aut.Konjugācija, Is.EqualTo(Konjugācija.I));
            Assert.That(aut.Grupa, Is.EqualTo(3));

            Assert.AreEqual("aunu", aut.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("aun", aut.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("aunam", aut.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("aunat", aut.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("aun", aut.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("aun", aut.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("āvu", aut.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("āvi", aut.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("āvām", aut.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("āvāt", aut.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("āva", aut.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("āva", aut.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("aušu", aut.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("ausi", aut.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("ausim", aut.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("ausiet", aut.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("aus", aut.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("aus", aut.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("esmu āvis", aut.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esi āvis", aut.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esam āvuši", aut.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esat āvuši", aut.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("ir āvis", aut.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("ir āvuši", aut.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esmu āvusi", aut.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esi āvusi", aut.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esam āvušas", aut.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esat āvušas", aut.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("ir āvusi", aut.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("ir āvušas", aut.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("biju āvis", aut.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("biji āvis", aut.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bijām āvuši", aut.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bijāt āvuši", aut.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bija āvis", aut.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bija āvuši", aut.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("biju āvusi", aut.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("biji āvusi", aut.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bijām āvušas", aut.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bijāt āvušas", aut.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bija āvusi", aut.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bija āvušas", aut.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("būšu āvis", aut.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsi āvis", aut.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsim āvuši", aut.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsiet āvuši", aut.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būs āvis", aut.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būs āvuši", aut.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšu āvusi", aut.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsi āvusi", aut.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsim āvušas", aut.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsiet āvušas", aut.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būs āvusi", aut.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būs āvušas", aut.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("aunot", aut.AtstāstījumaIzteiksmesVienkāršāTagadne());
            Assert.AreEqual("aušot", aut.AtstāstījumaIzteiksmesVienkāršāNākotne());

            Assert.AreEqual("esot āvis", aut.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot āvis", aut.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot āvis", aut.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot āvuši", aut.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot āvuši", aut.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot āvuši", aut.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot āvusi", aut.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot āvusi", aut.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot āvusi", aut.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot āvušas", aut.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot āvušas", aut.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot āvušas", aut.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("būšot āvis", aut.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot āvis", aut.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot āvis", aut.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot āvuši", aut.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot āvuši", aut.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot āvuši", aut.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot āvusi", aut.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot āvusi", aut.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot āvusi", aut.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot āvušas", aut.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot āvušas", aut.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot āvušas", aut.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("autu", aut.VēlējumaIzteiksmesVienkāršāTagadne());

            Assert.AreEqual("būtu āvis", aut.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu āvis", aut.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu āvis", aut.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu āvuši", aut.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu āvuši", aut.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu āvuši", aut.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu āvusi", aut.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu āvusi", aut.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu āvusi", aut.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu āvušas", aut.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu āvušas", aut.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu āvušas", aut.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("ir jāaun", aut.VajadzībasIzteiksmesVienkāršāTagadne());
            Assert.AreEqual("bija jāaun", aut.VajadzībasIzteiksmesVienkāršāPagātne());
            Assert.AreEqual("būs jāaun", aut.VajadzībasIzteiksmesVienkāršāNākotne());
            Assert.AreEqual("ir bijis jāaun", aut.VajadzībasIzteiksmesSaliktāTagadne());
            Assert.AreEqual("bija bijis jāaun", aut.VajadzībasIzteiksmesSaliktāPagātne());
            Assert.AreEqual("būs bijis jāaun", aut.VajadzībasIzteiksmesSaliktāNākotne());
            Assert.AreEqual("esot jāaun", aut.VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāTagadne());
            Assert.AreEqual("būšot jāaun", aut.VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāNākotne());
            Assert.AreEqual("būtu jāaun", aut.VajadzībasIzteiksmesVēlējumaPaveidaVienkāršāTagadne());
            Assert.AreEqual("būtu bijis jāaun", aut.VajadzībasIzteiksmesVēlējumaPaveidaSaliktāTagadne());

            Assert.AreEqual("ausim", aut.PavēlesIzteiksme(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("aun", aut.PavēlesIzteiksme(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("ausim", aut.PavēlesIzteiksme(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("auniet", aut.PavēlesIzteiksme(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("lai aun", aut.PavēlesIzteiksme(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("lai aun", aut.PavēlesIzteiksme(PersonasForma.DaudzskaitļaTrešāPersona));
        }

        [Test, Category("I konjugācija 3. grupa")]
        public void Tikt()
        {
            DarbībasVārds tikt = new DarbībasVārds("tikt", "tieku", "tiku", Konjugācija.I, 3);
            Assert.That(tikt.Nenoteiksme, Is.EqualTo("tikt"));
            Assert.That(tikt.NenoteiksmesCelms, Is.EqualTo("tik"));
            Assert.That(tikt.TagadnesCelms, Is.EqualTo("tiek"));
            Assert.That(tikt.PagātnesCelms, Is.EqualTo("tik"));
            Assert.That(tikt.Tiešs, Is.EqualTo(true));
            Assert.That(tikt.Atgriezenisks, Is.EqualTo(false));
            Assert.That(tikt.Konjugācija, Is.EqualTo(Konjugācija.I));
            Assert.That(tikt.Grupa, Is.EqualTo(3));

            Assert.AreEqual("tieku", tikt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("tiec", tikt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("tiekam", tikt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("tiekat", tikt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("tiek", tikt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("tiek", tikt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("tiku", tikt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("tiki", tikt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("tikām", tikt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("tikāt", tikt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("tika", tikt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("tika", tikt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("tikšu", tikt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("tiksi", tikt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("tiksim", tikt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("tiksiet", tikt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("tiks", tikt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("tiks", tikt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("esmu ticis", tikt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esi ticis", tikt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esam tikuši", tikt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esat tikuši", tikt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("ir ticis", tikt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("ir tikuši", tikt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esmu tikusi", tikt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esi tikusi", tikt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esam tikušas", tikt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esat tikušas", tikt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("ir tikusi", tikt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("ir tikušas", tikt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("biju ticis", tikt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("biji ticis", tikt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bijām tikuši", tikt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bijāt tikuši", tikt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bija ticis", tikt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bija tikuši", tikt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("biju tikusi", tikt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("biji tikusi", tikt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bijām tikušas", tikt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bijāt tikušas", tikt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bija tikusi", tikt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bija tikušas", tikt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("būšu ticis", tikt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsi ticis", tikt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsim tikuši", tikt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsiet tikuši", tikt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būs ticis", tikt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būs tikuši", tikt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšu tikusi", tikt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsi tikusi", tikt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsim tikušas", tikt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsiet tikušas", tikt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būs tikusi", tikt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būs tikušas", tikt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("tiekot", tikt.AtstāstījumaIzteiksmesVienkāršāTagadne());
            Assert.AreEqual("tikšot", tikt.AtstāstījumaIzteiksmesVienkāršāNākotne());

            Assert.AreEqual("esot ticis", tikt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot ticis", tikt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot ticis", tikt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot tikuši", tikt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot tikuši", tikt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot tikuši", tikt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot tikusi", tikt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot tikusi", tikt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot tikusi", tikt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot tikušas", tikt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot tikušas", tikt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot tikušas", tikt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("būšot ticis", tikt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot ticis", tikt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot ticis", tikt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot tikuši", tikt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot tikuši", tikt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot tikuši", tikt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot tikusi", tikt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot tikusi", tikt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot tikusi", tikt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot tikušas", tikt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot tikušas", tikt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot tikušas", tikt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("tiktu", tikt.VēlējumaIzteiksmesVienkāršāTagadne());

            Assert.AreEqual("būtu ticis", tikt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu ticis", tikt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu ticis", tikt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu tikuši", tikt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu tikuši", tikt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu tikuši", tikt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu tikusi", tikt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu tikusi", tikt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu tikusi", tikt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu tikušas", tikt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu tikušas", tikt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu tikušas", tikt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("ir jātiek", tikt.VajadzībasIzteiksmesVienkāršāTagadne());
            Assert.AreEqual("bija jātiek", tikt.VajadzībasIzteiksmesVienkāršāPagātne());
            Assert.AreEqual("būs jātiek", tikt.VajadzībasIzteiksmesVienkāršāNākotne());
            Assert.AreEqual("ir bijis jātiek", tikt.VajadzībasIzteiksmesSaliktāTagadne());
            Assert.AreEqual("bija bijis jātiek", tikt.VajadzībasIzteiksmesSaliktāPagātne());
            Assert.AreEqual("būs bijis jātiek", tikt.VajadzībasIzteiksmesSaliktāNākotne());
            Assert.AreEqual("esot jātiek", tikt.VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāTagadne());
            Assert.AreEqual("būšot jātiek", tikt.VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāNākotne());
            Assert.AreEqual("būtu jātiek", tikt.VajadzībasIzteiksmesVēlējumaPaveidaVienkāršāTagadne());
            Assert.AreEqual("būtu bijis jātiek", tikt.VajadzībasIzteiksmesVēlējumaPaveidaSaliktāTagadne());

            Assert.AreEqual("tiksim", tikt.PavēlesIzteiksme(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("tiec", tikt.PavēlesIzteiksme(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("tiksim", tikt.PavēlesIzteiksme(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("tieciet", tikt.PavēlesIzteiksme(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("lai tiek", tikt.PavēlesIzteiksme(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("lai tiek", tikt.PavēlesIzteiksme(PersonasForma.DaudzskaitļaTrešāPersona));
        }

        [Test, Category("I konjugācija 4. grupa")]
        public void Celt()
        {
            DarbībasVārds celt = new DarbībasVārds("celt", "ceļu", "cēlu", Konjugācija.I, 4);
            Assert.That(celt.Nenoteiksme, Is.EqualTo("celt"));
            Assert.That(celt.NenoteiksmesCelms, Is.EqualTo("cel"));
            Assert.That(celt.TagadnesCelms, Is.EqualTo("ceļ"));
            Assert.That(celt.PagātnesCelms, Is.EqualTo("cēl"));
            Assert.That(celt.Tiešs, Is.EqualTo(true));
            Assert.That(celt.Atgriezenisks, Is.EqualTo(false));
            Assert.That(celt.Konjugācija, Is.EqualTo(Konjugācija.I));
            Assert.That(celt.Grupa, Is.EqualTo(4));

            Assert.AreEqual("ceļu", celt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("cel", celt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("ceļam", celt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("ceļat", celt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("ceļ", celt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("ceļ", celt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("cēlu", celt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("cēli", celt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("cēlām", celt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("cēlāt", celt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("cēla", celt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("cēla", celt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("celšu", celt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("celsi", celt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("celsim", celt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("celsiet", celt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("cels", celt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("cels", celt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("esmu cēlis", celt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esi cēlis", celt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esam cēluši", celt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esat cēluši", celt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("ir cēlis", celt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("ir cēluši", celt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esmu cēlusi", celt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esi cēlusi", celt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esam cēlušas", celt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esat cēlušas", celt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("ir cēlusi", celt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("ir cēlušas", celt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("biju cēlis", celt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("biji cēlis", celt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bijām cēluši", celt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bijāt cēluši", celt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bija cēlis", celt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bija cēluši", celt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("biju cēlusi", celt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("biji cēlusi", celt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bijām cēlušas", celt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bijāt cēlušas", celt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bija cēlusi", celt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bija cēlušas", celt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("būšu cēlis", celt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsi cēlis", celt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsim cēluši", celt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsiet cēluši", celt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būs cēlis", celt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būs cēluši", celt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšu cēlusi", celt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsi cēlusi", celt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsim cēlušas", celt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsiet cēlušas", celt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būs cēlusi", celt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būs cēlušas", celt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("ceļot", celt.AtstāstījumaIzteiksmesVienkāršāTagadne());
            Assert.AreEqual("celšot", celt.AtstāstījumaIzteiksmesVienkāršāNākotne());

            Assert.AreEqual("esot cēlis", celt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot cēlis", celt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot cēlis", celt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot cēluši", celt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot cēluši", celt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot cēluši", celt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot cēlusi", celt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot cēlusi", celt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot cēlusi", celt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot cēlušas", celt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot cēlušas", celt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot cēlušas", celt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("būšot cēlis", celt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot cēlis", celt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot cēlis", celt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot cēluši", celt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot cēluši", celt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot cēluši", celt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot cēlusi", celt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot cēlusi", celt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot cēlusi", celt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot cēlušas", celt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot cēlušas", celt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot cēlušas", celt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("celtu", celt.VēlējumaIzteiksmesVienkāršāTagadne());

            Assert.AreEqual("būtu cēlis", celt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu cēlis", celt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu cēlis", celt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu cēluši", celt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu cēluši", celt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu cēluši", celt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu cēlusi", celt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu cēlusi", celt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu cēlusi", celt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu cēlušas", celt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu cēlušas", celt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu cēlušas", celt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("ir jāceļ", celt.VajadzībasIzteiksmesVienkāršāTagadne());
            Assert.AreEqual("bija jāceļ", celt.VajadzībasIzteiksmesVienkāršāPagātne());
            Assert.AreEqual("būs jāceļ", celt.VajadzībasIzteiksmesVienkāršāNākotne());
            Assert.AreEqual("ir bijis jāceļ", celt.VajadzībasIzteiksmesSaliktāTagadne());
            Assert.AreEqual("bija bijis jāceļ", celt.VajadzībasIzteiksmesSaliktāPagātne());
            Assert.AreEqual("būs bijis jāceļ", celt.VajadzībasIzteiksmesSaliktāNākotne());
            Assert.AreEqual("esot jāceļ", celt.VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāTagadne());
            Assert.AreEqual("būšot jāceļ", celt.VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāNākotne());
            Assert.AreEqual("būtu jāceļ", celt.VajadzībasIzteiksmesVēlējumaPaveidaVienkāršāTagadne());
            Assert.AreEqual("būtu bijis jāceļ", celt.VajadzībasIzteiksmesVēlējumaPaveidaSaliktāTagadne());

            Assert.AreEqual("celsim", celt.PavēlesIzteiksme(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("cel", celt.PavēlesIzteiksme(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("celsim", celt.PavēlesIzteiksme(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("celiet", celt.PavēlesIzteiksme(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("lai ceļ", celt.PavēlesIzteiksme(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("lai ceļ", celt.PavēlesIzteiksme(PersonasForma.DaudzskaitļaTrešāPersona));
        }

        [Test, Category("I konjugācija 4. grupa")]
        public void Belzt()
        {
            DarbībasVārds belzt = new DarbībasVārds("belzt", "belžu", "belzu", Konjugācija.I, 4);
            Assert.That(belzt.Nenoteiksme, Is.EqualTo("belzt"));
            Assert.That(belzt.NenoteiksmesCelms, Is.EqualTo("belz"));
            Assert.That(belzt.TagadnesCelms, Is.EqualTo("belž"));
            Assert.That(belzt.PagātnesCelms, Is.EqualTo("belz"));
            Assert.That(belzt.Tiešs, Is.EqualTo(true));
            Assert.That(belzt.Atgriezenisks, Is.EqualTo(false));
            Assert.That(belzt.Konjugācija, Is.EqualTo(Konjugācija.I));
            Assert.That(belzt.Grupa, Is.EqualTo(4));

            Assert.AreEqual("belžu", belzt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("belz", belzt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("belžam", belzt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("belžat", belzt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("belž", belzt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("belž", belzt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("belzu", belzt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("belzi", belzt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("belzām", belzt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("belzāt", belzt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("belza", belzt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("belza", belzt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("belzīšu", belzt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("belzīsi", belzt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("belzīsim", belzt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("belzīsiet", belzt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("belzīs", belzt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("belzīs", belzt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("esmu belzis", belzt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esi belzis", belzt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esam belzuši", belzt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esat belzuši", belzt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("ir belzis", belzt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("ir belzuši", belzt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esmu belzusi", belzt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esi belzusi", belzt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esam belzušas", belzt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esat belzušas", belzt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("ir belzusi", belzt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("ir belzušas", belzt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("biju belzis", belzt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("biji belzis", belzt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bijām belzuši", belzt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bijāt belzuši", belzt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bija belzis", belzt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bija belzuši", belzt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("biju belzusi", belzt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("biji belzusi", belzt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bijām belzušas", belzt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bijāt belzušas", belzt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bija belzusi", belzt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bija belzušas", belzt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("būšu belzis", belzt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsi belzis", belzt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsim belzuši", belzt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsiet belzuši", belzt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būs belzis", belzt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būs belzuši", belzt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšu belzusi", belzt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsi belzusi", belzt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsim belzušas", belzt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsiet belzušas", belzt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būs belzusi", belzt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būs belzušas", belzt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("belžot", belzt.AtstāstījumaIzteiksmesVienkāršāTagadne());
            Assert.AreEqual("belzīšot", belzt.AtstāstījumaIzteiksmesVienkāršāNākotne());

            Assert.AreEqual("esot belzis", belzt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot belzis", belzt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot belzis", belzt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot belzuši", belzt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot belzuši", belzt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot belzuši", belzt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot belzusi", belzt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot belzusi", belzt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot belzusi", belzt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot belzušas", belzt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot belzušas", belzt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot belzušas", belzt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("būšot belzis", belzt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot belzis", belzt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot belzis", belzt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot belzuši", belzt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot belzuši", belzt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot belzuši", belzt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot belzusi", belzt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot belzusi", belzt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot belzusi", belzt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot belzušas", belzt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot belzušas", belzt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot belzušas", belzt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("belztu", belzt.VēlējumaIzteiksmesVienkāršāTagadne());

            Assert.AreEqual("būtu belzis", belzt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu belzis", belzt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu belzis", belzt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu belzuši", belzt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu belzuši", belzt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu belzuši", belzt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu belzusi", belzt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu belzusi", belzt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu belzusi", belzt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu belzušas", belzt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu belzušas", belzt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu belzušas", belzt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("ir jābelž", belzt.VajadzībasIzteiksmesVienkāršāTagadne());
            Assert.AreEqual("bija jābelž", belzt.VajadzībasIzteiksmesVienkāršāPagātne());
            Assert.AreEqual("būs jābelž", belzt.VajadzībasIzteiksmesVienkāršāNākotne());
            Assert.AreEqual("ir bijis jābelž", belzt.VajadzībasIzteiksmesSaliktāTagadne());
            Assert.AreEqual("bija bijis jābelž", belzt.VajadzībasIzteiksmesSaliktāPagātne());
            Assert.AreEqual("būs bijis jābelž", belzt.VajadzībasIzteiksmesSaliktāNākotne());
            Assert.AreEqual("esot jābelž", belzt.VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāTagadne());
            Assert.AreEqual("būšot jābelž", belzt.VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāNākotne());
            Assert.AreEqual("būtu jābelž", belzt.VajadzībasIzteiksmesVēlējumaPaveidaVienkāršāTagadne());
            Assert.AreEqual("būtu bijis jābelž", belzt.VajadzībasIzteiksmesVēlējumaPaveidaSaliktāTagadne());

            Assert.AreEqual("belzīsim", belzt.PavēlesIzteiksme(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("belz", belzt.PavēlesIzteiksme(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("belzīsim", belzt.PavēlesIzteiksme(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("belziet", belzt.PavēlesIzteiksme(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("lai belž", belzt.PavēlesIzteiksme(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("lai belž", belzt.PavēlesIzteiksme(PersonasForma.DaudzskaitļaTrešāPersona));
        }

        [Test, Category("I konjugācija 4. grupa")]
        public void Kāpt()
        {
            DarbībasVārds kāpt = new DarbībasVārds("kāpt", "kāpju", "kāpu", Konjugācija.I, 4);
            Assert.That(kāpt.Nenoteiksme, Is.EqualTo("kāpt"));
            Assert.That(kāpt.NenoteiksmesCelms, Is.EqualTo("kāp"));
            Assert.That(kāpt.TagadnesCelms, Is.EqualTo("kāpj"));
            Assert.That(kāpt.PagātnesCelms, Is.EqualTo("kāp"));
            Assert.That(kāpt.Tiešs, Is.EqualTo(true));
            Assert.That(kāpt.Atgriezenisks, Is.EqualTo(false));
            Assert.That(kāpt.Konjugācija, Is.EqualTo(Konjugācija.I));
            Assert.That(kāpt.Grupa, Is.EqualTo(4));

            Assert.AreEqual("kāpju", kāpt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("kāp", kāpt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("kāpjam", kāpt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("kāpjat", kāpt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("kāpj", kāpt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("kāpj", kāpt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("kāpu", kāpt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("kāpi", kāpt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("kāpām", kāpt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("kāpāt", kāpt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("kāpa", kāpt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("kāpa", kāpt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("kāpšu", kāpt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("kāpsi", kāpt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("kāpsim", kāpt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("kāpsiet", kāpt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("kāps", kāpt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("kāps", kāpt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("esmu kāpis", kāpt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esi kāpis", kāpt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esam kāpuši", kāpt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esat kāpuši", kāpt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("ir kāpis", kāpt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("ir kāpuši", kāpt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esmu kāpusi", kāpt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esi kāpusi", kāpt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esam kāpušas", kāpt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esat kāpušas", kāpt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("ir kāpusi", kāpt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("ir kāpušas", kāpt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("biju kāpis", kāpt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("biji kāpis", kāpt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bijām kāpuši", kāpt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bijāt kāpuši", kāpt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bija kāpis", kāpt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bija kāpuši", kāpt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("biju kāpusi", kāpt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("biji kāpusi", kāpt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bijām kāpušas", kāpt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bijāt kāpušas", kāpt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bija kāpusi", kāpt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bija kāpušas", kāpt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("būšu kāpis", kāpt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsi kāpis", kāpt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsim kāpuši", kāpt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsiet kāpuši", kāpt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būs kāpis", kāpt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būs kāpuši", kāpt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšu kāpusi", kāpt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsi kāpusi", kāpt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsim kāpušas", kāpt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsiet kāpušas", kāpt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būs kāpusi", kāpt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būs kāpušas", kāpt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("kāpjot", kāpt.AtstāstījumaIzteiksmesVienkāršāTagadne());
            Assert.AreEqual("kāpšot", kāpt.AtstāstījumaIzteiksmesVienkāršāNākotne());

            Assert.AreEqual("esot kāpis", kāpt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot kāpis", kāpt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot kāpis", kāpt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot kāpuši", kāpt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot kāpuši", kāpt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot kāpuši", kāpt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot kāpusi", kāpt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot kāpusi", kāpt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot kāpusi", kāpt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot kāpušas", kāpt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot kāpušas", kāpt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot kāpušas", kāpt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("būšot kāpis", kāpt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot kāpis", kāpt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot kāpis", kāpt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot kāpuši", kāpt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot kāpuši", kāpt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot kāpuši", kāpt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot kāpusi", kāpt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot kāpusi", kāpt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot kāpusi", kāpt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot kāpušas", kāpt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot kāpušas", kāpt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot kāpušas", kāpt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("kāptu", kāpt.VēlējumaIzteiksmesVienkāršāTagadne());

            Assert.AreEqual("būtu kāpis", kāpt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu kāpis", kāpt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu kāpis", kāpt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu kāpuši", kāpt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu kāpuši", kāpt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu kāpuši", kāpt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu kāpusi", kāpt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu kāpusi", kāpt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu kāpusi", kāpt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu kāpušas", kāpt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu kāpušas", kāpt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu kāpušas", kāpt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("ir jākāpj", kāpt.VajadzībasIzteiksmesVienkāršāTagadne());
            Assert.AreEqual("bija jākāpj", kāpt.VajadzībasIzteiksmesVienkāršāPagātne());
            Assert.AreEqual("būs jākāpj", kāpt.VajadzībasIzteiksmesVienkāršāNākotne());
            Assert.AreEqual("ir bijis jākāpj", kāpt.VajadzībasIzteiksmesSaliktāTagadne());
            Assert.AreEqual("bija bijis jākāpj", kāpt.VajadzībasIzteiksmesSaliktāPagātne());
            Assert.AreEqual("būs bijis jākāpj", kāpt.VajadzībasIzteiksmesSaliktāNākotne());
            Assert.AreEqual("esot jākāpj", kāpt.VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāTagadne());
            Assert.AreEqual("būšot jākāpj", kāpt.VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāNākotne());
            Assert.AreEqual("būtu jākāpj", kāpt.VajadzībasIzteiksmesVēlējumaPaveidaVienkāršāTagadne());
            Assert.AreEqual("būtu bijis jākāpj", kāpt.VajadzībasIzteiksmesVēlējumaPaveidaSaliktāTagadne());

            Assert.AreEqual("kāpsim", kāpt.PavēlesIzteiksme(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("kāp", kāpt.PavēlesIzteiksme(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("kāpsim", kāpt.PavēlesIzteiksme(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("kāpiet", kāpt.PavēlesIzteiksme(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("lai kāpj", kāpt.PavēlesIzteiksme(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("lai kāpj", kāpt.PavēlesIzteiksme(PersonasForma.DaudzskaitļaTrešāPersona));
        }

        [Test, Category("I konjugācija 4. grupa")]
        public void Glābt()
        {
            DarbībasVārds glābt = new DarbībasVārds("glābt", "glābju", "glābu", Konjugācija.I, 4);
            Assert.That(glābt.Nenoteiksme, Is.EqualTo("glābt"));
            Assert.That(glābt.NenoteiksmesCelms, Is.EqualTo("glāb"));
            Assert.That(glābt.TagadnesCelms, Is.EqualTo("glābj"));
            Assert.That(glābt.PagātnesCelms, Is.EqualTo("glāb"));
            Assert.That(glābt.Tiešs, Is.EqualTo(true));
            Assert.That(glābt.Atgriezenisks, Is.EqualTo(false));
            Assert.That(glābt.Konjugācija, Is.EqualTo(Konjugācija.I));
            Assert.That(glābt.Grupa, Is.EqualTo(4));

            Assert.AreEqual("glābju", glābt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("glāb", glābt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("glābjam", glābt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("glābjat", glābt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("glābj", glābt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("glābj", glābt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("glābu", glābt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("glābi", glābt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("glābām", glābt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("glābāt", glābt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("glāba", glābt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("glāba", glābt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("glābšu", glābt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("glābsi", glābt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("glābsim", glābt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("glābsiet", glābt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("glābs", glābt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("glābs", glābt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("esmu glābis", glābt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esi glābis", glābt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esam glābuši", glābt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esat glābuši", glābt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("ir glābis", glābt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("ir glābuši", glābt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esmu glābusi", glābt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esi glābusi", glābt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esam glābušas", glābt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esat glābušas", glābt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("ir glābusi", glābt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("ir glābušas", glābt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("biju glābis", glābt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("biji glābis", glābt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bijām glābuši", glābt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bijāt glābuši", glābt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bija glābis", glābt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bija glābuši", glābt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("biju glābusi", glābt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("biji glābusi", glābt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bijām glābušas", glābt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bijāt glābušas", glābt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bija glābusi", glābt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bija glābušas", glābt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("būšu glābis", glābt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsi glābis", glābt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsim glābuši", glābt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsiet glābuši", glābt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būs glābis", glābt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būs glābuši", glābt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšu glābusi", glābt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsi glābusi", glābt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsim glābušas", glābt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsiet glābušas", glābt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būs glābusi", glābt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būs glābušas", glābt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("glābjot", glābt.AtstāstījumaIzteiksmesVienkāršāTagadne());
            Assert.AreEqual("glābšot", glābt.AtstāstījumaIzteiksmesVienkāršāNākotne());

            Assert.AreEqual("esot glābis", glābt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot glābis", glābt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot glābis", glābt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot glābuši", glābt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot glābuši", glābt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot glābuši", glābt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot glābusi", glābt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot glābusi", glābt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot glābusi", glābt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot glābušas", glābt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot glābušas", glābt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot glābušas", glābt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("būšot glābis", glābt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot glābis", glābt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot glābis", glābt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot glābuši", glābt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot glābuši", glābt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot glābuši", glābt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot glābusi", glābt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot glābusi", glābt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot glābusi", glābt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot glābušas", glābt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot glābušas", glābt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot glābušas", glābt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("glābtu", glābt.VēlējumaIzteiksmesVienkāršāTagadne());

            Assert.AreEqual("būtu glābis", glābt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu glābis", glābt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu glābis", glābt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu glābuši", glābt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu glābuši", glābt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu glābuši", glābt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu glābusi", glābt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu glābusi", glābt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu glābusi", glābt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu glābušas", glābt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu glābušas", glābt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu glābušas", glābt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("ir jāglābj", glābt.VajadzībasIzteiksmesVienkāršāTagadne());
            Assert.AreEqual("bija jāglābj", glābt.VajadzībasIzteiksmesVienkāršāPagātne());
            Assert.AreEqual("būs jāglābj", glābt.VajadzībasIzteiksmesVienkāršāNākotne());
            Assert.AreEqual("ir bijis jāglābj", glābt.VajadzībasIzteiksmesSaliktāTagadne());
            Assert.AreEqual("bija bijis jāglābj", glābt.VajadzībasIzteiksmesSaliktāPagātne());
            Assert.AreEqual("būs bijis jāglābj", glābt.VajadzībasIzteiksmesSaliktāNākotne());
            Assert.AreEqual("esot jāglābj", glābt.VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāTagadne());
            Assert.AreEqual("būšot jāglābj", glābt.VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāNākotne());
            Assert.AreEqual("būtu jāglābj", glābt.VajadzībasIzteiksmesVēlējumaPaveidaVienkāršāTagadne());
            Assert.AreEqual("būtu bijis jāglābj", glābt.VajadzībasIzteiksmesVēlējumaPaveidaSaliktāTagadne());

            Assert.AreEqual("glābsim", glābt.PavēlesIzteiksme(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("glāb", glābt.PavēlesIzteiksme(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("glābsim", glābt.PavēlesIzteiksme(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("glābiet", glābt.PavēlesIzteiksme(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("lai glābj", glābt.PavēlesIzteiksme(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("lai glābj", glābt.PavēlesIzteiksme(PersonasForma.DaudzskaitļaTrešāPersona));
        }

        [Test, Category("I konjugācija 4. grupa")]
        public void Stumt()
        {
            DarbībasVārds stumt = new DarbībasVārds("stumt", "stumju", "stūmu", Konjugācija.I, 4);
            Assert.That(stumt.Nenoteiksme, Is.EqualTo("stumt"));
            Assert.That(stumt.NenoteiksmesCelms, Is.EqualTo("stum"));
            Assert.That(stumt.TagadnesCelms, Is.EqualTo("stumj"));
            Assert.That(stumt.PagātnesCelms, Is.EqualTo("stūm"));
            Assert.That(stumt.Tiešs, Is.EqualTo(true));
            Assert.That(stumt.Atgriezenisks, Is.EqualTo(false));
            Assert.That(stumt.Konjugācija, Is.EqualTo(Konjugācija.I));
            Assert.That(stumt.Grupa, Is.EqualTo(4));

            Assert.AreEqual("stumju", stumt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("stum", stumt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("stumjam", stumt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("stumjat", stumt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("stumj", stumt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("stumj", stumt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("stūmu", stumt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("stūmi", stumt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("stūmām", stumt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("stūmāt", stumt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("stūma", stumt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("stūma", stumt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("stumšu", stumt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("stumsi", stumt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("stumsim", stumt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("stumsiet", stumt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("stums", stumt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("stums", stumt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("esmu stūmis", stumt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esi stūmis", stumt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esam stūmuši", stumt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esat stūmuši", stumt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("ir stūmis", stumt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("ir stūmuši", stumt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esmu stūmusi", stumt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esi stūmusi", stumt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esam stūmušas", stumt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esat stūmušas", stumt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("ir stūmusi", stumt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("ir stūmušas", stumt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("biju stūmis", stumt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("biji stūmis", stumt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bijām stūmuši", stumt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bijāt stūmuši", stumt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bija stūmis", stumt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bija stūmuši", stumt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("biju stūmusi", stumt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("biji stūmusi", stumt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bijām stūmušas", stumt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bijāt stūmušas", stumt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bija stūmusi", stumt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bija stūmušas", stumt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("būšu stūmis", stumt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsi stūmis", stumt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsim stūmuši", stumt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsiet stūmuši", stumt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būs stūmis", stumt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būs stūmuši", stumt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšu stūmusi", stumt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsi stūmusi", stumt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsim stūmušas", stumt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsiet stūmušas", stumt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būs stūmusi", stumt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būs stūmušas", stumt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("stumjot", stumt.AtstāstījumaIzteiksmesVienkāršāTagadne());
            Assert.AreEqual("stumšot", stumt.AtstāstījumaIzteiksmesVienkāršāNākotne());

            Assert.AreEqual("esot stūmis", stumt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot stūmis", stumt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot stūmis", stumt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot stūmuši", stumt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot stūmuši", stumt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot stūmuši", stumt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot stūmusi", stumt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot stūmusi", stumt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot stūmusi", stumt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot stūmušas", stumt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot stūmušas", stumt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot stūmušas", stumt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("būšot stūmis", stumt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot stūmis", stumt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot stūmis", stumt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot stūmuši", stumt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot stūmuši", stumt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot stūmuši", stumt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot stūmusi", stumt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot stūmusi", stumt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot stūmusi", stumt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot stūmušas", stumt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot stūmušas", stumt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot stūmušas", stumt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("stumtu", stumt.VēlējumaIzteiksmesVienkāršāTagadne());

            Assert.AreEqual("būtu stūmis", stumt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu stūmis", stumt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu stūmis", stumt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu stūmuši", stumt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu stūmuši", stumt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu stūmuši", stumt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu stūmusi", stumt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu stūmusi", stumt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu stūmusi", stumt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu stūmušas", stumt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu stūmušas", stumt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu stūmušas", stumt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("ir jāstumj", stumt.VajadzībasIzteiksmesVienkāršāTagadne());
            Assert.AreEqual("bija jāstumj", stumt.VajadzībasIzteiksmesVienkāršāPagātne());
            Assert.AreEqual("būs jāstumj", stumt.VajadzībasIzteiksmesVienkāršāNākotne());
            Assert.AreEqual("ir bijis jāstumj", stumt.VajadzībasIzteiksmesSaliktāTagadne());
            Assert.AreEqual("bija bijis jāstumj", stumt.VajadzībasIzteiksmesSaliktāPagātne());
            Assert.AreEqual("būs bijis jāstumj", stumt.VajadzībasIzteiksmesSaliktāNākotne());
            Assert.AreEqual("esot jāstumj", stumt.VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāTagadne());
            Assert.AreEqual("būšot jāstumj", stumt.VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāNākotne());
            Assert.AreEqual("būtu jāstumj", stumt.VajadzībasIzteiksmesVēlējumaPaveidaVienkāršāTagadne());
            Assert.AreEqual("būtu bijis jāstumj", stumt.VajadzībasIzteiksmesVēlējumaPaveidaSaliktāTagadne());

            Assert.AreEqual("stumsim", stumt.PavēlesIzteiksme(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("stum", stumt.PavēlesIzteiksme(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("stumsim", stumt.PavēlesIzteiksme(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("stumiet", stumt.PavēlesIzteiksme(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("lai stumj", stumt.PavēlesIzteiksme(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("lai stumj", stumt.PavēlesIzteiksme(PersonasForma.DaudzskaitļaTrešāPersona));
        }

        [Test, Category("I konjugācija 4. grupa")]
        public void Braukt()
        {
            DarbībasVārds braukt = new DarbībasVārds("braukt", "braucu", "braucu", Konjugācija.I, 4);
            Assert.That(braukt.Nenoteiksme, Is.EqualTo("braukt"));
            Assert.That(braukt.NenoteiksmesCelms, Is.EqualTo("brauk"));
            Assert.That(braukt.TagadnesCelms, Is.EqualTo("brauc"));
            Assert.That(braukt.PagātnesCelms, Is.EqualTo("brauc"));
            Assert.That(braukt.Tiešs, Is.EqualTo(true));
            Assert.That(braukt.Atgriezenisks, Is.EqualTo(false));
            Assert.That(braukt.Konjugācija, Is.EqualTo(Konjugācija.I));
            Assert.That(braukt.Grupa, Is.EqualTo(4));

            Assert.AreEqual("braucu", braukt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("brauc", braukt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("braucam", braukt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("braucat", braukt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("brauc", braukt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("brauc", braukt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("braucu", braukt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("brauci", braukt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("braucām", braukt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("braucāt", braukt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("brauca", braukt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("brauca", braukt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("braukšu", braukt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("brauksi", braukt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("brauksim", braukt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("brauksiet", braukt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("brauks", braukt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("brauks", braukt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("esmu braucis", braukt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esi braucis", braukt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esam braukuši", braukt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esat braukuši", braukt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("ir braucis", braukt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("ir braukuši", braukt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esmu braukusi", braukt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esi braukusi", braukt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esam braukušas", braukt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esat braukušas", braukt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("ir braukusi", braukt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("ir braukušas", braukt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("biju braucis", braukt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("biji braucis", braukt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bijām braukuši", braukt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bijāt braukuši", braukt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bija braucis", braukt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bija braukuši", braukt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("biju braukusi", braukt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("biji braukusi", braukt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bijām braukušas", braukt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bijāt braukušas", braukt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bija braukusi", braukt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bija braukušas", braukt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("būšu braucis", braukt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsi braucis", braukt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsim braukuši", braukt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsiet braukuši", braukt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būs braucis", braukt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būs braukuši", braukt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšu braukusi", braukt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsi braukusi", braukt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsim braukušas", braukt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsiet braukušas", braukt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būs braukusi", braukt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būs braukušas", braukt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("braucot", braukt.AtstāstījumaIzteiksmesVienkāršāTagadne());
            Assert.AreEqual("braukšot", braukt.AtstāstījumaIzteiksmesVienkāršāNākotne());

            Assert.AreEqual("esot braucis", braukt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot braucis", braukt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot braucis", braukt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot braukuši", braukt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot braukuši", braukt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot braukuši", braukt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot braukusi", braukt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot braukusi", braukt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot braukusi", braukt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot braukušas", braukt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot braukušas", braukt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot braukušas", braukt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("būšot braucis", braukt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot braucis", braukt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot braucis", braukt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot braukuši", braukt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot braukuši", braukt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot braukuši", braukt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot braukusi", braukt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot braukusi", braukt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot braukusi", braukt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot braukušas", braukt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot braukušas", braukt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot braukušas", braukt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("brauktu", braukt.VēlējumaIzteiksmesVienkāršāTagadne());

            Assert.AreEqual("būtu braucis", braukt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu braucis", braukt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu braucis", braukt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu braukuši", braukt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu braukuši", braukt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu braukuši", braukt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu braukusi", braukt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu braukusi", braukt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu braukusi", braukt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu braukušas", braukt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu braukušas", braukt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu braukušas", braukt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("ir jābrauc", braukt.VajadzībasIzteiksmesVienkāršāTagadne());
            Assert.AreEqual("bija jābrauc", braukt.VajadzībasIzteiksmesVienkāršāPagātne());
            Assert.AreEqual("būs jābrauc", braukt.VajadzībasIzteiksmesVienkāršāNākotne());
            Assert.AreEqual("ir bijis jābrauc", braukt.VajadzībasIzteiksmesSaliktāTagadne());
            Assert.AreEqual("bija bijis jābrauc", braukt.VajadzībasIzteiksmesSaliktāPagātne());
            Assert.AreEqual("būs bijis jābrauc", braukt.VajadzībasIzteiksmesSaliktāNākotne());
            Assert.AreEqual("esot jābrauc", braukt.VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāTagadne());
            Assert.AreEqual("būšot jābrauc", braukt.VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāNākotne());
            Assert.AreEqual("būtu jābrauc", braukt.VajadzībasIzteiksmesVēlējumaPaveidaVienkāršāTagadne());
            Assert.AreEqual("būtu bijis jābrauc", braukt.VajadzībasIzteiksmesVēlējumaPaveidaSaliktāTagadne());

            Assert.AreEqual("brauksim", braukt.PavēlesIzteiksme(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("brauc", braukt.PavēlesIzteiksme(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("brauksim", braukt.PavēlesIzteiksme(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("brauciet", braukt.PavēlesIzteiksme(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("lai brauc", braukt.PavēlesIzteiksme(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("lai brauc", braukt.PavēlesIzteiksme(PersonasForma.DaudzskaitļaTrešāPersona));
        }

        [Test, Category("I konjugācija 4. grupa")]
        public void Lūgt()
        {
            DarbībasVārds lūgt = new DarbībasVārds("lūgt", "lūdzu", "lūdzu", Konjugācija.I, 4);
            Assert.That(lūgt.Nenoteiksme, Is.EqualTo("lūgt"));
            Assert.That(lūgt.NenoteiksmesCelms, Is.EqualTo("lūg"));
            Assert.That(lūgt.TagadnesCelms, Is.EqualTo("lūdz"));
            Assert.That(lūgt.PagātnesCelms, Is.EqualTo("lūdz"));
            Assert.That(lūgt.Tiešs, Is.EqualTo(true));
            Assert.That(lūgt.Atgriezenisks, Is.EqualTo(false));
            Assert.That(lūgt.Konjugācija, Is.EqualTo(Konjugācija.I));
            Assert.That(lūgt.Grupa, Is.EqualTo(4));

            Assert.AreEqual("lūdzu", lūgt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("lūdz", lūgt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("lūdzam", lūgt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("lūdzat", lūgt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("lūdz", lūgt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("lūdz", lūgt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("lūdzu", lūgt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("lūdzi", lūgt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("lūdzām", lūgt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("lūdzāt", lūgt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("lūdza", lūgt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("lūdza", lūgt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("lūgšu", lūgt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("lūgsi", lūgt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("lūgsim", lūgt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("lūgsiet", lūgt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("lūgs", lūgt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("lūgs", lūgt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("esmu lūdzis", lūgt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esi lūdzis", lūgt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esam lūguši", lūgt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esat lūguši", lūgt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("ir lūdzis", lūgt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("ir lūguši", lūgt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esmu lūgusi", lūgt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esi lūgusi", lūgt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esam lūgušas", lūgt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esat lūgušas", lūgt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("ir lūgusi", lūgt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("ir lūgušas", lūgt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("biju lūdzis", lūgt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("biji lūdzis", lūgt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bijām lūguši", lūgt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bijāt lūguši", lūgt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bija lūdzis", lūgt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bija lūguši", lūgt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("biju lūgusi", lūgt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("biji lūgusi", lūgt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bijām lūgušas", lūgt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bijāt lūgušas", lūgt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bija lūgusi", lūgt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bija lūgušas", lūgt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("būšu lūdzis", lūgt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsi lūdzis", lūgt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsim lūguši", lūgt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsiet lūguši", lūgt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būs lūdzis", lūgt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būs lūguši", lūgt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšu lūgusi", lūgt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsi lūgusi", lūgt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsim lūgušas", lūgt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsiet lūgušas", lūgt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būs lūgusi", lūgt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būs lūgušas", lūgt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("lūdzot", lūgt.AtstāstījumaIzteiksmesVienkāršāTagadne());
            Assert.AreEqual("lūgšot", lūgt.AtstāstījumaIzteiksmesVienkāršāNākotne());

            Assert.AreEqual("esot lūdzis", lūgt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot lūdzis", lūgt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot lūdzis", lūgt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot lūguši", lūgt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot lūguši", lūgt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot lūguši", lūgt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot lūgusi", lūgt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot lūgusi", lūgt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot lūgusi", lūgt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot lūgušas", lūgt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot lūgušas", lūgt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot lūgušas", lūgt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("būšot lūdzis", lūgt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot lūdzis", lūgt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot lūdzis", lūgt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot lūguši", lūgt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot lūguši", lūgt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot lūguši", lūgt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot lūgusi", lūgt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot lūgusi", lūgt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot lūgusi", lūgt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot lūgušas", lūgt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot lūgušas", lūgt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot lūgušas", lūgt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("lūgtu", lūgt.VēlējumaIzteiksmesVienkāršāTagadne());

            Assert.AreEqual("būtu lūdzis", lūgt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu lūdzis", lūgt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu lūdzis", lūgt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu lūguši", lūgt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu lūguši", lūgt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu lūguši", lūgt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu lūgusi", lūgt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu lūgusi", lūgt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu lūgusi", lūgt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu lūgušas", lūgt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu lūgušas", lūgt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu lūgušas", lūgt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("ir jālūdz", lūgt.VajadzībasIzteiksmesVienkāršāTagadne());
            Assert.AreEqual("bija jālūdz", lūgt.VajadzībasIzteiksmesVienkāršāPagātne());
            Assert.AreEqual("būs jālūdz", lūgt.VajadzībasIzteiksmesVienkāršāNākotne());
            Assert.AreEqual("ir bijis jālūdz", lūgt.VajadzībasIzteiksmesSaliktāTagadne());
            Assert.AreEqual("bija bijis jālūdz", lūgt.VajadzībasIzteiksmesSaliktāPagātne());
            Assert.AreEqual("būs bijis jālūdz", lūgt.VajadzībasIzteiksmesSaliktāNākotne());
            Assert.AreEqual("esot jālūdz", lūgt.VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāTagadne());
            Assert.AreEqual("būšot jālūdz", lūgt.VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāNākotne());
            Assert.AreEqual("būtu jālūdz", lūgt.VajadzībasIzteiksmesVēlējumaPaveidaVienkāršāTagadne());
            Assert.AreEqual("būtu bijis jālūdz", lūgt.VajadzībasIzteiksmesVēlējumaPaveidaSaliktāTagadne());

            Assert.AreEqual("lūgsim", lūgt.PavēlesIzteiksme(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("lūdz", lūgt.PavēlesIzteiksme(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("lūgsim", lūgt.PavēlesIzteiksme(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("lūdziet", lūgt.PavēlesIzteiksme(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("lai lūdz", lūgt.PavēlesIzteiksme(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("lai lūdz", lūgt.PavēlesIzteiksme(PersonasForma.DaudzskaitļaTrešāPersona));
        }

        [Test, Category("I konjugācija 4. grupa")]
        public void Spiest()
        {
            DarbībasVārds spiest = new DarbībasVārds("spiest", "spiežu", "spiedu", Konjugācija.I, 4);
            Assert.That(spiest.Nenoteiksme, Is.EqualTo("spiest"));
            Assert.That(spiest.NenoteiksmesCelms, Is.EqualTo("spies"));
            Assert.That(spiest.TagadnesCelms, Is.EqualTo("spiež"));
            Assert.That(spiest.PagātnesCelms, Is.EqualTo("spied"));
            Assert.That(spiest.Tiešs, Is.EqualTo(true));
            Assert.That(spiest.Atgriezenisks, Is.EqualTo(false));
            Assert.That(spiest.Konjugācija, Is.EqualTo(Konjugācija.I));
            Assert.That(spiest.Grupa, Is.EqualTo(4));

            Assert.AreEqual("spiežu", spiest.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("spied", spiest.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("spiežam", spiest.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("spiežat", spiest.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("spiež", spiest.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("spiež", spiest.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("spiedu", spiest.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("spiedi", spiest.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("spiedām", spiest.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("spiedāt", spiest.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("spieda", spiest.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("spieda", spiest.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("spiedīšu", spiest.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("spiedīsi", spiest.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("spiedīsim", spiest.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("spiedīsiet", spiest.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("spiedīs", spiest.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("spiedīs", spiest.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("esmu spiedis", spiest.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esi spiedis", spiest.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esam spieduši", spiest.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esat spieduši", spiest.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("ir spiedis", spiest.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("ir spieduši", spiest.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esmu spiedusi", spiest.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esi spiedusi", spiest.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esam spiedušas", spiest.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esat spiedušas", spiest.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("ir spiedusi", spiest.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("ir spiedušas", spiest.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("biju spiedis", spiest.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("biji spiedis", spiest.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bijām spieduši", spiest.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bijāt spieduši", spiest.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bija spiedis", spiest.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bija spieduši", spiest.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("biju spiedusi", spiest.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("biji spiedusi", spiest.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bijām spiedušas", spiest.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bijāt spiedušas", spiest.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bija spiedusi", spiest.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bija spiedušas", spiest.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("būšu spiedis", spiest.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsi spiedis", spiest.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsim spieduši", spiest.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsiet spieduši", spiest.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būs spiedis", spiest.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būs spieduši", spiest.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšu spiedusi", spiest.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsi spiedusi", spiest.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsim spiedušas", spiest.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsiet spiedušas", spiest.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būs spiedusi", spiest.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būs spiedušas", spiest.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("spiežot", spiest.AtstāstījumaIzteiksmesVienkāršāTagadne());
            Assert.AreEqual("spiedīšot", spiest.AtstāstījumaIzteiksmesVienkāršāNākotne());

            Assert.AreEqual("esot spiedis", spiest.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot spiedis", spiest.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot spiedis", spiest.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot spieduši", spiest.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot spieduši", spiest.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot spieduši", spiest.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot spiedusi", spiest.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot spiedusi", spiest.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot spiedusi", spiest.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot spiedušas", spiest.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot spiedušas", spiest.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot spiedušas", spiest.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("būšot spiedis", spiest.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot spiedis", spiest.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot spiedis", spiest.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot spieduši", spiest.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot spieduši", spiest.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot spieduši", spiest.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot spiedusi", spiest.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot spiedusi", spiest.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot spiedusi", spiest.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot spiedušas", spiest.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot spiedušas", spiest.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot spiedušas", spiest.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("spiestu", spiest.VēlējumaIzteiksmesVienkāršāTagadne());

            Assert.AreEqual("būtu spiedis", spiest.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu spiedis", spiest.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu spiedis", spiest.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu spieduši", spiest.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu spieduši", spiest.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu spieduši", spiest.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu spiedusi", spiest.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu spiedusi", spiest.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu spiedusi", spiest.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu spiedušas", spiest.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu spiedušas", spiest.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu spiedušas", spiest.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("ir jāspiež", spiest.VajadzībasIzteiksmesVienkāršāTagadne());
            Assert.AreEqual("bija jāspiež", spiest.VajadzībasIzteiksmesVienkāršāPagātne());
            Assert.AreEqual("būs jāspiež", spiest.VajadzībasIzteiksmesVienkāršāNākotne());
            Assert.AreEqual("ir bijis jāspiež", spiest.VajadzībasIzteiksmesSaliktāTagadne());
            Assert.AreEqual("bija bijis jāspiež", spiest.VajadzībasIzteiksmesSaliktāPagātne());
            Assert.AreEqual("būs bijis jāspiež", spiest.VajadzībasIzteiksmesSaliktāNākotne());
            Assert.AreEqual("esot jāspiež", spiest.VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāTagadne());
            Assert.AreEqual("būšot jāspiež", spiest.VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāNākotne());
            Assert.AreEqual("būtu jāspiež", spiest.VajadzībasIzteiksmesVēlējumaPaveidaVienkāršāTagadne());
            Assert.AreEqual("būtu bijis jāspiež", spiest.VajadzībasIzteiksmesVēlējumaPaveidaSaliktāTagadne());

            Assert.AreEqual("spiedīsim", spiest.PavēlesIzteiksme(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("spied", spiest.PavēlesIzteiksme(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("spiedīsim", spiest.PavēlesIzteiksme(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("spiediet", spiest.PavēlesIzteiksme(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("lai spiež", spiest.PavēlesIzteiksme(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("lai spiež", spiest.PavēlesIzteiksme(PersonasForma.DaudzskaitļaTrešāPersona));
        }

        [Test, Category("I konjugācija 4. grupa")]
        public void Pļaut()
        {
            DarbībasVārds pļaut = new DarbībasVārds("pļaut", "pļauju", "pļāvu", Konjugācija.I, 4);
            Assert.That(pļaut.Nenoteiksme, Is.EqualTo("pļaut"));
            Assert.That(pļaut.NenoteiksmesCelms, Is.EqualTo("pļau"));
            Assert.That(pļaut.TagadnesCelms, Is.EqualTo("pļauj"));
            Assert.That(pļaut.PagātnesCelms, Is.EqualTo("pļāv"));
            Assert.That(pļaut.Tiešs, Is.EqualTo(true));
            Assert.That(pļaut.Atgriezenisks, Is.EqualTo(false));
            Assert.That(pļaut.Konjugācija, Is.EqualTo(Konjugācija.I));
            Assert.That(pļaut.Grupa, Is.EqualTo(4));

            Assert.AreEqual("pļauju", pļaut.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("pļauj", pļaut.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("pļaujam", pļaut.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("pļaujat", pļaut.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("pļauj", pļaut.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("pļauj", pļaut.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("pļāvu", pļaut.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("pļāvi", pļaut.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("pļāvām", pļaut.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("pļāvāt", pļaut.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("pļāva", pļaut.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("pļāva", pļaut.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("pļaušu", pļaut.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("pļausi", pļaut.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("pļausim", pļaut.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("pļausiet", pļaut.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("pļaus", pļaut.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("pļaus", pļaut.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("esmu pļāvis", pļaut.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esi pļāvis", pļaut.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esam pļāvuši", pļaut.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esat pļāvuši", pļaut.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("ir pļāvis", pļaut.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("ir pļāvuši", pļaut.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esmu pļāvusi", pļaut.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esi pļāvusi", pļaut.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esam pļāvušas", pļaut.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esat pļāvušas", pļaut.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("ir pļāvusi", pļaut.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("ir pļāvušas", pļaut.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("biju pļāvis", pļaut.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("biji pļāvis", pļaut.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bijām pļāvuši", pļaut.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bijāt pļāvuši", pļaut.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bija pļāvis", pļaut.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bija pļāvuši", pļaut.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("biju pļāvusi", pļaut.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("biji pļāvusi", pļaut.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bijām pļāvušas", pļaut.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bijāt pļāvušas", pļaut.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bija pļāvusi", pļaut.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bija pļāvušas", pļaut.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("būšu pļāvis", pļaut.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsi pļāvis", pļaut.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsim pļāvuši", pļaut.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsiet pļāvuši", pļaut.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būs pļāvis", pļaut.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būs pļāvuši", pļaut.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšu pļāvusi", pļaut.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsi pļāvusi", pļaut.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsim pļāvušas", pļaut.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsiet pļāvušas", pļaut.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būs pļāvusi", pļaut.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būs pļāvušas", pļaut.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("pļaujot", pļaut.AtstāstījumaIzteiksmesVienkāršāTagadne());
            Assert.AreEqual("pļaušot", pļaut.AtstāstījumaIzteiksmesVienkāršāNākotne());

            Assert.AreEqual("esot pļāvis", pļaut.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot pļāvis", pļaut.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot pļāvis", pļaut.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot pļāvuši", pļaut.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot pļāvuši", pļaut.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot pļāvuši", pļaut.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot pļāvusi", pļaut.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot pļāvusi", pļaut.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot pļāvusi", pļaut.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot pļāvušas", pļaut.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot pļāvušas", pļaut.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot pļāvušas", pļaut.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("būšot pļāvis", pļaut.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot pļāvis", pļaut.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot pļāvis", pļaut.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot pļāvuši", pļaut.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot pļāvuši", pļaut.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot pļāvuši", pļaut.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot pļāvusi", pļaut.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot pļāvusi", pļaut.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot pļāvusi", pļaut.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot pļāvušas", pļaut.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot pļāvušas", pļaut.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot pļāvušas", pļaut.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("pļautu", pļaut.VēlējumaIzteiksmesVienkāršāTagadne());

            Assert.AreEqual("būtu pļāvis", pļaut.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu pļāvis", pļaut.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu pļāvis", pļaut.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu pļāvuši", pļaut.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu pļāvuši", pļaut.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu pļāvuši", pļaut.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu pļāvusi", pļaut.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu pļāvusi", pļaut.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu pļāvusi", pļaut.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu pļāvušas", pļaut.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu pļāvušas", pļaut.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu pļāvušas", pļaut.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("ir jāpļauj", pļaut.VajadzībasIzteiksmesVienkāršāTagadne());
            Assert.AreEqual("bija jāpļauj", pļaut.VajadzībasIzteiksmesVienkāršāPagātne());
            Assert.AreEqual("būs jāpļauj", pļaut.VajadzībasIzteiksmesVienkāršāNākotne());
            Assert.AreEqual("ir bijis jāpļauj", pļaut.VajadzībasIzteiksmesSaliktāTagadne());
            Assert.AreEqual("bija bijis jāpļauj", pļaut.VajadzībasIzteiksmesSaliktāPagātne());
            Assert.AreEqual("būs bijis jāpļauj", pļaut.VajadzībasIzteiksmesSaliktāNākotne());
            Assert.AreEqual("esot jāpļauj", pļaut.VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāTagadne());
            Assert.AreEqual("būšot jāpļauj", pļaut.VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāNākotne());
            Assert.AreEqual("būtu jāpļauj", pļaut.VajadzībasIzteiksmesVēlējumaPaveidaVienkāršāTagadne());
            Assert.AreEqual("būtu bijis jāpļauj", pļaut.VajadzībasIzteiksmesVēlējumaPaveidaSaliktāTagadne());

            Assert.AreEqual("pļausim", pļaut.PavēlesIzteiksme(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("pļauj", pļaut.PavēlesIzteiksme(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("pļausim", pļaut.PavēlesIzteiksme(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("pļaujiet", pļaut.PavēlesIzteiksme(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("lai pļauj", pļaut.PavēlesIzteiksme(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("lai pļauj", pļaut.PavēlesIzteiksme(PersonasForma.DaudzskaitļaTrešāPersona));
        }

        [Test, Category("I konjugācija 4. grupa")]
        public void Šūt()
        {
            DarbībasVārds šūt = new DarbībasVārds("šūt", "šuju", "šuvu", Konjugācija.I, 4);
            Assert.That(šūt.Nenoteiksme, Is.EqualTo("šūt"));
            Assert.That(šūt.NenoteiksmesCelms, Is.EqualTo("šū"));
            Assert.That(šūt.TagadnesCelms, Is.EqualTo("šuj"));
            Assert.That(šūt.PagātnesCelms, Is.EqualTo("šuv"));
            Assert.That(šūt.Tiešs, Is.EqualTo(true));
            Assert.That(šūt.Atgriezenisks, Is.EqualTo(false));
            Assert.That(šūt.Konjugācija, Is.EqualTo(Konjugācija.I));
            Assert.That(šūt.Grupa, Is.EqualTo(4));

            Assert.AreEqual("šuju", šūt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("šuj", šūt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("šujam", šūt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("šujat", šūt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("šuj", šūt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("šuj", šūt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("šuvu", šūt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("šuvi", šūt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("šuvām", šūt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("šuvāt", šūt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("šuva", šūt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("šuva", šūt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("šūšu", šūt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("šūsi", šūt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("šūsim", šūt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("šūsiet", šūt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("šūs", šūt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("šūs", šūt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("esmu šuvis", šūt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esi šuvis", šūt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esam šuvuši", šūt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esat šuvuši", šūt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("ir šuvis", šūt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("ir šuvuši", šūt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esmu šuvusi", šūt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esi šuvusi", šūt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esam šuvušas", šūt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esat šuvušas", šūt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("ir šuvusi", šūt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("ir šuvušas", šūt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("biju šuvis", šūt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("biji šuvis", šūt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bijām šuvuši", šūt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bijāt šuvuši", šūt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bija šuvis", šūt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bija šuvuši", šūt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("biju šuvusi", šūt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("biji šuvusi", šūt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bijām šuvušas", šūt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bijāt šuvušas", šūt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bija šuvusi", šūt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bija šuvušas", šūt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("būšu šuvis", šūt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsi šuvis", šūt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsim šuvuši", šūt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsiet šuvuši", šūt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būs šuvis", šūt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būs šuvuši", šūt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšu šuvusi", šūt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsi šuvusi", šūt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsim šuvušas", šūt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsiet šuvušas", šūt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būs šuvusi", šūt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būs šuvušas", šūt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("šujot", šūt.AtstāstījumaIzteiksmesVienkāršāTagadne());
            Assert.AreEqual("šūšot", šūt.AtstāstījumaIzteiksmesVienkāršāNākotne());

            Assert.AreEqual("esot šuvis", šūt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot šuvis", šūt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot šuvis", šūt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot šuvuši", šūt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot šuvuši", šūt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot šuvuši", šūt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot šuvusi", šūt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot šuvusi", šūt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot šuvusi", šūt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot šuvušas", šūt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot šuvušas", šūt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot šuvušas", šūt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("būšot šuvis", šūt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot šuvis", šūt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot šuvis", šūt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot šuvuši", šūt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot šuvuši", šūt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot šuvuši", šūt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot šuvusi", šūt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot šuvusi", šūt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot šuvusi", šūt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot šuvušas", šūt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot šuvušas", šūt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot šuvušas", šūt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("šūtu", šūt.VēlējumaIzteiksmesVienkāršāTagadne());

            Assert.AreEqual("būtu šuvis", šūt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu šuvis", šūt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu šuvis", šūt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu šuvuši", šūt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu šuvuši", šūt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu šuvuši", šūt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu šuvusi", šūt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu šuvusi", šūt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu šuvusi", šūt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu šuvušas", šūt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu šuvušas", šūt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu šuvušas", šūt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("ir jāšuj", šūt.VajadzībasIzteiksmesVienkāršāTagadne());
            Assert.AreEqual("bija jāšuj", šūt.VajadzībasIzteiksmesVienkāršāPagātne());
            Assert.AreEqual("būs jāšuj", šūt.VajadzībasIzteiksmesVienkāršāNākotne());
            Assert.AreEqual("ir bijis jāšuj", šūt.VajadzībasIzteiksmesSaliktāTagadne());
            Assert.AreEqual("bija bijis jāšuj", šūt.VajadzībasIzteiksmesSaliktāPagātne());
            Assert.AreEqual("būs bijis jāšuj", šūt.VajadzībasIzteiksmesSaliktāNākotne());
            Assert.AreEqual("esot jāšuj", šūt.VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāTagadne());
            Assert.AreEqual("būšot jāšuj", šūt.VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāNākotne());
            Assert.AreEqual("būtu jāšuj", šūt.VajadzībasIzteiksmesVēlējumaPaveidaVienkāršāTagadne());
            Assert.AreEqual("būtu bijis jāšuj", šūt.VajadzībasIzteiksmesVēlējumaPaveidaSaliktāTagadne());

            Assert.AreEqual("šūsim", šūt.PavēlesIzteiksme(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("šuj", šūt.PavēlesIzteiksme(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("šūsim", šūt.PavēlesIzteiksme(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("šujiet", šūt.PavēlesIzteiksme(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("lai šuj", šūt.PavēlesIzteiksme(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("lai šuj", šūt.PavēlesIzteiksme(PersonasForma.DaudzskaitļaTrešāPersona));
        }

        [Test, Category("I konjugācija 4. grupa")]
        public void Sēt()
        {
            DarbībasVārds sēt = new DarbībasVārds("sēt", "sēju", "sēju", Konjugācija.I, 4);
            Assert.That(sēt.Nenoteiksme, Is.EqualTo("sēt"));
            Assert.That(sēt.NenoteiksmesCelms, Is.EqualTo("sē"));
            Assert.That(sēt.TagadnesCelms, Is.EqualTo("sēj"));
            Assert.That(sēt.PagātnesCelms, Is.EqualTo("sēj"));
            Assert.That(sēt.Tiešs, Is.EqualTo(true));
            Assert.That(sēt.Atgriezenisks, Is.EqualTo(false));
            Assert.That(sēt.Konjugācija, Is.EqualTo(Konjugācija.I));
            Assert.That(sēt.Grupa, Is.EqualTo(4));

            Assert.AreEqual("sēju", sēt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("sēj", sēt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("sējam", sēt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("sējat", sēt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("sēj", sēt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("sēj", sēt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("sēju", sēt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("sēji", sēt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("sējām", sēt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("sējāt", sēt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("sēja", sēt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("sēja", sēt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("sēšu", sēt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("sēsi", sēt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("sēsim", sēt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("sēsiet", sēt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("sēs", sēt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("sēs", sēt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("esmu sējis", sēt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esi sējis", sēt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esam sējuši", sēt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esat sējuši", sēt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("ir sējis", sēt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("ir sējuši", sēt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esmu sējusi", sēt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esi sējusi", sēt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esam sējušas", sēt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esat sējušas", sēt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("ir sējusi", sēt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("ir sējušas", sēt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("biju sējis", sēt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("biji sējis", sēt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bijām sējuši", sēt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bijāt sējuši", sēt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bija sējis", sēt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bija sējuši", sēt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("biju sējusi", sēt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("biji sējusi", sēt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bijām sējušas", sēt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bijāt sējušas", sēt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bija sējusi", sēt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bija sējušas", sēt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("būšu sējis", sēt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsi sējis", sēt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsim sējuši", sēt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsiet sējuši", sēt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būs sējis", sēt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būs sējuši", sēt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšu sējusi", sēt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsi sējusi", sēt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsim sējušas", sēt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsiet sējušas", sēt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būs sējusi", sēt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būs sējušas", sēt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("sējot", sēt.AtstāstījumaIzteiksmesVienkāršāTagadne());
            Assert.AreEqual("sēšot", sēt.AtstāstījumaIzteiksmesVienkāršāNākotne());

            Assert.AreEqual("esot sējis", sēt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot sējis", sēt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot sējis", sēt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot sējuši", sēt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot sējuši", sēt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot sējuši", sēt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot sējusi", sēt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot sējusi", sēt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot sējusi", sēt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot sējušas", sēt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot sējušas", sēt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot sējušas", sēt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("būšot sējis", sēt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot sējis", sēt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot sējis", sēt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot sējuši", sēt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot sējuši", sēt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot sējuši", sēt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot sējusi", sēt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot sējusi", sēt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot sējusi", sēt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot sējušas", sēt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot sējušas", sēt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot sējušas", sēt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("sētu", sēt.VēlējumaIzteiksmesVienkāršāTagadne());

            Assert.AreEqual("būtu sējis", sēt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu sējis", sēt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu sējis", sēt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu sējuši", sēt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu sējuši", sēt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu sējuši", sēt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu sējusi", sēt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu sējusi", sēt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu sējusi", sēt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu sējušas", sēt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu sējušas", sēt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu sējušas", sēt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("ir jāsēj", sēt.VajadzībasIzteiksmesVienkāršāTagadne());
            Assert.AreEqual("bija jāsēj", sēt.VajadzībasIzteiksmesVienkāršāPagātne());
            Assert.AreEqual("būs jāsēj", sēt.VajadzībasIzteiksmesVienkāršāNākotne());
            Assert.AreEqual("ir bijis jāsēj", sēt.VajadzībasIzteiksmesSaliktāTagadne());
            Assert.AreEqual("bija bijis jāsēj", sēt.VajadzībasIzteiksmesSaliktāPagātne());
            Assert.AreEqual("būs bijis jāsēj", sēt.VajadzībasIzteiksmesSaliktāNākotne());
            Assert.AreEqual("esot jāsēj", sēt.VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāTagadne());
            Assert.AreEqual("būšot jāsēj", sēt.VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāNākotne());
            Assert.AreEqual("būtu jāsēj", sēt.VajadzībasIzteiksmesVēlējumaPaveidaVienkāršāTagadne());
            Assert.AreEqual("būtu bijis jāsēj", sēt.VajadzībasIzteiksmesVēlējumaPaveidaSaliktāTagadne());

            Assert.AreEqual("sēsim", sēt.PavēlesIzteiksme(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("sēj", sēt.PavēlesIzteiksme(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("sēsim", sēt.PavēlesIzteiksme(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("sējiet", sēt.PavēlesIzteiksme(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("lai sēj", sēt.PavēlesIzteiksme(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("lai sēj", sēt.PavēlesIzteiksme(PersonasForma.DaudzskaitļaTrešāPersona));
        }

        [Test, Category("I konjugācija 4. grupa")]
        public void Bērt()
        {
            DarbībasVārds bērt = new DarbībasVārds("bērt", "beru", "bēru", Konjugācija.I, 4);
            Assert.That(bērt.Nenoteiksme, Is.EqualTo("bērt"));
            Assert.That(bērt.NenoteiksmesCelms, Is.EqualTo("bēr"));
            Assert.That(bērt.TagadnesCelms, Is.EqualTo("ber"));
            Assert.That(bērt.PagātnesCelms, Is.EqualTo("bēr"));
            Assert.That(bērt.Tiešs, Is.EqualTo(true));
            Assert.That(bērt.Atgriezenisks, Is.EqualTo(false));
            Assert.That(bērt.Konjugācija, Is.EqualTo(Konjugācija.I));
            Assert.That(bērt.Grupa, Is.EqualTo(4));

            Assert.AreEqual("beru", bērt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("ber", bērt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("beram", bērt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("berat", bērt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("ber", bērt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("ber", bērt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("bēru", bērt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("bēri", bērt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("bērām", bērt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("bērāt", bērt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("bēra", bērt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("bēra", bērt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("bēršu", bērt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("bērsi", bērt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("bērsim", bērt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("bērsiet", bērt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("bērs", bērt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("bērs", bērt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("esmu bēris", bērt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esi bēris", bērt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esam bēruši", bērt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esat bēruši", bērt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("ir bēris", bērt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("ir bēruši", bērt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esmu bērusi", bērt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esi bērusi", bērt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esam bērušas", bērt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esat bērušas", bērt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("ir bērusi", bērt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("ir bērušas", bērt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("biju bēris", bērt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("biji bēris", bērt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bijām bēruši", bērt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bijāt bēruši", bērt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bija bēris", bērt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bija bēruši", bērt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("biju bērusi", bērt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("biji bērusi", bērt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bijām bērušas", bērt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bijāt bērušas", bērt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bija bērusi", bērt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bija bērušas", bērt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("būšu bēris", bērt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsi bēris", bērt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsim bēruši", bērt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsiet bēruši", bērt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būs bēris", bērt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būs bēruši", bērt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšu bērusi", bērt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsi bērusi", bērt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsim bērušas", bērt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsiet bērušas", bērt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būs bērusi", bērt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būs bērušas", bērt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("berot", bērt.AtstāstījumaIzteiksmesVienkāršāTagadne());
            Assert.AreEqual("bēršot", bērt.AtstāstījumaIzteiksmesVienkāršāNākotne());

            Assert.AreEqual("esot bēris", bērt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot bēris", bērt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot bēris", bērt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot bēruši", bērt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot bēruši", bērt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot bēruši", bērt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot bērusi", bērt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot bērusi", bērt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot bērusi", bērt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot bērušas", bērt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot bērušas", bērt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot bērušas", bērt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("būšot bēris", bērt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot bēris", bērt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot bēris", bērt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot bēruši", bērt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot bēruši", bērt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot bēruši", bērt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot bērusi", bērt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot bērusi", bērt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot bērusi", bērt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot bērušas", bērt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot bērušas", bērt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot bērušas", bērt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("bērtu", bērt.VēlējumaIzteiksmesVienkāršāTagadne());

            Assert.AreEqual("būtu bēris", bērt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu bēris", bērt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu bēris", bērt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu bēruši", bērt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu bēruši", bērt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu bēruši", bērt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu bērusi", bērt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu bērusi", bērt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu bērusi", bērt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu bērušas", bērt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu bērušas", bērt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu bērušas", bērt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("ir jāber", bērt.VajadzībasIzteiksmesVienkāršāTagadne());
            Assert.AreEqual("bija jāber", bērt.VajadzībasIzteiksmesVienkāršāPagātne());
            Assert.AreEqual("būs jāber", bērt.VajadzībasIzteiksmesVienkāršāNākotne());
            Assert.AreEqual("ir bijis jāber", bērt.VajadzībasIzteiksmesSaliktāTagadne());
            Assert.AreEqual("bija bijis jāber", bērt.VajadzībasIzteiksmesSaliktāPagātne());
            Assert.AreEqual("būs bijis jāber", bērt.VajadzībasIzteiksmesSaliktāNākotne());
            Assert.AreEqual("esot jāber", bērt.VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāTagadne());
            Assert.AreEqual("būšot jāber", bērt.VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāNākotne());
            Assert.AreEqual("būtu jāber", bērt.VajadzībasIzteiksmesVēlējumaPaveidaVienkāršāTagadne());
            Assert.AreEqual("būtu bijis jāber", bērt.VajadzībasIzteiksmesVēlējumaPaveidaSaliktāTagadne());

            Assert.AreEqual("bērsim", bērt.PavēlesIzteiksme(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("ber", bērt.PavēlesIzteiksme(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("bērsim", bērt.PavēlesIzteiksme(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("beriet", bērt.PavēlesIzteiksme(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("lai ber", bērt.PavēlesIzteiksme(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("lai ber", bērt.PavēlesIzteiksme(PersonasForma.DaudzskaitļaTrešāPersona));
        }

        [Test, Category("I konjugācija 5. grupa")]
        public void Silt()
        {
            DarbībasVārds silt = new DarbībasVārds("silt", "silstu", "silu", Konjugācija.I, 5);
            Assert.That(silt.Nenoteiksme, Is.EqualTo("silt"));
            Assert.That(silt.NenoteiksmesCelms, Is.EqualTo("sil"));
            Assert.That(silt.TagadnesCelms, Is.EqualTo("silst"));
            Assert.That(silt.PagātnesCelms, Is.EqualTo("sil"));
            Assert.That(silt.Tiešs, Is.EqualTo(true));
            Assert.That(silt.Atgriezenisks, Is.EqualTo(false));
            Assert.That(silt.Konjugācija, Is.EqualTo(Konjugācija.I));
            Assert.That(silt.Grupa, Is.EqualTo(5));

            Assert.AreEqual("silstu", silt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("silsti", silt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("silstam", silt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("silstat", silt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("silst", silt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("silst", silt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("silu", silt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("sili", silt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("silām", silt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("silāt", silt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("sila", silt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("sila", silt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("silšu", silt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("silsi", silt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("silsim", silt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("silsiet", silt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("sils", silt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("sils", silt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("esmu silis", silt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esi silis", silt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esam siluši", silt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esat siluši", silt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("ir silis", silt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("ir siluši", silt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esmu silusi", silt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esi silusi", silt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esam silušas", silt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esat silušas", silt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("ir silusi", silt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("ir silušas", silt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("biju silis", silt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("biji silis", silt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bijām siluši", silt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bijāt siluši", silt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bija silis", silt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bija siluši", silt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("biju silusi", silt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("biji silusi", silt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bijām silušas", silt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bijāt silušas", silt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bija silusi", silt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bija silušas", silt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("būšu silis", silt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsi silis", silt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsim siluši", silt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsiet siluši", silt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būs silis", silt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būs siluši", silt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšu silusi", silt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsi silusi", silt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsim silušas", silt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsiet silušas", silt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būs silusi", silt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būs silušas", silt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("silstot", silt.AtstāstījumaIzteiksmesVienkāršāTagadne());
            Assert.AreEqual("silšot", silt.AtstāstījumaIzteiksmesVienkāršāNākotne());

            Assert.AreEqual("esot silis", silt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot silis", silt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot silis", silt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot siluši", silt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot siluši", silt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot siluši", silt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot silusi", silt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot silusi", silt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot silusi", silt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot silušas", silt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot silušas", silt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot silušas", silt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("būšot silis", silt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot silis", silt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot silis", silt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot siluši", silt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot siluši", silt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot siluši", silt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot silusi", silt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot silusi", silt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot silusi", silt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot silušas", silt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot silušas", silt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot silušas", silt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("siltu", silt.VēlējumaIzteiksmesVienkāršāTagadne());

            Assert.AreEqual("būtu silis", silt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu silis", silt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu silis", silt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu siluši", silt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu siluši", silt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu siluši", silt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu silusi", silt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu silusi", silt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu silusi", silt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu silušas", silt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu silušas", silt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu silušas", silt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("ir jāsilst", silt.VajadzībasIzteiksmesVienkāršāTagadne());
            Assert.AreEqual("bija jāsilst", silt.VajadzībasIzteiksmesVienkāršāPagātne());
            Assert.AreEqual("būs jāsilst", silt.VajadzībasIzteiksmesVienkāršāNākotne());
            Assert.AreEqual("ir bijis jāsilst", silt.VajadzībasIzteiksmesSaliktāTagadne());
            Assert.AreEqual("bija bijis jāsilst", silt.VajadzībasIzteiksmesSaliktāPagātne());
            Assert.AreEqual("būs bijis jāsilst", silt.VajadzībasIzteiksmesSaliktāNākotne());
            Assert.AreEqual("esot jāsilst", silt.VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāTagadne());
            Assert.AreEqual("būšot jāsilst", silt.VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāNākotne());
            Assert.AreEqual("būtu jāsilst", silt.VajadzībasIzteiksmesVēlējumaPaveidaVienkāršāTagadne());
            Assert.AreEqual("būtu bijis jāsilst", silt.VajadzībasIzteiksmesVēlējumaPaveidaSaliktāTagadne());

            Assert.AreEqual("silsim", silt.PavēlesIzteiksme(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("silsti", silt.PavēlesIzteiksme(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("silsim", silt.PavēlesIzteiksme(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("silstiet", silt.PavēlesIzteiksme(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("lai silst", silt.PavēlesIzteiksme(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("lai silst", silt.PavēlesIzteiksme(PersonasForma.DaudzskaitļaTrešāPersona));
        }

        [Test, Category("I konjugācija 5. grupa")]
        public void Atbilst()
        {
            DarbībasVārds atbilst = new DarbībasVārds("atbilst", "atbilstu", "atbildu", Konjugācija.I, 5);
            Assert.That(atbilst.Nenoteiksme, Is.EqualTo("atbilst"));
            Assert.That(atbilst.NenoteiksmesCelms, Is.EqualTo("atbils"));
            Assert.That(atbilst.TagadnesCelms, Is.EqualTo("atbilst"));
            Assert.That(atbilst.PagātnesCelms, Is.EqualTo("atbild"));
            Assert.That(atbilst.Tiešs, Is.EqualTo(true));
            Assert.That(atbilst.Atgriezenisks, Is.EqualTo(false));
            Assert.That(atbilst.Konjugācija, Is.EqualTo(Konjugācija.I));
            Assert.That(atbilst.Grupa, Is.EqualTo(5));

            Assert.AreEqual("atbilstu", atbilst.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("atbilsti", atbilst.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("atbilstam", atbilst.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("atbilstat", atbilst.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("atbilst", atbilst.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("atbilst", atbilst.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("atbildu", atbilst.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("atbildi", atbilst.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("atbildām", atbilst.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("atbildāt", atbilst.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("atbilda", atbilst.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("atbilda", atbilst.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("atbildīšu", atbilst.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("atbildīsi", atbilst.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("atbildīsim", atbilst.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("atbildīsiet", atbilst.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("atbildīs", atbilst.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("atbildīs", atbilst.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("esmu atbildis", atbilst.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esi atbildis", atbilst.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esam atbilduši", atbilst.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esat atbilduši", atbilst.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("ir atbildis", atbilst.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("ir atbilduši", atbilst.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esmu atbildusi", atbilst.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esi atbildusi", atbilst.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esam atbildušas", atbilst.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esat atbildušas", atbilst.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("ir atbildusi", atbilst.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("ir atbildušas", atbilst.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("biju atbildis", atbilst.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("biji atbildis", atbilst.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bijām atbilduši", atbilst.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bijāt atbilduši", atbilst.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bija atbildis", atbilst.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bija atbilduši", atbilst.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("biju atbildusi", atbilst.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("biji atbildusi", atbilst.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bijām atbildušas", atbilst.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bijāt atbildušas", atbilst.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bija atbildusi", atbilst.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bija atbildušas", atbilst.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("būšu atbildis", atbilst.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsi atbildis", atbilst.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsim atbilduši", atbilst.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsiet atbilduši", atbilst.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būs atbildis", atbilst.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būs atbilduši", atbilst.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšu atbildusi", atbilst.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsi atbildusi", atbilst.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsim atbildušas", atbilst.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsiet atbildušas", atbilst.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būs atbildusi", atbilst.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būs atbildušas", atbilst.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("atbilstot", atbilst.AtstāstījumaIzteiksmesVienkāršāTagadne());
            Assert.AreEqual("atbildīšot", atbilst.AtstāstījumaIzteiksmesVienkāršāNākotne());

            Assert.AreEqual("esot atbildis", atbilst.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot atbildis", atbilst.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot atbildis", atbilst.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot atbilduši", atbilst.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot atbilduši", atbilst.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot atbilduši", atbilst.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot atbildusi", atbilst.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot atbildusi", atbilst.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot atbildusi", atbilst.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot atbildušas", atbilst.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot atbildušas", atbilst.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot atbildušas", atbilst.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("būšot atbildis", atbilst.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot atbildis", atbilst.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot atbildis", atbilst.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot atbilduši", atbilst.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot atbilduši", atbilst.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot atbilduši", atbilst.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot atbildusi", atbilst.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot atbildusi", atbilst.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot atbildusi", atbilst.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot atbildušas", atbilst.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot atbildušas", atbilst.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot atbildušas", atbilst.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("atbilstu", atbilst.VēlējumaIzteiksmesVienkāršāTagadne());

            Assert.AreEqual("būtu atbildis", atbilst.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu atbildis", atbilst.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu atbildis", atbilst.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu atbilduši", atbilst.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu atbilduši", atbilst.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu atbilduši", atbilst.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu atbildusi", atbilst.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu atbildusi", atbilst.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu atbildusi", atbilst.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu atbildušas", atbilst.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu atbildušas", atbilst.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu atbildušas", atbilst.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("ir jāatbilst", atbilst.VajadzībasIzteiksmesVienkāršāTagadne());
            Assert.AreEqual("bija jāatbilst", atbilst.VajadzībasIzteiksmesVienkāršāPagātne());
            Assert.AreEqual("būs jāatbilst", atbilst.VajadzībasIzteiksmesVienkāršāNākotne());
            Assert.AreEqual("ir bijis jāatbilst", atbilst.VajadzībasIzteiksmesSaliktāTagadne());
            Assert.AreEqual("bija bijis jāatbilst", atbilst.VajadzībasIzteiksmesSaliktāPagātne());
            Assert.AreEqual("būs bijis jāatbilst", atbilst.VajadzībasIzteiksmesSaliktāNākotne());
            Assert.AreEqual("esot jāatbilst", atbilst.VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāTagadne());
            Assert.AreEqual("būšot jāatbilst", atbilst.VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāNākotne());
            Assert.AreEqual("būtu jāatbilst", atbilst.VajadzībasIzteiksmesVēlējumaPaveidaVienkāršāTagadne());
            Assert.AreEqual("būtu bijis jāatbilst", atbilst.VajadzībasIzteiksmesVēlējumaPaveidaSaliktāTagadne());

            Assert.AreEqual("atbildīsim", atbilst.PavēlesIzteiksme(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("atbilsti", atbilst.PavēlesIzteiksme(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("atbildīsim", atbilst.PavēlesIzteiksme(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("atbilstiet", atbilst.PavēlesIzteiksme(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("lai atbilst", atbilst.PavēlesIzteiksme(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("lai atbilst", atbilst.PavēlesIzteiksme(PersonasForma.DaudzskaitļaTrešāPersona));
        }

        [Test, Category("I konjugācija 0. grupa")]
        public void Glābties()
        {
            DarbībasVārds glābties = new DarbībasVārds("glābties", "glābjos", "glābos", Konjugācija.I, 0);
            Assert.That(glābties.Nenoteiksme, Is.EqualTo("glābties"));
            Assert.That(glābties.NenoteiksmesCelms, Is.EqualTo("glāb"));
            Assert.That(glābties.TagadnesCelms, Is.EqualTo("glābj"));
            Assert.That(glābties.PagātnesCelms, Is.EqualTo("glāb"));
            Assert.That(glābties.Tiešs, Is.EqualTo(false));
            Assert.That(glābties.Atgriezenisks, Is.EqualTo(true));
            Assert.That(glābties.Konjugācija, Is.EqualTo(Konjugācija.I));
            Assert.That(glābties.Grupa, Is.EqualTo(0));

            Assert.AreEqual("glābjos", glābties.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("glābies", glābties.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("glābjamies", glābties.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("glābjaties", glābties.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("glābjas", glābties.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("glābjas", glābties.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("glābos", glābties.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("glābies", glābties.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("glābāmies", glābties.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("glābāties", glābties.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("glābās", glābties.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("glābās", glābties.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("glābšos", glābties.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("glābsies", glābties.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("glābsimies", glābties.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("glābsieties", glābties.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("glābsies", glābties.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("glābsies", glābties.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("esmu glābies", glābties.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esi glābies", glābties.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esam glābušies", glābties.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esat glābušies", glābties.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("ir glābies", glābties.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("ir glābušies", glābties.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esmu glābusies", glābties.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esi glābusies", glābties.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esam glābušās", glābties.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esat glābušās", glābties.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("ir glābusies", glābties.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("ir glābušās", glābties.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("biju glābies", glābties.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("biji glābies", glābties.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bijām glābušies", glābties.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bijāt glābušies", glābties.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bija glābies", glābties.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bija glābušies", glābties.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("biju glābusies", glābties.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("biji glābusies", glābties.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bijām glābušās", glābties.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bijāt glābušās", glābties.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bija glābusies", glābties.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bija glābušās", glābties.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("būšu glābies", glābties.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsi glābies", glābties.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsim glābušies", glābties.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsiet glābušies", glābties.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būs glābies", glābties.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būs glābušies", glābties.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšu glābusies", glābties.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsi glābusies", glābties.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsim glābušās", glābties.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsiet glābušās", glābties.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būs glābusies", glābties.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būs glābušās", glābties.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("glābjoties", glābties.AtstāstījumaIzteiksmesVienkāršāTagadne());
            Assert.AreEqual("glābšoties", glābties.AtstāstījumaIzteiksmesVienkāršāNākotne());

            Assert.AreEqual("esot glābies", glābties.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot glābies", glābties.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot glābies", glābties.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot glābušies", glābties.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot glābušies", glābties.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot glābušies", glābties.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot glābusies", glābties.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot glābusies", glābties.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot glābusies", glābties.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot glābušās", glābties.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot glābušās", glābties.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot glābušās", glābties.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("būšot glābies", glābties.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot glābies", glābties.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot glābies", glābties.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot glābušies", glābties.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot glābušies", glābties.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot glābušies", glābties.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot glābusies", glābties.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot glābusies", glābties.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot glābusies", glābties.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot glābušās", glābties.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot glābušās", glābties.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot glābušās", glābties.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("glābtos", glābties.VēlējumaIzteiksmesVienkāršāTagadne());

            Assert.AreEqual("būtu glābies", glābties.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu glābies", glābties.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu glābies", glābties.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu glābušies", glābties.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu glābušies", glābties.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu glābušies", glābties.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu glābusies", glābties.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu glābusies", glābties.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu glābusies", glābties.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu glābušās", glābties.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu glābušās", glābties.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu glābušās", glābties.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("ir jāglābjas", glābties.VajadzībasIzteiksmesVienkāršāTagadne());
            Assert.AreEqual("bija jāglābjas", glābties.VajadzībasIzteiksmesVienkāršāPagātne());
            Assert.AreEqual("būs jāglābjas", glābties.VajadzībasIzteiksmesVienkāršāNākotne());
            Assert.AreEqual("ir bijis jāglābjas", glābties.VajadzībasIzteiksmesSaliktāTagadne());
            Assert.AreEqual("bija bijis jāglābjas", glābties.VajadzībasIzteiksmesSaliktāPagātne());
            Assert.AreEqual("būs bijis jāglābjas", glābties.VajadzībasIzteiksmesSaliktāNākotne());
            Assert.AreEqual("esot jāglābjas", glābties.VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāTagadne());
            Assert.AreEqual("būšot jāglābjas", glābties.VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāNākotne());
            Assert.AreEqual("būtu jāglābjas", glābties.VajadzībasIzteiksmesVēlējumaPaveidaVienkāršāTagadne());
            Assert.AreEqual("būtu bijis jāglābjas", glābties.VajadzībasIzteiksmesVēlējumaPaveidaSaliktāTagadne());

            Assert.AreEqual("glābsimies", glābties.PavēlesIzteiksme(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("glābies", glābties.PavēlesIzteiksme(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("glābsimies", glābties.PavēlesIzteiksme(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("glābieties", glābties.PavēlesIzteiksme(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("lai glābjas", glābties.PavēlesIzteiksme(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("lai glābjas", glābties.PavēlesIzteiksme(PersonasForma.DaudzskaitļaTrešāPersona));
        }

        [Test, Category("I konjugācija 0. grupa")]
        public void Apvelties()
        {
            DarbībasVārds apvelties = new DarbībasVārds("apvelties", "apveļos", "apvēlos", Konjugācija.I, 0);
            Assert.That(apvelties.Nenoteiksme, Is.EqualTo("apvelties"));
            Assert.That(apvelties.NenoteiksmesCelms, Is.EqualTo("apvel"));
            Assert.That(apvelties.TagadnesCelms, Is.EqualTo("apveļ"));
            Assert.That(apvelties.PagātnesCelms, Is.EqualTo("apvēl"));
            Assert.That(apvelties.Tiešs, Is.EqualTo(false));
            Assert.That(apvelties.Atgriezenisks, Is.EqualTo(true));
            Assert.That(apvelties.Konjugācija, Is.EqualTo(Konjugācija.I));
            Assert.That(apvelties.Grupa, Is.EqualTo(0));

            Assert.AreEqual("apveļos", apvelties.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("apvelies", apvelties.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("apveļamies", apvelties.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("apveļaties", apvelties.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("apveļas", apvelties.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("apveļas", apvelties.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("apvēlos", apvelties.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("apvēlies", apvelties.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("apvēlāmies", apvelties.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("apvēlāties", apvelties.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("apvēlās", apvelties.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("apvēlās", apvelties.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("apvelšos", apvelties.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("apvelsies", apvelties.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("apvelsimies", apvelties.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("apvelsieties", apvelties.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("apvelsies", apvelties.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("apvelsies", apvelties.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("esmu apvēlies", apvelties.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esi apvēlies", apvelties.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esam apvēlušies", apvelties.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esat apvēlušies", apvelties.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("ir apvēlies", apvelties.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("ir apvēlušies", apvelties.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esmu apvēlusies", apvelties.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esi apvēlusies", apvelties.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esam apvēlušās", apvelties.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esat apvēlušās", apvelties.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("ir apvēlusies", apvelties.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("ir apvēlušās", apvelties.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("biju apvēlies", apvelties.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("biji apvēlies", apvelties.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bijām apvēlušies", apvelties.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bijāt apvēlušies", apvelties.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bija apvēlies", apvelties.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bija apvēlušies", apvelties.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("biju apvēlusies", apvelties.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("biji apvēlusies", apvelties.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bijām apvēlušās", apvelties.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bijāt apvēlušās", apvelties.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bija apvēlusies", apvelties.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bija apvēlušās", apvelties.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("būšu apvēlies", apvelties.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsi apvēlies", apvelties.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsim apvēlušies", apvelties.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsiet apvēlušies", apvelties.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būs apvēlies", apvelties.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būs apvēlušies", apvelties.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšu apvēlusies", apvelties.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsi apvēlusies", apvelties.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsim apvēlušās", apvelties.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsiet apvēlušās", apvelties.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būs apvēlusies", apvelties.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būs apvēlušās", apvelties.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("apveļoties", apvelties.AtstāstījumaIzteiksmesVienkāršāTagadne());
            Assert.AreEqual("apvelšoties", apvelties.AtstāstījumaIzteiksmesVienkāršāNākotne());

            Assert.AreEqual("esot apvēlies", apvelties.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot apvēlies", apvelties.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot apvēlies", apvelties.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot apvēlušies", apvelties.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot apvēlušies", apvelties.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot apvēlušies", apvelties.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot apvēlusies", apvelties.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot apvēlusies", apvelties.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot apvēlusies", apvelties.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot apvēlušās", apvelties.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot apvēlušās", apvelties.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot apvēlušās", apvelties.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("būšot apvēlies", apvelties.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot apvēlies", apvelties.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot apvēlies", apvelties.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot apvēlušies", apvelties.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot apvēlušies", apvelties.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot apvēlušies", apvelties.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot apvēlusies", apvelties.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot apvēlusies", apvelties.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot apvēlusies", apvelties.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot apvēlušās", apvelties.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot apvēlušās", apvelties.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot apvēlušās", apvelties.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("apveltos", apvelties.VēlējumaIzteiksmesVienkāršāTagadne());

            Assert.AreEqual("būtu apvēlies", apvelties.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu apvēlies", apvelties.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu apvēlies", apvelties.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu apvēlušies", apvelties.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu apvēlušies", apvelties.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu apvēlušies", apvelties.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu apvēlusies", apvelties.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu apvēlusies", apvelties.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu apvēlusies", apvelties.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu apvēlušās", apvelties.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu apvēlušās", apvelties.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu apvēlušās", apvelties.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("ir jāapveļas", apvelties.VajadzībasIzteiksmesVienkāršāTagadne());
            Assert.AreEqual("bija jāapveļas", apvelties.VajadzībasIzteiksmesVienkāršāPagātne());
            Assert.AreEqual("būs jāapveļas", apvelties.VajadzībasIzteiksmesVienkāršāNākotne());
            Assert.AreEqual("ir bijis jāapveļas", apvelties.VajadzībasIzteiksmesSaliktāTagadne());
            Assert.AreEqual("bija bijis jāapveļas", apvelties.VajadzībasIzteiksmesSaliktāPagātne());
            Assert.AreEqual("būs bijis jāapveļas", apvelties.VajadzībasIzteiksmesSaliktāNākotne());
            Assert.AreEqual("esot jāapveļas", apvelties.VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāTagadne());
            Assert.AreEqual("būšot jāapveļas", apvelties.VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāNākotne());
            Assert.AreEqual("būtu jāapveļas", apvelties.VajadzībasIzteiksmesVēlējumaPaveidaVienkāršāTagadne());
            Assert.AreEqual("būtu bijis jāapveļas", apvelties.VajadzībasIzteiksmesVēlējumaPaveidaSaliktāTagadne());

            Assert.AreEqual("apvelsimies", apvelties.PavēlesIzteiksme(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("apvelies", apvelties.PavēlesIzteiksme(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("apvelsimies", apvelties.PavēlesIzteiksme(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("apvelieties", apvelties.PavēlesIzteiksme(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("lai apveļas", apvelties.PavēlesIzteiksme(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("lai apveļas", apvelties.PavēlesIzteiksme(PersonasForma.DaudzskaitļaTrešāPersona));
        }

        [Test, Category("II konjugācija 0. grupa")]
        public void Strādāt()
        {
            DarbībasVārds strādāt = new DarbībasVārds("strādāt", "strādāju", "strādāju", Konjugācija.II, 0);
            Assert.That(strādāt.Nenoteiksme, Is.EqualTo("strādāt"));
            Assert.That(strādāt.NenoteiksmesCelms, Is.EqualTo("strādā"));
            Assert.That(strādāt.TagadnesCelms, Is.EqualTo("strādāj"));
            Assert.That(strādāt.PagātnesCelms, Is.EqualTo("strādāj"));
            Assert.That(strādāt.Tiešs, Is.EqualTo(true));
            Assert.That(strādāt.Atgriezenisks, Is.EqualTo(false));
            Assert.That(strādāt.Konjugācija, Is.EqualTo(Konjugācija.II));
            Assert.That(strādāt.Grupa, Is.EqualTo(0));

            Assert.AreEqual("strādāju", strādāt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("strādā", strādāt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("strādājam", strādāt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("strādājat", strādāt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("strādā", strādāt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("strādā", strādāt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("strādāju", strādāt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("strādāji", strādāt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("strādājām", strādāt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("strādājāt", strādāt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("strādāja", strādāt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("strādāja", strādāt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("strādāšu", strādāt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("strādāsi", strādāt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("strādāsim", strādāt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("strādāsiet", strādāt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("strādās", strādāt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("strādās", strādāt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("esmu strādājis", strādāt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esi strādājis", strādāt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esam strādājuši", strādāt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esat strādājuši", strādāt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("ir strādājis", strādāt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("ir strādājuši", strādāt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esmu strādājusi", strādāt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esi strādājusi", strādāt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esam strādājušas", strādāt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esat strādājušas", strādāt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("ir strādājusi", strādāt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("ir strādājušas", strādāt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("biju strādājis", strādāt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("biji strādājis", strādāt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bijām strādājuši", strādāt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bijāt strādājuši", strādāt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bija strādājis", strādāt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bija strādājuši", strādāt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("biju strādājusi", strādāt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("biji strādājusi", strādāt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bijām strādājušas", strādāt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bijāt strādājušas", strādāt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bija strādājusi", strādāt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bija strādājušas", strādāt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("būšu strādājis", strādāt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsi strādājis", strādāt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsim strādājuši", strādāt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsiet strādājuši", strādāt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būs strādājis", strādāt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būs strādājuši", strādāt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšu strādājusi", strādāt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsi strādājusi", strādāt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsim strādājušas", strādāt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsiet strādājušas", strādāt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būs strādājusi", strādāt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būs strādājušas", strādāt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("strādājot", strādāt.AtstāstījumaIzteiksmesVienkāršāTagadne());
            Assert.AreEqual("strādāšot", strādāt.AtstāstījumaIzteiksmesVienkāršāNākotne());

            Assert.AreEqual("esot strādājis", strādāt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot strādājis", strādāt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot strādājis", strādāt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot strādājuši", strādāt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot strādājuši", strādāt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot strādājuši", strādāt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot strādājusi", strādāt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot strādājusi", strādāt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot strādājusi", strādāt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot strādājušas", strādāt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot strādājušas", strādāt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot strādājušas", strādāt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("būšot strādājis", strādāt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot strādājis", strādāt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot strādājis", strādāt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot strādājuši", strādāt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot strādājuši", strādāt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot strādājuši", strādāt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot strādājusi", strādāt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot strādājusi", strādāt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot strādājusi", strādāt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot strādājušas", strādāt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot strādājušas", strādāt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot strādājušas", strādāt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("strādātu", strādāt.VēlējumaIzteiksmesVienkāršāTagadne());

            Assert.AreEqual("būtu strādājis", strādāt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu strādājis", strādāt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu strādājis", strādāt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu strādājuši", strādāt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu strādājuši", strādāt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu strādājuši", strādāt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu strādājusi", strādāt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu strādājusi", strādāt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu strādājusi", strādāt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu strādājušas", strādāt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu strādājušas", strādāt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu strādājušas", strādāt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("ir jāstrādā", strādāt.VajadzībasIzteiksmesVienkāršāTagadne());
            Assert.AreEqual("bija jāstrādā", strādāt.VajadzībasIzteiksmesVienkāršāPagātne());
            Assert.AreEqual("būs jāstrādā", strādāt.VajadzībasIzteiksmesVienkāršāNākotne());
            Assert.AreEqual("ir bijis jāstrādā", strādāt.VajadzībasIzteiksmesSaliktāTagadne());
            Assert.AreEqual("bija bijis jāstrādā", strādāt.VajadzībasIzteiksmesSaliktāPagātne());
            Assert.AreEqual("būs bijis jāstrādā", strādāt.VajadzībasIzteiksmesSaliktāNākotne());
            Assert.AreEqual("esot jāstrādā", strādāt.VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāTagadne());
            Assert.AreEqual("būšot jāstrādā", strādāt.VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāNākotne());
            Assert.AreEqual("būtu jāstrādā", strādāt.VajadzībasIzteiksmesVēlējumaPaveidaVienkāršāTagadne());
            Assert.AreEqual("būtu bijis jāstrādā", strādāt.VajadzībasIzteiksmesVēlējumaPaveidaSaliktāTagadne());

            Assert.AreEqual("strādāsim", strādāt.PavēlesIzteiksme(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("strādā", strādāt.PavēlesIzteiksme(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("strādāsim", strādāt.PavēlesIzteiksme(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("strādājiet", strādāt.PavēlesIzteiksme(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("lai strādā", strādāt.PavēlesIzteiksme(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("lai strādā", strādāt.PavēlesIzteiksme(PersonasForma.DaudzskaitļaTrešāPersona));
        }

        [Test, Category("II konjugācija 0. grupa")]
        public void Zīmēt()
        {
            DarbībasVārds zīmēt = new DarbībasVārds("zīmēt", "zīmēju", "zīmēju", Konjugācija.II, 0);
            Assert.That(zīmēt.Nenoteiksme, Is.EqualTo("zīmēt"));
            Assert.That(zīmēt.NenoteiksmesCelms, Is.EqualTo("zīmē"));
            Assert.That(zīmēt.TagadnesCelms, Is.EqualTo("zīmēj"));
            Assert.That(zīmēt.PagātnesCelms, Is.EqualTo("zīmēj"));
            Assert.That(zīmēt.Tiešs, Is.EqualTo(true));
            Assert.That(zīmēt.Atgriezenisks, Is.EqualTo(false));
            Assert.That(zīmēt.Konjugācija, Is.EqualTo(Konjugācija.II));
            Assert.That(zīmēt.Grupa, Is.EqualTo(0));

            Assert.AreEqual("zīmēju", zīmēt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("zīmē", zīmēt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("zīmējam", zīmēt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("zīmējat", zīmēt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("zīmē", zīmēt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("zīmē", zīmēt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("zīmēju", zīmēt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("zīmēji", zīmēt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("zīmējām", zīmēt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("zīmējāt", zīmēt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("zīmēja", zīmēt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("zīmēja", zīmēt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("zīmēšu", zīmēt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("zīmēsi", zīmēt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("zīmēsim", zīmēt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("zīmēsiet", zīmēt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("zīmēs", zīmēt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("zīmēs", zīmēt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("esmu zīmējis", zīmēt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esi zīmējis", zīmēt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esam zīmējuši", zīmēt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esat zīmējuši", zīmēt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("ir zīmējis", zīmēt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("ir zīmējuši", zīmēt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esmu zīmējusi", zīmēt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esi zīmējusi", zīmēt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esam zīmējušas", zīmēt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esat zīmējušas", zīmēt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("ir zīmējusi", zīmēt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("ir zīmējušas", zīmēt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("biju zīmējis", zīmēt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("biji zīmējis", zīmēt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bijām zīmējuši", zīmēt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bijāt zīmējuši", zīmēt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bija zīmējis", zīmēt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bija zīmējuši", zīmēt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("biju zīmējusi", zīmēt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("biji zīmējusi", zīmēt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bijām zīmējušas", zīmēt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bijāt zīmējušas", zīmēt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bija zīmējusi", zīmēt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bija zīmējušas", zīmēt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("būšu zīmējis", zīmēt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsi zīmējis", zīmēt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsim zīmējuši", zīmēt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsiet zīmējuši", zīmēt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būs zīmējis", zīmēt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būs zīmējuši", zīmēt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšu zīmējusi", zīmēt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsi zīmējusi", zīmēt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsim zīmējušas", zīmēt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsiet zīmējušas", zīmēt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būs zīmējusi", zīmēt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būs zīmējušas", zīmēt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("zīmējot", zīmēt.AtstāstījumaIzteiksmesVienkāršāTagadne());
            Assert.AreEqual("zīmēšot", zīmēt.AtstāstījumaIzteiksmesVienkāršāNākotne());

            Assert.AreEqual("esot zīmējis", zīmēt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot zīmējis", zīmēt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot zīmējis", zīmēt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot zīmējuši", zīmēt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot zīmējuši", zīmēt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot zīmējuši", zīmēt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot zīmējusi", zīmēt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot zīmējusi", zīmēt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot zīmējusi", zīmēt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot zīmējušas", zīmēt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot zīmējušas", zīmēt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot zīmējušas", zīmēt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("būšot zīmējis", zīmēt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot zīmējis", zīmēt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot zīmējis", zīmēt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot zīmējuši", zīmēt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot zīmējuši", zīmēt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot zīmējuši", zīmēt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot zīmējusi", zīmēt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot zīmējusi", zīmēt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot zīmējusi", zīmēt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot zīmējušas", zīmēt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot zīmējušas", zīmēt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot zīmējušas", zīmēt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("zīmētu", zīmēt.VēlējumaIzteiksmesVienkāršāTagadne());

            Assert.AreEqual("būtu zīmējis", zīmēt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu zīmējis", zīmēt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu zīmējis", zīmēt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu zīmējuši", zīmēt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu zīmējuši", zīmēt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu zīmējuši", zīmēt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu zīmējusi", zīmēt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu zīmējusi", zīmēt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu zīmējusi", zīmēt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu zīmējušas", zīmēt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu zīmējušas", zīmēt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu zīmējušas", zīmēt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("ir jāzīmē", zīmēt.VajadzībasIzteiksmesVienkāršāTagadne());
            Assert.AreEqual("bija jāzīmē", zīmēt.VajadzībasIzteiksmesVienkāršāPagātne());
            Assert.AreEqual("būs jāzīmē", zīmēt.VajadzībasIzteiksmesVienkāršāNākotne());
            Assert.AreEqual("ir bijis jāzīmē", zīmēt.VajadzībasIzteiksmesSaliktāTagadne());
            Assert.AreEqual("bija bijis jāzīmē", zīmēt.VajadzībasIzteiksmesSaliktāPagātne());
            Assert.AreEqual("būs bijis jāzīmē", zīmēt.VajadzībasIzteiksmesSaliktāNākotne());
            Assert.AreEqual("esot jāzīmē", zīmēt.VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāTagadne());
            Assert.AreEqual("būšot jāzīmē", zīmēt.VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāNākotne());
            Assert.AreEqual("būtu jāzīmē", zīmēt.VajadzībasIzteiksmesVēlējumaPaveidaVienkāršāTagadne());
            Assert.AreEqual("būtu bijis jāzīmē", zīmēt.VajadzībasIzteiksmesVēlējumaPaveidaSaliktāTagadne());

            Assert.AreEqual("zīmēsim", zīmēt.PavēlesIzteiksme(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("zīmē", zīmēt.PavēlesIzteiksme(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("zīmēsim", zīmēt.PavēlesIzteiksme(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("zīmējiet", zīmēt.PavēlesIzteiksme(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("lai zīmē", zīmēt.PavēlesIzteiksme(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("lai zīmē", zīmēt.PavēlesIzteiksme(PersonasForma.DaudzskaitļaTrešāPersona));
        }

        [Test, Category("II konjugācija 0. grupa")]
        public void Medīt()
        {
            DarbībasVārds medīt = new DarbībasVārds("medīt", "medīju", "medīju", Konjugācija.II, 0);
            Assert.That(medīt.Nenoteiksme, Is.EqualTo("medīt"));
            Assert.That(medīt.NenoteiksmesCelms, Is.EqualTo("medī"));
            Assert.That(medīt.TagadnesCelms, Is.EqualTo("medīj"));
            Assert.That(medīt.PagātnesCelms, Is.EqualTo("medīj"));
            Assert.That(medīt.Tiešs, Is.EqualTo(true));
            Assert.That(medīt.Atgriezenisks, Is.EqualTo(false));
            Assert.That(medīt.Konjugācija, Is.EqualTo(Konjugācija.II));
            Assert.That(medīt.Grupa, Is.EqualTo(0));

            Assert.AreEqual("medīju", medīt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("medī", medīt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("medījam", medīt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("medījat", medīt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("medī", medīt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("medī", medīt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("medīju", medīt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("medīji", medīt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("medījām", medīt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("medījāt", medīt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("medīja", medīt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("medīja", medīt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("medīšu", medīt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("medīsi", medīt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("medīsim", medīt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("medīsiet", medīt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("medīs", medīt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("medīs", medīt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("esmu medījis", medīt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esi medījis", medīt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esam medījuši", medīt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esat medījuši", medīt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("ir medījis", medīt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("ir medījuši", medīt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esmu medījusi", medīt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esi medījusi", medīt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esam medījušas", medīt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esat medījušas", medīt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("ir medījusi", medīt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("ir medījušas", medīt.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("biju medījis", medīt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("biji medījis", medīt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bijām medījuši", medīt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bijāt medījuši", medīt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bija medījis", medīt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bija medījuši", medīt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("biju medījusi", medīt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("biji medījusi", medīt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bijām medījušas", medīt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bijāt medījušas", medīt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bija medījusi", medīt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bija medījušas", medīt.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("būšu medījis", medīt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsi medījis", medīt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsim medījuši", medīt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsiet medījuši", medīt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būs medījis", medīt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būs medījuši", medīt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšu medījusi", medīt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsi medījusi", medīt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsim medījušas", medīt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsiet medījušas", medīt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būs medījusi", medīt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būs medījušas", medīt.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("medījot", medīt.AtstāstījumaIzteiksmesVienkāršāTagadne());
            Assert.AreEqual("medīšot", medīt.AtstāstījumaIzteiksmesVienkāršāNākotne());

            Assert.AreEqual("esot medījis", medīt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot medījis", medīt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot medījis", medīt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot medījuši", medīt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot medījuši", medīt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot medījuši", medīt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot medījusi", medīt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot medījusi", medīt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot medījusi", medīt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot medījušas", medīt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot medījušas", medīt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot medījušas", medīt.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("būšot medījis", medīt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot medījis", medīt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot medījis", medīt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot medījuši", medīt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot medījuši", medīt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot medījuši", medīt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot medījusi", medīt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot medījusi", medīt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot medījusi", medīt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot medījušas", medīt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot medījušas", medīt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot medījušas", medīt.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("medītu", medīt.VēlējumaIzteiksmesVienkāršāTagadne());

            Assert.AreEqual("būtu medījis", medīt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu medījis", medīt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu medījis", medīt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu medījuši", medīt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu medījuši", medīt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu medījuši", medīt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu medījusi", medīt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu medījusi", medīt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu medījusi", medīt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu medījušas", medīt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu medījušas", medīt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu medījušas", medīt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("ir jāmedī", medīt.VajadzībasIzteiksmesVienkāršāTagadne());
            Assert.AreEqual("bija jāmedī", medīt.VajadzībasIzteiksmesVienkāršāPagātne());
            Assert.AreEqual("būs jāmedī", medīt.VajadzībasIzteiksmesVienkāršāNākotne());
            Assert.AreEqual("ir bijis jāmedī", medīt.VajadzībasIzteiksmesSaliktāTagadne());
            Assert.AreEqual("bija bijis jāmedī", medīt.VajadzībasIzteiksmesSaliktāPagātne());
            Assert.AreEqual("būs bijis jāmedī", medīt.VajadzībasIzteiksmesSaliktāNākotne());
            Assert.AreEqual("esot jāmedī", medīt.VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāTagadne());
            Assert.AreEqual("būšot jāmedī", medīt.VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāNākotne());
            Assert.AreEqual("būtu jāmedī", medīt.VajadzībasIzteiksmesVēlējumaPaveidaVienkāršāTagadne());
            Assert.AreEqual("būtu bijis jāmedī", medīt.VajadzībasIzteiksmesVēlējumaPaveidaSaliktāTagadne());

            Assert.AreEqual("medīsim", medīt.PavēlesIzteiksme(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("medī", medīt.PavēlesIzteiksme(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("medīsim", medīt.PavēlesIzteiksme(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("medījiet", medīt.PavēlesIzteiksme(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("lai medī", medīt.PavēlesIzteiksme(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("lai medī", medīt.PavēlesIzteiksme(PersonasForma.DaudzskaitļaTrešāPersona));
        }

        [Test, Category("II konjugācija 0. grupa")]
        public void Dejot()
        {
            DarbībasVārds dejot = new DarbībasVārds("dejot", "dejoju", "dejoju", Konjugācija.II, 0);
            Assert.That(dejot.Nenoteiksme, Is.EqualTo("dejot"));
            Assert.That(dejot.NenoteiksmesCelms, Is.EqualTo("dejo"));
            Assert.That(dejot.TagadnesCelms, Is.EqualTo("dejoj"));
            Assert.That(dejot.PagātnesCelms, Is.EqualTo("dejoj"));
            Assert.That(dejot.Tiešs, Is.EqualTo(true));
            Assert.That(dejot.Atgriezenisks, Is.EqualTo(false));
            Assert.That(dejot.Konjugācija, Is.EqualTo(Konjugācija.II));
            Assert.That(dejot.Grupa, Is.EqualTo(0));

            Assert.AreEqual("dejoju", dejot.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("dejo", dejot.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("dejojam", dejot.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("dejojat", dejot.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("dejo", dejot.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("dejo", dejot.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("dejoju", dejot.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("dejoji", dejot.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("dejojām", dejot.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("dejojāt", dejot.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("dejoja", dejot.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("dejoja", dejot.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("dejošu", dejot.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("dejosi", dejot.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("dejosim", dejot.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("dejosiet", dejot.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("dejos", dejot.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("dejos", dejot.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaTrešāPersona));

            Assert.AreEqual("esmu dejojis", dejot.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esi dejojis", dejot.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esam dejojuši", dejot.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esat dejojuši", dejot.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("ir dejojis", dejot.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("ir dejojuši", dejot.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esmu dejojusi", dejot.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esi dejojusi", dejot.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esam dejojušas", dejot.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esat dejojušas", dejot.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("ir dejojusi", dejot.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("ir dejojušas", dejot.ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("biju dejojis", dejot.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("biji dejojis", dejot.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bijām dejojuši", dejot.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bijāt dejojuši", dejot.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bija dejojis", dejot.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("bija dejojuši", dejot.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("biju dejojusi", dejot.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("biji dejojusi", dejot.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bijām dejojušas", dejot.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bijāt dejojušas", dejot.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bija dejojusi", dejot.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("bija dejojušas", dejot.ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("būšu dejojis", dejot.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsi dejojis", dejot.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsim dejojuši", dejot.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būsiet dejojuši", dejot.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būs dejojis", dejot.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būs dejojuši", dejot.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšu dejojusi", dejot.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsi dejojusi", dejot.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsim dejojušas", dejot.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būsiet dejojušas", dejot.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būs dejojusi", dejot.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būs dejojušas", dejot.ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("dejojot", dejot.AtstāstījumaIzteiksmesVienkāršāTagadne());
            Assert.AreEqual("dejošot", dejot.AtstāstījumaIzteiksmesVienkāršāNākotne());

            Assert.AreEqual("esot dejojis", dejot.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot dejojis", dejot.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot dejojis", dejot.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot dejojuši", dejot.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot dejojuši", dejot.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot dejojuši", dejot.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("esot dejojusi", dejot.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot dejojusi", dejot.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot dejojusi", dejot.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot dejojušas", dejot.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot dejojušas", dejot.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("esot dejojušas", dejot.AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("būšot dejojis", dejot.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot dejojis", dejot.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot dejojis", dejot.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot dejojuši", dejot.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot dejojuši", dejot.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot dejojuši", dejot.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būšot dejojusi", dejot.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot dejojusi", dejot.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot dejojusi", dejot.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot dejojušas", dejot.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot dejojušas", dejot.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būšot dejojušas", dejot.AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("dejotu", dejot.VēlējumaIzteiksmesVienkāršāTagadne());

            Assert.AreEqual("būtu dejojis", dejot.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu dejojis", dejot.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu dejojis", dejot.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu dejojuši", dejot.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu dejojuši", dejot.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu dejojuši", dejot.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Vīriešu));
            Assert.AreEqual("būtu dejojusi", dejot.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu dejojusi", dejot.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu dejojusi", dejot.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaTrešāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu dejojušas", dejot.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaPirmāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu dejojušas", dejot.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaOtrāPersona, Dzimte.Sieviešu));
            Assert.AreEqual("būtu dejojušas", dejot.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.DaudzskaitļaTrešāPersona, Dzimte.Sieviešu));

            Assert.AreEqual("ir jādejo", dejot.VajadzībasIzteiksmesVienkāršāTagadne());
            Assert.AreEqual("bija jādejo", dejot.VajadzībasIzteiksmesVienkāršāPagātne());
            Assert.AreEqual("būs jādejo", dejot.VajadzībasIzteiksmesVienkāršāNākotne());
            Assert.AreEqual("ir bijis jādejo", dejot.VajadzībasIzteiksmesSaliktāTagadne());
            Assert.AreEqual("bija bijis jādejo", dejot.VajadzībasIzteiksmesSaliktāPagātne());
            Assert.AreEqual("būs bijis jādejo", dejot.VajadzībasIzteiksmesSaliktāNākotne());
            Assert.AreEqual("esot jādejo", dejot.VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāTagadne());
            Assert.AreEqual("būšot jādejo", dejot.VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāNākotne());
            Assert.AreEqual("būtu jādejo", dejot.VajadzībasIzteiksmesVēlējumaPaveidaVienkāršāTagadne());
            Assert.AreEqual("būtu bijis jādejo", dejot.VajadzībasIzteiksmesVēlējumaPaveidaSaliktāTagadne());

            Assert.AreEqual("dejosim", dejot.PavēlesIzteiksme(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("dejo", dejot.PavēlesIzteiksme(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("dejosim", dejot.PavēlesIzteiksme(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("dejojiet", dejot.PavēlesIzteiksme(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("lai dejo", dejot.PavēlesIzteiksme(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("lai dejo", dejot.PavēlesIzteiksme(PersonasForma.DaudzskaitļaTrešāPersona));
        }

        [Test]
        public void Pūt()
        {
            DarbībasVārds pūst = DabūtDarbībasVārdu("pūst");
            Assert.AreEqual("pūšu", pūst.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona));
            Assert.AreEqual("pūt", pūst.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona));
            Assert.AreEqual("pūšam", pūst.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona));
            Assert.AreEqual("pūšat", pūst.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona));
            Assert.AreEqual("pūš", pūst.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona));
            Assert.AreEqual("pūš", pūst.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona));
        }

        [Test]
        public void Ātrdarbība()
        {
            var stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();

            DarbībasVārds dejot = new DarbībasVārds("dejot", "dejoju", "dejoju", Konjugācija.II, 0);
            dejot.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaPirmāPersona);
            dejot.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona);
            dejot.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaPirmāPersona);
            dejot.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaOtrāPersona);
            dejot.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona);
            dejot.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.DaudzskaitļaTrešāPersona);

            stopwatch.Stop();

            Assert.That(stopwatch.ElapsedMilliseconds, Is.LessThanOrEqualTo(10 * 6));
        }
    }
}