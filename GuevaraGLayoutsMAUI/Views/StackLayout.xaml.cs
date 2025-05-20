namespace GuevaraGLayoutsMAUI.Views;

public partial class StackLayout : ContentPage
{
	public StackLayout()
	{
		InitializeComponent();
	}

    private void ButtonIrAFlex_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new FlexLayout());
    }
}