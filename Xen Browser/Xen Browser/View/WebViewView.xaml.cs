using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xen_Browser.Models;

namespace Xen_Browser
{
    public partial class MainPage : ContentPage
    {
        public string URL;

        public MainPage()
        {
            InitializeComponent();
            webview.Source = "https://www.google.com";

            BindingContext = this;
        }

        public string webview_bind
        {
            set
            {
                input_url.Text = value;
            }
        }


        private void input_url_Focused(object sender, FocusEventArgs e)
        {
            URL = input_url.Text;
        }

        private void load_btn_Clicked(object sender, EventArgs e)
        {
            webview.Source = input_url.Text;
            URL = input_url.Text;

        }

        private void webview_Navigated(object sender, WebNavigatedEventArgs e)
        {
            URL = e.Url;
            input_url.Text = e.Url;

        }

        private void webview_Navigating(object sender, WebNavigatingEventArgs e)
        {
            URL = e.Url;
            input_url.Text = e.Url;

        }


        protected override bool OnBackButtonPressed()
        {
            if (webview.CanGoBack)
            {
                webview.GoBack();

            }
            else
            {
                System.Environment.Exit(0);
            }

            return true;

        }
    }
}
