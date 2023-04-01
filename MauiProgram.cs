using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific;
using Application = Microsoft.Maui.Controls.Application;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Hosting;


namespace PontoProf
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureMauiHandlers(handlers =>
                {
                    //handlers.AddHandler<Button, WpfButtonHandler>();
                    //handlers.AddHandler<TextBox, WpfTextBoxHandler>();
                });

            return builder.Build();
        }
    }

}
