using System;
using Tasker.Services;
using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;
using Tasker.MVVM.Models;

namespace Tasker.MVVM.Views;

public partial class LandingPage : ContentPage
{
    private readonly DatabaseService _databaseService;
    public LandingPage(DatabaseService databaseService)
    {
        InitializeComponent();
        _databaseService = databaseService;
    }

    private async void ViewPlansButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainView(_databaseService));
    }

    private async void CreateNewPlanButton_Clicked(object sender, EventArgs e)
    {
        //await Navigation.PushAsync(new NewTaskView(_databaseService, new ObservableCollection<Category>(), new ObservableCollection<MyTask>()));
    }
}