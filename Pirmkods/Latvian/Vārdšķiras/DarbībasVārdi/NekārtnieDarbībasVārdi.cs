using System;

namespace Latvian.Vārdšķiras.DarbībasVārdi
{
    public class BūtDarbībasVārds : IDarbībasVārds
    {
        public string ĪstenībasIzteiksmesVienkāršāTagadne(PersonasForma persona)
        {
            string vārds = null;

            switch (persona)
            {
                case PersonasForma.VienskaitļaPirmāPersona:
                    vārds = "esmu";
                    break;

                case PersonasForma.VienskaitļaOtrāPersona:
                    vārds = "esi";
                    break;

                case PersonasForma.DaudzskaitļaPirmāPersona:
                    vārds = "esam";
                    break;

                case PersonasForma.DaudzskaitļaOtrāPersona:
                    vārds = "esat";
                    break;

                case PersonasForma.VienskaitļaTrešāPersona:
                case PersonasForma.DaudzskaitļaTrešāPersona:
                    vārds = "ir";
                    break;
            }

            return vārds;
        }

        public string ĪstenībasIzteiksmesVienkāršāPagātne(PersonasForma persona)
        {
            string vārds = null;

            switch (persona)
            {
                case PersonasForma.VienskaitļaPirmāPersona:
                    vārds = "biju";
                    break;

                case PersonasForma.VienskaitļaOtrāPersona:
                    vārds = "biji";
                    break;

                case PersonasForma.DaudzskaitļaPirmāPersona:
                    vārds = "bijām";
                    break;

                case PersonasForma.DaudzskaitļaOtrāPersona:
                    vārds = "bijāt";
                    break;

                case PersonasForma.VienskaitļaTrešāPersona:
                case PersonasForma.DaudzskaitļaTrešāPersona:
                    vārds = "bija";
                    break;
            }

            return vārds;
        }

        public string ĪstenībasIzteiksmesVienkāršāNākotne(PersonasForma persona)
        {
            string vārds = null;

            switch (persona)
            {
                case PersonasForma.VienskaitļaPirmāPersona:
                    vārds = "būšu";
                    break;

                case PersonasForma.VienskaitļaOtrāPersona:
                    vārds = "būsi";
                    break;

                case PersonasForma.DaudzskaitļaPirmāPersona:
                    vārds = "būsim";
                    break;

                case PersonasForma.DaudzskaitļaOtrāPersona:
                    vārds = "būsiet";
                    break;

                case PersonasForma.VienskaitļaTrešāPersona:
                case PersonasForma.DaudzskaitļaTrešāPersona:
                    vārds = "būs";
                    break;
            }

            return vārds;
        }

        public string ĪstenībasIzteiksmesSaliktāTagadne(PersonasForma persona, Dzimte dzimte)
        {
            throw new NotImplementedException();
        }

        public string ĪstenībasIzteiksmesSaliktāPagātne(PersonasForma persona, Dzimte dzimte)
        {
            throw new NotImplementedException();
        }

        public string ĪstenībasIzteiksmesSaliktāNākotne(PersonasForma persona, Dzimte dzimte)
        {
            throw new NotImplementedException();
        }

        public string VēlējumaIzteiksmesVienkāršāTagadne()
        {
            return "būtu";
        }

        public string VēlējumaIzteiksmesSaliktāTagadne(PersonasForma persona, Dzimte dzimte)
        {
            return "būtu bijis";
        }

        public string VajadzībasIzteiksmesVienkāršāTagadne()
        {
            return "ir jābūt";
        }

        public string VajadzībasIzteiksmesVienkāršāPagātne()
        {
            return "bija jābūt";
        }

        public string VajadzībasIzteiksmesVienkāršāNākotne()
        {
            return "būs jābūt";
        }

        public string PavēlesIzteiksme(PersonasForma persona)
        {
            string vārds = null;

            switch (persona)
            {
                case PersonasForma.VienskaitļaPirmāPersona:
                    vārds = "esam";
                    break;

                case PersonasForma.VienskaitļaOtrāPersona:
                    vārds = "esi";
                    break;

                case PersonasForma.DaudzskaitļaPirmāPersona:
                    vārds = "būsim";
                    break;

                case PersonasForma.DaudzskaitļaOtrāPersona:
                    vārds = "esiet";
                    break;

                case PersonasForma.VienskaitļaTrešāPersona:
                case PersonasForma.DaudzskaitļaTrešāPersona:
                    vārds = "ir";
                    break;
            }

            return vārds;
        }

        public string Nenoteiksme
        {
            get { return "būt"; }
        }

        public string NenoteiksmesCelms
        {
            get { throw new NotImplementedException(); }
        }

        public string TagadnesCelms
        {
            get { throw new NotImplementedException(); }
        }

        public string PagātnesCelms
        {
            get { return "bij"; }
        }

        public bool Atgriezenisks
        {
            get { return false; }
        }

        public bool Tiešs
        {
            get { return true; }
        }

        public Konjugācija Konjugācija
        {
            get { throw new NotSupportedException(); }
        }

        public int Grupa
        {
            get { throw new NotSupportedException(); }
        }

        #region IDarbībasVārds Members


        public string AtstāstījumaIzteiksmesVienkāršāTagadne()
        {
            return "esot";
        }

        public string AtstāstījumaIzteiksmesVienkāršāNākotne()
        {
            return "būšot";
        }

        public string AtstāstījumaIzteiksmesSaliktāTagadne(PersonasForma persona, Dzimte dzimte)
        {
            return "esot bijis";
        }

        public string AtstāstījumaIzteiksmesSaliktāNākotne(PersonasForma persona, Dzimte dzimte)
        {
            return "būšot bijis";
        }

        #endregion

        #region IDarbībasVārds Members


        public string VajadzībasIzteiksmesSaliktāTagadne()
        {
            throw new NotImplementedException();
        }

        public string VajadzībasIzteiksmesSaliktāPagātne()
        {
            throw new NotImplementedException();
        }

        public string VajadzībasIzteiksmesSaliktāNākotne()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IDarbībasVārds Members


        public string VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāTagadne()
        {
            throw new NotImplementedException();
        }

        public string VajadzībasIzteiksmesAtstāstījumaPaveidaVienkāršāNākotne()
        {
            throw new NotImplementedException();
        }

        public string VajadzībasIzteiksmesVēlējumaPaveidaVienkāršāTagadne()
        {
            throw new NotImplementedException();
        }

        public string VajadzībasIzteiksmesVēlējumaPaveidaSaliktāTagadne()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
