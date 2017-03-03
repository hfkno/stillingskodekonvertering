

/// <summary>
/// Kartlegging fra/til stillingskodene i Hordaland Fylkeskommune
/// </summary>
namespace Hfk.Ansatte
{
    public enum AnsettelsesType
    {
        Engasjement = 0,
        FastAnsatt = 1,
        FastAnsattTurnus = 2,
        Folkevalgt = 3,
        Honorar = 4,
        Innleid = 5,
        Lærling = 6,
        Næringsdrivende = 7,
        Omsorgspermisjon = 8,
        PensjonistMedUndervisning = 9,
        PensjonistUtenUndervisning = 10,
        UtgåttKode = 11,
        SykemeldtEtterMaksdato = 12,
        StudiepermisjonUtenLønn = 13,
        Timelønnet = 14,
        TimelønnetMedEpost = 15,
        TimelønnetLærer = 16,
        Vikar = 17,
        Ekstrahjelp = 18,
        DummyAnsattForhold = 19
    }

    public static class EmployeeTypeConverter
    {
        public static AnsettelsesType StringToEmployeeType(string employeeTypeCode)
        {
            switch (employeeTypeCode)
            {
                case "E":
                    return AnsettelsesType.Engasjement;
                case "F":
                    return AnsettelsesType.FastAnsatt;
                case "FT":
                    return AnsettelsesType.FastAnsattTurnus;
                case "G":
                    return AnsettelsesType.Folkevalgt;
                case "H":
                    return AnsettelsesType.Honorar;
                case "I":
                    return AnsettelsesType.Innleid;
                case "L":
                    return AnsettelsesType.Lærling;
                case "N":
                    return AnsettelsesType.Næringsdrivende;
                case "OP":
                    return AnsettelsesType.Omsorgspermisjon;
                case "P":
                    return AnsettelsesType.PensjonistMedUndervisning;
                case "PE":
                    return AnsettelsesType.PensjonistUtenUndervisning;
                case "SE":
                    return AnsettelsesType.UtgåttKode;
                case "SM":
                    return AnsettelsesType.SykemeldtEtterMaksdato;
                case "SP":
                    return AnsettelsesType.StudiepermisjonUtenLønn;
                case "T":
                    return AnsettelsesType.Timelønnet;
                case "TE":
                    return AnsettelsesType.TimelønnetMedEpost;
                case "TL":
                    return AnsettelsesType.TimelønnetLærer;
                case "V":
                    return AnsettelsesType.Vikar;
                case "X":
                    return AnsettelsesType.Ekstrahjelp;
                case "Y":
                    return AnsettelsesType.DummyAnsattForhold;
            }

            return AnsettelsesType.DummyAnsattForhold;
        }

        public static string EmployeeTypeToString(AnsettelsesType employeeType)
        {
            switch (employeeType)
            {
                case AnsettelsesType.Engasjement:
                    return "E";
                case AnsettelsesType.FastAnsatt:
                    return "F";
                case AnsettelsesType.FastAnsattTurnus:
                    return "FT";
                case AnsettelsesType.Folkevalgt:
                    return "G";
                case AnsettelsesType.Honorar:
                    return "H";
                case AnsettelsesType.Innleid:
                    return "I";
                case AnsettelsesType.Lærling:
                    return "L";
                case AnsettelsesType.Næringsdrivende:
                    return "N";
                case AnsettelsesType.Omsorgspermisjon:
                    return "OP";
                case AnsettelsesType.PensjonistMedUndervisning:
                    return "P";
                case AnsettelsesType.PensjonistUtenUndervisning:
                    return "PE";
                case AnsettelsesType.UtgåttKode:
                    return "SE";
                case AnsettelsesType.SykemeldtEtterMaksdato:
                    return "SM";
                case AnsettelsesType.StudiepermisjonUtenLønn:
                    return "SP";
                case AnsettelsesType.Timelønnet:
                    return "T";
                case AnsettelsesType.TimelønnetMedEpost:
                    return "TE";
                case AnsettelsesType.TimelønnetLærer:
                    return "TL";
                case AnsettelsesType.Vikar:
                    return "V";
                case AnsettelsesType.Ekstrahjelp:
                    return "X";
                case AnsettelsesType.DummyAnsattForhold:
                    return "Y";
            }

            return string.Empty;
        }
    }
}
