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
    public partial class Detsember : ContentPage
    {
        public Detsember()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Jõululaupäevale eelnev päev", "Jõululaupäevale eelnev päev", "Back");
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            DisplayAlert("Jõululaupäev", "Jõululaupäev (ka: jõuluõhtu) on 24. detsember, päev enne esimest jõulupüha. Eestis on see päev riigipüha.Juliuse kalendri järgi, mida kasutab teiste seas Vene Õigeusu Kirik, langeb see päev praegu(aastatel 1900–2099) 6.jaanuarile.", "Back");
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            DisplayAlert("Esimene jõulupüha", "esimene ja teine jõulupüha (25. ja 26. detsember) riigipühad ja puhkepäevad, alates 2005. aastast ka jõululaupäev.", "Back");
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            DisplayAlert("Teine jõulupüha", "Esimene ja teine jõulupüha (25. ja 26. detsember) riigipühad ja puhkepäevad, alates 2005. aastast ka jõululaupäev.", "Back");
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            DisplayAlert("Uuele aastale eelnev päev", "Uuele aastale eelnev päev", "Back");
        }
    }
}