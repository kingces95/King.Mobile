using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Xamarin.Forms.Platform.iOS;
using System.Drawing;
using Xamarin.Forms;
using King.Mobile.Controls;
using King.Mobile.Controls.Platform;

[assembly: ExportRenderer(typeof(KingLabel), typeof(KingLabelRenderer))]

namespace King.Mobile.Controls.Platform {

    public sealed class KingLabelRenderer : ViewRenderer<KingLabel, UILabel> {
        protected override void OnElementChanged(ElementChangedEventArgs<KingLabel> e) {
            base.OnElementChanged(e);
            SetNativeControl(new UILabel(RectangleF.Empty));
            Control.AttributedText = new NSAttributedString("Hello World!", new UIStringAttributes());
        }
    }
}