namespace Ships.MVVM.Models
{
    public class Route
    {
        public int id { get; set; }
        public string abbrev { get; set; }
        public string nameroute { get; set; }
        public int next_dock_id { get; set; }
        public string next_dock_name_mark { get; set; }
        public int next_schedule_id { get; set; }
        public int first_dock_id { get; set; }
        public int first_dock_name_mark { get; set; }
        public int last_dock_id { get; set; }
        public int last_dock_name_mark { get; set; }


    }
}
