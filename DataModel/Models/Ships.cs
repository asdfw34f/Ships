using FileHelpers;
using System.Collections.ObjectModel;

namespace DataModel.Models
{
    [DelimitedRecord(",")]
    public class Ships
    {
        public ObservableCollection<Ships> ships = new ObservableCollection<Ships>();
    }
}