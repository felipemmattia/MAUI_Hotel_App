using MauiAppHotel.Views;

namespace MauiAppHotel;

public partial class Inicio : ContentPage
{
    public Inicio()
    {
        InitializeComponent();
    }
    private void OnIniciarClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ContratacaoHospedagem());
    }
    private void OnSobreClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Sobre());
    }
}