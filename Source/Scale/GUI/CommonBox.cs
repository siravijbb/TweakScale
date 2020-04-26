using System;
using UnityEngine;
using KSPe.UI;

namespace TweakScale.GUI
{
    internal class CommonBox : TimedMessageBox
    {
        internal static GUIStyle createWinStyle (Color titlebarColor)
        {
            GUIStyle winStyle;
            {
                winStyle = new GUIStyle("Window")
                {
                    fontSize = 22,
                    fontStyle = FontStyle.Bold,
                    alignment = TextAnchor.UpperCenter,
                    wordWrap = false
                };
                winStyle.focused.textColor =
                    winStyle.normal.textColor =
                    winStyle.active.textColor =
                    winStyle.hover.textColor = titlebarColor;
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

        internal static GUIStyle createTextStyle ()
        {
            GUIStyle textStyle;
            {
                textStyle = new GUIStyle("Label")
                {
                    fontSize = 14,
                    fontStyle = FontStyle.Normal,
                    alignment = TextAnchor.MiddleLeft,
                    wordWrap = true
                };
                textStyle.focused.textColor =
                    textStyle.normal.textColor =
                    textStyle.active.textColor =
                    textStyle.hover.textColor = Color.white;
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
