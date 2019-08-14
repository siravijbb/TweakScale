using System;
using UnityEngine;
using KSPe.UI;

namespace TweakScale.GUI
{
    internal class HotFixAdviseBox : CommonBox
    {
        private static readonly string MSG = @"There're {0} parts with hot fixes detected.

A hot fix is a patch crafted to reach the intended results by brute force to solve problems diagnosed but that cannot be fixed by normal means (as pull requesting the fix to the offending Add'On repository).

It's safe to start new games and share crafts - but you can have problems by installing or removing Add'Ons, as hot fixes are usually dumb and aimed to a specific situation.";

        internal static void show(int overrule_count)
        {
            GameObject go = new GameObject("TweakScale.AdviseBox");
            TimedMessageBox dlg = go.AddComponent<TimedMessageBox>();

            GUIStyle win = createWinStyle();
            GUIStyle text = createTextStyle();

            dlg.Show(
                "TweakScale advises", 
                String.Format(MSG, overrule_count),
                30, 0, -1,
                win, text
            );
            Log.detail("\"TweakScale advises\" about overrules checks was displayed");
        }
    }
}