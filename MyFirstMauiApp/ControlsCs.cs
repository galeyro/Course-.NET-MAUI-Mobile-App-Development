namespace MyFirstMauiApp;

public class ControlsCs : ContentPage
{
    int count = 0;
    Label lblCounter;
    public ControlsCs()
    {
        var scrollView = new ScrollView();
        var stackLayout = new StackLayout();
        scrollView.Content = stackLayout;

        lblCounter = new Label
        {
            Text = "Click the button",
            FontSize = 22,
            FontAttributes = FontAttributes.Italic,
            HorizontalOptions = LayoutOptions.Center,
        };
        stackLayout.Children.Add(lblCounter);

        var btnCounter = new Button
        {
            Text = "Click me",
            HorizontalOptions = LayoutOptions.Center,
        };
        stackLayout.Children.Add(btnCounter);
        btnCounter.Clicked += OnCounterClicked;

        this.Content = scrollView;
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;
        lblCounter.Text = $"Clicked count: {count}";
    }
    
}