using System;
using Crystalbyte.Chocolate.UI;

namespace Crystalbyte.Chocolate {
    public sealed class GeolocationRequestCanceledEventArgs : EventArgs {
        internal GeolocationRequestCanceledEventArgs() { }
        public Browser Brower { get; internal set; }
        public string RequestingUrl { get; internal set; }
        public int RequestId { get; internal set; }
    }
}