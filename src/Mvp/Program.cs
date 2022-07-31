using Microsoft.Extensions.Configuration;
using Mvp.Models.Repositories;
using Mvp.Models.Repositories.Contracts;
using Mvp.Presenters;
using Mvp.Views;
using System.Reflection;

namespace Mvp;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        IConfigurationRoot configuration = new ConfigurationBuilder()
            .AddUserSecrets(Assembly.GetAssembly(typeof(Program)))
            .Build();

        IMainView view = new MainView();

        new MainPresenter(configuration.GetConnectionString("DefaultConnection"), view);

        Application.Run((Form)view);
    }    
}