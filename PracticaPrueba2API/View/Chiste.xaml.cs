namespace PracticaPrueba2API.View;
using PracticaPrueba2API.Repositories;

public partial class Chiste : ContentPage
{
	private readonly ChisteRepository _chistesRepository;
	public Chiste()
	{
		InitializeComponent();
		_chistesRepository = new ChisteRepository();
		CargarChiste();
	}

	private async void CargarChiste()
	{
		try
		{
			var chiste = await _chistesRepository.GetChisteAsync();
			ChisteLabel.Text = chiste;
		}  catch (Exception ex)
		{
			ChisteLabel.Text = $"Error al cargar el chiste: {ex.Message}";
		}
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		CargarChiste();
    }
}