using Tasker.MVVM.Views;

namespace Tasker
{
    public partial class App : Application
    {
        public App(IServiceProvider serviceProvider)
        {
            InitializeComponent();

            MainPage = new NavigationPage(serviceProvider.GetRequiredService<PrivacyPrinciples>());

            //// Check if the privacy principles have been accepted
            //bool Accepted = Preferences.Get("PrivacyPrinciplesAccepted", false);

            //if (Accepted)
            //{
            //    // Navigate to the Landing Page if accepted
            //    MainPage = new NavigationPage(serviceProvider.GetRequiredService<LandingPage>());
            //}
            //else
            //{
            //    // Navigate to the Privacy Principles Page if declined
            //    MainPage = new NavigationPage(serviceProvider.GetRequiredService<PrivacyPrinciples>());
            //}
        }
    }
}