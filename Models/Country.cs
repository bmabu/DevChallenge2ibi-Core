using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevChallenge2ibi.Models
{
    public class Country
    {
        #nullable enable
        public Names? Name { get; set; }
        public string[]? Tld { get; set; }
        public string? Cioc { get; set; }
        public bool? Independent { get; set; }
        public string? Status { get; set; }
        public bool? UnMember { get; set; }
        public Dictionary<string, Currency>? Currencies { get; set; }
        public Idd? Idd { get; set; }
        public string[]? Capital { get; set; }
        public string[]? AltSpellings { get; set; }
        public string? Region { get; set; }
        public string? Subregion { get; set; }
        public Dictionary<string, string>? Languages { get; set; }
        public Dictionary<string, TranslationsLang>? Translations { get; set; }
        public string[]? Latlng { get; set; }
        public bool? Landlocked { get; set; }
        public string[]? Borders { get; set; }
        public float? Area { get; set; }
        public Dictionary<string, DemonymsLang>? Demonyms { get; set; }
        public string? Flag { get; set; }
        public Maps? Maps { get; set; }
        public int? Population { get; set; }
        public Dictionary<string, string>? Gini { get; set; }
        public string? Fifa { get; set; }

        public List<Car>? Cars { get; set; }
        public string[]? Timezones { get; set; }
        public string[]? Continents { get; set; }
        public Flags? Flags { get; set; }
        public CoatOfArms? CoatOfArms { get; set; }
        public string? StartOfWeek { get; set; }
        public CapitalInfo? CapitalInfo { get; set; }

        public PostalCode? PostalCode { get; set; }
#nullable disable

    }

    public class PostalCode
    {
        public string format { get; set; }
        public string regex { get; set; }

    }

    public class CapitalInfo
    {
        public string[] latlng { get; set; }

    }

    public class CoatOfArms
    {
        public string Png { get; set; }
        public string Svg { get; set; }

    }
    public class Flags
    {
        public string Png { get; set; }
        public string Svg { get; set; }

    }

    public class Car
{
    public ArrayList Signs { get; set; }
    public string Side { get; set; }
   
}

//COntry Name Properties
public class Names
    {
        public string Common { get; set; }
        public string Official { get; set; }
        public Dictionary<string, NativeName> NativeName { get; set; }
    }
   
    public class NativeName
    {
        public string Official { get; set; }
        public string Common { get; set; }

    }

    //Currenct Properties
    //public class Currency
    //{
    //    public List<Dictionary<string, CurrencyLang>> CurrencyLang{ get; set; }
    //}
    public class Currency
    {
        public string Name { get; set; }
        public string Symbol { get; set; }

    }

    public class Idd
    {
        public string Root { get; set; }
        public ArrayList Suffixes { get; set; }

    }

    public class TranslationsLang
    {
        public string Official { get; set; }
        public string Common { get; set; }

    }

    public class DemonymsLang
    {
        public string F { get; set; }
        public string M { get; set; }
    }

    public class Maps
    {
        public string googleMaps { get; set; }
        public string openStreetMaps { get; set; }
    }

}
