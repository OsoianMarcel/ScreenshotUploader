﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.Helpers.KeyboardHook
{
    /// <summary>
    /// The enumeration of possible modifiers.
    /// </summary>
    [Flags]
    public enum ModifierKeys : uint
    {
        Alt = 1,
        Control = 2,
        Shift = 4,
        Win = 8
    }
}
