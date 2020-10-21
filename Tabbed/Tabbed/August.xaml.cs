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
    public partial class August : ContentPage
    {
        public August()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Taasiseseisvumispäev", "Taasiseseisvumispäev (ka iseseisvuse taastamise päev) on Eesti Vabariigi riigipüha, millega igal aastal 20. augustil tähistatakse Eesti Vabariigi de facto taastamist Eesti Vabariigi Ülemnõukogu otsusega Eesti riiklikust iseseisvusest, mis võeti Eesti Komiteega kooskõlastatult vastu Eesti Vabariigi Ülemnõukogu istungil 20. augustil 1991 kell 23.03.", "Back");
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            DisplayAlert("Kommunismi ja natsismi ohvrite mälestuspäev", "Kommunismi ja natsismi ohvrite mälestuspäev (paljudes Euroopa riikides tuntud kui stalinismi ja natsismi ohvrite mälestuspäev), ka musta lindi päev, on Euroopa Liidus 23. augustil tähistatav rahvusvaheline kommunismi ja natsismi ohvrite mälestamise päev.[1]Algatus stalinismi ja natsismi ohvrite mälestuspäeva üle - euroopaliseks tähistamiseks tehti 2008.aastal Euroopa Parlamendis.[2] Lõplik otsus võeti Euroopa Parlamendis vastu 2.aprillil 2009.Otsuse poolt oli 533 saadikut, 44 oli vastu ja 33 erapooletud.21.mail 2009 kiitis Eesti valitsus heaks seaduseelnõu, mis kuulutas 23.augusti stalinismi ja natsismi kuritegude ohvrite mälestuspäevaks.[3] Pühade ja tähtpäevade seaduses kannab see kommunismi ja natsismi ohvrite mälestuspäeva nime.[4]", "Back");
        }
    }
}