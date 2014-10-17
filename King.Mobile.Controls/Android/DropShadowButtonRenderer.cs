using King.Mobile.Controls;
using King.Mobile.Controls.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(DropShadowButton), typeof(DropShadowButtonRenderer))]
namespace King.Mobile.Controls.Android {

    [AttributeUsage(AttributeTargets.Assembly)]
    public sealed class KingMobileControlsReferenceAttribute : Attribute { }

    public class DropShadowButtonRenderer : ButtonRenderer {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e) {
            base.OnElementChanged(e);
        }
    }
}
