using Microsoft.Maui.Storage;

namespace AppBindingCommands;




public partial class App : Application
{
    public App()
    {

        InitializeComponent();

        DateTime data = DateTime.Now;
        Preferences.Set("dtAtual", data);
        Preferences.Set("acaoInicial", string.Format("*App executado às {0}.\n", data));
        
        MainPage = new AppShell();
    }

    protected override void OnStart()
    {
        base.OnStart();
        Preferences.Set("acaoStart", string.Format("*App iniciado às {0}. \n", DateTime.Now));
    }

    protected override void OnSleep()
    {
        base.OnSleep();
        Preferences.Set("acaoSleep", string.Format("*App em segundo plano às {0}. \n", DateTime.Now));
    }

    protected override void OnResume()
    {
        base.OnResume();
        Preferences.Set("acaoResume", string.Format("*App reativado às {0}. \n", DateTime.Now));
    }
}
