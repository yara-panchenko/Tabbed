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
    public partial class Mai : ContentPage
    {
        public Mai()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Kevadpüha", "Kevadpüha on Eesti riigipüha, mida peetakse 1. mail. Pühaga tähistatakse kevade saabumist.1.mai kui kevadpüha kattub nii rahvusvahelise töörahvapühaga kui ka Eesti rahvakalendri volbripäevaga.","Back");
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            DisplayAlert("Emadepäev", "Emadepäev on Eestis mai teisel pühapäeval. Emadepäeva tähistati maailmas esimest korda 10. mail 1908 Ameerika Ühendriikides Lääne-Virginias Graftoni kirikus.Eestis tähistati seda päeva esimest korda 1922.aastal Uderna koolis piduliku koosviibimisega, mille organiseeris Naiste Karskusliit Helmi Mäelo algatusel.Üle - eestilisena tähistati seda päeva aasta hiljem, 3.juunil 1923.Emadepäeva tähistamine kogus populaarsust ja seda tähistati kuni 1940.aastani.Uuesti hakati Eestis emadepäeva tähistama 1988.aastal.", "Back");
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            DisplayAlert("Nelipühade 1. püha", "Nelipühad (kiriklikus kasutuses ka nelipüha, nelipühi, Kolmainu püha; kreekakeelne nimetus Πεντηκοστή Pentēkostē, 'viiekümnes [päev]'; kirikuslaavikeelne nimetus Пятидесятница Pjatidesjatnitsa, 'viiekümnes [päev]') on kristlik püha, millega mälestatakse Püha Vaimu laskumist apostlitele 50. päeval pärast Jeesuse Kristuse ülestõusmist. Ajaliselt on see 10 päeva pärast taevaminemispüha. See on kiriku sünnipäev.", "Back");
        }
    }
}