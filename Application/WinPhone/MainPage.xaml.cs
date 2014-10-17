using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

using Xamarin.Forms;
using King.Mobile.Controls;
using King.Mobile.Controls.WinPhone;

// Must include reference
[assembly: KingMobileControlsReference]

namespace CustomControlLibrary.WinPhone {
    public partial class MainPage : PhoneApplicationPage {
        
        public MainPage() {
            InitializeComponent();

            Forms.Init();
            Content = CustomControlLibrary.App.GetMainPage().ConvertPageToUIElement(this);
        }
    }
}
