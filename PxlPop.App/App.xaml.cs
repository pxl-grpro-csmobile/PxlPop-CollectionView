
namespace PxlPop.App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            this.UserAppTheme = AppTheme.Light;
            return new Window(new AppShell());
        }
    }
}
