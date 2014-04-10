﻿using System;
using System.Runtime.InteropServices;
using System.Windows.Interop;

namespace SimpleAudio.Hotkeys
{
    public class HotKeyManager
    {

        #region HotKey Interop

        private const int WM_HotKey = 786;

        [DllImport("user32", CharSet = CharSet.Ansi,
                   SetLastError = true, ExactSpelling = true)]
        private static extern int RegisterHotKey(IntPtr hwnd,
                int id, int modifiers, int key);

        [DllImport("user32", CharSet = CharSet.Ansi,
                   SetLastError = true, ExactSpelling = true)]
        private static extern int UnregisterHotKey(IntPtr hwnd, int id);

        #endregion

        #region Interop-Encapsulation

        private HwndSourceHook hook;
        private HwndSource hwndSource;

        private void RegisterHotKey(int id, HotKey hotKey)
        {
        }

        private void UnregisterHotKey(int id)
        {
        }

        #endregion
    }
}