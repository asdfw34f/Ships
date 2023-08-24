using System;

namespace Ships.MVVM.Models
{
    public class Dock
    {
        public int id { get; set; }
        public string name_mark { get; set; }
        public Tuple<int, int> geopoint { get; set; }
    }
}
