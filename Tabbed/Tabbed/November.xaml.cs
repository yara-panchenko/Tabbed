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
    public partial class November : ContentPage
    {
        public November()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Hingedepäe", "Katoliiklikus kirikukalendris kehtestati 1006. aastal 2. november hingedepäeva ehk usklike surnute mälestuspäevana.Eestlastel jääb hingedepäev hingedeaja sisse.Hingedepäeva on nimetatud juba 14.sajandi allikates, kuid selle(nagu ka 1.novembri ehk pühakutepäeva) tähistamine on jäänud omauskumustele tugineva hingedeaja varju.1990.aastatel levis tava süüdata hingedepäeval koduakendel ja kalmistul sugulaste haudadel lahkunute mälestuseks küünlad.", "Back");
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            DisplayAlert("Isadepäev", "Isadepäev on tähtpäev, millega märgitakse meeste rolli laste kasvatamisel ning avaldatakse tänu isadele ja vanaisadele. Eestis peetakse isadepäeva iga novembrikuu teisel pühapäeval.Alates 1998.aastast annab Eesti Naisliit välja aasta isa tiitlit.", "Back");
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            DisplayAlert("Taassünni päev", "Taassünni päev on riiklik tähtpäev, mida tähistatakse 16. novembril.16.novembril 1988 võttis Eesti NSV Ülemnõukogu vastu deklaratsiooni Eesti NSV suveräänsusest.Ühtlasi võttis Eesti NSV Ülemnõukogu vastu sellekohase põhiseaduse muudatuse Eesti NSV õigusaktide ülimuslikkusest NSV Liidu seaduste suhtes.[1]NSV Liidu Ülemnõukogu tunnistas mõlemad mittevastavaks NSV Liidu konstitutsiooni ja NSV Liidu seadustega.[2]Taassünni päev ei ole lipupäev.", "Back");
        }
    }
}