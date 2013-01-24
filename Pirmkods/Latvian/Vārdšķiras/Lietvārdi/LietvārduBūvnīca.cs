namespace Latvian.Vārdšķiras.Lietvārdi
{
    public static class LietvārduBūvnīca
    {
        /// <summary>
        /// II deklinācijas izņēmumi, kas beidzas ar -s.
        /// </summary>
        private static string[] otrāsDeklinācijasIzņēmumi = new string[] {
            "akmens", "asmens", "rudens", "zibens", "ūdens", "mēness", "sāls", "suns"
        };

        /// <summary>
        /// VI klases lietvārdi.
        /// 
        /// Dabūju no openoffice.org pareizrakstības pārbaudes vārdnīcas, iespējams, ka nav visi.
        /// Varbūt pārvietot uz resursiem?
        /// </summary>
        private static string[] sestāsDeklinācijasVārdi = new string[] {
            "acs", "apakšģints", "asins", "ass", "auss", "akts", 
            "balss", "bezvēsts", "bikts", "birzs", "blakts", "bārksts", "cilts", 
            "dakts", "debess", "drāts", "dzelzs", "dzirksts", "dūksts", 
            "govs", "grunts", "guns", "ģikts", "ģints",
            "igvāts", "ilkss", "izkapts", 
            "klints", "klēts", "krants", "krāsns", "krūts", "kvīts", "kārts", "kūts", 
            "laputs", "lecekts", 
            "maksts", "nakts", "nots", "nāss", "nīts", 
            "olekts", "palts", "pavēsts", "pils", "pirts", "plīts", "pults", "pāksts", "rūts", 
            "sirds", "skrots", "smilts", "spīts", "šalts",
            "takts", "telts", "tāss", 
            "uguns", "uts", "uztakts", 
            "vakts", "valsts", "vants", "versts", "vāts", "vēsts", 
            "zivs", "zoss", "žults"
        };

        private static string[] atriegrezniskoLietvārduGalotnes = new string[] {
            "šanās", "tājies", "tājās", "ējies", "ējās", "ājies", "umies"
        };

        /// <summary>
        /// Mēģina uzminēt lietvārda deklināciju, balstoties uz galotni.
        /// 
        /// Pilnīgi precīzi atpazīst dažus I (-š), visus III (-us), IV (-a) un V (-a) deklinācijas lietvārdus.
        /// Atpazīst II deklinācijas izņēmumus.
        /// Uzmanīgi: pie II deklinācijas iet daudzskaitlinieki, kam ir galotne -is (debesis, piem.).
        /// Toties debess tiek pareizi atpazīts kā VI deklinācijas lietvārds, kā arī čupa citu.
        /// Šis saraksts gan nav pilnīgs. Pārējie -s un -š vārdi tiek uzskatīti par I deklinācijas vārdiem.
        /// Visi pārējie vārdi ar nestandarta galotnēm tiks atgriezti kā nelokāmi lietvārdi.
        /// </summary>
        /// <seealso cref="this.sestāsDeklinācijasVārdi"/>
        /// <seealso cref="this.otrāsDeklinācijasIzņēmumi"/>
        /// <seealso cref="this.atriegrezniskoLietvārduGalotnes"/>
        public static Lietvārds Jauns(string vārds)
        {
            if (vārds.BeidzasAr(atriegrezniskoLietvārduGalotnes))
            {
                return new AtgriezenisksLietvārds(vārds);
            }
            else if (vārds.BeidzasAr(sestāsDeklinācijasVārdi))
            {
                return new SestāsDeklinācijasLietvārds(vārds);
            }
            else if (vārds.BeidzasAr("us"))
            {
                return new TrešāsDeklinācijasLietvārds(vārds);
            }
            else if (vārds.BeidzasAr("is") || vārds.BeidzasAr(otrāsDeklinācijasIzņēmumi))
            {
                if (char.IsUpper(vārds[0]))
                    return new OtrāsDeklinācijasPersonvārdaLietvārds(vārds);
                return new OtrāsDeklinācijasLietvārds(vārds);
            }
            else if (vārds.BeidzasAr("s", "š"))
            {
                return new PirmāsDeklinācijasLietvārds(vārds);
            }
            else if (vārds.BeidzasAr("a"))
            {
                return new CeturtāsDeklinācijasLietvārds(vārds);
            }
            else if (vārds.BeidzasAr("e"))
            {
                return new PiektāsDeklinācijasLietvārds(vārds);
            }
            else
            {
                return new NelokāmsLietvārds(vārds, Dzimte.Vīriešu);
            }
        }

        /// <summary>
        /// Mēģina uzminēt lietvārda deklināciju, balstoties uz galotni un dzimumu.
        /// </summary>
        /// <param name="vārds"></param>
        /// <param name="dzimte"></param>
        /// <returns></returns>
        public static Lietvārds Jauns(string vārds, Dzimte dzimte)
        {
            if (vārds.BeidzasAr(atriegrezniskoLietvārduGalotnes))
            {
                return new AtgriezenisksLietvārds(vārds);
            }
            else if (vārds.BeidzasAr("us"))
            {
                return new TrešāsDeklinācijasLietvārds(vārds);
            }
            else if (vārds.BeidzasAr(sestāsDeklinācijasVārdi) || (vārds.BeidzasAr("s") && dzimte == Dzimte.Sieviešu))
            {
                return new SestāsDeklinācijasLietvārds(vārds);
            }
            else if (vārds.BeidzasAr("is") || vārds.BeidzasAr(otrāsDeklinācijasIzņēmumi))
            {
                if (char.IsUpper(vārds[0]))
                    return new OtrāsDeklinācijasPersonvārdaLietvārds(vārds);
                return new OtrāsDeklinācijasLietvārds(vārds);
            }
            else if (vārds.BeidzasAr("s", "š"))
            {
                return new PirmāsDeklinācijasLietvārds(vārds);
            }
            else if (vārds.BeidzasAr("a"))
            {
                return new CeturtāsDeklinācijasLietvārds(vārds, dzimte);
            }
            else if (vārds.BeidzasAr("e"))
            {
                return new PiektāsDeklinācijasLietvārds(vārds, dzimte);
            }
            else
            {
                return new NelokāmsLietvārds(vārds, Dzimte.Vīriešu);
            }
        }
    }
}
