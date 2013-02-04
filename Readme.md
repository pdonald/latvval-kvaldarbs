Latviešu valodas vārdu locītājs
===============================

Abstract
--------
The paper „Latvian word inflector” describes the development of a software library for inflecting nouns, adjectives, verbs and participles in Latvian.

Anotācija
---------

Kvalifikācijas darbs „Latviešu valodas vārdu locītājs” apraksta programmatūras bibliotēkas izstrādi, kas ļauj izlocīt latviešu valodas lietvārdus, īpašības vārdus, darbības vārdus un divdabjus, zinot to pamatformas un morfoloģiskās īpašības. Gudrākiem vārdiem sakot, tas ir morfoloģiskais sintezators.

Ievads
------

Šī darba mērķis ir apkopot un aprakstīt programmatūras prasību specifikācijā latviešu valodas vārdu locīšanas likumus un, balstoties uz savāktajām prasībām, projektēt un praktiski izveidot vārdu locīšanas bibliotēku.

Izveidotajā programmatūras bibliotēkā tiek locītas tikai pamatvārdšķiras: lietvārdi, īpašības vārdi, darbības vārdi (un arī divdabji). Pārējās vārdšķiras ir vai nu nelokāmas, lokās paredzami un īpatnēji vai var izlocīt kā lietvārdus un īpašības vārdus.

Lai varētu izlocīt vārdus, bibliotēkai ir jāzina vārda pamatforma un morfoloģiskās īpašības, pēc kurām nosaka, kādu locīšanas paraugu izmantot. Šādu informāciju var atrast specializētās vārdnīcās.

Bibliotēkai ir vairāki praktiski pielietojumi:

* meklēšana visos vārda locījumos,
* vārda pārvēršana no vienskaitļa daudzskaitlī,
* automatizēta daudzu personvārdu locīšana,
* valodas apmācība,
* valodas spēles,
* vārdu analīze.

Kvalifikācijas darbā latviešu valodas vārdu locīšanas bibliotēka tika izveidota programmēšanas valodā C#, un visi izmantotie locīšanas likumi ir aprakstīti tabulu veidā programmatūras prasību specifikācijā un iespējamais projektējums objektorientētā programmēšanas valodā ir aprakstīts programmatūras projektējuma aprakstā. Izmantojot abus dokumentus, ir iespējams izveidot tādu pašu bibliotēku jebkurā citā programmēšanas valodā, kas atbalsta darbības ar teksta virknēm.

Darbs ir izstrādāts patstāvīgi un neatkarīgi no citiem līdzīgiem projektiem.

Lietošana
---------

Vairāk lietošanas piemērus var atrast [vienībtestu mapē](Pirmkods/Latvian.Tests).

```csharp
[Test, Category("I deklinācija")]
public void Koks()
{
    Lietvārds koks = new PirmāsDeklinācijasLietvārds("koks");
    Assert.AreEqual(Dzimte.Vīriešu, koks.Dzimte);
    Assert.AreEqual(Deklinācija.I, (koks as DeklinējamsLietvārds).Deklinācija);
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
```
