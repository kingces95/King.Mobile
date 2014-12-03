using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms.Platform.iOS;
using System.Drawing;
using Xamarin.Forms;
using King.Mobile.Controls;
using King.Mobile.Controls.Platform;

#if __UNIFIED__
using UIKit;
using Foundation;
#else
using MonoTouch.UIKit;
using MonoTouch.Foundation;
#endif

namespace King.Mobile.Controls.Platform {

    public sealed class KingLabelRenderer : ViewRenderer<KingLabel, UILabel> {
        protected override void OnElementChanged(ElementChangedEventArgs<KingLabel> e) {
            base.OnElementChanged(e);
            SetNativeControl(new UILabel(RectangleF.Empty));
            Control.AttributedText = new NSAttributedString("Hello World!", new UIStringAttributes());
        }
    }
}