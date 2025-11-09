namespace MauiAppHotel;

public partial class Sobre : ContentPage
{
	public Sobre()
	{
		InitializeComponent();
	}
<<<<<<< HEAD
    private void OnVoltarInicioClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Inicio());
    }
}
=======

	private async void btBack_clicked(object sender, EventArgs e)
	{
		await Navigation.PopAsync();
	}
}
>>>>>>> 8654fe5ff262433f08b9cc596d495a9d3d41769d
