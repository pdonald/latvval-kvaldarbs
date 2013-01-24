using Latvian.Vārdšķiras.ĪpašībasVārdi;

namespace Latvian.Vārdšķiras.DarbībasVārdi.Divdabji
{
    public class CiešamāsKārtasTagadnesDivdabis : ĪpašībasVārds
    {
        public CiešamāsKārtasTagadnesDivdabis(DarbībasVārds vārds) : base(vārds.TagadnesCelms +
            (vārds.Konjugācija == Konjugācija.III && vārds.Grupa == 1 ? "ām" : "am"), "s")
        {
        }
    }
}
