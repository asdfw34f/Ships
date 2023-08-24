using System.Collections.ObjectModel;

namespace Ships.MVVM.Models
{
    public class Docks
    {
        public ObservableCollection<Dock> docks { get; set; } = new ObservableCollection<Dock>();
    }
}
