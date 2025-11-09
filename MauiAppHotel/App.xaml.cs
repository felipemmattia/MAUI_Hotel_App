using MauiAppHotel.Models;

namespace MauiAppHotel
{
    public partial class App : Application
    {
        public List<Quarto> lista_quartos = new List<Quarto>
        {
            new Quarto()
            {
                Descricao = "Suíte Super Luxo",
                ValorDiariaAdulto = 110.0,
                ValorDiariaCrianca = 55.0
            },
            new Quarto()
            {
                Descricao = "Suíte Luxo",
                ValorDiariaAdulto = 80.0,
                ValorDiariaCrianca = 40.0
            },
            new Quarto()
            {
                Descricao = "Suíte Single",
                ValorDiariaAdulto = 50,
                ValorDiariaCrianca = 25
            },
            new Quarto()
            {
                Descricao = "Suíte Crise",
                ValorDiariaAdulto = 25,
                ValorDiariaCrianca = 12.5
            }
        };

        public App()
        {
            InitializeComponent();

<<<<<<< HEAD
            MainPage = new NavigationPage(new Inicio());
=======
            MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
>>>>>>> 8654fe5ff262433f08b9cc596d495a9d3d41769d
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
<<<<<<< HEAD
            window.Height = 600;
=======
            window.Height = 650;
>>>>>>> 8654fe5ff262433f08b9cc596d495a9d3d41769d

            return window;
        }
    }
}
