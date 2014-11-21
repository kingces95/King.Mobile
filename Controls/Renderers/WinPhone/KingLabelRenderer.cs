using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Xamarin.Forms.Platform.WinPhone;

namespace King.Mobile.Controls.Platform {
    public sealed class KingLabelRenderer : ViewRenderer<KingLabel, TextBlock> {
        protected override void OnElementChanged(ElementChangedEventArgs<KingLabel> e) {
            base.OnElementChanged(e);

            var textBlock = new TextBlock {
                Text = "Hello World"
            };

            SetNativeControl(textBlock);
        }
    }
}
