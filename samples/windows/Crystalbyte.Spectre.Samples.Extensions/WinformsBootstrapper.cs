﻿#region Licensing notice

// Copyright (C) 2012, Alexander Wieser-Kuciel <alexander.wieser@crystalbyte.de>
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//    http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

#endregion

#region Using directives

using System;
using System.Collections.Generic;
using Crystalbyte.Spectre.Samples.Extensions;
using Crystalbyte.Spectre.Scripting;
using Crystalbyte.Spectre.UI;

#endregion

namespace Crystalbyte.Spectre.Samples {
    public sealed class WinformsBootstrapper : Bootstrapper {
        protected override void ConfigureSettings(ApplicationSettings settings) {
#if DEBUG
            settings.IsSingleProcess = true;
#endif
            base.ConfigureSettings(settings);
        }

        protected override IList<Extension> RegisterScriptingExtensions() {
            var extensions = base.RegisterScriptingExtensions();
            extensions.Add(new IncrementExtension());
            extensions.Add(new IncrementAsyncExtension());
            return extensions;
        }

        protected override IEnumerable<Viewport> CreateViewports() {
            yield return new Viewport(
                new Window {StartupUri = new Uri("spectre://localhost/Views/index.html")},
                new BrowserDelegate());
        }
    }
}