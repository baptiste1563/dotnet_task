using CommunityToolkit.Mvvm.ComponentModel;
using DotnetTask.Models;
using DotnetTask.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace DotnetTask.ViewModels
{
    public partial class MainPageViewModel : ObservableObject
    {
        private readonly TaskDbContext _context;

        [ObservableProperty]
        ObservableCollection<TaskItem> tasks;

        public MainPageViewModel(TaskDbContext context)
        {
            _context = context;
            LoadTasks();
        }

        private async void LoadTasks()
        {
            var list = await _context.Tasks.Include(t => t.Auteur).ToListAsync();
            tasks = new ObservableCollection<TaskItem>(list);
        }
    }
}