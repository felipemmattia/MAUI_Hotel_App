namespace MauiAppHotel;

public partial class Sobre : ContentPage
{
	public Sobre()
	{
		InitializeComponent();
	}
    private void OnVoltarInicioClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Inicio());
    }
}