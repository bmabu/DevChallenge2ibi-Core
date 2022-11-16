using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevChallenge2ibi.Models
{
    public class CountryName
    {
        public class Name
        {
            public string Common { get; set; }
            public string Official { get; set; }
            public List<NativeName> NativeName { get; set; }
        }
        public class NativeName
        {
            public List<LangName> LangName { get; set; }

        }
        public class LangName
        {
            public string Official { get; set; }
            public string Common { get; set; }

        }

    }
}
