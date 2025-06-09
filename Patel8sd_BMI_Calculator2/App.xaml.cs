namespace Patel8sd_BMICalculator2;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        // The main page is now the AppShell itself.
        MainPage = new AppShell();
    }
}