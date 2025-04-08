using dotnet_tack.Data;
using dotnet_tack.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace dotnet_tack
{
    public partial class MainPage : ContentPage
    {
        public AppDbContext _dbContext;



        public MainPage(AppDbContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
            
        }

        private async void OnAddTaskClicked(object sender, EventArgs e)
        {
            var newTask = new dotnet_tack.Models.Task
            {
                Title = "Learn MySQL with EF Core",
                Status = Avancement.EnCours,
            };

            _dbContext.Tasks.Add(newTask);
            await _dbContext.SaveChangesAsync();
            await DisplayAlert("Success", "Task added to MySQL database!", "OK");
        }

    }
}
