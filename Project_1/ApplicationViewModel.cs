using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;

namespace Project_1
{
    // Модель представления
    public class ApplicationViewModel: INotifyPropertyChanged
    {
        private Phone _selectedPhone;

        public ObservableCollection<Phone> Phones { get; set; }

        public Phone SelectedPhone 
        {
            get { return _selectedPhone; }
            set 
            {
                _selectedPhone = value;
                OnPropertyChanged();
            }
        }

        public ApplicationViewModel() 
        {
            Phones = new ObservableCollection<Phone>
            {
                new Phone { Title="iPhone 7", Company="Apple", Price=56000 },
                new Phone {Title="Galaxy S7 Edge", Company="Samsung", Price =60000 },
                new Phone {Title="Elite x3", Company="HP", Price=56000 },
                new Phone {Title="Mi5S", Company="Xiaomi", Price=35000 },
				new Phone {Title="Mi5S", Company="Xiaomi", Price=35001 }
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "") 
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
}
