using FileHelpers;
using System.Collections.ObjectModel;

namespace DataModel.Models
{
    [DelimitedRecord(",")]
    public class Docks
    {
        public ObservableCollection<Dock> docks { get; set; } = new ObservableCollection<Dock>();
    }
}
