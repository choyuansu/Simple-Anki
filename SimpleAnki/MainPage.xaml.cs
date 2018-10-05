using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   
using Xamarin.Forms;

namespace SimpleAnki
{
    public partial class MainPage : ContentPage
    {
        private int count = 0;

        public MainPage()
        {
            InitializeComponent();
            label.Text = "0";
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            // Delegate command is another way
            count++;
            label.Text = count.ToString();
        }
    }
}
