using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
//using King.Mobile.Controls.Platform;

namespace Xamarin.Forms {
    public sealed class RendererAttribute : Attribute {
        public RendererAttribute(Type type) { }
    }
}

namespace King.Mobile.Controls
{
    //[Renderer(typeof(DropShadowButtonRenderer))]
    public class DropShadowButton : Button {
        public DropShadowButton() {
            //var type = typeof(JasonsHypothosis);
            //var type2 = typeof(DropShadowButtonRenderer);
        }
    }
}
