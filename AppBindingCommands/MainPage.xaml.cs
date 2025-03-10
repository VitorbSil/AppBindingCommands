namespace AppBindingCommands
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }


        private void btnAtualizarInformacoes_Clicked(object sender, EventArgs e)
        {
            string informacoes = string.Empty;

            if (Preferences.ContainsKey("acaoInicial"))
            {
                informacoes += Preferences.Get("acaoInicial", string.Empty);
            }
            if (Preferences.ContainsKey("acaoStart"))
            {
                informacoes += Preferences.Get("acaoStart", string.Empty);
            }
            if (Preferences.ContainsKey("acaoSleep"))
            {
                informacoes += Preferences.Get("acaoSleep", string.Empty);
            }
            if (Preferences.ContainsKey("acaoResume"))
            {
                informacoes += Preferences.Get("acaoResume", string.Empty);
            }


        }
    }

}
