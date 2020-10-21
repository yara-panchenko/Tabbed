using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Markup;
using Xamarin.Forms.Xaml;

namespace Tabbed
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Jaanuar : ContentPage
    {
        public Jaanuar()
        {
            InitializeComponent();
        }
        
        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Uusaasta", "Uusaasta on püha, mil tähistatakse uue kalendriaasta algust. Lääneriikides, kus kasutatakse Gregoriuse kalendrit, on uusaasta 1.jaanuaril.Eestis on 1.jaanuari kui uusaastat nimetatud ka nääripäevaks.Eesti Vabariigis on 1.jaanuaril tähistatav uusaasta riigipüha, sellele eelnev tööpäev on töölepingu seaduse alusel 3 tunni võrra lühendatud.", "Back" );
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            DisplayAlert("Kolmekuningupäev", "Kolmekuningapäev on 6. jaanuaril ja kirikukalendris on see päev, kui kolm Hommikumaa tarka leidsid Jeesuslapse. Eesti rahvakalendris tähistas see jõuluaja lõppu, olles ühtlasi jõuluaja viimane püha.", "Back");
        }
    }
}