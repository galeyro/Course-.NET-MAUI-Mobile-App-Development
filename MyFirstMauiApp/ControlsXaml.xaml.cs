namespace MyFirstMauiApp;

public partial class ControlsXaml : ContentPage
{
    private int count = 0;
    
    public ControlsXaml()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;
        lblCounter.Text = $"Clicked count: {count}";
    }
}