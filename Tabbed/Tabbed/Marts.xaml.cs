using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tabbed
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Marts : ContentPage
    {
        public Marts()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Emakeelepäev", "Emakeelepäev on riiklik tähtpäev, mida tähistatakse 1996. aastast luuletaja Kristjan Jaak Petersoni sünniaastapäeval, 14. märtsil.[1] Emakeelepäeva jaoks valiti Kristjan Jaak Petersoni sünnipäev, kuna Peterson oli üks esimesi eestikeelseid kirjanikke. ","Back");
        }
    }
}