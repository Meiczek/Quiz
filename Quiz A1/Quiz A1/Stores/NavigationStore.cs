using Quiz_A1.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_A1.Stores
{
    public class NavigationStore
    {
        public event Action CurrentViewModelChanged;
        private BaseViewModel _currentViewModel;
        public BaseViewModel CurrentViewModel { get=>_currentViewModel; 
            set {
                _currentViewModel = value;
                OnCurrentViewModelChanged();
            } 
        }

        private void OnCurrentViewModelChanged()
        {
            CurrentViewModelChanged?.Invoke();
        }
    }
}
