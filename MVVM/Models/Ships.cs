using System.Collections.ObjectModel;

namespace Ships.MVVM.Models
{
    public class Ships
    {
        public ObservableCollection<Ships> ships = new ObservableCollection<Ships>();
    }
}