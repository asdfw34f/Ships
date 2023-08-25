using FileHelpers;

namespace DataModel.Models
{
    [DelimitedRecord(",")]
    public class Ship
    {
        public int id { get; set; }
        public string name { get; set; }
        public string codeclass { get; set; }
        public string codesubclass { get; set; }
    }
}
