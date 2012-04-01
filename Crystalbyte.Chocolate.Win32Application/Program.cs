﻿#region Namespace Directives

using System;
using System.Diagnostics;
using System.Reflection;
using Crystalbyte.Chocolate.UI;

#endregion

namespace Crystalbyte.Chocolate {
    internal static class Program {
        /// <summary>
        ///   The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main() {
            var module = Assembly.GetExecutingAssembly().ManifestModule;
            var success = Framework.Initialize(module);
            if (!success) {
                Debug.WriteLine("initialization failed");
                return;
            }

            if (!Framework.IsRootProcess) {
                return;
            }

            Framework.AttachRenderer(new Renderer(new Window(), new WindowDelegate()));
            Framework.AttachRenderer(new Renderer(new Window(), new WindowDelegate()));
            Framework.AttachRenderer(new Renderer(new Window(), new WindowDelegate()));
            Framework.Run();
            Framework.Shutdown();
        }
    }
}