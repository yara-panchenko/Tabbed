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
    public partial class Oktoober : ContentPage
    {
        public Oktoober()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Hõimupäev", "Hõimupäevad – meie pikim traditsioon. Hõimupäevad on kõige olulisem soome - ugri rahvaid tutvustav ja koostööd edendav avalikkusele suunatud üritustesari.Kaunis tava rääkida oktoobrikuu kolmandal nädalal hõimurahvastest ja nende kultuuridest sai alguse juba 1931.aastal, kuid katkes nõukogude ajal. 1988.aastal traditsioon taaselustati ning märtsis 2011 võttis Riigikogu üksmeelselt vastu otsus tähistada hõimupäeva oktoobrikuu kolmandal laupäeval riikliku tähtpäevana, mil heisatakse riigilipud.Hõimupäeva tähistavad ka Soome, Ungari ja mõned Vene Föderatsioonis paiknevad hõimurahvad.","Back");
        }
    }
}