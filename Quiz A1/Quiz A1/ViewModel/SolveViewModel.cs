using Quiz_A1.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Quiz_A1.ViewModel
{
    public class SolveViewModel : BaseViewModel
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
        public SolveViewModel(NavigationStore navigationStore)
        {
            UpdateViewCommand = new NavigateCommand<MenuViewModel>(navigationStore, () => new MenuViewModel(navigationStore));
        }
    }
}
