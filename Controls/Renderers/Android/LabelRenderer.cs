using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
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