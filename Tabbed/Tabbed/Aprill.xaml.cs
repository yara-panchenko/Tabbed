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
    public partial class Aprill : ContentPage
    {
        public Aprill()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Suur reede", "Suur reede on kristlik püha, mil tähistatakse Jeesus Kristuse ristilöömist ja surma Kolgata mäel. See kuulub kokku rea teiste pühadega, mis seostuvad Jeesuse eluga. Suur reede eelneb ülestõusmispühadele ning võib langeda kokku juudiusu paasapühadega.", "Back");
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            DisplayAlert("Ülestõusmispühade 1. püha", "Ülestõusmispühad ehk lihavõttepühad ehk lihavõtted ehk paasapühad, argikeeles ka munadepühad[1] on kristluses liikuvad pühad, mis algavad esimesel täiskuu pühapäeval pärast kevadist pööripäeva. Pühad mälestavad Jeesus Kristuse surnuist ülestõusmist pärast ristilöömist. Samale ajale jääb ka maausuliste kiigepüha ehk munapüha.", "Back");
        }
    }
}