using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Xen_Browser.Models
{
    public class WebViewModel : ViewModel
    {
        public WebViewModel()
        {
            loadurl_command = new Command(loadurl);

        }

        public Command loadurl_command { get; }

        public string URL;
        public string url_bind
        {
            get => URL;
            set
            {
                URL = value;
                OnPropertyChanged();
            }
        }

        void loadurl()
        {
            OnPropertyChanged(nameof(url_bind));
        }

    }
}
