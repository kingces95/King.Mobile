using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

// A hard reference is required here. 
// Apparently the build removes unreferenced assemblies from the deployment package. 
//[assembly: King.Mobile.Controls.Platform.KingMobileControlsReference]

namespace Application.x64.iOS {
    public class Application {
        // This is the main entry point of the application.
        static void Main(string[] args) {
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            UIApplication.Main(args, null, "AppDelegate");
        }
    }
}