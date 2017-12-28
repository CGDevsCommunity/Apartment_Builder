﻿using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Foxsys.ApartmentEditor
{
    public static class WindowObjectDrawer
    {
        private static ApartmentEditorWindow _CurrentWindow;

        public static ApartmentEditorWindow CurrentWindow
        {
            set { _CurrentWindow = value; }
        }
        //uses colors specified in handles
        public static void DrawCircle(Vector2 point)
        {
            Handles.DrawWireDisc(_CurrentWindow.Grid.GridToGUI(point), Vector3.back, SkinManager.Instance.CurrentSkin.CirclesRad / _CurrentWindow.Grid.Zoom);
        }
        //uses colors specified in handles
        public static void DrawLine(Vector2 point1, Vector2 point2)
        {
            Handles.DrawLine(_CurrentWindow.Grid.GridToGUI(point1), _CurrentWindow.Grid.GridToGUI(point2));
        }

        public static void DrawLabel(Vector2 position, string text)
        {
            Handles.Label(_CurrentWindow.Grid.GridToGUI(position), text, SkinManager.Instance.CurrentSkin.TextStyle);
        }
    }
}