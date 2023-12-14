using EventCommands.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCommands.ViewModels
{
    public class MainViewModel : ObservableObject
    {
        private TodoListViewModel _todoListViewModel;

        public MainViewModel()
        {
            _todoListViewModel = new TodoListViewModel();
        }

        public TodoListViewModel TodoListViewModel
        {
            get { return _todoListViewModel; }
            set
            {
                _todoListViewModel = value;
                OnPropertyChanged(nameof(TodoListViewModel));
            }
        }
    }
}
