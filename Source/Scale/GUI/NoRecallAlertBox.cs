using System;
using UnityEngine;
using KSPe;

namespace TweakScale.GUI
{
    internal static class NoRecallAlertBox
    {
        private static readonly string MSG = @"KSP Recall was not found!

From KSP 1.9 and newer, KSP Recall **is needed** to fix problems on Resources (not only on TweakScale, it only happens that TweakScale is the first known victim of the problem).";

        private static readonly string AMSG = @"download KSP Recall from the Forum's page (KSP will close)";

        internal static void Show()
        {
            KSPe.Common.Dialogs.ShowStopperAlertBox.Show(
                MSG,
                AMSG,
                () => { Application.OpenURL("https://forum.kerbalspaceprogram.com/index.php?/topic/192048-*"); Application.Quit(); }
            );
            Log.force("\"Houston, we have a Problem!\" about KSP-Recall was displayed");
        }
    }
}