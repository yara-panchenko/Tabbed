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
                CurrentPage = Children[0];
            }
            else if(result=="Veebruar")
            {
                CurrentPage = Children[1];
            }
            else if (result == "Marts")
            {
                CurrentPage = Children[2];
            }
            else if (result == "Aprill")
            {
                CurrentPage = Children[3];
            }
            else if (result == "Mai")
            {
                CurrentPage = Children[4];
            }
            else if (result == "Juuni")
            {
                CurrentPage = Children[5];
            }
            else if (result == "Juuli")
            {
                CurrentPage = Children[6];
            }
            else if (result == "August")
            {
                CurrentPage = Children[7];
            }
            else if (result == "September")
            {
                CurrentPage = Children[8];
            }
            else if (result == "Oktoober")
            {
                CurrentPage = Children[9];
            }
            else if (result == "November")
            {
                CurrentPage = Children[10];
            }
            else if (result == "Detsember")
            {
                CurrentPage = Children[11];
            }
        }
    }
}
