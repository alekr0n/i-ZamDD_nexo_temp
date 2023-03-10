using System.Collections.ObjectModel;
using System.Linq;

namespace TelerikWpfApp3
{
    public class MyComboBoxList
    {
        private Data source = new Data();
        private ObservableCollection<Grupa> grupaList = new ObservableCollection<Grupa>();

        public MyComboBoxList()
        {
            LoadGrupa();
        }
        private void LoadGrupa()
        {
            foreach(var grupa in source.GetGrupa())
            {
                grupaList.Add(grupa);
            }
        }
        public ObservableCollection<Grupa> GrupaList
        {
            get { return this.grupaList; }
        }
        

    }
}
