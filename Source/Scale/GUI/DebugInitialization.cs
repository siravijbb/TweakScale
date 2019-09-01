using System;
using UnityEngine;
using KSPe.UI;
using UnityEngine.Experimental.UIElements.StyleEnums;

namespace TweakScale.GUI
{
    internal static class DebugInitializationAlertBox
    {
        private static readonly string MSG = @"TweakScale is mangling the GameDatabase.

Please wait.

This Dialog Box will close by itself when the work is done.

(please don't click on that OK button =P , I didn't had the time to write a new Dialog Class!)
";

        internal static void Show()
        {
            GameObject go = new GameObject("TweakScale.DebugInitializationAlertBox");
            MessageBox dlg = go.AddComponent<MessageBox>();
            
            GUIStyle win = new GUIStyle("Window")
            {
                fontSize = 26,
                fontStyle = FontStyle.Bold
            };
            win.normal.textColor = Color.red;
            win.border.top = 36;

            GUIStyle text = new GUIStyle("Label")
            {
                fontSize = 18,
                fontStyle = FontStyle.Normal,
                alignment = TextAnchor.MiddleLeft
            };
            text.padding.top = 8;
            text.padding.bottom = text.padding.top;
            text.padding.left = text.padding.top;
            text.padding.right = text.padding.top;
            {
                Texture2D tex = new Texture2D(1,1);
                tex.SetPixel(0,0,new Color(0f, 0f, 0f, 0.45f));
                tex.Apply();
                text.normal.background = tex;
            }

            dlg.Show(
                "DEBUG INITIALIZATION", 
                MSG,
                win, text
            );
            Log.detail("Debug Initialization Dialog was diplayed");
        }

        internal static void Close()
        {
            GameObject go = GameObject.Find("TweakScale.DebugInitializationAlertBox");
            go.DestroyGameObject();
        }
    }
}