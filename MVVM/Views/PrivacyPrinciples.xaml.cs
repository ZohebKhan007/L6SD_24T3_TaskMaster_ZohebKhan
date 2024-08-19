using Tasker.Services;

namespace Tasker.MVVM.Views;

public partial class PrivacyPrinciples : ContentPage
{
    private readonly DatabaseService _databaseService;
    public PrivacyPrinciples(DatabaseService databaseService)
    {
        InitializeComponent();
        _databaseService = databaseService;
    }

    private async void OnAcceptClicked(object sender, EventArgs e)
    {
        // Set the accepted flag in preferences
        //Preferences.Set("PrivacyPrinciplesAccepted", true);

        // Directed to the Landing Page
        await Navigation.PushAsync(new LandingPage(_databaseService));

        // Removal of this page from the navigaton stack
        //Navigation.RemovePage(this);
    }

    private void OnDeclineClicked(object sender, EventArgs e)
    {
        // Exit the app if the user declines the privacy principles
        // System.Diagnostics.Process.GetCurrentProcess().CloseMainWindow();
#if ANDROID
        Android.OS.Process.KillProcess(Android.OS.Process.MyPid());
#endif
    }
}