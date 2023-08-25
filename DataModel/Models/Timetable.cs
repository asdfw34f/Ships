using FileHelpers;

namespace DataModel.Models
{
    [DelimitedRecord(",")]
    public class Timetable
    {
        public int day { get; set; }
        public int startdate { get; set; }
        public int enddate { get; set; }
        public int starttime { get; set; }
        public int endtime { get; set; }
        public int duration { get; set; }

    }
}