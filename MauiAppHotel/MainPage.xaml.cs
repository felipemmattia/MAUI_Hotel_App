<<<<<<< HEAD
﻿namespace MauiAppHotel
=======
﻿using System.Threading.Tasks;

namespace MauiAppHotel
>>>>>>> 8654fe5ff262433f08b9cc596d495a9d3d41769d
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
