using PracticaPrueba2API.View;

namespace PracticaPrueba2API
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void GoChistes_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Chiste());   
        }

        private void GoAbout_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new About());
        }
    }

}
