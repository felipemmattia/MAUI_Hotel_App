
namespace MauiAppHotel;

public partial class Agradecimento : ContentPage
{
	public Agradecimento()
	{
        InitializeComponent();
    }
    private void OnVoltarInicioClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Inicio());
    }
    private void OnSobreClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Sobre());
    }

}