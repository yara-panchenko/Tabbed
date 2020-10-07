using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tabbed
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            Start_screen();
            InitializeComponent();
            
        }
        public async void Start_screen()
        {
            string result = await DisplayPromptAsync("Message", "Sisestage avatava kuu");
            if (result == "Jaanuar")
            {
                
            }
            else if(result=="Veebruar")
            {
                
            }
            else if (result == "Marts")
            {

            }
            else if (result == "Aprill")
            {

            }
            else if (result == "Mai")
            {

            }
            else if (result == "Juuni")
            {

            }
            else if (result == "Juuli")
            {

            }
            else if (result == "August")
            {

            }
            else if (result == "September")
            {

            }
            else if (result == "Oktoober")
            {

            }
            else if (result == "November")
            {

            }
            else if (result == "Detsember")
            {

            }
        }
    }
}
