namespace EvoLift.App;

public partial class StartupPage : ContentPage
{
    private readonly AppStartup _startup;
    private readonly IServiceProvider _services;
    private bool _started;

    public StartupPage(
        AppStartup startup,
        IServiceProvider services)
    {
        InitializeComponent();
        _startup = startup;
        _services = services;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        if (_started)
            return;

        _started = true;

        try
        {
            await _startup.InitializeAsync();

            var shell = _services.GetRequiredService<AppShell>();

            Application.Current!.Windows[0].Page = shell;
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine(ex);

            await DisplayAlert(
                "Startup failed",
                "The database could not be initialized. " +
                "Your data has not intentionally been deleted. " +
                "Please retry or recover your backup.",
                "OK");

            _started = false;
        }
    }
}
