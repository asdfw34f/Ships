using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Models
{

    internal class Telemetry
    {
        internal int id { get; set; }
        internal Location locatoin { get; set; }

    }

    internal class Location
    {
        string cog { get; set; }
        double lat { get; set; }
        double lon { get; set; }
        double sog { get; set; }
        long ts { get; set; }

    }
}
