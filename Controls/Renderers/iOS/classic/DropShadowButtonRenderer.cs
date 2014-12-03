using King.Mobile.Controls;
using King.Mobile.Controls.Platform;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

#if __UNIFIED__
using UIKit;
#else
using MonoTouch.UIKit;
#endif

namespace King.Mobile.Controls.Platform {

    public class KingDropShadowButtonRenderer : ButtonRenderer {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e) {
            var foo = typeof(Foo);
            base.OnElementChanged(e);

            if (Control == null)
                return;

            Control.Layer.ShadowColor = UIColor.Red.CGColor;
            Control.Layer.ShadowOffset = new SizeF(12.0f, 12.0f);

            Control.Layer.MasksToBounds = false;
            Control.ClipsToBounds = false;
            Control.Layer.ShadowRadius = 7;
            Control.Layer.ShadowOffset = new SizeF(10, 10);
            Control.Layer.ShadowOpacity = 0.8f;
        }
    }
}
