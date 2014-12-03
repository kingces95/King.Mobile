
using Android.Widget;
using King.Mobile.Controls;
using King.Mobile.Controls.Platform;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

namespace King.Mobile.Controls.Platform {

    public class KingLabelRenderer : ViewRenderer<KingLabel, TextView> {
        private TextView m_view;

        protected override void OnElementChanged(ElementChangedEventArgs<KingLabel> e) {
            base.OnElementChanged(e);
            if (m_view == null) {
                m_view = new TextView(Context);
                SetNativeControl(m_view);
            }

            m_view.Text = "Hello World!";
        }
    }
}