namespace MauiAppHotel;

public partial class Sobre : ContentPage
{
	public Sobre()
	{
		InitializeComponent();
	}

	private async void btBack_clicked(object sender, EventArgs e)
	{
		await Navigation.PopAsync();
	}
}
