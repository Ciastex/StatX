﻿namespace OverCR.StatX.Hooks.WinAPI
{
    class Messages
    {
        internal enum Mouse
        {
            LeftButtonDown = 0x0201,
            LeftButtonUp = 0x0202,
            LeftButtonDoubleClick = 0x0203,
            MouseMove = 0x0200,
            MouseWheel = 0x020A,
            RightButtonDown = 0x0204,
            RightButtonUp = 0x0205,
            MiddleButtonDown = 0x0207,
            MiddleButtonUp = 0x0208
        }

        internal enum Keyboard
        {
            KeyDown = 0x100,
            SystemKeyDown = 0x104,
            KeyUp = 0x101,
            SystemKeyUp = 0x105
        }
    }
}
