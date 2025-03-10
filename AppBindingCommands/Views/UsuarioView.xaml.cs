using AppBindingCommands.ViewModel;

namespace AppBindingCommands.Views;

public partial class UsuarioView : ContentPage
{
	private UsuarioViewModel viewModel;
	public UsuarioView()
	{
		InitializeComponent();
		viewModel = new UsuarioViewModel();
		BindingContext = viewModel;
	}
}