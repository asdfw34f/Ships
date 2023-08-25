using FileHelpers;
using System.Collections.ObjectModel;

namespace DataModel.Models
{
    [DelimitedRecord(",")]
    public class CollectionSchedule
    {
        public ObservableCollection<Schedule> schedules { get; set; } = new ObservableCollection<Schedule>();
    }
}
