﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PM02RestApi
{
    public class Countries
    {
        public class Currency
        {
            public string code { get; set; }
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Language
        {
            public string iso639_1 { get; set; }
            public string iso639_2 { get; set; }
            public string name { get; set; }
            public string nativeName { get; set; }
        }

        public class Translations
        {
            public string de { get; set; }
            public string es { get; set; }
            public string fr { get; set; }
            public string ja { get; set; }
            public string it { get; set; }
            public string br { get; set; }
            public string pt { get; set; }
            public string nl { get; set; }
            public string hr { get; set; }
            public string fa { get; set; }
        }

        public class RegionalBloc
        {
            public string acronym { get; set; }
            public string name { get; set; }
            public IList<string> otherAcronyms { get; set; }
            public IList<object> otherNames { get; set; }
        }

        public class CountriesREst
        {
            public string name { get; set; }
            public IList<string> topLevelDomain { get; set; }
            public string alpha2Code { get; set; }
            public string alpha3Code { get; set; }
            public IList<string> callingCodes { get; set; }
            public string capital { get; set; }
            public IList<string> altSpellings { get; set; }
            public string region { get; set; }
            public string subregion { get; set; }
            public int population { get; set; }
            public IList<double> latlng { get; set; }
            public string demonym { get; set; }
            public double? area { get; set; }
            public double? gini { get; set; }
            public IList<string> timezones { get; set; }
            public IList<string> borders { get; set; }
            public string nativeName { get; set; }
            public string numericCode { get; set; }
            public IList<Currency> currencies { get; set; }
            public IList<Language> languages { get; set; }
            public Translations translations { get; set; }
            public string flag { get; set; }
            public IList<RegionalBloc> regionalBlocs { get; set; }
            public string cioc { get; set; }
        }
    }
}
