using System.Collections.ObjectModel;

namespace Ships.MVVM.Models
{
    public class CollectionSchedule
    {
        public ObservableCollection<Schedule> schedules { get; set; } = new ObservableCollection<Schedule>();
    }
}
