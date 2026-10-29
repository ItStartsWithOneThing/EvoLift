using Microsoft.Extensions.DependencyInjection;

namespace EvoLift.App
{
    public partial class Application : Microsoft.Maui.Controls.Application
    {
        private readonly IServiceProvider _services;

        public Application(IServiceProvider services)
        {
            _services = services;
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(_services.GetRequiredService<StartupPage>());
        }
    }
}