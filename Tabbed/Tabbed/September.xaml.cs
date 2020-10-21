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
    public partial class September : ContentPage
    {
        public September()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Vanavanemate päev", "Vanavanemate päev on eesti riiklik tähtpäev, mida tähistatakse septembri teisel pühapäeval.21.jaanuaril 2010 võttis Riigikogu 81 poolthäälega vastu otsuse lisada vanavanemate päev riiklike tähtpäevade hulka[1][2].Vanavanemate päeva tähistatakse septembrikuu teisel pühapäeval ja eelnõu algataja valis selle päeva põhjusel, et ka emade - ja isadepäeva tähistatakse just kuu teisel pühapäeval.Seadusemuudatus sai teoks kodanikualgatuse korras ja eelnõu Pühade ja tähtpäevade seaduse muutmiseks esitas Erakond Eestimaa Rohelised fraktsioonile Kanal 2 reporter Heiki Valner[3].","Back");
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            DisplayAlert("Vastupanuvõitluse päev", "Vastupanuvõitluse päev, ka Otto Tiefi valitsuse päev, on riiklik tähtpäev, mida tähistatakse 22.septembril.Ettepaneku 22.septembri tähistamiseks riikliku tähtpäevana algatasid 2005.aastal Isamaaliit ja Res Publica.[1] Eelnõude esitamise käigus Riigikogule sai algsest Otto Tiefi valitsuse mälestuspäevast Vastupanuvõitluse päev.[2] Päeva tähistati esimest korda ametlikult 2007.aastal.22.septembrit ei valitud vastupanuvõitluse päevaks juhuslikult.Sellel päeval mälestatakse neid inimesi, kes kahe okupatsiooni vahelisel ajal interregnumit ära kasutades püüdsid taastada Eesti riiklikku iseseisvust.", "Back");
        }
    }
}