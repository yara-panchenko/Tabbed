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
    public partial class Juuni : ContentPage
    {
        public Juuni()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Eesti lipu päev", "Eesti lipu päev on Eesti Vabariigi riiklik tähtpäev, 4. juuni. See päev märgib Eesti lipu emalipu õnnistamist Otepääl Eesti Üliõpilaste Seltsi lipuna 23. mail 1884 (uue kalendri järgi 4. juunil).Eesti lipu päeva seadis Riigikogu sisse 14.aprillil 2004. 63 poolthäälega võeti vastu Isamaaliidu fraktsiooni ja Riigikogu liikme Tiit Matsulevitši poolt 19.jaanuaril 2004 algatatud pühade ja tähtpäevade seaduse muutmise seadus.Esimest korda tähistati Eesti lipu päeva 2004.aastal, sinimustvalge lipu pühitsemise 120.aastapäeval","Back");
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            DisplayAlert("Leinapäev", "Leinapäev on mälestuspäev, mil inimene või grupp inimesi mälestab, meenutab ja leinab traagilises sündmuses osaks saanud inimest või inimesi.Eestis on leinapäevaks 14.juuni, mil mälestatakse 1941.aasta 14.juuni küüditamise ohvreid, 1949.aasta 25.märtsi ohvreid, Nõukogude lennuväe terrorirünnakutes hukkunud tsiviilelanikke, Läände põgenemisel hukkunuid, arreteeritutena maha lastuid või laagrites hukkunuid, võitluses Eesti eest langenuid, Teise maailmasõja ajal ja pärast sõda hukkunuid.", "Back");
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            DisplayAlert("Võidupühale eelnev päev", "Võidupühale eelnev päev", "Back");
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            DisplayAlert("Võidupüha", "Võidupüha on Eesti riigipüha, mida peetakse 23. juunil alates aastast 1934. Sellega tähistatakse Eesti võitu Võnnu lahingus Landesveeri üle 23. juunil 1919 ja see on ka eestlaste kõigi aegade võitude ja võitluste mälestuspäev, meenutamaks Lembitu päevil alanud lakkamatut võitlust eesti rahva olemasolu ja poliitilise vabaduse eest. (Eesti Vabariigi valitsuse otsusest 1934).Võidupüha on eraisikutele kohustuslik lipuheiskamise päev.Võidupüha tähistamine on tseremoniaalselt seotud jaanipäeva tähistamisega 24.juunil.", "Back");
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            DisplayAlert("Jaanipäev", "Jaanipäev on Eestis 24. juunil tähistatav püha. 24. juunile eelnevat 23. juuni päeva nimetatakse jaanilaupäevaks ja nendevahelist ööd jaaniööks, seda tähistatakse Eestis, Lätis ja põhjamaades jaanituledega.Jaanipäeva nimetus pärineb kirikukalendrist, kirikus tähistatakse sel päeval Ristija Johannese sünnipäeva.Eesti Vabariigis on jaanilaupäev ja jaanipäev riigipühad; jaanilaupäeval peetakse Eestis võidupüha, mis tähistab Eesti vägede võitu Vabadussõjas Võnnu lahingus 23.juunil 1919 Landeswehri üle.", "Back");
        }
    }
}