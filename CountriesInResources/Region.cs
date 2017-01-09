using System.Collections.Generic;

namespace CountriesInResources
{
    public class Region : Location
    {
        public IEnumerable<Country> Countries { get; set; }
    }
}