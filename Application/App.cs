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

            var foo = typeof(King.Mobile.Controls.Platform.KingLabelRenderer);

            return new ContentPage {
                //Content = new Label() { Text = "Hello World!!" }
                //Content = new KingLabel()
                Content = new DropShadowButton {
                    Text = "Hello, Forms !",
                    VerticalOptions = LayoutOptions.CenterAndExpand,
                    HorizontalOptions = LayoutOptions.CenterAndExpand,
                },
            };
        }
    }

}
///Library/Developer/CoreSimulator/Devices/5B71B7AC-2ACD-492E-81BA-7D007FEB3AD4/
///data/Containers/Bundle/Application/2B82A128-8E37-47C1-A004-70F3BE123AE3/ShimiOS.app/King.Mobile.Controls.Platform.dll
