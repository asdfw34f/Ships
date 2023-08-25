using FileHelpers;
using System;

namespace DataModel.Models
{
    [DelimitedRecord(",")]
    public class Dock
    {
        public int id { get; set; }
        public string name_mark { get; set; }
        public Tuple<int, int> geopoint { get; set; }
    }
}
