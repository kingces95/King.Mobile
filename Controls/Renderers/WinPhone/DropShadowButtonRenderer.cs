using King.Mobile.Controls;
using King.Mobile.Controls.WinPhone;
using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Xamarin.Forms;
using Xamarin.Forms.Platform.WinPhone;

[assembly: ExportRenderer(typeof(DropShadowButton), typeof(DropShadowButtonRenderer))]
namespace King.Mobile.Controls.WinPhone {

    [AttributeUsage(AttributeTargets.Assembly)]
    public sealed class KingMobileControlsReferenceAttribute : Attribute { }

    public class DropShadowButtonRenderer : ButtonRenderer {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e) {
            base.OnElementChanged(e);
        }
    }
}
