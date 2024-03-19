using Quiz_A1.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Quiz_A1.ViewModel
{
    public class TypeNameViewModel : BaseViewModel
    {
        private BaseViewModel _selectedViewModel;
        private NavigationStore navigationStore;

        public BaseViewModel SelectedViewModel
        {
            get { return _selectedViewModel; }
            set
            {
                _selectedViewModel = value;
                OnPropertyChanged(nameof(SelectedViewModel));
            }
        }

        public ICommand UpdateViewCommand { get; set; }
        public ICommand UpdateViewCommandCreate { get; set; }

        public TypeNameViewModel(NavigationStore navigationStore)
        {
            UpdateViewCommand = new NavigateCommand<MenuViewModel>(navigationStore, () => new MenuViewModel(navigationStore));
            UpdateViewCommandCreate = new NavigateCommand<CreateViewModel>(navigationStore, () => new CreateViewModel(navigationStore));

        }
    }
}
