using System;
using UnityEngine;
using KSPe;

namespace TweakScale.GUI
{
    internal static class ShowStopperAlertBox
    {
        private static readonly string MSG = @"Unfortunately TweakScale found {0} **FATAL** issue(s) on your KSP installment! This probably will corrupt your savagames sooner or later!

The KSP.log is listing every compromised part(s) on your installment, look for lines with '[TweakScale] ERROR: **FATAL**' on the log line. Be aware that the parts being reported are not the culprits, but the Screaming Victims. There's no possible automated fix for these.";

        private static readonly string AMSG = @"call for help on the TweakScale thread on the Forum (KSP will close). We will help you on diagnosing the Add'On that is troubling you. Publish your KSP.log on some file share service and mention it on the post";

        internal static void Show(int failure_count)
        {
            KSPe.Common.Dialogs.ShowStopperAlertBox.Show(
                string.Format(MSG, failure_count),
                AMSG,
                () => { Application.OpenURL("https://forum.kerbalspaceprogram.com/index.php?/topic/179030-*"); Application.Quit(); }
            );
            Log.detail("\"Houston, we have a Problem!\" was displayed");
        }
    }
}