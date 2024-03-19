using Quiz_A1.Core;
using Quiz_A1.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Quiz_A1.ViewModel
{
    public class CreateViewModel : BaseViewModel
    {

        private BaseViewModel _selectedViewModel;
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
        public ICommand UpdateViewCommandNext { get; set; }
        public CreateViewModel(NavigationStore navigationStore)
        {
            UpdateViewCommandNext = new NavigateCommand<CreateViewModel>(navigationStore, () => new CreateViewModel(navigationStore));
            UpdateViewCommand = new NavigateCommand<MenuViewModel>(navigationStore, () => new MenuViewModel(navigationStore));
        }

    }


}

