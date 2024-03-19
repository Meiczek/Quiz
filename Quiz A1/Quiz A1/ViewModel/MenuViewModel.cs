using Quiz_A1.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Quiz_A1.ViewModel
{
    public class MenuViewModel : BaseViewModel
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

        public MenuViewModel(NavigationStore navigationStore)
        { 
            UpdateViewCommand = new NavigateCommand<SolveViewModel>(navigationStore, () => new SolveViewModel(navigationStore));
            UpdateViewCommandCreate = new NavigateCommand<TypeNameViewModel>(navigationStore, () => new TypeNameViewModel(navigationStore));

        }
    }
}
