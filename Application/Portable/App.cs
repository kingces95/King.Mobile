using King.Mobile.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace MyApplication {
    public class App {
        public static Page GetMainPage() {

            // "/Users/chrisking/Library/Developer/CoreSimulator/Devices/4911405A-B90D-4FAC-9A75-08582715E45C/
            //data/Applications/DD76311C-15EC-4E59-9AC2-E0A71EFD8CED/ApplicationiOS.app/King.Mobile.Controls.Platform.dll"


            //var type = typeof(DropShadowButtonRenderer);
            var assemblyName = ", King.Mobile.Controls.Platform, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null";
            var dropShadowButtonRenderer = "King.Mobile.Controls.Platform.DropShadowButtonRenderer" + assemblyName;
            var dropShadowButtonRendererType = Type.GetType(dropShadowButtonRenderer);

            var header = "King.Mobile.Controls.Platform.Header2" + assemblyName;
            var headerType = Type.GetType(header);

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
