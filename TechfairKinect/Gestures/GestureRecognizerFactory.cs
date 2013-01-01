﻿using System;
using System.Collections.Generic;
using TechfairKinect.Factories;
using TechfairKinect.Gestures.Keyboard;

namespace TechfairKinect.Gestures
{
    internal class GestureRecognizerFactory : SettingsBasedSingularFactory<IGestureRecognizer>
    {
        protected override string SettingsKey { get { return "GestureRecognizerImplementation"; } }

        private static Dictionary<string, Type> _implementationsByName = new Dictionary<string, Type>
        {
            { "Keyboard", typeof(KeyboardGestureRecognizer) }
        };

        protected override Dictionary<string, Type> ImplementationsBySettingsValue { get { return _implementationsByName; } }
    }
}
