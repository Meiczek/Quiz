using Quiz_A1.Stores;
using Quiz_A1.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_A1.Core
{
    public class NavigateCommandCreate<TViewModel> : RelayCommand
       where TViewModel : BaseViewModel
    {
        private readonly NavigationStore _navigationStore;
        private readonly Func<TViewModel> _fixViewModel;

        public NavigateCommandCreate(NavigationStore navigationStore, Func<TViewModel> createViewModel)
        {
            this._navigationStore = navigationStore;
            _fixViewModel = createViewModel;
        }
        public override void Execute(object parameter)
        {
            _navigationStore.CurrentViewModel = _fixViewModel();
        }
    }
}
