using Latvian.Vārdšķiras.ĪpašībasVārdi;

namespace Latvian.Vārdšķiras.DarbībasVārdi.Divdabji
{
    public class DarāmāsKārtasTagadnesDivdabis : ĪpašībasVārds
    {
        public DarāmāsKārtasTagadnesDivdabis(DarbībasVārds vārds) : base(
            (vārds.TagadnesCelms.BeidzasAr("š", "ž") ? vārds.PagātnesCelms : vārds.TagadnesCelms)
                + "ošs")
        {
        }
    }
}
