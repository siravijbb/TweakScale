using System;
using UnityEngine;
using KSPe.UI;

namespace TweakScale.GUI
{
    internal class UnsupportedKSPAdviseBox : CommonBox
    {
        private static readonly string MSG = @"Unfortunately TweakScale is currently not known to work correctly on KSP 1.10 (and newer)!

It's not certain that it will not work fine, it's **NOT KNOWN** and if anything goes wrong, KSP will inject bad information on your savegames corrupting parts with TwekScale.

Please proceed with caution - use S.A.V.E. just in case.";

        internal static void Show()
        {
            GameObject go = new GameObject("TweakScale.AdviseBox");
            TimedMessageBox dlg = go.AddComponent<TimedMessageBox>();

            GUIStyle win = createWinStyle(Color.white);
            GUIStyle text = createTextStyle();

            dlg.Show(
                "TweakScale advises", 
                MSG,
                30, 0, 0,
                win, text
            );
            Log.force("\"TweakScale advises\" about KSP was displayed.");
        }
    }
}