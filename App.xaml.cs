using Microsoft.Extensions.DependencyInjection;

namespace Ejercicio09Grid_3196382
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new EjemploGrid();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}