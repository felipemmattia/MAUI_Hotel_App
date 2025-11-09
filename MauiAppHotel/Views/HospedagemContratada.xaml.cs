namespace MauiAppHotel.Views;

public partial class HospedagemContratada : ContentPage
{
	public HospedagemContratada()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Navigation.PopAsync();
    }

    private void Btn_reserva_clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Agradecimento());
    }
}