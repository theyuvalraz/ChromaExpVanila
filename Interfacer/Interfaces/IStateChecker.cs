﻿using System;

namespace Interfacer.Interfaces
{
    public interface IStateChecker
    {
        IGetKeyboardLayout KeyboardLayout { get; set; }
        bool CurrentStateNeeded { set; }
        bool FirstAnimationNeeded { set; }
        bool SecondAnimationNeeded { set; }
        bool BaseNeeded { set; }
        bool ClearNeeded { set; }
        bool TimeAnimationNeeded { set; }
        IKeyboardController Control { get; set; }
        Action States();
    }
}