namespace GuevaraGLayoutsMAUI.Views;

public partial class GridLayout : ContentPage
{
	public GridLayout()
	{
		InitializeComponent();
	}

    private void ButtonIrAStackLayout_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new StackLayout());
    }
}