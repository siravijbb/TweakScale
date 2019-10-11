using System;
using UnityEngine;
using KSPe.UI;

namespace TweakScale.GUI
{
    internal class CommonBox : TimedMessageBox
    {
        private static GUIStyle winStyle = null;
        internal static GUIStyle createWinStyle ()
        {
            if (null == winStyle)
            {
                winStyle = new GUIStyle("Window")
                {
                    fontSize = 22,
                    fontStyle = FontStyle.Bold,
                    alignment = TextAnchor.UpperCenter,
                    wordWrap = false
                };
                winStyle.focused.textColor = winStyle.normal.textColor = Color.yellow;
                winStyle.active.textColor = Color.white;
                winStyle.border.top = 5;
                { 
                    Texture2D tex = new Texture2D(1,1);
                    tex.SetPixel(0,0,new Color(0f, 0f, 0f, 0.45f));
                    tex.Apply();
                    winStyle.normal.background = tex;
                }
            }

            return winStyle;
        }

        private static GUIStyle textStyle = null;
        internal static GUIStyle createTextStyle ()
        {
            if (null == textStyle)
            {
                textStyle = new GUIStyle("Label")
                {
                    fontSize = 14,
                    fontStyle = FontStyle.Normal,
                    alignment = TextAnchor.MiddleLeft,
                    wordWrap = true
                };
                textStyle.active.textColor =
                    textStyle.focused.textColor =
                    textStyle.normal.textColor = Color.white;
                textStyle.padding.top = 8;
                textStyle.padding.bottom = textStyle.padding.top;
                textStyle.padding.left = textStyle.padding.top;
                textStyle.padding.right = textStyle.padding.top;
                {
                    Texture2D tex = new Texture2D(1,1);
                    tex.SetPixel(0,0,new Color(0f, 0f, 0f, 0.45f));
                    tex.Apply();
                    textStyle.active.background =
                        textStyle.focused.background =
                        textStyle.normal.background = tex;
                }
            }
            return textStyle;
        }
    }
}
