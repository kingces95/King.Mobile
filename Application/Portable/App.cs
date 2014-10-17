using King.Mobile.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace CustomControlLibrary {
    public class App {
        public static Page GetMainPage() {
            return new ContentPage {
                Content = new DropShadowButton {
                    Text = "Hello, Forms !",
                    VerticalOptions = LayoutOptions.CenterAndExpand,
                    HorizontalOptions = LayoutOptions.CenterAndExpand,
                },
            };
        }
    }

}
