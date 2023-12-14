using EventCommands.Models;
using EventCommands.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EventCommands.Commands
{
    public class LoadToDoItemsCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;
        private readonly TodoListViewModel _todoListViewModel;

        public LoadToDoItemsCommand(TodoListViewModel todoListViewModel)
        {
            _todoListViewModel = todoListViewModel;
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public async void Execute(object? parameter)
        {
            IEnumerable<TodoItem> todoItems = await GetTodoItemsAsync();

            _todoListViewModel.TodoItems = new ObservableCollection<TodoItem>(todoItems);
        }
        private async Task<IEnumerable<TodoItem>> GetTodoItemsAsync()
        {
            return await Task.FromResult(new[]
            {
                new TodoItem()
                {
                    Description = "Walk the dog.",
                    IsCompleted = false,
                    OwnerName = "Jonh"
                },
                new TodoItem()
                {
                    Description = "Take out the trash.",
                    IsCompleted = false,
                    OwnerName = "Mary"
                },
                new TodoItem()
                {
                    Description = "Upload YouTube video.",
                    IsCompleted = true,
                    OwnerName = "SingletonSean"
                },
            });
        }
    }
}
