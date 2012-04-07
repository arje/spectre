#region Namespace Directives

using System;

#endregion

namespace Crystalbyte.Chocolate.UI {
    public sealed class BrowserEventArgs : EventArgs {
        internal BrowserEventArgs(Browser browser) {
            Browser = browser;
        }

        public Browser Browser { get; internal set; }
    }
}