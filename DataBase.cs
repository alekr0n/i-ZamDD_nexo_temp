using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace TelerikWpfApp3
{
    public class DataBase : INotifyPropertyChanged
    {
        private List<string> _name;
        
        public DataBase()
        {
            Grupa = new List<string> { "Grupa 1", "Grupa 2", "Grupa 3", "Grupa 4", "Grupa 5" };
            Cecha = new List<string> { "Cecha 1", "Cecha 2", "Cecha 3", "Cecha 4", "Cecha 5" };
            Dostawca = new List<string> { "Dostawca 1", "Dostawca 2", "Dostawca 3", "Dostawca 4", "Dostawca 5" };
            Producent = new List<string> { "Producent 1", "Producent 2", "Producent 3", "Producent 4", "Producent 5" };
            Flaga = new List<string> { "Flaga 1", "Flaga 2", "Flaga 3", "Flaga 4", "Flaga 5" };
            Magazyn = new List<string> { "Magazyn 1", "Magazyn 2", "Magazyn 3", "Magazyn 4", "Magazyn 5" };
        }

        public List<string> Grupa
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }
        public List<string> Cecha
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }
        public List<string> Dostawca
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }
        public List<string> Producent
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }
        public List<string> Flaga
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }
        public List<string> Magazyn
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propetyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propetyName));
        }
    }

}
