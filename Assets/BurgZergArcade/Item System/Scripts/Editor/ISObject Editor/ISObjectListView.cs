using UnityEngine;
using System.Collections;

namespace BurgZergArcade.ItemSystem.Editor
{

    public partial class ISObjectEditor
    {

        Vector2 _scrollPos = Vector2.zero;
        int _listviewWidth = 200;

        void ListView()
            {
            _scrollPos = GUILayout.BeginScrollView(_scrollPos, "Box", GUILayout.ExpandHeight(true), GUILayout.Width(_listviewWidth));
            // GUILayout.Label("Hi");   test
            GUILayout.EndScrollView();

                //DisplayQualities();

                //EditorGUILayout.EndScrollView();
            }

    }
}
