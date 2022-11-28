﻿using UnityEditor;
using UnityEngine;

namespace ORL.ShaderInspector
{
    public class Styles
    {
        public static Texture2D CreateTexture(Color color)
        {
            var tex = new Texture2D(1, 1);
            tex.SetPixel(0, 0, color);
            tex.Apply();
            return tex;
        }

        public static GUIStyle Divider = new GUIStyle
        {
            fixedHeight = 1f,
            normal = new GUIStyleState
            {
                background = CreateTexture(new Color(0f, 0f, 0f, 0.6f))
            }
        };

        public static GUIStyle CustomDividerStyle(float height, Color color)
        {
            return new GUIStyle
            {
                fixedHeight = height,
                normal = new GUIStyleState
                {
                    background = CreateTexture(color),
                }
            };
        }

        public static GUIStyle Header1BgStye = new GUIStyle
        {
            normal = new GUIStyleState
            {
                background = CreateTexture(new Color(0f,0f,0f,0.3f))
            }
        };

        public static GUIStyle Header1TextStyle = new GUIStyle
        {
            fontSize = 12,
            fontStyle = FontStyle.Bold,
            alignment = TextAnchor.MiddleLeft,
            normal = new GUIStyleState
            {
                textColor = new Color(1f,1f,1f, 0.8f),
            }
        };
        
        public static GUIStyle NoteTextStyle = new GUIStyle(EditorStyles.wordWrappedLabel)
        {
            fontSize = 11,
            normal = new GUIStyleState
            {
                textColor = new Color(1f,1f,1f, 0.5f),
            }
        };
        
        public static GUIStyle LinkTextStyle = new GUIStyle(EditorStyles.wordWrappedLabel)
        {
            fontSize = 11,
            normal = new GUIStyleState
            {
                textColor = new Color(64f/255f, 206f/255f, 245f/255f),
            }
        };

        public static GUIStyle FoldoutFolded = new GUIStyle
        {
            fixedWidth = 10f,
            fixedHeight = 10f,
            normal = new GUIStyleState
            {
                background = Resources.Load<Texture2D>("Arrow_R"),
            }
        };

        public static GUIStyle FoldoutUnfolded = new GUIStyle
        {
            fixedWidth = 10f,
            fixedHeight = 10f,
            normal = new GUIStyleState
            {
                background = Resources.Load<Texture2D>("Arrow_D"),
            }
        };
    }
}