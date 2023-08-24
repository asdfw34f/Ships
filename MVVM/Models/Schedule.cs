namespace Ships.MVVM.Models
{
    public class Schedule
    {
        public int id { get; set; }
        public string name { get; set; }
        public Route route { get; set; }
        public Ship ship { get; set; }
        public Timetable timetable { get; set; }
        public Position position { get; set; }
        public ChangedSchedule changed_schedule { get; set; }
    }
}
