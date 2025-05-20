namespace GuevaraGLayoutsMAUI.Views;

public partial class FlexLayout : ContentPage
{
	public FlexLayout()
	{
		InitializeComponent();
	}

    private void ButtonRegresar_Clicked(object sender, EventArgs e)
    {
		Navigation.PopAsync();
    }
}