﻿using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using King.Mobile.Controls.IOS;


// A hard reference is required here. 
// Apparently the build removes unreferenced assemblies from the deployment package. 
[assembly: KingMobileControlsReference]

namespace CustomControlLibrary.iOS {
    public class Application {
        // This is the main entry point of the application.
        static void Main(string[] args) {
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            UIApplication.Main(args, null, "AppDelegate");
        }
    }
}