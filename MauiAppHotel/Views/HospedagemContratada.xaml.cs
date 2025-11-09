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
<<<<<<< HEAD

    private void Btn_reserva_clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Agradecimento());
    }
=======
>>>>>>> 8654fe5ff262433f08b9cc596d495a9d3d41769d
}