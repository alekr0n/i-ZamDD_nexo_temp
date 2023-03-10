using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelerikWpfApp3
{
    public class Data
    {
        ObservableCollection<Grupa> grupy = new ObservableCollection<Grupa>();
        #region Grupa manipulation
        public void EntryGrupaData()
        {
            grupy.Add(new Grupa()
            {
                Nazwa = "pomadki"
            });
            grupy.Add(new Grupa()
            {
                Nazwa = "Woda"
            });
            grupy.Add(new Grupa()
            {
                Nazwa = "dezedoranty"
            });
        }
        public ObservableCollection<Grupa> GetGrupa()
        {
            grupy.Clear();
            EntryGrupaData();
            return this.grupy;
        }
        #endregion
    }
}
