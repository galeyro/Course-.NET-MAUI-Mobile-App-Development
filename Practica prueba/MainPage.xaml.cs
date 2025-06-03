using System.Threading.Tasks;

namespace Practica_prueba
{
    public partial class MainPage : ContentPage
    {
        private string valorRecargaSeleccionado = "--";
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnRecargaSeleccionada(object sender, EventArgs e)
        {
            var radio = sender as RadioButton;
            if (radio.IsChecked)
            {
                valorRecargaSeleccionado = radio.Value.ToString();
                mensajeRecargaLabel.Text = $"Ha seleccionado una recarga de: {valorRecargaSeleccionado} dólares";
            }
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            bool confirmacion = await DisplayAlert(
                "Confirmacion",
                $"Desea recargar {valorRecargaSeleccionado} dolares?",
                "Si",
                "No"
                );

            if (confirmacion)
            {
                await DisplayAlert("Finalizado",
                    "Recarga exitosa",
                    "OK");
            }
        }
    }

}
