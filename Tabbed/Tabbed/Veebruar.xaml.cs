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
    public partial class Veebruar : ContentPage
    {
        public Veebruar()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Tartu rahu", "Tartu rahuleping on 2. veebruaril 1920 Eesti Vabariigi ja Nõukogude Venemaa vahel Tartus sõlmitud rahvusvaheline leping, millega lõpetati Vabadussõda, määrati Eesti idapiir ning Nõukogude Venemaa tunnustas Eesti Vabariigi iseseisvust.", "Back");
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            DisplayAlert("Eesti Vabariigi aastapäevale eelnev päev", "Eesti Vabariigi aastapäev on 24. veebruaril, millega tähistatakse Eesti Vabariigi väljakuulutamist 1918. aasta 24. veebruaril. Sel päeval avaldati Tallinnas Manifest kõigile Eestimaa rahvastele, milles kuulutati välja sõltumatu ja demokraatlik Eesti Vabariik. 24. veebruar on Eesti rahvuspüha ja iseseisvuspäev.", "Back");
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            DisplayAlert("Iseseisvuspäev, Eesti Vabariigi aastapäev", "Iseseisvuspäev on iseseisvuse väljakuulutamise või muu iseseisvumisega seotud sündmuse aastapäev. Enamikus riikides tähistatakse seda päeva rahvuspühana.", "Back");
        }
    }
}