using System;
using UnityEngine;
using KSPe;

namespace TweakScale.GUI
{
    internal static class UnsupportedKSPAlertBox
    {
        private static readonly string MSG = @"Unfortunately TweakScale is currently not known to work correctly on KSP 1.10 (and newer)!

It's not certain that it will not work fine, it's **NOT KNOWN** and if anything goes wrong, KSP will inject bad information on your savegames corrupting parts with TwekScale.";

        private static readonly string AMSG = @"check the GitHub issue #115 (KSP will close) to be updated on any news about KSP 1.10";

        internal static void Show()
        {
            KSPe.Common.Dialogs.ShowStopperAlertBox.Show(
                MSG,
                AMSG,
                () => { Application.OpenURL("https://github.com/net-lisias-ksp/TweakScale/issues/115"); Application.Quit(); }
            );
            Log.force("\"Houston, we have a Problem!\" about KSP 1.10 was displayed");
        }
    }
}