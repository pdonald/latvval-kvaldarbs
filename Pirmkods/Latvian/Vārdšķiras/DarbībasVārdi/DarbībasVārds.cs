namespace Latvian.Vārdšķiras.DarbībasVārdi
{
    using Divdabji;
    using System;

    /// <summary>
    /// Darbības vārdu maiņu laikos, personās un skaitļos sauc par konjugēšanu.
    /// Pēc konjugēšanas īpatnībām darbības vārdus iedala trīs konjugācijās.
    /// </summary>
    /// <see>http://www.liis.lv/latval/morfol/darbv-konj.htm</see>
    public enum Konjugācija
    {
        I, II, III
    }

    /// <summary>
    /// Darbības vārdiem ir trīs vienskaitļa un trīs daudzskaitļa personu formas.
    /// Tiem nav tieši izteiktas skaitļa kategorijas, jo skaitli izsaka ar personu.
    /// Personu nozīmi izsaka personu galotnes, kā arī personu vietniekvārdi.
    /// </summary>
    /// <see>http://www.liis.lv/latval/morfol/darbv-psk.htm</see>
    public enum PersonasForma
    {
        VienskaitļaPirmāPersona, // Vienskaitļa 1.personu lieto, runājot par paša runātāja veicamo darbību.
        VienskaitļaOtrāPersona, // Vienskaitļa 2.personu lieto, stāstot par uzrunātās personas rīcību, uzrunājot citu personu, vispārināta laika nozīmē.
        VienskaitļaTrešāPersona, // 3.personu lieto, runājot par citu personu (personām), stāstot par stāvokli, dažādiem procesiem, vispārināta laika nozīmē.
        DaudzskaitļaPirmāPersona, // Daudzskaitļa 1.personu lieto, runājot par darbību, ko veic vairākas personas, ieskaitot runātāju.
        DaudzskaitļaOtrāPersona, // Daudzskaitļa 2.personu lieto, stāstot par uzrunāto personu rīcību, uzrunājot vairākas personas, kā pieklājības formu, uzrunājot vienu cilvēku.
        DaudzskaitļaTrešāPersona // Darbības vārdam vienskaitļa un daudzskaitļa 3.personā ir viena un tā pati forma.

        /* Es, Tu, ViņsViņa, Mēs, Jūs, ViņiViņas */
    }

    public interface IDarbībasVārds
    {
        /// <summary>
        /// Darbības vārds īstenības izteiksmē izsaka darbību kā realitāti tagadnē, pagātnē vai nākotnē vai arī to noliedz.
        /// Šo attieksmi pret īstenību pauž darbības vārda laiku formas.
        /// Īpaša rādītāja īstenības izteiksmei nav.
        /// </summary>
        string ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma persona);
        string ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma persona);
        string ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma persona);
        string ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma persona, Dzimte dzimte);
        string ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma persona, Dzimte dzimte);
        string ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma persona, Dzimte dzimte);

        string AtstāstījumaIzteiksmesVienkāršāTagadne();
        string AtstāstījumaIzteiksmesVienkāršāNākotne();
        string AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma persona, Dzimte dzimte);
        string AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma persona, Dzimte dzimte);
        
        /// <summary>
        /// Darbības vārds vēlējuma izteiksmē izsaka vēlēšanos, lai darbība tiktu īstenota, vai arī norāda, ka darbība ir iespējama.
        /// </summary>
        string VēlējumaIzteiksmesVienkāršāTagadne();
        string VēlējumaIzteiksmesSaliktāTagadne(PersonasForma persona, Dzimte dzimte);

        /// <summary>
        /// Darbības vārds vajadzības izteiksmē izsaka vajadzību, nepieciešamību īstenot darbību.
        /// </summary>
        string VajadzībasIzteiksmesVienkāršāTagadne();
        string VajadzībasIzteiksmesVienkāršāPagātne();
        string VajadzībasIzteiksmesVienkāršāNākotne();
        string VajadzībasIzteiksmesSaliktāTagadne();
        string VajadzībasIzteiksmesSaliktāPagātne();
        string VajadzībasIzteiksmesSaliktāNākotne();
        string VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāTagadne();
        string VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāNākotne();
        string VajadzībasIzteiksmesVēlējumaPaveidaVienkāršāTagadne();
        string VajadzībasIzteiksmesVēlējumaPaveidaSaliktāTagadne();

        /// <summary>
        /// Darbības vārds pavēles izteiksmē izsaka rosinājumu – aicinājumu, lūgumu, aizliegumu, pavēli.
        /// Pavēles izteiksmei nav īpaša rādītāja, teikumi ar darbības vārdu pavēles izteiksmē parasti ir izsaukuma teikumi.
        /// Pavēles izteiksmei nav laiku formu. Tās formām ir tagadnes nozīme.
        /// </summary>
        string PavēlesIzteiksme(PersonasForma persona);

        /// <summary>
        /// Nenoteiksme (infinitīvs) ir darbības vārda forma, kas darbību, procesu vai stāvokli tikai nosauc, bet nenorāda uz laiku, personu un skaitli.
        /// Nenoteiksmi izsaka ar galotni -t vai -ties.
        /// Nenoteiksme uzskatāma par darbības vārda pamatformu, to pretstata visām pārējām darbības vārda formām.
        /// </summary>
        string Nenoteiksme { get; }

        /// <summary>
        /// Nenoteiksmes celms.
        /// To iegūst no nenoteiksmes formas, atmetot galotni.
        /// </summary>
        string NenoteiksmesCelms { get; }

        /// <summary>
        /// Tagadnes celms.
        /// To iegūst no īstenības izteiksmes vienkāršās tagadnes vienskaitļa vai daudzskaitļa 1.personas formas, atmetot galotni.
        /// </summary>
        string TagadnesCelms { get; }

        /// <summary>
        /// Pagātnes celms.
        /// To iegūst no īstenības izteiksmes vienkāršās pagātnes vienskaitļa vai daudzskaitļa 1.personas formas, atmetot galotni.
        /// </summary>
        string PagātnesCelms { get; }

        /// <summary>
        /// Atgriezeniskiem darbības vārdiem nenoteiksmē ir galotne -ties.
        /// </summary>
        bool Atgriezenisks { get; }

        /// <summary>
        /// Tiešiem darbības vārdiem nenoteiksmē ir galotne -t
        /// </summary>
        bool Tiešs { get; }

        /// <summary>
        /// Darbības vārdu maiņu laikos, personās un skaitļos sauc par konjugēšanu.
        /// Pēc konjugēšanas īpatnībām darbības vārdus iedala trīs konjugācijās.
        /// </summary>
        Konjugācija Konjugācija { get; }

        /// <summary>
        /// I konjugācijas darbības vārdus iedala piecās grupās.
        /// III konjugācijas darbības vārdus iedala divās grupās.
        /// </summary>
        int Grupa { get; }
    }

    public class DarbībasVārds : Vārds, IDarbībasVārds
    {
        private string nenoteiksme;
        private string nenoteiksmesCelms;
        private string tagadnesCelms;
        private string pagātnesCelms;
        private Konjugācija konjugācija;
        private int grupa;

        public DarbībasVārds(string nenoteiksme, string tagadne, string pagātne,
            Konjugācija konjugācija, int grupa)
        {
            this.nenoteiksme = nenoteiksme;
            this.konjugācija = konjugācija;
            this.grupa = grupa;

            NenoteiksmesCelms = nenoteiksme;
            TagadnesCelms = tagadne;
            PagātnesCelms = pagātne;
        }

        #region Rekvizīti
        public string Nenoteiksme
        {
            get { return nenoteiksme; }
        }

        public string NenoteiksmesCelms
        {
            get
            {
                return nenoteiksmesCelms;
            }
            protected set
            {
                if (!value.BeidzasAr("ties", "t"))
                    throw new ArgumentException();

                if (value.BeidzasAr("ties"))
                {
                    nenoteiksmesCelms = value.AtmestGalotni("ties");
                }
                else
                {
                    nenoteiksmesCelms = value.AtmestGalotni("t");
                }
            }
        }

        public string TagadnesCelms
        {
            get
            {
                return tagadnesCelms;
            }
            protected set
            {
                if (value.BeidzasAr("u"))
                {
                    tagadnesCelms = value.AtmestGalotni("u");
                }
                else if (value.BeidzasAr("os"))
                {
                    tagadnesCelms = value.AtmestGalotni("os");
                }
                else
                {
                    tagadnesCelms = value;
                }
            }
        }

        public string PagātnesCelms
        {
            get
            {
                return pagātnesCelms;
            }
            protected set
            {
                if (value.BeidzasAr("u"))
                {
                    pagātnesCelms = value.AtmestGalotni("u");
                }
                else if (value.BeidzasAr("os"))
                {
                    pagātnesCelms = value.AtmestGalotni("os");
                }
                else
                {
                    pagātnesCelms = value;
                }
            }
        }

        public Konjugācija Konjugācija
        {
            get { return konjugācija; }
        }

        public int Grupa
        {
            get { return grupa; }
        }

        public bool Atgriezenisks
        {
            get { return nenoteiksme.BeidzasAr("ties"); }
        }

        public bool Tiešs
        {
            get { return nenoteiksme.BeidzasAr("t"); }
        }
        #endregion

        public string ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma persona)
        {
            string vārds = LīdzskaņuMijaĪstenībasIzteiksmesVienkāršajaiTagadnei(TagadnesCelms, persona);

            // Visi izņemot III konjugācijas 1.grupas darbības vārdi
            bool īsaGalotne = !(Konjugācija == Konjugācija.III && Grupa == 1);

            switch (persona)
            {
                // Vienkāršās tagadnes vienskaitļa 1.personas formā darbības vārdam ir galotne -u vai -os.
                case PersonasForma.VienskaitļaPirmāPersona:
                    vārds += Tiešs ? "u" : "os";
                    break;

                // Vienkāršās tagadnes vienskaitļa 2.personas formā darbības vārds ir bez galotnes vai ar galotni -i vai -ies.
                case PersonasForma.VienskaitļaOtrāPersona:
                    string galotne = "";

                    if (Atgriezenisks)
                    {
                        galotne = "ies";
                    }
                    else
                    {
                        // Galotne -i ir visiem tiešajiem III konjugācijas darbības vārdiem, kā arī I konjugācijas 5.grupas un tiem 3.grupas darbības vārdiem, 
                        // kam sakne beidzas ar līdzskaņiem d, p vai t.
                        if ((Konjugācija == Konjugācija.III) ||
                            (Konjugācija == Konjugācija.I && (Grupa == 3 || Grupa == 5) && TagadnesCelms.BeidzasAr("t", "d", "p")))
                        {
                            galotne = "i";
                        }
                    }

                    // Citi tiešie I konjugācijas un II konjugācijas darbības vārdi vienkāršās tagadnes vienskaitļa 2.personā tiek lietoti bezgalotnes formā.

                    vārds += galotne;
                    break;

                // Vienkāršās tagadnes daudzskaitļa 1.personas formā darbības vārdam ir galotne -am, -ām, -amies vai -āmies.
                case PersonasForma.DaudzskaitļaPirmāPersona:
                    if (īsaGalotne)
                    {
                        vārds += Tiešs ? "am" : "amies";
                    }
                    else
                    {
                        // Galotnes -ām, -āmies ir III konjugācijas 1.grupas darbības vārdiem
                        vārds += Tiešs ? "ām" : "āmies";
                    }
                    break;

                // Vienkāršās tagadnes daudzskaitļa 2.personas formā darbības vārdam ir galotne -at, -āt, -aties vai -āties.
                case PersonasForma.DaudzskaitļaOtrāPersona:
                    if (īsaGalotne)
                    {
                        vārds += Tiešs ? "at" : "aties";
                    }
                    else
                    {
                        // Galotnes -āt, -āties ir III konjugācijas 1.grupas darbības vārdiem
                        vārds += Tiešs ? "āt" : "āties";
                    }
                    break;

                case PersonasForma.VienskaitļaTrešāPersona:
                case PersonasForma.DaudzskaitļaTrešāPersona:
                    if (īsaGalotne)
                    {
                        // Tiešajiem darbības vārdiem nav galotnes, bet atgriezeniskajiem darbības vārdiem ir galotne -as.
                        vārds += Tiešs ? "" : "as";
                    }
                    else
                    {
                        // Vienkāršās tagadnes 3.personas formā III konjugācijas 1.grupas darbības vārdiem ir galotne -a vai -ās
                        vārds += Tiešs ? "a" : "ās";
                    }

                    // II konjugācijas darbības vārdiem 3.personā un vienskaitļa 2.personā ir viena un tā pati forma.
                    break;
            }

            return vārds;
        }

        public string ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma persona)
        {
            string vārds = PagātnesCelms;

            switch (persona)
            {
                // Vienkāršajā pagātnē vienskaitļa 1.personas formā darbības vārdiem ir galotne -u vai -os.
                // II konjugācijas darbības vārdiem sakrīt vienkāršās pagātnes un vienkāršās tagadnes vienskaitļa 1.personas formas.
                case PersonasForma.VienskaitļaPirmāPersona:
                    vārds += Tiešs ? "u" : "os";
                    break;

                // Vienkāršajā pagātnē vienskaitļa 2.personas formā darbības vārdiem ir galotne -i vai -ies.
                case PersonasForma.VienskaitļaOtrāPersona:
                    vārds += Tiešs ? "i" : "ies";
                    break;

                // Vienkāršajā pagātnē daudzskaitļa 1.personas formā visiem darbības vārdiem ir galotne -ām vai -āmies.
                case PersonasForma.DaudzskaitļaPirmāPersona:
                    vārds += Tiešs ? "ām" : "āmies";
                    break;

                // Vienkāršajā pagātnē daudzskaitļa 2.personas formā visiem darbības vārdiem ir galotne -āt vai -āties.
                case PersonasForma.DaudzskaitļaOtrāPersona:
                    vārds += Tiešs ? "āt" : "āties";
                    break;

                // Vienkāršajā pagātnē 3.personas formā visiem darbības vārdiem ir galotne -a vai -ās.
                case PersonasForma.VienskaitļaTrešāPersona:
                case PersonasForma.DaudzskaitļaTrešāPersona:
                    vārds += Tiešs ? "a" : "ās";
                    break;
            }

            return vārds;
        }

        public string ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma persona)
        {
            // Vienkāršās nākotnes personu formas veido, darbības vārda nenoteiksmes celmam pievienojot piedēkli -š- vienskaitļa 1.personas formā vai piedēkli -s- pārējās personu formās un personu galotni.
            // I konjugācijas darbības vārdiem, kam nenoteiksmē galotnes priekšā ir līdzskanis s vai z, veidojot vienkāršās nākotnes personu formas pirms piedēkļa -s- vai -š- tiek iesprausts līdzskanis ī izrunas atvieglošanai.
            string vārds = LīdzskaņuMijaĪstenībasIzteiksmesVienkāršajaiNākotnei(NenoteiksmesCelms);

            switch (persona)
            {
                // Vienkāršās nākotnes personu formas veido, darbības vārda nenoteiksmes celmam pievienojot piedēkli -š- vienskaitļa 1.personas formā...
                case PersonasForma.VienskaitļaPirmāPersona:
                    vārds += "š" + (Tiešs ? "u" : "os");
                    break;

                // ...vai piedēkli -s- pārējās personu formās un personu galotni.
                case PersonasForma.VienskaitļaOtrāPersona:
                    vārds += "s" + (Tiešs ? "i" : "ies");
                    break;

                // Vienkāršajā nākotnē daudzskaitļa 1.personas formā darbības vārdam ir galotne -im vai -imies.
                case PersonasForma.DaudzskaitļaPirmāPersona:
                    vārds += "s" + (Tiešs ? "im" : "imies");
                    break;

                // Vienkāršajā nākotnē daudzskaitļa 2.personas formā darbības vārdam ir galotne -it, -ities vai -iet, -ieties.
                // Mana piezīme: -it un -ities tiek reti izmantots un var vienmēr aizstāt ar -iet un -ieties, tāpēc to izņēmu.
                case PersonasForma.DaudzskaitļaOtrāPersona:
                    vārds += "s" + (Tiešs ? "iet" : "ieties");
                    break;

                case PersonasForma.VienskaitļaTrešāPersona:
                case PersonasForma.DaudzskaitļaTrešāPersona:
                    vārds += "s" + (Tiešs ? "" : "ies");
                    break;
            }

            return vārds;
        }

        public string ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma persona, Dzimte dzimte)
        {
            IDarbībasVārds būt = new BūtDarbībasVārds();
            DarāmāsKārtasPagātnesDivdabis divdabis = new DarāmāsKārtasPagātnesDivdabis(this);

            return būt.ĪstenībasIzteiksmesVienkāršāTagadne(persona) + " " +
                divdabis.Nominatīvs(dzimte, PersonasSkaitlis(persona), ĪpašībasVārdi.Galotne.Nenoteiktā);
        }

        public string ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma persona, Dzimte dzimte)
        {
            IDarbībasVārds būt = new BūtDarbībasVārds();
            DarāmāsKārtasPagātnesDivdabis divdabis = new DarāmāsKārtasPagātnesDivdabis(this);

            return būt.ĪstenībasIzteiksmesVienkāršāPagātne(persona) + " " +
                divdabis.Nominatīvs(dzimte, PersonasSkaitlis(persona), ĪpašībasVārdi.Galotne.Nenoteiktā);
        }

        public string ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma persona, Dzimte dzimte)
        {
            IDarbībasVārds būt = new BūtDarbībasVārds();
            DarāmāsKārtasPagātnesDivdabis divdabis = new DarāmāsKārtasPagātnesDivdabis(this);

            return būt.ĪstenībasIzteiksmesVienkāršāNākotne(persona) + " " +
                divdabis.Nominatīvs(dzimte, PersonasSkaitlis(persona), ĪpašībasVārdi.Galotne.Nenoteiktā);
        }

        public string AtstāstījumaIzteiksmesVienkāršāTagadne()
        {
            return TagadnesCelms + (Tiešs ? "ot" : "oties");
        }

        public string AtstāstījumaIzteiksmesVienkāršāNākotne()
        {
            string nākotnesCelms = LīdzskaņuMijaĪstenībasIzteiksmesVienkāršajaiNākotnei(NenoteiksmesCelms);
            return nākotnesCelms + "š" + (Tiešs ? "ot" : "oties");
        }

        public string AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma persona, Dzimte dzimte)
        {
            IDarbībasVārds būt = new BūtDarbībasVārds();
            DarāmāsKārtasPagātnesDivdabis divdabis = new DarāmāsKārtasPagātnesDivdabis(this);

            return būt.AtstāstījumaIzteiksmesVienkāršāTagadne() + " " +
                divdabis.Nominatīvs(dzimte, PersonasSkaitlis(persona), ĪpašībasVārdi.Galotne.Nenoteiktā);
        }

        public string AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma persona, Dzimte dzimte)
        {
            IDarbībasVārds būt = new BūtDarbībasVārds();
            DarāmāsKārtasPagātnesDivdabis divdabis = new DarāmāsKārtasPagātnesDivdabis(this);

            return būt.AtstāstījumaIzteiksmesVienkāršāNākotne() + " " +
                divdabis.Nominatīvs(dzimte, PersonasSkaitlis(persona), ĪpašībasVārdi.Galotne.Nenoteiktā);
        }

        public string VēlējumaIzteiksmesVienkāršāTagadne()
        {
            // Vēlējuma izteiksmes rādītājs ir formants -tu vai -tos.
            return NenoteiksmesCelms + (Tiešs ? "tu" : "tos");
        }

        public string VēlējumaIzteiksmesSaliktāTagadne(PersonasForma persona, Dzimte dzimte)
        {
            IDarbībasVārds būt = new BūtDarbībasVārds();
            DarāmāsKārtasPagātnesDivdabis divdabis = new DarāmāsKārtasPagātnesDivdabis(this);

            return būt.VēlējumaIzteiksmesVienkāršāTagadne() + " " +
                divdabis.Nominatīvs(dzimte, PersonasSkaitlis(persona), ĪpašībasVārdi.Galotne.Nenoteiktā);
        }

        public string VajadzībasIzteiksmesVienkāršāTagadne()
        {
            IDarbībasVārds būt = new BūtDarbībasVārds();
            return būt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona) + " " +
                "jā" + ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona);
        }

        public string VajadzībasIzteiksmesVienkāršāPagātne()
        {
            IDarbībasVārds būt = new BūtDarbībasVārds();
            return būt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaTrešāPersona) + " " +
                "jā" + ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona);
        }

        public string VajadzībasIzteiksmesVienkāršāNākotne()
        {
            IDarbībasVārds būt = new BūtDarbībasVārds();
            return būt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaTrešāPersona) + " " +
                "jā" + ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona);
        }

        public string VajadzībasIzteiksmesSaliktāTagadne()
        {
            IDarbībasVārds būt = new BūtDarbībasVārds();
            DarāmāsKārtasPagātnesDivdabis divdabis = new DarāmāsKārtasPagātnesDivdabis(būt);

            return būt.ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona) + " " +
                divdabis.Nominatīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, ĪpašībasVārdi.Galotne.Nenoteiktā) + " " +
                "jā" + ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona);
        }

        public string VajadzībasIzteiksmesSaliktāPagātne()
        {
            IDarbībasVārds būt = new BūtDarbībasVārds();
            DarāmāsKārtasPagātnesDivdabis divdabis = new DarāmāsKārtasPagātnesDivdabis(būt);

            return būt.ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma.VienskaitļaTrešāPersona) + " " +
                divdabis.Nominatīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, ĪpašībasVārdi.Galotne.Nenoteiktā) + " " +
                "jā" + ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona);
        }

        public string VajadzībasIzteiksmesSaliktāNākotne()
        {
            IDarbībasVārds būt = new BūtDarbībasVārds();
            DarāmāsKārtasPagātnesDivdabis divdabis = new DarāmāsKārtasPagātnesDivdabis(būt);

            return būt.ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.VienskaitļaTrešāPersona) + " " +
                divdabis.Nominatīvs(Dzimte.Vīriešu, Skaitlis.Vienskaitlis, ĪpašībasVārdi.Galotne.Nenoteiktā) + " " +
                "jā" + ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona);
        }

        public string VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāTagadne()
        {
            IDarbībasVārds būt = new BūtDarbībasVārds();
            return būt.AtstāstījumaIzteiksmesVienkāršāTagadne() + " " +
                "jā" + ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona);
        }

        public string VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāNākotne()
        {
            IDarbībasVārds būt = new BūtDarbībasVārds();
            return būt.AtstāstījumaIzteiksmesVienkāršāNākotne() + " " +
                "jā" + ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona);
        }

        public string VajadzībasIzteiksmesVēlējumaPaveidaVienkāršāTagadne()
        {
            IDarbībasVārds būt = new BūtDarbībasVārds();
            return būt.VēlējumaIzteiksmesVienkāršāTagadne() + " " +
                "jā" + ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona);
        }

        public string VajadzībasIzteiksmesVēlējumaPaveidaSaliktāTagadne()
        {
            IDarbībasVārds būt = new BūtDarbībasVārds();
            return būt.VēlējumaIzteiksmesSaliktāTagadne(PersonasForma.VienskaitļaPirmāPersona, Dzimte.Vīriešu) + " " +
                "jā" + ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona);
        }

        public string PavēlesIzteiksme(PersonasForma persona)
        {
            string vārds = null;

            switch (persona)
            {
                // Pavēles izteiksme netiek lietota vienskaitļa 1.personā.
                // Mana piezīme: izņēmumu tak nemetīšu... tāpēc sakrīt ar daudzskaitļa 1.personu.
                case PersonasForma.VienskaitļaPirmāPersona:
                case PersonasForma.DaudzskaitļaPirmāPersona:
                    vārds = ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma.DaudzskaitļaPirmāPersona);
                    break;

                // Pavēles izteiksmes vienskaitļa 2.personas forma ir vienāda ar īstenības izteiksmes vienskaitļa 2.personas formu.
                case PersonasForma.VienskaitļaOtrāPersona:
                    vārds = ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona);
                    vārds = LīdzskaņuMijaPavēlesIzteiksmei(vārds, persona);
                    break;

                // Pavēles izteiksmes daudzskaitļa 2.personas formu veido, darbības vārda īstenības izteiksmes vienkāršās tagadnes vienskaitļa 2.personas formas celmam pievienojot galotni -iet vai -ieties.
                case PersonasForma.DaudzskaitļaOtrāPersona:
                    vārds = ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaOtrāPersona);
                    vārds = LīdzskaņuMijaPavēlesIzteiksmei(vārds, persona);

                    vārds += Tiešs ? "iet" : "ieties";
                    break;

                // Ar 3.personas nozīmi pavēles izteiksmē lieto īstenības izteiksmes vienkāršās tagadnes 3.personas formu savienojumā ar partikulu lai.
                case PersonasForma.VienskaitļaTrešāPersona:
                case PersonasForma.DaudzskaitļaTrešāPersona:
                    vārds = "lai " + ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma.VienskaitļaTrešāPersona);
                    break;
            }

            return vārds;
        }

        protected string LīdzskaņuMijaĪstenībasIzteiksmesVienkāršajaiTagadnei(string celms, PersonasForma persona)
        {
            // Daļai I konjugācijas darbības vārdu vienkāršās tagadnes personu formās, izņemot vienskaitļa 2.personas formu, saknes beigās rodas līdzskaņu mija.
            if (Konjugācija == Konjugācija.I && persona == PersonasForma.VienskaitļaOtrāPersona)
            {
                if (Konjugācija == Konjugācija.I && Grupa == 4)
                {
                    string pagātnesCelmaPēdējaisBurts = PagātnesCelms[PagātnesCelms.Length - 1].ToString();
                    celms = celms.LīdzskaņuMija("bj", pagātnesCelmaPēdējaisBurts);
                    celms = celms.LīdzskaņuMija("mj", pagātnesCelmaPēdējaisBurts);
                    celms = celms.LīdzskaņuMija("pj", pagātnesCelmaPēdējaisBurts);
                    celms = celms.LīdzskaņuMija("ļ", pagātnesCelmaPēdējaisBurts);
                    celms = celms.LīdzskaņuMija("š", pagātnesCelmaPēdējaisBurts);
                    celms = celms.LīdzskaņuMija("ž", pagātnesCelmaPēdējaisBurts);
                }
                else
                {
                    celms = celms.LīdzskaņuMija("bj", "b");
                    celms = celms.LīdzskaņuMija("mj", "m");
                    celms = celms.LīdzskaņuMija("pj", "p");
                    celms = celms.LīdzskaņuMija("ļ", "l");
                    celms = celms.LīdzskaņuMija("š", "s");
                    celms = celms.LīdzskaņuMija("ž", "z");
                }

                // Dažiem I konjugācijas darbības vārdiem, kam nenoteiksmē galotnes priekšā ir līdzskanis k vai g, līdzskaņu mija ir tikai vienkāršās tagadnes vienskaitļa 2.personas formā.
                if (Nenoteiksme.BeidzasAr("kt", "kties"))
                {
                    celms = celms.LīdzskaņuMija("k", "c");
                }
                else if (Nenoteiksme.BeidzasAr("gt", "gties"))
                {
                    celms = celms.LīdzskaņuMija("g", "dz");
                }
            }

            if (Konjugācija == Konjugācija.II && ((persona == PersonasForma.VienskaitļaTrešāPersona || persona == PersonasForma.DaudzskaitļaTrešāPersona) || persona == PersonasForma.VienskaitļaOtrāPersona))
            {
                celms = celms.AtmestGalotni("j");
            }

            // Dažiem III konjugācijas darbības vārdiem, kam nenoteiksmē izskaņu -ēt vai -īt priekšā ir līdzskani c vai dz, visās vienkāršās tagadnes personu formās galotnes priekšā ir līdzskanis k vai g.
            /* if ($this->conjugation == 3) {
            if ($this->infinitive->BeidzasAr('ēt', 'ēties', 'īt', 'īties') {
                $word->palatalise('c', 'k');
                $word->palatalise('dz', 'g');
            }
            } */

            return celms;
        }

        protected string LīdzskaņuMijaĪstenībasIzteiksmesVienkāršajaiNākotnei(string celms)
        {
            // I konjugācijas darbības vārdiem...
            if (Konjugācija == Konjugācija.I)
            {
                // (šis gan nav nekur rakstīts)
                if (PagātnesCelms.BeidzasAr("t"))
                {
                    celms = celms.LīdzskaņuMija("s", "t");
                }
                else if (PagātnesCelms.BeidzasAr("d"))
                {
                    celms = celms.LīdzskaņuMija("s", "d");
                }

                // ...kam nenoteiksmē galotnes priekšā ir līdzskanis s vai z...
                if (NenoteiksmesCelms.BeidzasAr("s", "z"))
                {
                    // ...veidojot vienkāršās nākotnes personu formas pirms piedēkļa -s- vai -š- tiek iesprausts līdzskanis ī izrunas atvieglošanai.
                    celms += "ī";
                }
            }

            return celms;
        }

        protected string LīdzskaņuMijaPavēlesIzteiksmei(string celms, PersonasForma persona)
        {
            if (persona == PersonasForma.DaudzskaitļaOtrāPersona)
            {
                // var īsāk, bez if'a
                if (celms.BeidzasAr("i"))
                {
                    celms = celms.AtmestGalotni("i");
                }
                else if (celms.BeidzasAr("ies"))
                {
                    celms = celms.AtmestGalotni("ies");
                }
            }

            if (PagātnesCelms.BeidzasAr("t"))
            {
                celms = celms.LīdzskaņuMija("s", "t");
                celms = celms.LīdzskaņuMija("ž", "t"); // typo?
            }
            else if (PagātnesCelms.BeidzasAr("d"))
            {
                celms = celms.LīdzskaņuMija("s", "d");
                celms = celms.LīdzskaņuMija("z", "d");
            }

            if (Konjugācija == Konjugācija.II && persona == PersonasForma.DaudzskaitļaOtrāPersona)
            {
                celms += "j";
            }

            return celms;
        }

        private static Skaitlis PersonasSkaitlis(PersonasForma persona)
        {
            switch (persona)
            {
                default:
                case PersonasForma.VienskaitļaPirmāPersona:
                case PersonasForma.VienskaitļaOtrāPersona:
                case PersonasForma.VienskaitļaTrešāPersona:
                    return Skaitlis.Vienskaitlis;

                case PersonasForma.DaudzskaitļaPirmāPersona:
                case PersonasForma.DaudzskaitļaOtrāPersona:
                case PersonasForma.DaudzskaitļaTrešāPersona:
                    return Skaitlis.Daudzskaitlis;
            }
        }
    }
}
